using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WinFormsApp1.Models
{
    public static  class KeyMapper
    {
        public static bool[] GetHardwareSignal(Keys keyCode)
        {
            switch (keyCode)
            {
                case Keys.Up:
                    return new bool[] { false, false, false, true }; // 0001
                case Keys.Down:
                    return new bool[] { false, false, true, false }; // 0010
                case Keys.Left:
                    return new bool[] { false, false, true, true }; // 0011
                case Keys.Right:
                    return new bool[] { false, true, false, false }; // 0100
                case Keys.Space:
                    return new bool[] { false, true, false, true }; // 0101
                case Keys.Z:
                    return new bool[] { false, true, true, false }; // 0110
                case Keys.X:
                    return new bool[] { false, true, true, true }; // 0111
                default:
                    return new bool[] { false, false, false, false }; // 0000 none
            }

        }
    }
}
