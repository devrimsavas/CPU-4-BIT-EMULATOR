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
            Assembler.Compile(bootCode);
            while (Assembler.ExecuteNextLine()) { }

        }
        public static void Boot1 ()
        {
            string[] bootCode = new string[]
            {
                // CLS "mov ax,0000", "push ax", "store 000A",
                
                "call load_sprite",
                "main:",
                "mov ax,0111",
                "push ax",
                "store 000E",
                "call clear_s",
                "call cr",
                "loadb 2,0000",
                "store 000F",
                "loadb 2,0001",
                "store 000F",
                "loadb 2,0002",
                "store 000F",
                "call nl",
                "call cr",
                "loadb 2,0003",
                "store 000F",
                "loadb 2,0004",
                "store 000F",
                "loadb 2,0005",
                "store 000F",
                "call nl",
                "call cr",
                "loadb 2,0006",
                "store 000F",
                "loadb 2,0007",
                "store 000F",
                "loadb 2,0008",
                "store 000F",
                "call nl",
                "call cr",
                "loadb 2,0009",
                "store 000F",
                "loadb 2,000A",
                "store 000F",
                "loadb 2,000B",
                "store 000F",
                "call nl",
                "call cr",
                "loadb 2,000C",
                "store 000F",
                "loadb 2,000D",
                "store 000F",
                "loadb 2,000E",
                "store 000F",
                "call nl",
                "call cr",
                "loadb 2,000F",
                "store 000F",
                "loadb 3,0000",
                "store 000F",
                "loadb 3,0001",
                "store 000F",
                "call nl",
                "call cr",
                "loadb 3,0002",
                "store 000F",
                "loadb 3,0003",
                "store 000F",
                "loadb 3,0004",
                "store 000F",
                "call nl",
                "call cr",
                "loadb 3,0005",
                "store 000F",
                "loadb 3,0006",
                "store 000F",
                "loadb 3,0007",
                "store 000F",
                "call nl",
                "call cr",
                "loadb 3,0008",
                "store 000F",
                "loadb 3,0009",
                "store 000F",
                "loadb 3,000A",
                "store 000F",
                "call nl",
                "call cr",
                "loadb 3,000B",
                "store 000F",
                "loadb 3,000C",
                "store 000F",
                "loadb 3,000D",
                "store 000F",
                "call nl",
                "call cr",
                "loadb 3,000E",
                "store 000F",
                "loadb 3,000F",
                "store 000F",
                "loadb 4,0000",
                "store 000F",
                "call nl",
                "call cr",
                "loadb 4,0001",
                "store 000F",
                "loadb 4,0002",
                "store 000F",
                "loadb 4,0003",
                "store 000F",
                "jmp end",
                "cr:",
                "mov ax,0000",
                "push ax",
                "store 000D",
                "ret",
                "nl:",
                "mov ax,0001",
                "push ax",
                "store 000B",
                "ret",
                "clear_s:",
                "mov ax,0000",
                "push ax",
                "store 000A",
                "ret",
                "load_sprite:",
                "mov ax,0000",
                "push ax",
                "storeb 2,0000",
                "mov ax,1111",
                "push ax",
                "storeb 2,0001",
                "mov ax,0000",
                "push ax",
                "storeb 2,0002",
                "mov ax,0001",
                "push ax",
                "storeb 2,0003",
                "mov ax,0000",
                "push ax",
                "storeb 2,0004",
                "mov ax,1000",
                "push ax",
                "storeb 2,0005",
                "mov ax,0010",
                "push ax",
                "storeb 2,0006",
                "mov ax,1001",
                "push ax",
                "storeb 2,0007",
                "mov ax,0100",
                "push ax",
                "storeb 2,0008",
                "mov ax,0010",
                "push ax",
                "storeb 2,0009",
                "mov ax,0000",
                "push ax",
                "storeb 2,000A",
                "mov ax,0100",
                "push ax",
                "storeb 2,000B",
                "mov ax,0010",
                "push ax",
                "storeb 2,000C",
                "mov ax,1001",
                "push ax",
                "storeb 2,000D",
                "mov ax,0100",
                "push ax",
                "storeb 2,000E",
                "mov ax,0010",
                "push ax",
                "storeb 2,000F",
                "mov ax,0110",
                "push ax",
                "storeb 3,0000",
                "mov ax,0100",
                "push ax",
                "storeb 3,0001",
                "mov ax,0001",
                "push ax",
                "storeb 3,0002",
                "mov ax,0000",
                "push ax",
                "storeb 3,0003",
                "mov ax,1000",
                "push ax",
                "storeb 3,0004",
                "mov ax,1000",
                "push ax",
                "storeb 3,0005",
                "mov ax,1111",
                "push ax",
                "storeb 3,0006",
                "mov ax,0001",
                "push ax",
                "storeb 3,0007",
                "mov ax,1100",
                "push ax",
                "storeb 3,0008",
                "mov ax,0110",
                "push ax",
                "storeb 3,0009",
                "mov ax,0011",
                "push ax",
                "storeb 3,000A",
                "mov ax,1110",
                "push ax",
                "storeb 3,000B",
                "mov ax,0110",
                "push ax",
                "storeb 3,000C",
                "mov ax,0111",
                "push ax",
                "storeb 3,000D",
                "mov ax,0111",
                "push ax",
                "storeb 3,000E",
                "mov ax,1111",
                "push ax",
                "storeb 3,000F",
                // BANK 4
                "mov ax,1110",
                "push ax",
                "storeb 4,0000",
                "mov ax,0001",
                "push ax",
                "storeb 4,0001",
                "mov ax,1111",
                "push ax",
                "storeb 4,0002",
                "mov ax,1000",
                "push ax",
                "storeb 4,0003",
                "ret",
                "end:",


            };
            Assembler.Compile(bootCode);
            while (Assembler.ExecuteNextLine()) { }
        }
    }
}
