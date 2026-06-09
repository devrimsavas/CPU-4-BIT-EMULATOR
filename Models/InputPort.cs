using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public static class InputPort
    {
        //Current key state as 4-bit value 
        private static bool[] _currentKey = new bool[] { false, false, false, false };
        public static void SetKey(bool[] keyCode)
        {
            _currentKey = ((bool[])keyCode.Clone());
        }

        public static bool[] ReadKey()
        {
            return (bool[])_currentKey.Clone(); 
        }
    }
}
