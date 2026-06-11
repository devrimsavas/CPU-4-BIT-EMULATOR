using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models
{
    internal class DataMemory
    {
        public static ComputerMonitor ScreenHardware;

        // === BANK SYSTEM ===
        // Bank 0 = default 
        // Bank 1,2,3 = extra ram 
        private static int _activeBank = 0;
        private static Dictionary<int, bool[]>[] _banks = new Dictionary<int, bool[]>[16];

        // Bank 0 to keep existed code selected default bank 0
        public static Dictionary<int, bool[]> Ram => _banks[0];

        public static void Initialize()
        {
            // create 4 bank 
            for (int b = 0; b < 16; b++)
            {
                _banks[b] = new Dictionary<int, bool[]>();
                for (int i = 0; i < 16; i++)
                {
                    _banks[b][i] = new bool[4];
                }
            }
            _activeBank = 0;
        }

        public static void SwitchBank(int bank)
        {
            if (bank >= 0 && bank < 16)
            {
                _activeBank = bank;
            }
        }

        public static int ActiveBank => _activeBank;

        public static void Write(int address, bool[] data)
        {
            if (address >= 0 && address < 16 && data.Length == 4)
            {
                _banks[_activeBank][address] = (bool[])data.Clone();

                // hardware ports work only data memory 0 default 
                if (_activeBank == 0 && address >= 10 && address <= 15 && ScreenHardware != null)
                {
                    ScreenHardware.ProcessCommand(address, data);
                }
            }
            else
            {
                throw new ArgumentException("Invalid address or data length.");
            }
        }

        public static bool[] Read(int address, int bank=-1)
        {
            int targetBank=bank==-1 ? _activeBank : bank;   
            if (address >= 0 && address < 16)
            {
                return (bool[])_banks[targetBank][address].Clone();
            }
            return new bool[4] { false, false, false, false };
        }
    }
}