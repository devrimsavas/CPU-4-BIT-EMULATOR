using System;
using System.Linq;

namespace WinFormsApp1.Models
{
    public static class RomLoader
    {
        // === CORE ===
        private static bool[] ToBits(string binary)
            => binary.PadLeft(4, '0').Select(c => c == '1').ToArray();

        private static bool[] IntToBits(int value)
            => ToBits(Convert.ToString(value & 0xF, 2));

        private static void Send(int port, bool[] data)
            => DataMemory.ScreenHardware.ProcessCommand(port, data);

        // === SCREEN COMMANDS ===
        public static void CLS()
            => Send(10, new bool[4]);

        public static void SetColor(int colorCode)
            => Send(14, IntToBits(colorCode));

        public static void SetX(int x)
            => Send(7, IntToBits(x));

        public static void SetY(int y)
            => Send(4, IntToBits(y));

        public static void CarriageReturn()
            => Send(13, new bool[4]);

        public static void Newline(int lines = 1)
            => Send(11, IntToBits(lines));

        public static void Draw(string pattern)
            => Send(15, ToBits(pattern));

        public static void Draw(bool[] pattern)
            => Send(15, pattern);

        // === LOCATE ===
        public static void Locate(int x, int y)
        {
            SetY(y);
            SetX(x);
        }

        // === SPRITE ===
        public static void DrawSprite(int x, int y, string[] rows)
        {
            for (int i = 0; i < rows.Length; i++)
            {
                Locate(x, y + i);
                // her satır 3 block = 12 bit = 3 x 4 bit
                string row = rows[i].PadRight(12, '0');
                Draw(row.Substring(0, 4));
                Draw(row.Substring(4, 4));
                Draw(row.Substring(8, 4));
            }
        }

        // === CHARACTER ===
        public static void DrawChar(int x, int y, int romPage, int charId)
        {
            var page = CharacterRom.RomPages[romPage];
            if (!page.TryGetValue(charId, out bool[][] pattern)) return;

            Locate(x, y);
            DataMemory.ScreenHardware.DrawCharacter(pattern);
        }

        // === TEXT ===
        public static void DrawText(int x, int y, string text, int color = 14)
        {
            SetColor(color);
            SetY(y);
            SetX(x);

            foreach (char c in text.ToUpper())
            {
                int page, id;
                if (c >= 'A' && c <= 'P') { page = 0; id = c - 'A'; }
                else if (c >= 'Q' && c <= 'Z') { page = 1; id = c - 'Q'; }
                else if (c >= '0' && c <= '9') { page = 3; id = c - '0'; }
                else
                {
                    // space
                    Send(12, new bool[] { false, false, false, true });
                    continue;
                }

                // assembly deki handle_ap gibi — page sec, char id push, print
                Send(9, IntToBits(page));  // store 0009 = ROM page
                var romPage = CharacterRom.RomPages[page];
                if (romPage.TryGetValue(id, out bool[][] pattern))
                    DataMemory.ScreenHardware.DrawCharacter(pattern);
            }
        }

        // === RAM LOADER ===
        public static void LoadToBank(int bank, int startAddr, bool[][] data)
        {
            for (int i = 0; i < data.Length && startAddr + i < 16; i++)
            {
                int savedBank = DataMemory.ActiveBank;
                DataMemory.SwitchBank(bank);
                DataMemory.Write(startAddr + i, data[i]);
                DataMemory.SwitchBank(savedBank);
            }
        }

        public static void LoadToBank(int bank, int startAddr, string[] binaryStrings)
        {
            bool[][] data = binaryStrings.Select(s => ToBits(s)).ToArray();
            LoadToBank(bank, startAddr, data);
        }
    }
}