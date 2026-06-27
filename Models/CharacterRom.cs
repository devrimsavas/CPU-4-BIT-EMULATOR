using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public static class CharacterRom
    {
        
        //Data, Data1, DataArithSymbols,DataDigits
        //CHARSET A-P
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
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { true,  false, false, false  }, // 1000
                new bool[] { true, true, true,  false }, // 1110
                new bool[] { true,  false, false, false  }, // 1000
                new bool[] { true,  true,  true,  false }  // 1110
            }},
            //ID 5 (0101)- F Pattern
            {5, new bool[][]
            {
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { true,  false, false, false  }, // 1000
                new bool[] { true, true, true,  false }, // 1110
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
                new bool[] { true,true,true,false }, // 1110
                new bool[] { false,true,false,false }, // 0100
                new bool[] { false,true,false,false }, // 0100
                new bool[] { false,true,false,false  }, // 0100
                new bool[] { true,true,true,false }  // 1110

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
            //ID 10 (1010)- K Pattern
            {10, new bool[][]
            {
                new bool[] { true,false,false,true }, // 1001
                new bool[] { true,false,true,false }, // 1010
                new bool[] { true,true,false,false }, // 1100
                new bool[] { true,false,true,false  }, // 1010
                new bool[] { true,false,false,true }  // 1001

            } },
            //ID 11 (1011)- L Pattern
            {11, new bool[][]
            {
                new bool[] { false,true,false,false }, // 0100
                new bool[] { false,true,false,false }, // 0100
                new bool[] { false,true,false,false }, // 0100
                new bool[] { false,true,false,false  }, // 0100
                new bool[] { false,true,true,true }  // 0111

            } },
            //ID 12 (1100)- M Pattern
            {12, new bool[][]
            {
                new bool[] { true,false,false,true }, // 1001
                new bool[] { true,false,true,true }, // 1011
                new bool[] { true,true,true,true }, // 1111
                new bool[] { true,false,false,true  }, // 1001
                new bool[] { true,false,false,true }  // 1001

            } },
            //ID 13 (1101)- N Pattern
            {13, new bool[][]
            {
                new bool[] { true,true,false,true }, // 1101
                new bool[] { true,true,true,true }, // 1111
                new bool[] { true,false,true,true}, // 1011
                new bool[] { true,false,false,true  }, // 1001
                new bool[] { true,false,false,true}  // 1001

            } },
            //ID 14 (1110)- O Pattern
            {14, new bool[][]
            {
                new bool[] { false,true,true,false }, // 0110
                new bool[] { true,false,false,true }, // 1001
                new bool[] { true,false,false,true }, // 1001
                new bool[] { true,false,false,true  }, // 1001
                new bool[] { false,true,true,false }  // 0110

            } },
            //ID 15 (1111)- P Pattern
            {15, new bool[][]
            {
                new bool[] { true,true,false,false }, // 1100
                new bool[] { true,false,true,false }, // 1010
                new bool[] { true,false,true,false }, // 1010
                new bool[] { true,true,false,false  }, // 1100
                new bool[] { true,false,false,false }  // 1000

            } },
            
        }; //BANK 1 END 
        public static Dictionary<int, bool[][]> Data1 = new()
{
            // ID 0 - Q Pattern 
            {0, new bool[][]
            {
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { false, false, true,  true  }  // 0011
            }},

            // ID 1 - R Pattern 
            {1, new bool[][]
            {
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { true,  true,  true,  true  }, // 1111
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false, false, true  }  // 1001
            }},

            // ID 2 - S Pattern
            {2, new bool[][]
            {
                new bool[] { false, true,  true,  true  }, // 0111
                new bool[] { true,  false, false, false }, // 1000
                new bool[] { true,  true,  true,  true  }, // 1111
                new bool[] { false, false, false, true  }, // 0001
                new bool[] { true,  true,  true,  false }  // 1110
            }},

            // ID 3 - T Pattern
            {3, new bool[][]
            {
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, true,  false, false }  // 0100
            }},

            // ID 4 - U Pattern
            {4, new bool[][]
            {
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { false, true,  true,  false }  // 0110
            }},

            // ID 5 - V Pattern
            {5, new bool[][]
            {
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false, true,  true  }, // 1011
                new bool[] { false, true,  true,  false }  // 0110
            }},

            // ID 6 - W Pattern
            {6, new bool[][]
            {
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  true,  false, true  }, // 1101
                new bool[] { true,  false, true,  true  }, // 1011
                new bool[] { false, true,  true,  false }  // 0110
            }},

            // ID 7 - X Pattern
            {7, new bool[][]
            {
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { true,  false, false, true  }  // 1001
            }},

            // ID 8 - Y Pattern
            {8, new bool[][]
            {
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { true,  true,  true,  false }  // 1110
            }},

            // ID 9 - Z Pattern
            {9, new bool[][]
            {
                new bool[] {  true,  true,  true ,false }, // 1110
                new bool[] { false, false, true,false  }, // 0010
                new bool[] { false, true,false,  false }, // 0100
                new bool[] {  true,  false, false,false }, // 1000
                new bool[] {  true,  true,  true ,false }  // 1110
            }},

            // ID 10 - [ Pattern (Mapped as '(' in original prompt)
            {10, new bool[][]
            {
                new bool[] { true,  true,  true,  true  }, // 1111
                new bool[] { true,  false, false, false }, // 1000
                new bool[] { true,  false, false, false }, // 1000
                new bool[] { true,  false, false, false }, // 1000
                new bool[] { true,  true,  true,  true  }  // 1111
            }},

            // ID 11 - \ Pattern
            {11, new bool[][]
            {
                new bool[] { true,  false, false, false }, // 1000
                new bool[] { true,  true,  false, false }, // 1100
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { false, false, true,  true  }, // 0011
                new bool[] { false, false, false, true  }  // 0001
            }},

            // ID 12 - ] Pattern (Mapped as ')' in original prompt)
            {12, new bool[][]
            {
                new bool[] { true,  true,  true,  true  }, // 1111
                new bool[] { false, false, false, true  }, // 0001
                new bool[] { false, false, false, true  }, // 0001
                new bool[] { false, false, false, true  }, // 0001
                new bool[] { true,  true,  true,  true  }  // 1111
            }},

            // ID 13 - ^ Pattern
            {13, new bool[][]
            {
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }  // 0000
            }},

            // ID 14 - _ Pattern
            {14, new bool[][]
            {
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { true,  true,  true,  true  }  // 1111
            }},

            // ID 15 - Space Pattern
            {15, new bool[][]
            {
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }  // 0000
            }}
        }; //data1 end 

        public static Dictionary<int, bool[][]> DataArithSymbols = new()
{
            // ID 0 - Exclamation Mark (!) Pattern
            {0, new bool[][]
            {
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, true,  false, false }  // 0100
            }},

            // ID 1 - Double Quote (") Pattern
            {1, new bool[][]
            {
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }  // 0000
            }},

            // ID 2 - Hash/Number (#) Pattern
            {2, new bool[][]
            {
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { true,  true,  true,  true  }, // 1111
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { true,  true,  true,  true  }, // 1111
                new bool[] { false, true,  true,  false }  // 0110
            }},

            // ID 3 - Dollar Sign ($) Pattern - Adjusted for better 4x5 readability
            {3, new bool[][]
            {
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { false, true,  false, true  }, // 0101
                new bool[] { false, true,  true,  false }  // 0110
            }},

            // ID 4 - Percent (%) Pattern
            {4, new bool[][]
            {
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { false, false, true,  false }, // 0010
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { true,  false, false, true  }  // 1001
            }},

            // ID 5 - Ampersand (&) Pattern
            {5, new bool[][]
            {
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { false, true,  false, true  }  // 0101
            }},

            // ID 6 - Apostrophe (') Pattern
            {6, new bool[][]
            {
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }  // 0000
            }},

            // ID 7 - Left Parenthesis ( ( ) Pattern
            {7, new bool[][]
            {
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { true,  true,  false, false }, // 1100
                new bool[] { true,  false, false, false }, // 1000
                new bool[] { true,  true,  false, false }, // 1100
                new bool[] { false, true,  true,  false }  // 0110
            }},

            // ID 8 - Right Parenthesis ( ) ) Pattern
            {8, new bool[][]
            {
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { false, false, true,  true  }, // 0011
                new bool[] { false, false, false, true  }, // 0001
                new bool[] { false, false, true,  true  }, // 0011
                new bool[] { false, true,  true,  false }  // 0110
            }},

            // ID 9 - Asterisk (*) Pattern
            {9, new bool[][]
            {
                new bool[] { false, false, false, false }, // 0000
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { false, false, false, false }  // 0000
            }},

            // ID 10 - Plus (+) Pattern
            {10, new bool[][]
            {
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, false, false, false }  // 0000
            }},

            // ID 11 - Comma (,) Pattern
            {11, new bool[][]
            {
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, true,  false }, // 0010
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { true,  true,  false, false }  // 1100
            }},

            // ID 12 - Minus/Dash (-) Pattern
            {12, new bool[][]
            {
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { true,  true,  true,  true  }, // 1111
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }  // 0000
            }},

            // ID 13 - Period/Dot (.) Pattern
            {13, new bool[][]
            {
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, false, false }, // 0000
                new bool[] { false, false, true,  false }  // 0010
            }},

            // ID 14 - Forward Slash (/) Pattern
            {14, new bool[][]
            {
                new bool[] { false, false, false, true  }, // 0001
                new bool[] { false, false, true,  true  }, // 0011
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { true,  true,  false, false }, // 1100
                new bool[] { true,  false, false, false }  // 1000
            }},

            // ID 15 - ? pattern
            {15, new bool[][]
            {
                new bool[] { false, true, false, false }, // 0100
                new bool[] { true,false,true,false }, // 1010
                new bool[] { false, false, true, false }, // 0010
                new bool[] { false, true, false, false }, // 0100
                new bool[] { false, true, false, false }  // 0100
            }}
        }; //arithmatic Data dic end 

        public static Dictionary<int, bool[][]> DataDigits = new()
{
            // ID 0 - Digit 0 Pattern
            {0, new bool[][]
            {
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { true,  false, true,  true  }, // 1011
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  true,  false, true  }, // 1101
                new bool[] { false, true,  true,  false }  // 0110
            }},

            // ID 1 - Digit 1 Pattern
            {1, new bool[][]
            {
                new bool[] { false, false, true,  false }, // 0010
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { false, false, true,  false }, // 0010
                new bool[] { false, false, true,  false }, // 0010
                new bool[] { false, true,  true,  true  }  // 0111
            }},

            // ID 2 - Digit 2 Pattern
            {2, new bool[][]
            {
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { false, false, true,  false }, // 0010
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { true,  false, false, false }, // 1000
                new bool[] { true,  true,  true,  false }  // 1110
            }},

            // ID 3 - Digit 3 Pattern
            {3, new bool[][]
            {
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { false, false, true,  false }, // 0010
                new bool[] { false, true,  true,  false }, // 0110
                new bool[] { false, false, true,  false }, // 0010
                new bool[] { false, true,  true,  false }  // 0110
            }},

            // ID 4 - Digit 4 Pattern
            {4, new bool[][]
            {
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { false, false, true,  false }, // 0010
                new bool[] { false, false, true,  false }  // 0010
            }},

            // ID 5 - Digit 5 Pattern
            {5, new bool[][]
            {
                new bool[] { false, true,  true,  true  }, // 0111
                new bool[] { false, true,  false, false }, // 0100
                new bool[] { false, true,  true,  true  }, // 0111
                new bool[] { false, false, false, true  }, // 0001
                new bool[] { false, true,  true,  true  }  // 0111
            }},

            // ID 6 - Digit 6 Pattern
            {6, new bool[][]
            {
                new bool[] { true,  true,  true,  true  }, // 1111
                new bool[] { true,  false, false, false }, // 1000
                new bool[] { true,  true,  true,  true  }, // 1111
                new bool[] { true,  false, false, true  }, // 1001
                new bool[] { true,  true,  true,  true  }  // 1111
            }},

            // ID 7 - Digit 7 Pattern
            {7, new bool[][]
            {
                new bool[] { false, true,  true,  true  }, // 0111
                new bool[] { false, false, false, true  }, // 0001
                new bool[] { false, false, false, true  }, // 0001
                new bool[] { false, false, false, true  }, // 0001
                new bool[] { false, false, false, true  }  // 0001
            }},

            // ID 8 - Digit 8 Pattern
            {8, new bool[][]
            {
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { true,  true,  true,  false }  // 1110
            }},

            // ID 9 - Digit 9 Pattern
            {9, new bool[][]
            {
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { true,  false, true,  false }, // 1010
                new bool[] { true,  true,  true,  false }, // 1110
                new bool[] { false, false, true,  false }, // 0010
                new bool[] { true,  true,  true,  false }  // 1110
            }},
            // ID 10 - Symbol : 
            {10, new bool[][]
            {
                new bool[] { false,false,false , false }, // 0000
                new bool[] { false,true,false,  false }, // 0100
                new bool[] { false,false,false,false }, // 0000
                new bool[] { false, true,false,false }, // 0100
                new bool[] { false,false,false,false }  // 0000
            }},
            // ID 11 - Symbol ;  
            {11, new bool[][]
            {
                new bool[] { false,false,false , false }, // 0000
                new bool[] { false,false,true,  false }, // 0010
                new bool[] { false,false,false,false }, // 0000
                new bool[] { false, false,true,false }, // 0010
                new bool[] { false,true,false,false }  // 0100
            }},
            // ID 12 - Symbol <
            {12, new bool[][]
            {
                new bool[] { false,false,true,false }, // 0010
                new bool[] { false,true,false,  false }, // 0100
                new bool[] { true,false,false,false }, // 1000
                new bool[] { false, true,false,false }, // 0100
                new bool[] { false, false, true, false }  // 0010
            }},
            // ID 13 - Symbol =
            {13, new bool[][]
            {
                new bool[] { false,false,false,false }, // 0000
                new bool[] { true,true,true, false }, // 1110
                new bool[] { false,false,false,false }, // 0000
                new bool[] { true,true,true, false }, // 1110
                new bool[] { false, false, false, false }  // 0000
            }},
            // ID 14 - Symbol >
            {14, new bool[][]
            {
                new bool[] { false,true,false,false }, // 0100
                new bool[] { false,false,true,false }, // 0010
                new bool[] { false,false,false,true  }, // 0001
                new bool[] { false,false,true,false }, // 0010
                new bool[] { false, true, false, false }  // 0100
            }},
            // ID 15 - Symbol ?
            {15, new bool[][]
            {
                new bool[] { false,true,false,false }, // 0100
                new bool[] { false,false,true,false }, // 1010
                new bool[] { false,false,true,false }, // 0010
                new bool[] { false,true,false,false}, // 0100
                new bool[] { false, true, false, false }  // 0100
            }},

        }; //digit end 

        public static Dictionary<int, bool[][]> DataSpecial = new()
        {
            // ID 5 - Space (keyboard page 0, code 5)
            {5, new bool[][]
            {
                new bool[] { true, true, true, true },
                new bool[] { true, true, true, true },
                new bool[] { true, true, true, true },
                new bool[] { true, true, true, true },
                new bool[] { true, true, true, true }
            }},

            // ID 6 - Enter arrow (keyboard page 0, code 6)
            {6, new bool[][]
            {
                new bool[] { false, false, false, true },
                new bool[] { false, false, true, true },
                new bool[] { false, true, true, false },
                new bool[] { true, true, false, false },
                new bool[] { false, false, false, false }
            }},
            // ID 8 - Backspace
            {8, new bool[][]
            {
                new bool[] { false, false, false, false },
                new bool[] { false, true,  false, false },
                new bool[] { true,  true,  true,  false },
                new bool[] { false, true,  false, false },
                new bool[] { false, false, false, false }
            }},



        };

        public static Dictionary<int, bool[][]> GameSprites = new()
        {
            //ID 0 -TILE 1
            
            // Sprite 1 (Top Left )
            { 0, new bool[][] {
                new bool[] { false,false,false,false },       // 0000
                new bool[] { false,false,false,true },     // 0001
                new bool[] { false, false, true, false },   // 0010
                new bool[] { false,false,true,false },     // 0010
                new bool[] { false, false, true,true }    // 0011
            }},
        
            // Sprite 2 (Top Center) 
            { 1, new bool[][] {
                new bool[] { true,true,true,true },   // 1111
                new bool[] { true,false,false,true },    // 1001
                new bool[] { false,false,false,false },    // 0000
                new bool[] { true,false,false,true },    // 1001
                new bool[] { false,false,false,false }      // 0000
            }},
    
            // Sprite 3 (Top Right)
            { 2, new bool[][] {
                new bool[] { false, false, false, false },    // 0000
                new bool[] { true,false,false,false },    // 1000
                new bool[] { false,true,false,false },    // 0100
                new bool[] { false, true, false,false },      // 0100
                new bool[] { true,true,false,false }    // 1100
            }},
    
            // Sprite 4 (Middle Left)
            { 3, new bool[][] {
                new bool[] { false, false,false,true },     // 0001
                new bool[] { false, false, false, true },   // 0001
                new bool[] { false, true, true, true },       // 0100
                new bool[] { false,true,true,true },     // 0111
                new bool[] { false,false,false,false }      // 0000
            }},
    
            // Sprite 5 (Middle Center)
            { 4, new bool[][] {
                new bool[] { false,true,true,false },    // 0110
                new bool[] { false,false,false,false },    // 0000
                new bool[] { true,true,true,true },    // 1111
                new bool[] { true, false,false,true },      // 1001
                new bool[] { true,false,false,true }    // 1001
            }},
    
            // Sprite 6 (Middle Right)
            { 5, new bool[][] {
                new bool[] { true, false, false, false },   // 1000
                new bool[] { true, false, false, true },    // 1000
                new bool[] { false, false, true, false },   // 0010
                new bool[] { true,true,true, false },   // 1110
                new bool[] { false, false, false, false }    // 0000
            }},
    
            // Sprite 7 (Bottom Left)
            { 6, new bool[][] {
                new bool[] { false,false,false,false },     // 0000
                new bool[] { false,false,false,true },     // 0001
                new bool[] { false, false, false, false },   // 0000
                new bool[] { false, false, false, false },   // 0000
                new bool[] { false, false, false, false }    // 0000
            }},
    
            // Sprite 8 (Bottom Center)
            { 7, new bool[][] {
                new bool[] { true, false, false, true },   // 1001
                new bool[] { true, false, false, true },    // 1001
                new bool[] { false, false, false, false },   // 0000
                new bool[] { false, false, false, false },   // 0000
                new bool[] { false, false, false, false }    // 0000
            }},
            //Sprite 9, (Bottom Left)
            {8, new bool[][]
            {
                new bool[] { false, false, false, false },   // 0000
                new bool[] { true, false, false, false },    // 1000
                new bool[] { false, false, false, false },   // 0000
                new bool[] { false, false, false, false },   // 0000
                new bool[] { false, false, false, false }    // 0000

            } }

        };

        public static Dictionary<int, bool[][]> GameMan1 = new()
        {
             // Sprite 1
             { 0, new bool[][] {
                 new bool[] { false, false, false, true },    // 0001
                 new bool[] { false, false, true, false },    // 0010
                 new bool[] { false, false, true, true },    // 0011
                 new bool[] { false, false, true, true },    // 0011
                 new bool[] { false, true, false, true }    // 0101
             }},

             // Sprite 2
             { 1, new bool[][] {
                 new bool[] { true, false, false, false },    // 1000
                 new bool[] { false, true, false, false },    // 0100
                 new bool[] { true, true, false, false },    // 1100
                 new bool[] { true, true, false, false },    // 1100
                 new bool[] { true, false, true, false }    // 1010
             }},

             // Sprite 3
             { 2, new bool[][] {
                 new bool[] { true, false, false, true },    // 1001
                 new bool[] { false, false, true, false },    // 0010
                 new bool[] { false, false, true, false },    // 0010
                 new bool[] { false, false, true, false },    // 0010
                 new bool[] { false, true, true, false }    // 0110
             }},

             // Sprite 4
             { 3, new bool[][] {
                 new bool[] { true, false, false, true },    // 1001
                 new bool[] { false, true, false, false },    // 0100
                 new bool[] { false, true, false, false },    // 0100
                 new bool[] { false, true, false, false },    // 0100
                 new bool[] { false, true, true, false }    // 0110
             }},



        };

        public static Dictionary<int, bool[][]> BallGame = new()
        {
             // Sprite 0
             { 0, new bool[][] {
                 new bool[] { false, false, false, false },    // 0000
                 new bool[] { false, false, true, true },    // 0011
                 new bool[] { false, true, true, true },    // 0111
                 new bool[] { true, true, true, true },    // 1111
                 new bool[] { true, true, true, true }    // 1111
             }},

             // Sprite 1
             { 1, new bool[][] {
                 new bool[] { false, false, false, false },    // 0000
                 new bool[] { true, true, false, false },    // 1100
                 new bool[] { true, true, true, false },    // 1110
                 new bool[] { true, true, true, true },    // 1111
                 new bool[] { false, true, true, true }    // 0111
             }},

             // Sprite 2
             { 2, new bool[][] {
                 new bool[] { true, true, true, false },    // 1110
                 new bool[] { true, true, true, true },    // 1111
                 new bool[] { false, true, true, true },    // 0111
                 new bool[] { false, false, true, true },    // 0011
                 new bool[] { false, false, false, false }    // 0000
             }},

             // Sprite 3
             { 3, new bool[][] {
                 new bool[] { true, true, true, true },    // 1111
                 new bool[] { true, true, true, true },    // 1111
                 new bool[] { true, true, true, false },    // 1110
                 new bool[] { true, true, false, false },    // 1100
                 new bool[] { false, false, false, false }    // 0000
             }},
              // Sprite 4
             { 4, new bool[][] {
                 new bool[] { true, false, true, false },    // 1010
                 new bool[] { false, true, false, true },    // 0101
                 new bool[] { true, false, true, false },    // 1010
                 new bool[] { false, true, false, true },    // 0101
                 new bool[] { true, false, true, false }    // 1010
             }},

             // Sprite 5
             { 5, new bool[][] {
                 new bool[] { true, false, true, false },    // 1010
                 new bool[] { false, true, false, true },    // 0101
                 new bool[] { true, false, true, false },    // 1010
                 new bool[] { false, true, false, true },    // 0101
                 new bool[] { true, false, true, false }    // 1010
             }},

             // Sprite 6
             { 6, new bool[][] {
                 new bool[] { false, true, false, true },    // 0101
                 new bool[] { true, false, true, false },    // 1010
                 new bool[] { false, true, false, true },    // 0101
                 new bool[] { true, false, true, false },    // 1010
                 new bool[] { false, true, false, true }    // 0101
             }},

             // Sprite 7
             { 7, new bool[][] {
                 new bool[] { false, true, false, true },    // 0101
                 new bool[] { true, false, true, false },    // 1010
                 new bool[] { false, true, false, true },    // 0101
                 new bool[] { true, false, true, false },    // 1010
                 new bool[] { false, true, false, true }    // 0101
             }},
             // Sprite 8
             { 8, new bool[][] {
                 new bool[] { false, false, true, false },    // 0010
                 new bool[] { false, false, true, true },    // 0011
                 new bool[] { false, true, false, true },    // 0101
                 new bool[] { false, true, true, true },    // 0111
                 new bool[] { false, false, true, false }    // 0010
             }},

             // Sprite 9
             { 9, new bool[][] {
                 new bool[] { false, true, false, false },    // 0100
                 new bool[] { true, true, false, false },    // 1100
                 new bool[] { true, false, true, false },    // 1010
                 new bool[] { true, true, true, false },    // 1110
                 new bool[] { false, true, false, false }    // 0100
             }},
            { 10, new bool[][]
            {
                new bool[] { false, false, false, false },
                new bool[] { false, false, false, false },
                new bool[] { false, false, false, false },
                new bool[] { false, false, false, false },
                new bool[] { false, false, false, false }


            }}






        };

        public static readonly List<Dictionary<int, bool[][]>> RomPages = new()
        {
            Data,
            Data1,
            DataArithSymbols,
            DataDigits,
            DataSpecial,
            //GameSprites,
            //GameMan1
            BallGame,
        };






    }
}
