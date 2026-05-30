using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Register(string regName, bool[] regArray)
    {
        public string RegName = regName;
        public bool[] RegArray = regArray;

        public void AddBit(int bitPos)
        {
            int targetIndex = 3 - bitPos;
            RegArray[targetIndex] = !RegArray[targetIndex];
        }
        public bool[] DisplayRegister()
        {
            return RegArray;
        }
        public void ClearRegister()
        {

            for (int i = 0; i < RegArray.Length; i++)
            {
                RegArray[i] = false;
            }

        }

    }
}
