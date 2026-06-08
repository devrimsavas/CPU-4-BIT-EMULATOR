using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public static class Assembler
    {
        //program counter and label memory 
        public static int PC { get;private set; } = 0; //line number tracker for execution flow control, can be used for future jump instructions and loops
        public static Dictionary<string,int> Labels=new(StringComparer.OrdinalIgnoreCase); // Label memory to store line numbers for jump instructions, currently unused but essential for future control flow features
        public static string[] LoadedCode=Array.Empty<string>(); // Loaded code from file or input, can be used for multi-line execution and future features like loops and conditionals
        //Zero flag 
        public static bool ZeroFlag { get; set; } = false; // Zero flag to indicate if the last ALU operation resulted in zero, can be used for future conditional jump instructions    
        //callstack for call and ret instructions 
        public static Stack<int> CallStack { get;private set; }=new Stack<int>(); // Call stack to manage return addresses for CALL and RET instructions, currently unused but essential for future function call features

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
            //
            // === IMMEDIATE ASSIGNMENT (MOV) ===
            // Check if it's a dynamic MOV AX with a binary value!
            if (cleanLine.StartsWith("MOV AX,", StringComparison.OrdinalIgnoreCase))
            {
                // Extract the binary string part (e.g., "1111")
                string binaryPart = cleanLine.Substring(7).Trim(); // Takes everything after "MOV AX,"

                if (binaryPart.Length == 4 && binaryPart.All(c => c == '0' || c == '1'))
                {
                    // Convert "1111" string to bool[] array
                    bool[] newRegValue = binaryPart.Select(c => c == '1').ToArray();

                    // Inject the data directly into the hardware register
                    Program.Ax.RegArray = (bool[])newRegValue.Clone();

                    // Log success to UI without touching the Stack!
                    OnExecutionComplete?.Invoke($"Loaded AX with {binaryPart} directly via MOV");
                    return; // Execution finished successfully
                }
                else
                {
                    OnExecutionComplete?.Invoke($"Syntax Error: Invalid 4-bit binary value '{binaryPart}'");
                    return;
                }
            }

            // MOV BX
            if (cleanLine.StartsWith("MOV BX,", StringComparison.OrdinalIgnoreCase))
            {
                // Extract the binary string part after "MOV BX,"
                string binaryPart = cleanLine.Substring(7).Trim();

                if (binaryPart.Length == 4 && binaryPart.All(c => c == '0' || c == '1'))
                {
                    // Convert string to bool[] array
                    bool[] newRegValue = binaryPart.Select(c => c == '1').ToArray();

                    // Inject the data directly into the BX hardware register
                    Program.Bx.RegArray = (bool[])newRegValue.Clone();

                    // Log success to UI without touching the Stack!
                    OnExecutionComplete?.Invoke($"Loaded BX with {binaryPart} directly via MOV");
                    return; // Execution finished successfully
                }
                else
                {
                    OnExecutionComplete?.Invoke($"Syntax Error: Invalid 4-bit binary value '{binaryPart}'");
                    return;
                }
            }
            //=== Ram Operations ===
            //Handle Store "STORE 1111" to store AX value into RAM address 0x0F (15 in decimal)
            // === STORE  ===

            if (cleanLine.StartsWith("STORE ", StringComparison.OrdinalIgnoreCase))
            {
                string rawAddr = cleanLine.Substring(6).Trim();

                try
                {
                    // Parse the address directly as Hexadecimal (e.g., "0A", "000F")
                    int address = Convert.ToInt32(rawAddr, 16);

                    // Ensure the address is within the 16-address limit (0x00 to 0x0F)
                    if (address >= 0 && address < 16)
                    {
                        var poppedReg = Program.Stack.PopRegister();

                        if (poppedReg != null)
                        {
                            DataMemory.Write(address, poppedReg.RegArray);

                            string bitString = string.Join("", poppedReg.RegArray.Select(b => b ? "1" : "0"));
                            OnExecutionComplete?.Invoke($"STORE: Saved {bitString} to RAM[0x{address:X2}]");
                        }
                        else
                        {
                            OnExecutionComplete?.Invoke("Hardware Error: Stack Underflow.");
                        }
                    }
                    else
                    {
                        OnExecutionComplete?.Invoke($"Hardware Error: Address out of range '{rawAddr}'. Max is 0F.");
                    }
                }
                catch
                {
                    OnExecutionComplete?.Invoke($"Syntax Error: Invalid hex address '{rawAddr}'");
                }

                return;
            }

            // === LOAD ===
            if (cleanLine.StartsWith("LOAD ", StringComparison.OrdinalIgnoreCase))
            {
                string rawAddr = cleanLine.Substring(5).Trim();

                try
                {
                    // Parse the address directly as Hexadecimal
                    int address = Convert.ToInt32(rawAddr, 16);

                    // Ensure the address is within the 16-address limit
                    if (address >= 0 && address < 16)
                    {
                        bool[] ramData = DataMemory.Read(address);
                        Program.Stack.AddRegister(new Register("RAM", (bool[])ramData.Clone()));

                        string bitString = string.Join("", ramData.Select(b => b ? "1" : "0"));
                        OnExecutionComplete?.Invoke($"LOAD: Fetched {bitString} from RAM[0x{address:X2}]");
                    }
                    else
                    {
                        OnExecutionComplete?.Invoke($"Hardware Error: Address out of range '{rawAddr}'. Max is 0F.");
                    }
                }
                catch
                {
                    OnExecutionComplete?.Invoke($"Syntax Error: Invalid hex address '{rawAddr}'");
                }

                return;
            }

            //==PRINT (VIDEO OUT) LOGIC 
            if (cleanLine.Equals("PRINT", StringComparison.OrdinalIgnoreCase))
            {
                var poppedReg = Program.Stack.PopRegister();

                if (poppedReg != null)
                {
                    // Convert 4-bit boolean array to an integer ID (0 to 15)
                    int charId = (poppedReg.RegArray[0] ? 8 : 0) +
                                 (poppedReg.RegArray[1] ? 4 : 0) +
                                 (poppedReg.RegArray[2] ? 2 : 0) +
                                 (poppedReg.RegArray[3] ? 1 : 0);

                    // Fetch pixels directly from the Character ROM
                    if (CharacterRom.Data1.TryGetValue(charId, out bool[][] pattern)) //ROM 1
                    {
                        // UI update log for successful decoding
                        OnExecutionComplete?.Invoke($"VPU DECODER: Drawing Char ID {charId} to screen via PRINT");

                        // NOTE: WinForms UI pixel drawing logic will go here
                        /*
                        for (int r=0;r<pattern.Length;r++)
                        {
                            //1. send 4 bits to screen to draw to row simulates STORE 000F
                            DataMemory.ScreenHardware.ProcessCommand(15, pattern[r]);
                            //trigger Y scrolle STORE 000B sim with 0001
                            DataMemory.ScreenHardware.ProcessCommand(11, new bool[] { false, false, false, true });
                        }
                        */
                        // Send the entire pattern to the monitor's new hardware function
                        DataMemory.ScreenHardware.DrawCharacter(pattern);



                    }
                    else
                    {
                        OnExecutionComplete?.Invoke($"VPU ERROR: Unknown Char ID {charId} in ROM");
                    }
                }
                else
                {
                    OnExecutionComplete?.Invoke("Hardware Error: Stack Underflow during PRINT!");
                }

                return;
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
            AluInputBuffer.ClearBuffers(); // Clear buffers before loading new data

            // 1. Determine if operation is Unary (1 parameter) or Binary (2 parameters)
            // 10xx (SHL, SHR, INC, DEC) and 0011 (NOT) are unary operations.
            bool isUnary = opcode[0] == true || (opcode[0] == false && opcode[1] == false && opcode[2] == true && opcode[3] == true);


            WinFormsApp1.Models.Register poppedA = null;
            WinFormsApp1.Models.Register poppedB = null;
            //  (DEBUGGING)
            string opName = string.Join("", opcode.Select(b => b ? "1" : "0"));
            string valA = poppedA != null ? string.Join("", poppedA.RegArray.Select(b => b ? "1" : "0")) : "NULL";
            string valB = poppedB != null ? string.Join("", poppedB.RegArray.Select(b => b ? "1" : "0")) : "NULL";

            
            Console.WriteLine($"ALU DEBUG: Opcode:{opName} | A:{valA} | B:{valB}");

            if (isUnary)
            {
                // Pop only once and assign directly to A for unary operations
                poppedA = Program.Stack.PopRegister();
            }
            else
            {
                // Pop twice for binary operations (LIFO: first popped is B, second is A)
                poppedB = Program.Stack.PopRegister();
                poppedA = Program.Stack.PopRegister();
            }

            // Load into buffers safely
            if (poppedA != null) AluInputBuffer.LoadTempA(poppedA.RegArray);
            else AluInputBuffer.IsTempALoaded = false; // Force AluInputBuffer to assign 0000

            if (poppedB != null) AluInputBuffer.LoadTempB(poppedB.RegArray);
            else AluInputBuffer.IsTempBLoaded = false; // Force AluInputBuffer to assign 0000

            // Load opcode and execute hardware logic
            AluInputBuffer.LoadOppCode(opcode);
            bool[] hardwareResult = AluInputBuffer.Execute();
            //update zero flag based on the result
            ZeroFlag = hardwareResult.All(bit => bit == false);

            // 2. CRITICAL FIX: Write-Back the result to the Stack!
            // Clone the array to prevent memory reference ghosting bugs
            Program.Stack.AddRegister(new WinFormsApp1.Models.Register("ALU_RES", (bool[])hardwareResult.Clone()));

            // Convert to readable string and log to UI
            string stringResult = string.Join("", hardwareResult.Select(b => b ? "1" : "0"));
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
            //string cleanLine = line.Trim().ToUpper();
            string cleanLine=Regex.Replace(line.Trim(), @"\s+", " ").ToUpper(); // Normalize spaces and convert to uppercase for consistent parsing

            // 1. Handle Dynamic PUSH with data (e.g., "PUSH AX, 0110")
            // First 4 bits: Opcode (1100 or 1101), Last 4 bits: The binary data
            if (cleanLine.StartsWith("MOV AX,",StringComparison.OrdinalIgnoreCase))
            {
                string data = cleanLine.Substring(8).Trim();
                return "1100" + data;
            }
            if (cleanLine.StartsWith("MOV BX,",StringComparison.OrdinalIgnoreCase))
            {
                string data = cleanLine.Substring(8).Trim();
                return "1101" + data;
            }
            //memory load 
            if (cleanLine.StartsWith("LOAD ",StringComparison.OrdinalIgnoreCase))
            {
                string data = cleanLine.Substring(5).Trim();
                return "0110" + To4BitBinary(data); 
            }
            //memory store
            if (cleanLine.StartsWith("STORE ",StringComparison.OrdinalIgnoreCase))
            {
                string data = cleanLine.Substring(6).Trim();
                return "0111" + To4BitBinary(data); // 
            }
            // === JMP ===
            if (cleanLine.EndsWith(":"))
            {
                return "LABEL"; // Special marker for labels, not actual machine code
            }
            if (cleanLine.StartsWith("JMP ", StringComparison.OrdinalIgnoreCase))
            {
                return "11111111"; // Special marker for jump instructions, not actual machine code unfortunally it is fake because we have no real opcode for jump, but this will help us identify it in the UI and handle it properly during execution
            }
            //zero flag
            if (cleanLine.StartsWith("JZ",StringComparison.OrdinalIgnoreCase))
            {
                return "11111110"; // Special marker for JZ (Jump if Zero) instruction, not actual machine code, but will help us identify it in the UI and handle it properly during execution when we implement conditional jumps
            }
            //call and ret
            if (cleanLine.StartsWith("CALL ", StringComparison.OrdinalIgnoreCase))
            {
                return "11111101"; // Special marker for CALL instruction, not actual machine code, but will help us identify it in the UI and handle it properly during execution when we implement function calls
            }
            //ret instruction
            if (cleanLine.Equals("RET", StringComparison.OrdinalIgnoreCase))
            {
                return "11111100"; // Special marker for RET instruction, not actual machine code, but will help us identify it in the UI and handle it properly during execution when we implement function calls
            }
            //JNZ (Jump if Not Zero)
            if (cleanLine.StartsWith("JNZ", StringComparison.OrdinalIgnoreCase))
            {
                return "11111011"; // Special marker for JNZ (Jump if Not Zero) instruction, not actual machine code, but will help us identify it in the UI and handle it properly during execution when we implement conditional jumps
            }
            //PRINT (it is a bit cheating but i need special command for chargen)
            //VPU Print instruction
            if (cleanLine.Equals("PRINT",StringComparison.OrdinalIgnoreCase))
            {
                //check if i used before 
                return "11110111";
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

        private static string To4BitBinary(string input)
        {
            try
            {
                // Parse the input directly as a hexadecimal number
                int value = Convert.ToInt32(input.Trim(), 16);

                // Convert to binary string and pad to 4 bits (e.g., A -> 10 -> "1010")
                return Convert.ToString(value, 2).PadLeft(4, '0');
            }
            catch
            {
                // Fallback for UI if parsing fails
                return "0000";
            }
        }
        //compile and find label 
        public static void Compile(string[] lines)
        {
            LoadedCode = lines;
            Labels.Clear();
            PC = 0;
            for (int i=0;i< lines.Length; i++)
            {
                string cleanLine = lines[i].Trim();
                //if line end  with colon, treat it as label and store the line number in label memory  
                if (cleanLine.EndsWith(":"))
                {
                    string labelName = cleanLine.TrimEnd(':');
                    Labels[labelName] = i; // Store the line number for this label
                }
            }
        }

        //JMP logic 
        //when it calls , program counter run a line and execute 
        public static bool ExecuteNextLine()
        {
            if (PC >= LoadedCode.Length) return false; // Kod bitti

            string cleanLine = LoadedCode[PC].Trim();

            // skip empty lines and labels (lines ending with ":") during execution, but still increment the program counter to avoid infinite loops on labels
            if (string.IsNullOrWhiteSpace(cleanLine) || cleanLine.EndsWith(":"))
            {
                PC++;
                return true;
            }

            // === JMP (JUMP) COMMAND CHECK ===
            if (cleanLine.StartsWith("JMP ", StringComparison.OrdinalIgnoreCase))
            {
                string targetLabel = cleanLine.Substring(4).Trim();
                if (Labels.TryGetValue(targetLabel, out int targetLine))
                {
                    PC = targetLine; // jump label to line number
                    OnExecutionComplete?.Invoke($"JUMPED to label: {targetLabel}");
                }
                else
                {
                    OnExecutionComplete?.Invoke($"Syntax Error: Label '{targetLabel}' not found.");
                    PC = LoadedCode.Length; // terminate execution if label is not found to prevent infinite loops
                }
                return true;
            }

            // if not a jump, run normally
            RunCode(cleanLine);
            PC++; // increment program counter to move to the next line for the next execution cycle
            return true;
        }


    }
}