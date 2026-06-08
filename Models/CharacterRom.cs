using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public static class CharacterRom
    {
        public static readonly Dictionary<int, bool[][]> Data = new()
        {
            //ID 0 (0000)-> A pattern 
            { 0, new bool[][] {
                new bool[] { false, true,  true, false }, // 0110
                new bool[] { true,  false, false,  true }, // 1001
                new bool[] { true,  true,  true,  true }, // 1111
                new bool[] { true,  false,false,  true }, // 1001
                new bool[] { true,  false, false,  true }  // 1001
            }},
            //ID 1 (0001)-> B pattern
            { 1, new bool[][] {
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  true,  true,  false }  // 1110
            }},
            //ID 2 (0010)-> C Pattern
            { 2, new bool[][] {
                new bool[] { false,  true,  true,  false }, // 0110
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false,  false,  false }, // 1000
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { false,  true,  true,  false }  // 0110
            }},
            //ID 3 (0011)-> D Pattern 
            { 3, new bool[][] {
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false,  false,  true }, // 1001
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  true,  true,  false }  // 1110
            }},
            //ID 4 (0100)-E Pattern 
            { 4, new bool[][] {
                new bool[] { true,  true,  true,  true }, // 1111
                new bool[] { true,  false, false, false  }, // 1000
                new bool[] { true, true, true,  true }, // 1111
                new bool[] { true,  false, false, false  }, // 1000
                new bool[] { true,  true,  true,  true }  // 1111
            }},
            //ID 5 (0101)- F Pattern
            {5, new bool[][]
            {
                new bool[] { true,  true,  true,  true }, // 1111
                new bool[] { true,  false, false, false  }, // 1000
                new bool[] { true, true, true,  true }, // 1111
                new bool[] { true,  false, false, false  }, // 1000
                new bool[] { true,  false,  false, false }  // 1000
            
            } },
            // ID 6(0110)- G Pattern
            {6, new bool[][]
            {
                new bool[] { false,  true,  true,  true }, // 0111
                new bool[] { true,  false, false, false  }, // 1000
                new bool[] { true, false, true,  true }, // 1011
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { false,  true,true,true }  // 0111

            } },
            //ID 7 (0111)- H Pattern
            {7, new bool[][]
            {
                new bool[] { true,false,false,true }, // 1001
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true, true, true,  true }, // 1111
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false,false,true }  // 1001

            } },
            //ID 8 (1000)- I Pattern
            {8, new bool[][]
            {
                new bool[] { true,true,true,true }, // 1111
                new bool[] { false,true,true,false }, // 0110
                new bool[] { false,true,true,false }, // 0110
                new bool[] { false,true,true,false  }, // 0110
                new bool[] { true,true,true,true }  // 1111

            } },
            //ID 9 (1001)- J Pattern
            {9, new bool[][]
            {
                new bool[] { false,false,true,false }, // 0010
                new bool[] { false,false,true,false }, // 0010
                new bool[] { false,false,true,false }, // 0010
                new bool[] { true,false,true,false  }, // 1010
                new bool[] { true,true,false,false }  // 1100

            } },










        };
    }
}
