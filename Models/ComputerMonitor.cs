using System;
using System.Drawing;

namespace WinFormsApp1.Models
{
    public class ComputerMonitor
    {
        private const int Width = 512;
        private const int Height = 512;
        private const int PixelScale = 4;

        private bool[,] _pixelBuffer;
        private ushort[] _attributeMatrix;
        private int _cursorX;
        private int _cursorY;
        private ushort _activeColorCode = 14;

        public ComputerMonitor()
        {
            _pixelBuffer = new bool[Width, Height];
            _attributeMatrix = new ushort[4096];
            for (int i = 0; i < 4096; i++)
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
                    int blockX = _cursorX / 8;
                    int blockY = _cursorY / 8;
                    int index = (blockY * 64) + blockX;
                    if (index >= 0 && index < 4096)
                        _attributeMatrix[index] = _activeColorCode;

                    bool bitValue = data[i];
                    for (int dx = 0; dx < PixelScale; dx++)
                        for (int dy = 0; dy < PixelScale; dy++)
                            if (_cursorX + dx < Width && _cursorY + dy < Height)
                                _pixelBuffer[_cursorX + dx, _cursorY + dy] = bitValue;

                    AdvanceCursor();
                }
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
                for (int i = 0; i < 4096; i++)
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
                    int blockX = px / 8;
                    int blockY = py / 8;
                    int index = (blockY * 64) + blockX;
                    if (index >= 0 && index < 4096)
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

            _cursorX = startX + (5 * PixelScale);
            if (_cursorX >= Width)
            {
                _cursorX = 0;
                _cursorY += (6 * PixelScale);
                if (_cursorY >= Height)
                    _cursorY = 0;
            }
        }

        public bool IsPixelActive(int x, int y) => _pixelBuffer[x, y];

        public ushort GetColorAttribute(int x, int y)
        {
            int blockX = x / 8;
            int blockY = y / 8;
            int index = (blockY * 64) + blockX;
            if (index < 0 || index >= 4096) return 2;
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