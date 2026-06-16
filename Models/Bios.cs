using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public static class Bios
    {
        public static void Boot()
        {
            string[] bootCode = new string[]
            {
                // CLS
                "mov ax,0000", "push ax", "store 000A",
        
                // Color = Cyan (1011)
                "mov ax,1011", "push ax", "store 000E",
        
                // === BIT4 === (ROM page 0: B=1, I=8 | ROM page 1: T=3 | ROM page 3: 4=4)
                // B — page 0, ID 1
                "mov ax,0000", "push ax", "store 0009",
                "mov ax,0001", "push ax", "print",
                // I — page 0, ID 8
                "mov ax,1000", "push ax", "print",
                // T — page 1, ID 3
                "mov ax,0001", "push ax", "store 0009",
                "mov ax,0011", "push ax", "print",
                // 4 — page 3, ID 4
                "mov ax,0011", "push ax", "store 0009",
                "mov ax,0100", "push ax", "print",

                // Color = Yellow (1110)
                "mov ax,1110", "push ax", "store 000E",

                // newline
                "mov ax,0110", "push ax", "store 000B",
                "mov ax,0000", "push ax", "store 000D",

                // === WELCOME === 
                // W — page 1, ID 6
                "mov ax,0001", "push ax", "store 0009",
                "mov ax,0110", "push ax", "print",
                // E — page 0, ID 4
                "mov ax,0000", "push ax", "store 0009",
                "mov ax,0100", "push ax", "print",
                // L — page 0, ID 11
                "mov ax,1011", "push ax", "print",
                // C — page 0, ID 2
                "mov ax,0010", "push ax", "print",
                // O — page 0, ID 14
                "mov ax,1110", "push ax", "print",
                // M — page 0, ID 12
                "mov ax,1100", "push ax", "print",
                // E — page 0, ID 4
                "mov ax,0100", "push ax", "print",

                // newline
                "mov ax,0110", "push ax", "store 000B",
                "mov ax,0000", "push ax", "store 000D",

                // Color = Green (1010)
                "mov ax,1010", "push ax", "store 000E",

                // === READY ===
                // R — page 1, ID 1
                "mov ax,0001", "push ax", "store 0009",
                "mov ax,0001", "push ax", "print",
                // E — page 0, ID 4
                "mov ax,0000", "push ax", "store 0009",
                "mov ax,0100", "push ax", "print",
                // A — page 0, ID 0
                "mov ax,0000", "push ax", "print",
                // D — page 0, ID 3
                "mov ax,0011", "push ax", "print",
                // Y — page 1, ID 8
                "mov ax,0001", "push ax", "store 0009",
                "mov ax,1000", "push ax", "print",
                // newline
                "mov ax,0110", "push ax", "store 000B",
                "mov ax,0000", "push ax", "store 000D",

                // Color = Light Gray (0111)
                "mov ax,0111", "push ax", "store 000E",

                // === 244 BYTES FREE ===
                // 2 — page 3, ID 2
                "mov ax,0011", "push ax", "store 0009",
                "mov ax,0010", "push ax", "print",
                // 4 — page 3, ID 4
                "mov ax,0100", "push ax", "print",
                // 4 — page 3, ID 4
                "mov ax,0100", "push ax", "print",
                // space — page 1, ID 15
                "mov ax,0001", "push ax", "store 0009",
                "mov ax,1111", "push ax", "print",
                // B — page 0, ID 1
                "mov ax,0000", "push ax", "store 0009",
                "mov ax,0001", "push ax", "print",
                // Y — page 1, ID 8
                "mov ax,0001", "push ax", "store 0009",
                "mov ax,1000", "push ax", "print",
                // T — page 1, ID 3
                "mov ax,0011", "push ax", "print",
                // E — page 0, ID 4
                "mov ax,0000", "push ax", "store 0009",
                "mov ax,0100", "push ax", "print",
                // S — page 1, ID 2
                "mov ax,0001", "push ax", "store 0009",
                "mov ax,0010", "push ax", "print",
                // space — page 1, ID 15
                "mov ax,1111", "push ax", "print",
                // F — page 0, ID 5
                "mov ax,0000", "push ax", "store 0009",
                "mov ax,0101", "push ax", "print",
                // R — page 1, ID 1
                "mov ax,0001", "push ax", "store 0009",
                "mov ax,0001", "push ax", "print",
                // E — page 0, ID 4
                "mov ax,0000", "push ax", "store 0009",
                "mov ax,0100", "push ax", "print",
                // E — page 0, ID 4
                "mov ax,0100", "push ax", "print",

            };
            //Assembler.Compile(bootCode);
            //while (Assembler.ExecuteNextLine()) { }



        }
    }
}
