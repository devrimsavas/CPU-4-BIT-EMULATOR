using System;
using System.Drawing;

namespace WinFormsApp1.Models
{
    public class ComputerMonitor
    {
        // ============================================================
        //  DISPLAY CONFIG  — change these two and everything follows
        // ============================================================
        private const int Width = 256;       // was 512
        private const int Height = 256;       // was 512
        private const int PixelScale = 2;     // was 4 (logical area stays 128x128)

        // ---- Derived constants (do not edit by hand) ----
        private const int BlockSize = 8;                         // 8x8 color cells (ZX-style attributes)
        private const int BlocksPerRow = Width / BlockSize;         // 32  (was 64)
        private const int BlocksPerCol = Height / BlockSize;        // 32
        private const int AttrCount = BlocksPerRow * BlocksPerCol; // 1024 (was 4096)

        // Character cell geometry (logical pixels) — glyphs stay 4x5
        private const int CharW = 4;   // glyph width  in logical px
        private const int CharH = 5;   // glyph height in logical px
        private const int CharAdvX = 5;   // x advance per char (4 + 1 gap)
        private const int CharAdvY = 6;   // y advance per line (5 + 1 gap)

        private bool[,] _pixelBuffer;
        private ushort[] _attributeMatrix;
        private int _cursorX;
        private int _cursorY;
        private ushort _activeColorCode = 14;

        // for backspace / cursor read
        public int CursorX => _cursorX;
        public int CursorY => _cursorY;

        // expose dimensions so the renderer can stay in sync
        public int ScreenWidth => Width;
        public int ScreenHeight => Height;

        public ComputerMonitor()
        {
            _pixelBuffer = new bool[Width, Height];
            _attributeMatrix = new ushort[AttrCount];
            for (int i = 0; i < AttrCount; i++)
                _attributeMatrix[i] = 0;
            _cursorX = 0;
            _cursorY = 0;
        }

        public void ProcessCommand(int address, bool[] data)
        {
            if (data == null || data.Length != 4) return;

            // 0x0F: Draw 4 pixels
            if (address == 15)
            {
                for (int i = 0; i < 4; i++)
                {
                    int blockX = _cursorX / BlockSize;
                    int blockY = _cursorY / BlockSize;
                    int index = (blockY * BlocksPerRow) + blockX;
                    if (index >= 0 && index < AttrCount)
                        _attributeMatrix[index] = _activeColorCode;

                    bool bitValue = data[i];
                    for (int dx = 0; dx < PixelScale; dx++)
                        for (int dy = 0; dy < PixelScale; dy++)
                            if (_cursorX + dx < Width && _cursorY + dy < Height)
                                _pixelBuffer[_cursorX + dx, _cursorY + dy] = bitValue;

                    AdvanceCursor();
                }
            }

            // 0x01: Backspace — move cursor back one character
            else if (address == 1)
            {
                _cursorX -= (CharAdvX * PixelScale);
                if (_cursorX < 0) _cursorX = 0;
                //added after 256x256 to delete cursor trace
                // erase the character cell at the new position
                for (int dx = 0; dx < CharAdvX * PixelScale; dx++)
                    for (int dy = 0; dy < CharH * PixelScale; dy++)
                    {
                        int fx = _cursorX + dx;
                        int fy = _cursorY + dy;
                        if (fx >= 0 && fx < Width && fy >= 0 && fy < Height)
                            _pixelBuffer[fx, fy] = false;
                    }

            }

            // 0x02: Draw cursor block at current position (no advance)
            else if (address == 2)
            {
                /*
                for (int dx = 0; dx < CharW * PixelScale; dx++)
                    for (int dy = 0; dy < CharH * PixelScale; dy++)
                    {
                        int fx = _cursorX + dx;
                        int fy = _cursorY + dy;
                        if (fx < Width && fy < Height)
                            _pixelBuffer[fx, fy] = true;
                    }
                */
                _cursorX -= (CharAdvX * PixelScale);
                if (_cursorX < 0) _cursorX = 0;

            }

            // 0x0E: Set color
            else if (address == 14)
            {
                _activeColorCode = ConvertBoolArrayToUShort(data);
            }
            // 0x0D: Carriage return — X only reset
            else if (address == 13)
            {
                _cursorX = 0;
            }
            // 0x0C: Fast forward X
            else if (address == 12)
            {
                int steps = ConvertBoolArrayToUShort(data) * PixelScale;
                _cursorX += steps;
                if (_cursorX >= Width)
                {
                    _cursorX %= Width;
                    _cursorY += PixelScale;
                }
            }
            // 0x0B: Newline — Y only
            else if (address == 11)
            {
                int lines = ConvertBoolArrayToUShort(data);
                if (lines == 0) lines = 1;
                _cursorY += (lines * PixelScale);
                if (_cursorY >= Height)
                    _cursorY %= Height;
            }
            // 0x0A: CLS
            else if (address == 10)
            {
                Array.Clear(_pixelBuffer, 0, _pixelBuffer.Length);
                for (int i = 0; i < AttrCount; i++)
                    _attributeMatrix[i] = 0;
                _cursorX = 0;
                _cursorY = 0;
                _activeColorCode = 14;
            }
            // 0x07: Set absolute X
            else if (address == 7)
            {
                int xPos = ConvertBoolArrayToUShort(data) * PixelScale;
                _cursorX = xPos;
            }
            // 0x04: Set absolute Y
            else if (address == 4)
            {
                int yPos = ConvertBoolArrayToUShort(data) * PixelScale;
                _cursorY = yPos;
            }
            // 0x03: Set absolute X — HIGH BYTE
            else if (address == 3)
            {
                int xHigh = ConvertBoolArrayToUShort(data);
                _cursorX = xHigh * 16 * PixelScale;
            }
        }

        private void AdvanceCursor()
        {
            _cursorX += PixelScale;
            if (_cursorX >= Width)
            {
                _cursorX = 0;
                _cursorY += PixelScale;
                if (_cursorY >= Height) _cursorY = 0;
            }
        }

        public void DrawCharacter(bool[][] pattern)
        {
            int startX = _cursorX;
            int startY = _cursorY;

            for (int r = 0; r < pattern.Length; r++)
            {
                for (int c = 0; c < pattern[r].Length; c++)
                {
                    int px = startX + (c * PixelScale);
                    int py = startY + (r * PixelScale);
                    int blockX = px / BlockSize;
                    int blockY = py / BlockSize;
                    int index = (blockY * BlocksPerRow) + blockX;
                    if (index >= 0 && index < AttrCount)
                        _attributeMatrix[index] = _activeColorCode;

                    bool bitValue = pattern[r][c];
                    for (int dx = 0; dx < PixelScale; dx++)
                        for (int dy = 0; dy < PixelScale; dy++)
                        {
                            int finalX = px + dx;
                            int finalY = py + dy;
                            if (finalX < Width && finalY < Height)
                                _pixelBuffer[finalX, finalY] = bitValue;
                        }
                }
            }

            _cursorX = startX + (CharAdvX * PixelScale);
            if (_cursorX >= Width)
            {
                _cursorX = 0;
                _cursorY += (CharAdvY * PixelScale);
                if (_cursorY >= Height)
                    _cursorY = 0;
            }
        }

        public bool IsPixelActive(int x, int y) => _pixelBuffer[x, y];

        public ushort GetColorAttribute(int x, int y)
        {
            int blockX = x / BlockSize;
            int blockY = y / BlockSize;
            int index = (blockY * BlocksPerRow) + blockX;
            if (index < 0 || index >= AttrCount) return 2;
            return _attributeMatrix[index];
        }

        private ushort ConvertBoolArrayToUShort(bool[] data)
        {
            int value = 0;
            if (data[0]) value += 8;
            if (data[1]) value += 4;
            if (data[2]) value += 2;
            if (data[3]) value += 1;
            return (ushort)value;
        }
    }
}