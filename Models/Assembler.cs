using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public static class Assembler
    {
        // This delegate or action will point to  Form's UI update logic
        public static Action<string> OnExecutionComplete;

    private static readonly Dictionary<string, Action> instructionSet = new(StringComparer.OrdinalIgnoreCase)

    {
            // === LOGICAL OPERATIONS ===
        { "AND",   () => RunHardwareOperation(new bool[] { false, false, false, false }) }, // 0000
        { "OR",    () => RunHardwareOperation(new bool[] { false, false, false, true  }) }, // 0001
        { "XOR",   () => RunHardwareOperation(new bool[] { false, false, true,  false }) }, // 0010
        { "NOT",   () => RunHardwareOperation(new bool[] { false, false, true,  true  }) }, // 0011 

        // === ARITHMETIC OPERATIONS ===
        { "ADD",   () => RunHardwareOperation(new bool[] { false, true,  false, false }) }, // 0100
        { "SUB",   () => RunHardwareOperation(new bool[] { false, true,  false, true  }) }, // 0101

        // === ADVANCED OPERATIONS ===
        { "SHL",   () => RunHardwareOperation(new bool[] { true,  false, false, false }) }, // 1000
        { "SHR",   () => RunHardwareOperation(new bool[] { true,  false, false, true  }) }, // 1001
        { "INC",   () => RunHardwareOperation(new bool[] { true,  false, true,  false }) }, // 1010
        { "DEC",   () => RunHardwareOperation(new bool[] { true,  false, true,  true  }) }, // 1011

        // === STACK OPERATIONS (Strict Hardware Bit Mapping) ===
        { "PUSH AX", () => RunStackOperation(new bool[] { true,  true,  false, false }) }, // 1100
        { "PUSH BX", () => RunStackOperation(new bool[] { true,  true,  false, true  }) }, // 1101
        { "POP AX",  () => RunStackOperation(new bool[] { true,  true,  true,  false }) }, // 1110
        { "POP BX",  () => RunStackOperation(new bool[] { true,  true,  true,  true  }) }  // 1111
        
        //{"OUT AX",()=> RunHardwareOperation(new bool[] { true,  true,  true,  true }) }, // 1111 4 BIT LIMIT SO THIS IS NOT IMPLEMENTED, MAYBE LATER IF I ADD MORE REGISTERS OR EXPAND TO 8 BITS
    };

        //parser 
        public static void RunCode(string line)
        {
            // Clean spaces
            string cleanLine = line.Trim();

            //  Check if it's a dynamic PUSH AX with a binary value!
            if (cleanLine.StartsWith("PUSH AX,", StringComparison.OrdinalIgnoreCase))
            {
                // Extract the binary string part (e.g., "1111")
                string binaryPart = cleanLine.Substring(8).Trim(); // Takes everything after "PUSH AX,"

                if (binaryPart.Length == 4 && binaryPart.All(c => c == '0' || c == '1'))
                {
                    // Convert "1111" string to bool[] array
                    bool[] newRegValue = binaryPart.Select(c => c == '1').ToArray();

                    // Inject the data directly into the hardware register!
                    //Program.Ax.RegArray = newRegValue;
                    Program.Ax.RegArray = (bool[])newRegValue.Clone();

                    // Now that AX is loaded, safely fire the standard PUSH AX action from the dictionary
                    if (instructionSet.TryGetValue("PUSH AX", out var pushAction))
                    {
                        pushAction.Invoke();
                        //return; // Execution finished successfully
                        OnExecutionComplete?.Invoke($"Loaded AX with {binaryPart} directly");
                        return; // Execution finished successfully
                    }
                }
                else
                {
                    OnExecutionComplete?.Invoke($"Syntax Error: Invalid 4-bit binary value '{binaryPart}'");
                    return;
                }
            }
            //PUSH BX
            if (cleanLine.StartsWith("PUSH BX,", StringComparison.OrdinalIgnoreCase))
            {
                // Extract the binary string part after "PUSH BX,"
                string binaryPart = cleanLine.Substring(8).Trim();

                if (binaryPart.Length == 4 && binaryPart.All(c => c == '0' || c == '1'))
                {
                    // Convert string to bool[] array
                    bool[] newRegValue = binaryPart.Select(c => c == '1').ToArray();

                    // Inject the data directly into the BX hardware register!
                    //Program.Bx.RegArray = newRegValue;
                    Program.Bx.RegArray = (bool[])newRegValue.Clone();

                    // Safely fire the standard PUSH BX action from your dictionary
                    if (instructionSet.TryGetValue("PUSH BX", out var pushAction))
                    {
                        pushAction.Invoke();
                        OnExecutionComplete?.Invoke($"Loaded BX with {binaryPart} directly");
                        return;
                        //return; // Execution finished successfully
                    }
                }
                else
                {
                    OnExecutionComplete?.Invoke($"Syntax Error: Invalid 4-bit binary value '{binaryPart}'");
                    return;
                }
            }


            // === instructions ===
            if (instructionSet.TryGetValue(cleanLine, out var hardwareAction))
            {
                hardwareAction.Invoke();
            }
            else
            {
                OnExecutionComplete?.Invoke($"Invalid instruction: {cleanLine}");
            }
        }

        // hardwares
        private static void RunHardwareOperation(bool[] opcode)
        {
            var poppedB = Program.Stack.PopRegister();
            var poppedA = Program.Stack.PopRegister();

            // If data exists in stack, load it. If it's null, our AluInputBuffer defaults will handle it!
            if (poppedA != null) AluInputBuffer.LoadTempA(poppedA.RegArray);
            else AluInputBuffer.IsTempALoaded = false; // Force AluInputBuffer to assign 0000

            if (poppedB != null) AluInputBuffer.LoadTempB(poppedB.RegArray);
            else AluInputBuffer.IsTempBLoaded = false; // Force AluInputBuffer to assign 0000

            // 1. Load the 4-bit signal into the control unit buffer
            AluInputBuffer.LoadOppCode(opcode);

            // 2. Fire the processor logic directly!
            bool[] hardwareResult = AluInputBuffer.Execute();

            // 3. Convert the bool array to a readable string (e.g., "0110")
            string stringResult = string.Join("", hardwareResult.Select(b => b ? "1" : "0"));

            // 4. Send this result back to the Form's Output Window automatically
            OnExecutionComplete?.Invoke("Result: " + stringResult);
        }
        //  helper for stack operations
        public static void RunStackOperation(bool[] opcode)
        {
            string operationName = "";

            // 1100: PUSH AX
            if (opcode[0] && opcode[1] && !opcode[2] && !opcode[3])
            {
                Program.Stack.AddRegister(new Register("Ax", (bool[])Program.Ax.RegArray.Clone()));
                operationName = "PUSH AX";
            }
            // 1101: PUSH BX
            else if (opcode[0] && opcode[1] && !opcode[2] && opcode[3])
            {
                Program.Stack.AddRegister(new Register("Bx", (bool[])Program.Bx.RegArray.Clone()));
                operationName = "PUSH BX";
            }
            // 1110: POP AX
            else if (opcode[0] && opcode[1] && opcode[2] && !opcode[3])
            {
                var poppedRegister = Program.Stack.PopRegister();
                if (poppedRegister != null) Program.Ax.RegArray = (bool[])poppedRegister.RegArray.Clone();
                operationName = "POP AX";
            }
            // 1111: POP BX
            else if (opcode[0] && opcode[1] && opcode[2] && opcode[3])
            {
                var poppedRegister = Program.Stack.PopRegister();
                if (poppedRegister != null) Program.Bx.RegArray = (bool[])poppedRegister.RegArray.Clone();
                operationName = "POP BX";
            }

            // Send the result back to the Form's UI automatically so it can refresh boxes
            OnExecutionComplete?.Invoke("Executed: " + operationName);
        }

    }
}