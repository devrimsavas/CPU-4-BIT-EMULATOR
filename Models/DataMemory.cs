using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Data memory chip 
namespace WinFormsApp1.Models
{
    internal class DataMemory
    {
        //16 hardware addresses (0x00 to 0x0F) for 4-bit data architecture
        //each address can store a 4-bit value (0 to 15)
        public static Dictionary<int, bool[]> Ram=new Dictionary<int, bool[]>();
        //Initialize the data memory with default values (0)
        public static void Initialize()
        {
            Ram.Clear();
            //format for each address, we create a bool array of size 4 to represent the 4 bits
            for (int i = 0; i < 16; i++)
            {
                Ram[i] = new bool[4]; // 4 bits initialized to false (0)
            }
        }
        //write data to a specific address in the data memory (0x00 to 0x0F)    
        public static void Write(int address, bool[] data)
        {
            if (address>=0 && address < 16 && data.Length == 4)
            {
                //clone the data array to ensure that we are not modifying the original array passed as an argument
                //Ram[address] = data;
                Ram[address] = (bool[])data.Clone(); // store a clone of the data to prevent external modification
            }
            else
            {
                throw new ArgumentException("Invalid address or data length. Address must be between 0 and 15, and data must be a 4-bit array.");
            }
        }
        //read data from a specific address in the data memory (0x00 to 0x0F)
        public static bool[] Read(int address)
        {
            if (address >= 0 && address < 16)
            {
                return (bool[])Ram[address].Clone(); // return a clone of the data to prevent external modification 
            }
            
            //hardware fallback 
            return new bool[4] { false, false, false, false }; // return default value (0) if address is invalid   
        }
    }
}
