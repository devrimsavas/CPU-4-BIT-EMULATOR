using System;
using System.Drawing;

namespace WinFormsApp1.Models
{
    public class ComputerMonitor
    {
        // Define screen dimensions
        private const int Width = 512;
        private const int Height = 512;
        private const int PixelScale = 4; // 8x8 pixel blocks for color attributes or 4x4 pixel blocks for drawing

        // Pixel layer buffer (Layer 1 - Monochrome shapes)
        private bool[,] _pixelBuffer;

        // Color attribute matrix (Layer 2 - 32x32 blocks = 1024 blocks total)
        // NOTe:  if 512x512 and if  8x8 (PixelScale ) 
        // 512 / 8 = 64 block  totaly 64 x 64 = 4096 block
        // ram expended a bit cheat? check architecture
        private ushort[] _attributeMatrix;

        // Scanline cursor coordinates
        private int _cursorX;
        private int _cursorY;

        // smart brush active color 6 ? check again maybe black better?
        private ushort _activeColorCode = 6;

        public ComputerMonitor()
        {
            // Initialize the blank pixel screen
            _pixelBuffer = new bool[Width, Height];

            // Initialize the color matrix memory bank (Genişletildi: 4096)
            _attributeMatrix = new ushort[4096];

            // Fill the screen with default color code (e.g., 2 for Lime Green)
            for (int i = 0; i < 4096; i++)
            {
                _attributeMatrix[i] = 2;
            }

            // Reset cursors
            _cursorX = 0;
            _cursorY = 0;
        }

        // Central command hub for screen segment addresses (0x0A to 0x0F)
        public void ProcessCommand(int address, bool[] data)
        {
            // Safety check
            if (data == null || data.Length != 4) return;

            // 0x0F: Draw 4 pixels to the screen
            if (address == 15)
            {
                for (int i = 0; i < 4; i++)
                {
                    // 1. Brush 
                    int blockX = _cursorX / 8;
                    int blockY = _cursorY / 8;
                    int index = (blockY * 64) + blockX; // 

                    if (index >= 0 && index < 4096)
                    {
                        _attributeMatrix[index] = _activeColorCode;
                    }

                    // 2. DRAW PIXEL
                    bool bitValue = data[i];

                    // pixel block
                    for (int dx = 0; dx < PixelScale; dx++)
                    {
                        for (int dy = 0; dy < PixelScale; dy++)
                        {
                            // against limit 
                            if (_cursorX + dx < Width && _cursorY + dy < Height)
                            {
                                _pixelBuffer[_cursorX + dx, _cursorY + dy] = bitValue;
                            }
                        }
                    }

                    // advance cursor
                    AdvanceCursor();
                }
            }

            // 0x0E: SET THE ACTIVE BRUSH COLOR
            else if (address == 14)
            {
                // update brush color 
                _activeColorCode = ConvertBoolArrayToUShort(data);
            }

            // RESET CURSOR (0x0D)
            else if (address == 13)
            {
                _cursorX = 0;
                _cursorY = 0;
            }

            // 0x0C: FAST FORWARD X (Skip blank spaces horizontally)
            else if (address == 12)
            {
                int steps = ConvertBoolArrayToUShort(data) * PixelScale; // PixelScale 
                _cursorX += steps;

                if (_cursorX >= Width)
                {
                    _cursorX %= Width;
                    _cursorY += PixelScale; // jump with pixelscale
                }
            }

            // 0x0B: NEWLINE (Jump Y and reset X)
            else if (address == 11)
            {
                int lines = ConvertBoolArrayToUShort(data);
                if (lines == 0) lines = 1;

                _cursorY += (lines * PixelScale); // PixelScale 
                _cursorX = 0;

                if (_cursorY >= Height)
                {
                    _cursorY %= Height;
                }
            }

            // 0x0A: CLS
            else if (address == 10)
            {
                Array.Clear(_pixelBuffer, 0, _pixelBuffer.Length);
                for (int i = 0; i < 4096; i++) // memory extension 
                {
                    _attributeMatrix[i] = 2;
                }
                _cursorX = 0;
                _cursorY = 0;
                _activeColorCode = 6; // reset brush 
            }
        }

        // Handle the scanline movement
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

        // Helper: Convert bool[4] to a numeric value (0 to 15)
        private ushort ConvertBoolArrayToUShort(bool[] data)
        {
            int value = 0;
            if (data[0]) value += 8; // MSB
            if (data[1]) value += 4;
            if (data[2]) value += 2;
            if (data[3]) value += 1; // LSB
            return (ushort)value;
        }

        // Check if a specific pixel is active in the buffer
        public bool IsPixelActive(int x, int y)
        {
            return _pixelBuffer[x, y];
        }

        // Determine the color code for any given X/Y pixel coordinate
        public ushort GetColorAttribute(int x, int y)
        {
            int blockX = x / 8;
            int blockY = y / 8;
            int index = (blockY * 64) + blockX; // update to 64

            // return greens if it exceeds limit
            if (index < 0 || index >= 4096) return 2;

            return _attributeMatrix[index];
        }
    }
}