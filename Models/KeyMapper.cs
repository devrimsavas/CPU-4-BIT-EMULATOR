using System.Windows.Forms;

namespace WinFormsApp1.Models
{
    public static class KeyMapper
    {
        public static (bool[] page, bool[] code) GetHardwareSignal(Keys keyCode)
        {
            switch (keyCode)
            {
                // PAGE 0 — special keys
                case Keys.Up: return (ToBits(0), ToBits(1));
                case Keys.Down: return (ToBits(0), ToBits(2));
                case Keys.Left: return (ToBits(0), ToBits(3));
                case Keys.Right: return (ToBits(0), ToBits(4));
                case Keys.Space: return (ToBits(0), ToBits(5));
                case Keys.Enter: return (ToBits(0), ToBits(6));
                case Keys.Escape: return (ToBits(0), ToBits(7));

                // PAGE 1 — A to P
                case Keys.A: return (ToBits(1), ToBits(0));
                case Keys.B: return (ToBits(1), ToBits(1));
                case Keys.C: return (ToBits(1), ToBits(2));
                case Keys.D: return (ToBits(1), ToBits(3));
                case Keys.E: return (ToBits(1), ToBits(4));
                case Keys.F: return (ToBits(1), ToBits(5));
                case Keys.G: return (ToBits(1), ToBits(6));
                case Keys.H: return (ToBits(1), ToBits(7));
                case Keys.I: return (ToBits(1), ToBits(8));
                case Keys.J: return (ToBits(1), ToBits(9));
                case Keys.K: return (ToBits(1), ToBits(10));
                case Keys.L: return (ToBits(1), ToBits(11));
                case Keys.M: return (ToBits(1), ToBits(12));
                case Keys.N: return (ToBits(1), ToBits(13));
                case Keys.O: return (ToBits(1), ToBits(14));
                case Keys.P: return (ToBits(1), ToBits(15));

                // PAGE 2 — Q to Z
                case Keys.Q: return (ToBits(2), ToBits(0));
                case Keys.R: return (ToBits(2), ToBits(1));
                case Keys.S: return (ToBits(2), ToBits(2));
                case Keys.T: return (ToBits(2), ToBits(3));
                case Keys.U: return (ToBits(2), ToBits(4));
                case Keys.V: return (ToBits(2), ToBits(5));
                case Keys.W: return (ToBits(2), ToBits(6));
                case Keys.X: return (ToBits(2), ToBits(7));
                case Keys.Y: return (ToBits(2), ToBits(8));
                case Keys.Z: return (ToBits(2), ToBits(9));

                // PAGE 3 — 0 to 9
                case Keys.D0: return (ToBits(3), ToBits(0));
                case Keys.D1: return (ToBits(3), ToBits(1));
                case Keys.D2: return (ToBits(3), ToBits(2));
                case Keys.D3: return (ToBits(3), ToBits(3));
                case Keys.D4: return (ToBits(3), ToBits(4));
                case Keys.D5: return (ToBits(3), ToBits(5));
                case Keys.D6: return (ToBits(3), ToBits(6));
                case Keys.D7: return (ToBits(3), ToBits(7));
                case Keys.D8: return (ToBits(3), ToBits(8));
                case Keys.D9: return (ToBits(3), ToBits(9));

                default: return (ToBits(0), ToBits(0));
            }
        }

        private static bool[] ToBits(int value)
        {
            return new bool[]
            {
                (value & 0x08) != 0,
                (value & 0x04) != 0,
                (value & 0x02) != 0,
                (value & 0x01) != 0
            };
        }
    }
}