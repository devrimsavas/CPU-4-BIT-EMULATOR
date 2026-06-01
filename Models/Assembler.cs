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
            //=== Ram Operations ===
            //Handle Store "STORE 1111" to store AX value into RAM address 0x0F (15 in decimal)
            if (cleanLine.StartsWith("STORE ", StringComparison.OrdinalIgnoreCase))
            {
                // Extract the 4-bit binary address
                string binaryAddr = cleanLine.Substring(6).Trim();

                if (binaryAddr.Length == 4 && binaryAddr.All(c => c == '0' || c == '1'))
                {
                    // Convert binary string to decimal integer for dictionary key
                    int address = Convert.ToInt32(binaryAddr, 2);

                    // Pop the value from the top of the stack
                    var poppedReg = Program.Stack.PopRegister();

                    if (poppedReg != null)
                    {
                        // Write to Data RAM
                        DataMemory.Write(address, poppedReg.RegArray);
                        string bitString = string.Join("", poppedReg.RegArray.Select(b => b ? "1" : "0"));
                        OnExecutionComplete?.Invoke($"STORE: Saved {bitString} to RAM[0x{address:X2}]");
                    }
                    else
                    {
                        OnExecutionComplete?.Invoke("Hardware Error: Stack Underflow. Nothing to STORE.");
                    }
                    return;
                }
                else
                {
                    OnExecutionComplete?.Invoke($"Syntax Error: Invalid 4-bit address '{binaryAddr}'");
                    return;
                }
            }

            // Handle LOAD command (e.g., "LOAD 0010")
            if (cleanLine.StartsWith("LOAD ", StringComparison.OrdinalIgnoreCase))
            {
                // Extract the 4-bit binary address
                string binaryAddr = cleanLine.Substring(5).Trim();

                if (binaryAddr.Length == 4 && binaryAddr.All(c => c == '0' || c == '1'))
                {
                    // Convert binary string to decimal integer for dictionary key
                    int address = Convert.ToInt32(binaryAddr, 2);

                    // Read from Data RAM
                    bool[] ramData = DataMemory.Read(address);

                    // Push the read data onto the stack
                    Program.Stack.AddRegister(new Register("RAM", (bool[])ramData.Clone()));
                    string bitString = string.Join("", ramData.Select(b => b ? "1" : "0"));
                    OnExecutionComplete?.Invoke($"LOAD: Fetched {bitString} from RAM[0x{address:X2}]");
                    return;
                }
                else
                {
                    OnExecutionComplete?.Invoke($"Syntax Error: Invalid 4-bit address '{binaryAddr}'");
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

        // Helper method to convert text mnemonics to 8-bit machine code for the UI Grid
        public static string GetMachineCode(string line)
        {
            string cleanLine = line.Trim().ToUpper();

            // 1. Handle Dynamic PUSH with data (e.g., "PUSH AX, 0110")
            // First 4 bits: Opcode (1100 or 1101), Last 4 bits: The binary data
            if (cleanLine.StartsWith("PUSH AX,"))
            {
                string data = cleanLine.Substring(8).Trim();
                return "1100" + data;
            }
            if (cleanLine.StartsWith("PUSH BX,"))
            {
                string data = cleanLine.Substring(8).Trim();
                return "1101" + data;
            }
            //memory load 
            if (cleanLine.StartsWith("LOAD "))
            {
                string data = cleanLine.Substring(5).Trim();
                return "0110" + data; 
            }
            //memory store
            if (cleanLine.StartsWith("STORE "))
            {
                string data = cleanLine.Substring(6).Trim();
                return "0111" + data; // 
            }

            // 2. Handle Standard 4-bit instructions (Padded with 0000 to complete 8-bit architecture)
            switch (cleanLine)
            {
                case "AND": return "00000000";
                case "OR": return "00010000";
                case "XOR": return "00100000";
                case "NOT": return "00110000";
                case "ADD": return "01000000";
                case "SUB": return "01010000";
                case "SHL": return "10000000";
                case "SHR": return "10010000";
                case "INC": return "10100000";
                case "DEC": return "10110000";
                case "PUSH AX": return "11000000";
                case "PUSH BX": return "11010000";
                case "POP AX": return "11100000";
                case "POP BX": return "11110000";
                case "LOAD": return "01100000"; // Custom code for LOAD operation
                case "STORE": return "01110000"; // Custom code for STORE operation

                default: return "00000000"; // Fallback for syntax errors
            }
        }

    }
}