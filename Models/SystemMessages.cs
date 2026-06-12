using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public static class SystemMessages
    {
        // English documentation repository for the UI menus
        public static readonly string AboutInfo =
            "Custom 4-Bit Retro Microprocessor Emulator\n" +
            "Version: 1.0 (Development Phase)\n\n" +
            "Architecture Specifications:\n" +
            "- 4-Bit Shared Data Bus\n" +
            "- 2 Discrete Internal Hardware Registers (AX, BX)\n" +
            "- Hardware-based FILO/LIFO Memory Stack\n" +
            "- Combinational Logic ALU (16-Opcode Limit)\n\n" +
            "Designed and Emulated smoothly in C# WinForms.\n\n" +
            "2026 © Devrim Savas Yilmaz.\n";

        public static readonly string IsaReferenceInfo =
            "SUPPORTED INSTRUCTION SET ARCHITECTURE (ISA):\n\n" +
            "0000: AND        - Bitwise Logical AND (TempA & TempB)\n" +
            "0001: OR         - Bitwise Logical OR (TempA | TempB)\n" +
            "0010: XOR        - Bitwise Logical XOR (TempA ^ TempB)\n" +
            "0011: NOT        - Invert TempA Bits (~TempA)\n" +
            "0100: ADD        - Arithmetic Addition (TempA + TempB)\n" +
            "0101: SUB        - Arithmetic Subtraction (TempA - TempB)\n" +
            "1000: SHL        - Shift TempA Left by 1 position\n" +
            "1001: SHR        - Shift TempA Right by 1 position\n" +
            "1010: INC        - Increment TempA by 1\n" +
            "1011: DEC        - Decrement TempA by 1\n" +
            "1100: PUSH AX    - Push AX Register onto Stack\n" +
            "1101: PUSH BX    - Push BX Register onto Stack\n" +
            "1110: POP AX     - Pop Top of Stack into AX Register\n" +
            "1111: POP BX     - Pop Top of Stack into BX Register";

        public static readonly string OpGuideInfo =
            "SUPPORTED INSTRUCTION SET ARCHITECTURE (ISA):\n\n" +
            "-- LOGICAL OPERATIONS --\n" +
            "0000: AND      - Bitwise Logical AND\n" +
            "0001: OR       - Bitwise Logical OR\n" +
            "0010: XOR      - Bitwise Logical XOR\n" +
            "0011: NOT      - Invert TempA Bits (~TempA)\n\n" +
            "-- ARITHMETIC OPERATIONS --\n" +
            "0100: ADD      - Arithmetic Addition (TempA + TempB)\n" +
            "0101: SUB      - Arithmetic Subtraction (TempA - TempB)\n\n" +
            "-- ADVANCED OPERATIONS --\n" +
            "1000: SHL      - Shift TempA Left by 1 position\n" +
            "1001: SHR      - Shift TempA Right by 1 position\n" +
            "1010: INC      - Increment TempA by 1\n" +
            "1011: DEC      - Decrement TempA by 1\n\n" +
            "-- STACK & REGISTER OPERATIONS --\n" +
            "1100: PUSH AX  - Push AX Register onto Stack\n" +
            "1101: PUSH BX  - Push BX Register onto Stack\n" +
            "1110: POP AX   - Pop Stack Top into AX Register\n" +
            "1111: POP BX   - Pop Stack Top into BX Register";
    }

}
