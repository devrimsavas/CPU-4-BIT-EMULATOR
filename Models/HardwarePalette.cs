using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsApp1.Models
{
    public static class HardwarePalette
    {
        public static readonly Color[] Colors = new Color[]
        {
            Color.Black,                         // 0000 - Background Black
            Color.FromArgb(0, 0, 170),           // 0001 - Dark Blue
            Color.FromArgb(0, 170, 0),           // 0010 - Dark Green
            Color.FromArgb(0, 170, 170),         // 0011 - Dark Cyan
            Color.FromArgb(170, 0, 0),           // 0100 - Dark Red
            Color.FromArgb(170, 0, 170),         // 0101 - Dark Magenta
            Color.FromArgb(170, 85, 0),          // 0110 - Brown
            Color.FromArgb(170, 170, 170),       // 0111 - Light Gray
            Color.FromArgb(85, 85, 85),          // 1000 - Dark Gray
            Color.FromArgb(85, 85, 255),         // 1001 - Bright Blue
            Color.FromArgb(85, 255, 85),         // 1010 - Bright Green
            Color.FromArgb(85, 255, 255),        // 1011 - Bright Cyan
            Color.FromArgb(255, 85, 85),         // 1100 - Bright Red
            Color.FromArgb(255, 85, 255),        // 1101 - Bright Magenta
            Color.FromArgb(255, 255, 85),        // 1110 - Bright Yellow
            Color.FromArgb(255, 255, 255)        // 1111 - Pure White

        };
    }
}
