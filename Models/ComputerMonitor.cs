using System;
using System.Drawing;

namespace WinFormsApp1.Models
{
    public class ComputerMonitor
    {
        // Define screen dimensions
        private const int Width = 256;
        private const int Height = 256;
        private const int PixelScale = 4; // 8x8 pixel blocks for color attributes or 4x4 pixel blocks for drawing

        // Pixel layer buffer (Layer 1 - Monochrome shapes)
        private bool[,] _pixelBuffer;

        // Color attribute matrix (Layer 2 - 32x32 blocks = 1024 blocks total)
        private ushort[] _attributeMatrix;

        // Scanline cursor coordinates
        private int _cursorX;
        private int _cursorY;

        public ComputerMonitor()
        {
            // Initialize the blank pixel screen
            _pixelBuffer = new bool[Width, Height];

            // Initialize the color matrix memory bank
            _attributeMatrix = new ushort[1024];

            // Fill the screen with default color code (e.g., 2 for Lime Green)
            for (int i = 0; i < 1024; i++)
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

            //pixel size  is 4 now 

            // 0x0F: Draw 4 pixels to the screen or more look ax pixelscale
            if (address == 15)
            {
                for (int i = 0; i < 4; i++)
                {
                    // O anki bit true mu false mu?
                    bool bitValue = data[i];

                    // 1 piksel çizmek yerine, PixelScale x PixelScale boyutunda koca bir tuğla boyuyoruz!
                    for (int dx = 0; dx < PixelScale; dx++)
                    {
                        for (int dy = 0; dy < PixelScale; dy++)
                        {
                            // Ekrandan dışarı taşmamak için güvenlik şeridi
                            if (_cursorX + dx < Width && _cursorY + dy < Height)
                            {
                                _pixelBuffer[_cursorX + dx, _cursorY + dy] = bitValue;
                            }
                        }
                    }

                    // İmleci ilerlet (artık 1'er 1'er değil, tuğla tuğla atlayacak)
                    AdvanceCursor();
                }
            }


            // 0x0E: Set the color for the CURRENT 8x8 block
            else if (address == 14)
            {
                // Convert 4-bit bool array to a color code (0-15)
                ushort colorCode = ConvertBoolArrayToUShort(data);

                // Calculate which 8x8 block the cursor is currently in
                int blockX = _cursorX / 8;
                int blockY = _cursorY / 8;
                int index = (blockY * 32) + blockX;

                // Update the color attribute for this block
                if (index >= 0 && index < 1024)
                {
                    _attributeMatrix[index] = colorCode;
                }
            }
            // Addresses 10, 11, 12, 13 (0x0A to 0x0D) are open for future modules!
            //RESET CURSOR (0x0D)
            else if (address == 13)
            {
                _cursorX = 0;
                _cursorY = 0;
            }
            // 0x0C: FAST FORWARD X (Skip blank spaces horizontally)
            else if (address == 12)
            {
                // Read the 4-bit data and multiply by 4 pixels per step
                int steps = ConvertBoolArrayToUShort(data) * 4;
                _cursorX += steps;

                // Wrap around to the next line if it exceeds screen width
                if (_cursorX >= Width)
                {
                    _cursorX %= Width;
                    _cursorY++;
                }
            }
            // 0x0B: NEWLINE (Jump Y and reset X)
            else if (address == 11)
            {
                // Move down by the requested number of lines (0-15)
                int lines = ConvertBoolArrayToUShort(data);
                if (lines == 0) lines = 1; // Default to 1 line if 0 is sent

                _cursorY += lines;
                _cursorX = 0; // Return cursor to the far left

                // Wrap around to top if it exceeds screen height
                if (_cursorY >= Height)
                {
                    _cursorY %= Height;
                }
            }
            else if (address == 10)
            {
                Array.Clear(_pixelBuffer, 0, _pixelBuffer.Length); // Clear the pixel buffer;
                for (int i = 0; i < 1024; i++)
                {
                    _attributeMatrix[i] = 2; // Reset all color attributes to default (e.g., 2 for Lime Green)
                }
                    _cursorX = 0; // Reset cursor position
                    _cursorY = 0;
            }   

        }

        
        // Handle the scanline movement
        private void AdvanceCursor()
        {
            // İmleci tuğla boyutu kadar sağa kaydır
            _cursorX += PixelScale;

            // Eğer satırın sonuna geldiyse
            if (_cursorX >= Width)
            {
                _cursorX = 0;

                // Bir alt satıra geçerken de yine tuğlanın boyutu kadar aşağı in!
                _cursorY += PixelScale;

                // Eğer ekranın en altına geldiyse başa dön
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
            int index = (blockY * 32) + blockX;
            return _attributeMatrix[index];
        }
    }
}