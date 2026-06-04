using System.Diagnostics;
using System.Media;
using System.Runtime.Intrinsics.X86;
using WinFormsApp1.Models;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //İnitialize the data memory grid with default values for visualization
            InitializeDataMemoryGrid();
            WinFormsApp1.Models.DataMemory.Initialize();

            //videoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //videoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            videoGrid.Rows.Clear();
            videoGrid.Columns.Clear(); // Önce eski sütunları da temizle

            // add 8 columns
            for (int i = 0; i < 8; i++)
            {
                videoGrid.Columns.Add($"col{i}", "");
                videoGrid.Columns[i].Width = 30;
            }

            // add 8 rows
            for (int i = 0; i < 8; i++)
            {
                videoGrid.Rows.Add();
                videoGrid.Rows[i].Height = 30;
            }


            for (int i = 0; i < videoGrid.Columns.Count; i++)
            {
                videoGrid.Columns[i].Width = 30; // pixelSize;
            }
            videoGrid.ClearSelection();
            videoGrid.CurrentCell = null;


        }
        // Simulated Program Counter to track current instruction in memory
        private int programCounter = 0;
        // Flag to indicate if the CPU is halted (e.g., after executing a HLT instruction or reaching end of memory)
        private bool isHalted = false;
        //Core hardware cycle for fetch-decode-execute

        private void ExecuteNextInstruction()
        {
            Debug.WriteLine($"cpu speed {cpuClock.Interval}");
            if (isHalted) return; // If CPU is halted, do not execute further instructions

            //Hardware Error: Check if there are instructions in memory and if the program counter is within bounds
            if (MemoryGrid.Rows.Count == 0)
            {
                isHalted = true;
                cpuClock.Stop();
                MessageBox.Show("No instructions in memory!", "Hardware Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Successful fetch-decode-execute cycle:Program counter reaches the end of loaded instructions
            if (programCounter >= MemoryGrid.Rows.Count)
            {
                isHalted = true;
                cpuClock.Stop();
                MessageBox.Show("End of program memory reached. CPU halted.", "Program Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Fetch
            string assemblyLine = MemoryGrid.Rows[programCounter].Cells[1].Value.ToString().Trim();

            //highlight current instruction in grid
            MemoryGrid.ClearSelection();
            MemoryGrid.Rows[programCounter].Selected = true;

            // === JUMP  and conditional Jump ===

            // === JUMP & CONDITIONAL JUMP LOGIC ===
            if (assemblyLine.StartsWith("JMP ", StringComparison.OrdinalIgnoreCase) ||
                assemblyLine.StartsWith("JZ ", StringComparison.OrdinalIgnoreCase) ||
                assemblyLine.StartsWith("JNZ ", StringComparison.OrdinalIgnoreCase))
            {
                bool isJz = assemblyLine.StartsWith("JZ ", StringComparison.OrdinalIgnoreCase);
                bool isJnz = assemblyLine.StartsWith("JNZ ", StringComparison.OrdinalIgnoreCase);

                // Ignore JZ if Zero Flag is 0
                if (isJz && !Assembler.ZeroFlag)
                {
                    programCounter++;
                    Assembler.OnExecutionComplete?.Invoke("JZ ignored: Zero Flag is 0");
                }
                // Ignore JNZ if Zero Flag is 1
                else if (isJnz && Assembler.ZeroFlag)
                {
                    programCounter++;
                    Assembler.OnExecutionComplete?.Invoke("JNZ ignored: Zero Flag is 1");
                }
                else
                {
                    // Extract label name ("JZ " is 3 chars, "JMP " and "JNZ " are 4 chars)
                    int prefixLength = isJz ? 3 : 4;
                    string targetLabel = assemblyLine.Substring(prefixLength).Trim();
                    bool labelFound = false;

                    // Search the memory grid for the target label
                    for (int i = 0; i < MemoryGrid.Rows.Count; i++)
                    {
                        string checkLine = MemoryGrid.Rows[i].Cells[1].Value.ToString().Trim();
                        if (checkLine.Equals(targetLabel + ":", StringComparison.OrdinalIgnoreCase))
                        {
                            programCounter = i; // Jump!
                            labelFound = true;

                            string jumpType = isJz ? "JZ" : (isJnz ? "JNZ" : "JMP");
                            Assembler.OnExecutionComplete?.Invoke($"{jumpType} executed. Jumped to {targetLabel}");
                            break;
                        }
                    }

                    if (!labelFound)
                    {
                        Assembler.OnExecutionComplete?.Invoke($"Syntax Error: Label '{targetLabel}' not found!");
                        isHalted = true;
                        cpuClock.Stop();
                    }
                }
            }
            //jump end 

            // === LABEL JUMP  ===
            else if (assemblyLine.EndsWith(":"))
            {
                // Label is not an executable instruction, just a marker for jumps. Skip execution. 
                // bypass do not send to cpu.
                programCounter++;
                ExecuteNextInstruction(); // execute the next instruction immediately after the label without waiting for the next clock tick
                return;
            }
            //==CALL Subroutine logic 
            else if (assemblyLine.StartsWith("CALL ", StringComparison.OrdinalIgnoreCase))
            {
                string targetLabel = assemblyLine.Substring(5).Trim();
                bool labelFound = false;

                for (int i = 0; i < MemoryGrid.Rows.Count; i++)
                {
                    string checkLine = MemoryGrid.Rows[i].Cells[1].Value.ToString().Trim();
                    if (checkLine.Equals(targetLabel + ":", StringComparison.OrdinalIgnoreCase))
                    {
                        // Save the CURRENT line number to the Call Stack before jumping
                        Assembler.CallStack.Push(programCounter);

                        programCounter = i; // Jump to the subroutine
                        labelFound = true;
                        Assembler.OnExecutionComplete?.Invoke($"CALL executed. Saved return address and jumped to {targetLabel}");
                        break;
                    }
                }

                if (!labelFound)
                {
                    Assembler.OnExecutionComplete?.Invoke($"Syntax Error: Label '{targetLabel}' not found!");
                    isHalted = true;
                    cpuClock.Stop();
                }
            }
            // === RET (RETURN) LOGIC ===
            else if (assemblyLine.Equals("RET", StringComparison.OrdinalIgnoreCase))
            {
                if (Assembler.CallStack.Count > 0)
                {
                    // Pop the saved address and return to the line IMMEDIATELY AFTER the CALL
                    programCounter = Assembler.CallStack.Pop() + 1;
                    Assembler.OnExecutionComplete?.Invoke("RET executed. Returned to main program.");
                }
                else
                {
                    // Hardware crash if RET is called without a prior CALL
                    Assembler.OnExecutionComplete?.Invoke("Hardware Error: RET called with empty Call Stack!");
                    isHalted = true;
                    cpuClock.Stop();
                }
            }



            //end call 

            else
            {
                // Normal instruction execute
                Assembler.RunCode(assemblyLine);
                programCounter++; // increment program counter to point to the next instruction for the next cycle
            }

            RefreshDataMemoryGrid(); // Update the data memory grid
            WinFormsApp1.Models.PlaySound.Play();
        }
        //end of core cycle

        private void AddInstructionToMemory(string address, string assembly, string machineCode)
        {
            MemoryGrid.Rows.Add(address, assembly, machineCode);
        }

        private void ax0_Click(object sender, EventArgs e)
        {
            Program.Ax.AddBit(0);
            ax0.Text = Program.Ax.RegArray[3] ? "1" : "0";
            ax0.BackColor = Program.Ax.RegArray[3] ? Color.Yellow : Color.Red;


        }

        private void ax1_Click(object sender, EventArgs e)
        {
            Program.Ax.AddBit(1);
            ax1.Text = Program.Ax.RegArray[2] ? "1" : "0";
            ax1.BackColor = Program.Ax.RegArray[2] ? Color.Yellow : Color.Red;

        }

        private void ax2_Click(object sender, EventArgs e)
        {
            Program.Ax.AddBit(2);
            ax2.Text = Program.Ax.RegArray[1] ? "1" : "0";
            ax2.BackColor = Program.Ax.RegArray[1] ? Color.Yellow : Color.Red;
        }

        private void ax3_Click(object sender, EventArgs e)
        {
            Program.Ax.AddBit(3);
            ax3.Text = Program.Ax.RegArray[0] ? "1" : "0";
            ax3.BackColor = Program.Ax.RegArray[0] ? Color.Yellow : Color.Red;
        }

        private void regAxPush_Click(object sender, EventArgs e)
        {
            bool[] currentAxBits = (bool[])Program.Ax.RegArray.Clone();
            Register axCopy = new Register("Ax", currentAxBits);
            Program.Stack.AddRegister(axCopy);
            //list 
            stackList.Items.Clear();
            var currentList = Program.Stack.DisplayStack();
            for (int i = currentList.Count - 1; i >= 0; i--)
            {
                var reg = currentList[i];
                string bitString = string.Join("", reg.RegArray.Select(b => b ? "1" : "0"));
                stackList.Items.Add($"{reg.RegName}: {bitString}");
            }

        }

        private void resetAx_Click(object sender, EventArgs e)
        {
            Program.Ax.ClearRegister();
            ax0.Text = "0"; ax0.BackColor = Color.Red;
            ax1.Text = "0"; ax1.BackColor = Color.Red;
            ax2.Text = "0"; ax2.BackColor = Color.Red;
            ax3.Text = "0"; ax3.BackColor = Color.Red;


        }

        private void bx0_Click(object sender, EventArgs e)
        {
            Program.Bx.AddBit(0);
            bx0.Text = Program.Bx.RegArray[3] ? "1" : "0";
            bx0.BackColor = Program.Bx.RegArray[3] ? Color.Yellow : Color.Red;

        }

        private void bx1_Click(object sender, EventArgs e)
        {
            Program.Bx.AddBit(1);
            bx1.Text = Program.Bx.RegArray[2] ? "1" : "0";
            bx1.BackColor = Program.Bx.RegArray[2] ? Color.Yellow : Color.Red;

        }

        private void bx2_Click(object sender, EventArgs e)
        {
            Program.Bx.AddBit(2);
            bx2.Text = Program.Bx.RegArray[1] ? "1" : "0";
            bx2.BackColor = Program.Bx.RegArray[1] ? Color.Yellow : Color.Red;
        }

        private void bx3_Click(object sender, EventArgs e)
        {
            Program.Bx.AddBit(3);
            bx3.Text = Program.Bx.RegArray[0] ? "1" : "0";
            bx3.BackColor = Program.Bx.RegArray[0] ? Color.Yellow : Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool[] currentBxBits = (bool[])Program.Bx.RegArray.Clone();
            Register bxCopy = new Register("Bx", currentBxBits);
            Program.Stack.AddRegister(bxCopy);
            //list
            stackList.Items.Clear();
            var currentList = Program.Stack.DisplayStack();
            for (int i = currentList.Count - 1; i >= 0; i--)
            {
                var reg = currentList[i];
                string bitString = string.Join("", reg.RegArray.Select(b => b ? "1" : "0"));
                stackList.Items.Add($"{reg.RegName}: {bitString}");
            }

        }

        private void resetBx_Click(object sender, EventArgs e)
        {
            Program.Bx.ClearRegister();
            bx0.Text = "0"; bx0.BackColor = Color.Red;
            bx1.Text = "0"; bx1.BackColor = Color.Red;
            bx2.Text = "0"; bx2.BackColor = Color.Red;
            bx3.Text = "0"; bx3.BackColor = Color.Red;

        }

        private void clearStackButton_Click(object sender, EventArgs e)
        {
            Program.Stack.ClearStack();
            stackList.Items.Clear();
        }

        private void popStackButton_Click(object sender, EventArgs e)
        {
            Register popped = Program.Stack.PopRegister();
            if (popped != null)
            {
                string bitString = string.Join("", popped.RegArray.Select(b => b ? "1" : "0"));
                popedRegister.Text = $"Last Popped: {popped.RegName} ({bitString})";

            }
            else
            {
                popedRegister.Text = "Stack is empty!";
            }
        }

        private void op0_Click(object sender, EventArgs e)
        {
            Program.oppCodeA.Bits[3] = !Program.oppCodeA.Bits[3];
            op0.Text = Program.oppCodeA.Bits[3] ? "1" : "0";
            op0.BackColor = Program.oppCodeA.Bits[3] ? Color.Yellow : Color.Red;


        }

        private void op1_Click(object sender, EventArgs e)
        {
            Program.oppCodeA.Bits[2] = !Program.oppCodeA.Bits[2];
            op1.Text = Program.oppCodeA.Bits[2] ? "1" : "0";
            op1.BackColor = Program.oppCodeA.Bits[2] ? Color.Yellow : Color.Red;
        }

        private void op2_Click(object sender, EventArgs e)
        {
            Program.oppCodeA.Bits[1] = !Program.oppCodeA.Bits[1];
            op2.Text = Program.oppCodeA.Bits[1] ? "1" : "0";
            op2.BackColor = Program.oppCodeA.Bits[1] ? Color.Yellow : Color.Red;

        }

        private void op3_Click(object sender, EventArgs e)
        {
            Program.oppCodeA.Bits[0] = !Program.oppCodeA.Bits[0];
            op3.Text = Program.oppCodeA.Bits[0] ? "1" : "0";
            op3.BackColor = Program.oppCodeA.Bits[0] ? Color.Yellow : Color.Red;
        }

        private void oppPush_Click(object sender, EventArgs e)
        {

            Program.oppCodeA.SetBits(Program.oppCodeA.Bits);
            string binaryString = string.Join("", Program.oppCodeA.Bits.Select(b => b ? "1" : "0"));
            oppCom.Items.Add($"Opcode: {binaryString}");

        }

        private void executebutton_Click(object sender, EventArgs e)
        {
            try
            {
                var dataB = Program.Stack.PopRegister();
                var dataA = Program.Stack.PopRegister();
                //load 
                AluInputBuffer.LoadTempB(dataB.RegArray);
                AluInputBuffer.LoadTempA(dataA.RegArray);
                // 3. STEP: Load the currently active Opcode from the toggle panel into the buffer
                AluInputBuffer.LoadOppCode(Program.oppCodeA.Bits);
                // 4. STEP: Execute the operation and get the result
                bool[] resultBits = AluInputBuffer.Execute();
                //print result
                string resultString = string.Join("", resultBits.Select(b => b ? "1" : "0"));
                OutputRegister.Items.Add($"Result: {resultString}");
                //RESET 
                AluInputBuffer.ClearBuffers();



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during execution: {ex.Message}");



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //memory grid 
            MemoryGrid.BackgroundColor = Color.LightGray;
            MemoryGrid.ForeColor = Color.Black;
            MemoryGrid.ColumnCount = 3;
            MemoryGrid.Columns[0].Name = "Address";
            MemoryGrid.Columns[1].Name = "Assembly";
            MemoryGrid.Columns[2].Name = "Machine Code";
            MemoryGrid.AllowUserToAddRows = false;
            MemoryGrid.ReadOnly = true;
            MemoryGrid.RowHeadersVisible = false;
            MemoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MemoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //Assembler 
            Assembler.OnExecutionComplete += (resultText) =>
            {
                OutputRegister.Items.Add(resultText);
                RefreshUI();
                RefreshDataMemoryGrid();
                //video 
                UpdateVideoDisplay();

            };
        }

        private void oppResetButton_Click(object sender, EventArgs e)
        {
            oppCom.Items.Clear();
            Program.oppCodeA.Clear();
        }

        private void runCodeButton_Click(object sender, EventArgs e)
        {

            // Split the text into individual lines
            string[] lines = assemblyCodeBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string cleanLine = line.Trim();

                // Pass each line to the Assembler core
                Assembler.RunCode(cleanLine);

            }
            //assemblyCodeBox.Clear();    
        }

        private void clearEditorButton_Click(object sender, EventArgs e)
        {

            // Ask for user confirmation before clearing the editor
            DialogResult result = MessageBox.Show(
                "Are you sure? This will delete all your assembly code!",
                "Confirm Clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // If the user clicks 'Yes', clear the text box
            if (result == DialogResult.Yes)
            {
                assemblyCodeBox.Clear();
            }
        }

        private void loadToMemoryButton_Click(object sender, EventArgs e)
        {
            // Clear old data safely before loading new program
            MemoryGrid.Rows.Clear();
            WinFormsApp1.Models.ProgramMemory.MemoryList.Clear();

            string[] lines = assemblyCodeBox.Lines;
            int address = 0;

            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();
                if (string.IsNullOrEmpty(trimmedLine) || trimmedLine.StartsWith(";")) continue;

                string assemblyText = "";
                string machineCode = "";

                // Check if the incoming line consists only of '0' and '1'
                bool isBinary = true;
                foreach (char c in trimmedLine)
                {
                    if (c != '0' && c != '1')
                    {
                        isBinary = false;
                        break;
                    }
                }

                if (isBinary)
                {
                    // The file provided raw machine code bits
                    machineCode = trimmedLine;

                    // Extract the first 4 bits to perform a quick disassembly lookup
                    string opcodePart = trimmedLine.Substring(0, Math.Min(4, trimmedLine.Length));
                    assemblyText = DisassembleOpcode(opcodePart);
                }
                else
                {
                    // The user typed a standard text mnemonic command
                    assemblyText = trimmedLine;
                    // NOTE: Replace with your actual dictionary/parser lookup method if named differently
                    machineCode = Assembler.GetMachineCode(trimmedLine);
                }

                // Properly map variables to the corresponding hardware columns
                string hexAddress = "0x" + address.ToString("X2");
                MemoryGrid.Rows.Add(hexAddress, assemblyText, machineCode);
                WinFormsApp1.Models.ProgramMemory.MemoryList.Add(machineCode);

                address++;
            }

        }
        // Helper method to convert binary opcodes back to readable text
        private string DisassembleOpcode(string opcode)
        {
            switch (opcode)
            {
                case "0000": return "AND";
                case "0001": return "OR";
                case "0010": return "XOR";
                case "0011": return "NOT";
                case "0100": return "ADD";
                case "0101": return "SUB";
                case "1000": return "SHL";
                case "1001": return "SHR";
                case "1010": return "INC";
                case "1011": return "DEC";
                case "1100": return "PUSH AX";
                case "1101": return "PUSH BX";
                case "1110": return "POP AX";
                case "1111": return "POP BX";
                default: return "UNKNOWN";
            }
        }


        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            // Check if there is any data in RAM to save
            if (WinFormsApp1.Models.ProgramMemory.MemoryList.Count == 0)
            {
                MessageBox.Show("Memory is empty! Load some code first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize the save file dialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set file extensions and default title
                saveFileDialog.Filter = "Binary ROM File (*.bin)|*.bin|Text File (*.txt)|*.txt";
                saveFileDialog.Title = "Save CPU Program Memory";
                saveFileDialog.DefaultExt = "bin";

                // If the user clicks OK, save the contents
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Write the dynamic RAM list to the selected file
                    System.IO.File.WriteAllLines(saveFileDialog.FileName, WinFormsApp1.Models.ProgramMemory.MemoryList);

                    // Show a success confirmation
                    MessageBox.Show("Hardware memory dumped to file successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void clearOutput_Click(object sender, EventArgs e)
        {
            OutputRegister.Items.Clear();
        }

        private void RefreshUI()
        {
            // Sync AX Register UI
            ax0.Text = Program.Ax.RegArray[3] ? "1" : "0";
            ax0.BackColor = Program.Ax.RegArray[3] ? Color.Yellow : Color.Red;
            ax1.Text = Program.Ax.RegArray[2] ? "1" : "0";
            ax1.BackColor = Program.Ax.RegArray[2] ? Color.Yellow : Color.Red;
            ax2.Text = Program.Ax.RegArray[1] ? "1" : "0";
            ax2.BackColor = Program.Ax.RegArray[1] ? Color.Yellow : Color.Red;
            ax3.Text = Program.Ax.RegArray[0] ? "1" : "0";
            ax3.BackColor = Program.Ax.RegArray[0] ? Color.Yellow : Color.Red;

            // Sync BX Register UI
            bx0.Text = Program.Bx.RegArray[3] ? "1" : "0";
            bx0.BackColor = Program.Bx.RegArray[3] ? Color.Yellow : Color.Red;
            bx1.Text = Program.Bx.RegArray[2] ? "1" : "0";
            bx1.BackColor = Program.Bx.RegArray[2] ? Color.Yellow : Color.Red;
            bx2.Text = Program.Bx.RegArray[1] ? "1" : "0";
            bx2.BackColor = Program.Bx.RegArray[1] ? Color.Yellow : Color.Red;
            bx3.Text = Program.Bx.RegArray[0] ? "1" : "0";
            bx3.BackColor = Program.Bx.RegArray[0] ? Color.Yellow : Color.Red;

            // Sync Stack List UI
            stackList.Items.Clear();
            var currentList = Program.Stack.DisplayStack();
            for (int i = currentList.Count - 1; i >= 0; i--)
            {
                var reg = currentList[i];
                string bitString = string.Join("", reg.RegArray.Select(b => b ? "1" : "0"));
                stackList.Items.Add($"{reg.RegName}: {bitString}");
            }
        }

        private void cpuClock_Tick(object sender, EventArgs e)
        {
            ExecuteNextInstruction();
            //RefreshUI();
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            ExecuteNextInstruction();
            RefreshUI();
        }

        private void btnStartClock_Click(object sender, EventArgs e)
        {
            isHalted = false;
            cpuClock.Start();

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //flush memory grid and program memory list
            MemoryGrid.Rows.Clear();
            OutputRegister.Items.Clear();
            
            WinFormsApp1.Models.ProgramMemory.MemoryList.Clear();
            WinFormsApp1.Models.DataMemory.Initialize(); // Reset the backend data memory to default values  
            InitializeDataMemoryGrid(); // Re-initialize the data memory grid to default values
            //reset 
            stackList.Items.Clear();


            programCounter = 0;
            isHalted = false;
            Program.Ax.ClearRegister();
            Program.Bx.ClearRegister();
            Program.Stack.ClearStack();
            RefreshUI();
        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assemblyCodeBox.Clear();
            assemblyCodeBox.AppendText("PUSH AX, 0111\r\n");
            assemblyCodeBox.AppendText("PUSH BX, 0010\r\n");
            assemblyCodeBox.AppendText("SUB\r\n");
            assemblyCodeBox.AppendText("PUSH AX, 0110\r\n");
            assemblyCodeBox.AppendText("PUSH BX, 0011\r\n");
            assemblyCodeBox.AppendText("ADD\r\n");
            assemblyCodeBox.AppendText("POP AX\r\n");
            assemblyCodeBox.AppendText("POP BX\r\n");


        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string aboutInfo = "Custom 4-Bit Retro Microprocessor Emulator\n" +
                       "Version: 1.0 (Development Phase)\n\n" +
                       "Architecture Specifications:\n" +
                       "- 4-Bit Shared Data Bus\n" +
                       "- 2 Discrete Internal Hardware Registers (AX, BX)\n" +
                       "- Hardware-based FILO/LIFO Memory Stack\n" +
                       "- Combinational Logic ALU (16-Opcode Limit)\n\n" +
                       "Designed and Emulated smoothly in C# WinForms.\n\n" +
                       "2026 © Devrim Savas Yilmaz. \n";

            MessageBox.Show(aboutInfo, "About Core Architecture", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void isaReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string isaInfo = "SUPPORTED INSTRUCTION SET ARCHITECTURE (ISA):\n\n" +
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

            MessageBox.Show(isaInfo, "Hardware ISA Reference", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void oppGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string isaInfo = "SUPPORTED INSTRUCTION SET ARCHITECTURE (ISA):\n\n" +
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

            MessageBox.Show(isaInfo, "Current Hardware ISA Reference", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void hARDWARERESETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Stop the system clock immediately
            cpuClock.Stop();

            // Reset all hardware flags and counters
            programCounter = 0;
            isHalted = false;

            // Clear the memory grid selection safely
            if (MemoryGrid.Rows.Count > 0)
            {
                MemoryGrid.ClearSelection();
            }

            // NOTE: Reset your AX/BX register variables and Stack list here
            // Example: RegisterAX = new bool[4]; RegisterBX = new bool[4];
            // Example: StackList.Items.Clear();

            MessageBox.Show("CPU hardware cold boot sequence completed. All buffers and registers reset.", "Hardware Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void hZSLOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cpuClock.Interval = 100;
        }

        private void hZNORMALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //normal mode
            cpuClock.Interval = 500;
        }

        private void tURBOMODEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //turbo
            cpuClock.Interval = 20;
        }

        private void saveCodeToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if there is any data in RAM to save
            if (WinFormsApp1.Models.ProgramMemory.MemoryList.Count == 0)
            {
                MessageBox.Show("Memory is empty! Load some code first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize the save file dialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set file extensions and default title
                saveFileDialog.Filter = "Binary ROM File (*.bin)|*.bin|Text File (*.txt)|*.txt";
                saveFileDialog.Title = "Save CPU Program Memory";
                saveFileDialog.DefaultExt = "bin";

                // If the user clicks OK, save the contents
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Write the dynamic RAM list to the selected file
                    System.IO.File.WriteAllLines(saveFileDialog.FileName, WinFormsApp1.Models.ProgramMemory.MemoryList);

                    // Show a success confirmation
                    MessageBox.Show("Hardware memory dumped to file successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void lOADFROMFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initialize the open file dialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filter to match the save format
                openFileDialog.Filter = "Text File (*.txt)|*.txt|Binary ROM File (*.bin)|*.bin|All Files (*.*)|*.*";
                openFileDialog.Title = "Load CPU Program";

                // If the user selects a file and clicks OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Read the entire file content as a single block to prevent UI thread freezing
                        string fileContent = System.IO.File.ReadAllText(openFileDialog.FileName);

                        // Assign the entire text to the editor in one single UI operation
                        assemblyCodeBox.Text = fileContent;

                        // Show a success confirmation
                        MessageBox.Show("Program loaded into the editor successfully!", "Load Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Failsafe: Catch and display any file reading errors
                        MessageBox.Show("Error reading file: " + ex.Message, "Hardware I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void loadFromBinaryBT_Click(object sender, EventArgs e)
        {
            Console.Write("test");
            Debug.WriteLine("test");


        }

        private void InitializeDataMemoryGrid()
        {
            if (dataMemoryGrid.Rows.Count >= 16) return;
            dataMemoryGrid.Rows.Clear();
            for (int i = 0; i < 16; i++)
            {
                string hexAddress = "0x" + i.ToString("X2");
                //inject current data memory values into the grid for visualization
                dataMemoryGrid.Rows.Add(hexAddress, "0000");
            }
        }

        // Ram chip show 
        private void RefreshDataMemoryGrid()
        {
            if (dataMemoryGrid.Rows.Count < 16 || dataMemoryGrid.Columns.Count < 2)
            {
                InitializeDataMemoryGrid();
                return;
            }
            // Loop through all 16 hardware RAM addresses
            for (int i = 0; i < 16; i++)
            {
                // Read the actual data from the backend RAM chip
                bool[] ramData = WinFormsApp1.Models.DataMemory.Read(i);

                // Convert the boolean array to a binary string (e.g., "1010")
                string bitString = string.Join("", ramData.Select(b => b ? "1" : "0"));

                // Update the 'Data' column (Index 1) for this specific row in the UI
                dataMemoryGrid.Rows[i].Cells[1].Value = bitString;
            }
        }

        private void lOADSAMPLE2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fast multiplication example using shifts and adds
            assemblyCodeBox.Clear();
            assemblyCodeBox.AppendText("PUSH AX, 0011\r\n");
            assemblyCodeBox.AppendText("PUSH AX\r\n");
            assemblyCodeBox.AppendText("SHL\r\n");
        }

        private void fastDivisionUsingSHR82ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fast division by 2 example using shifts
            assemblyCodeBox.Clear();
            assemblyCodeBox.AppendText("PUSH AX, 1000\r\n");
            assemblyCodeBox.AppendText("PUSH AX\r\n");
            assemblyCodeBox.AppendText("SHR\r\n");

        }

        private void storeToMemoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //store AX to memory address 0x00 example
            assemblyCodeBox.Clear();
            assemblyCodeBox.AppendText("PUSH AX, 1010\r\n"); // Load AX with some value (e.g., 1010)
            assemblyCodeBox.AppendText("STORE 0000\r\n"); // Push AX onto the stack
            assemblyCodeBox.AppendText("PUSH AX,0101\r\n"); // Pop the value back into AX to simulate a memory store operation
            assemblyCodeBox.AppendText("STORE 1111\r\n"); // 
            assemblyCodeBox.AppendText("LOAD 0000\r\n"); // Load AX with the value from memory address 0x00
            assemblyCodeBox.AppendText("LOAD 1111\r\n"); // Load AX with the value from memory address 0x0F (for demonstration)
            assemblyCodeBox.AppendText("ADD\r\n"); // Push the loaded value onto the stack to view in output

        }

        private void xorSwapTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Xor Swap example: Swapping values in AX and BX without a temporary register using XOR
            assemblyCodeBox.Clear();
            assemblyCodeBox.AppendText("PUSH AX, 1010\r\n"); // Load AX with value 1010 (13 in decimal) 
            assemblyCodeBox.AppendText("PUSH BX, 0101\r\n"); // Load BX with value 0101 (5 in decimal)
            assemblyCodeBox.AppendText("PUSH AX\r\n"); // Push AX onto the stack to save its value Ax=AX XOR BX
            assemblyCodeBox.AppendText("PUSH BX\r\n"); // Push BX onto the stack to save its value BX=AX XOR BX (BX now holds original AX value)
            assemblyCodeBox.AppendText("XOR\r\n"); // AX now holds the result of AX XOR BX
            assemblyCodeBox.AppendText("POP AX\r\n");
            assemblyCodeBox.AppendText("PUSH AX\r\n"); // BX now holds the result of AX XOR BX (original AX value)   
            assemblyCodeBox.AppendText("PUSH BX\r\n"); // AX now holds the original BX value, completing the swap
            assemblyCodeBox.AppendText("XOR\r\n"); // Finalize the swap by XORing again to restore original values
            assemblyCodeBox.AppendText("POP BX\r\n"); // AX now holds the original BX value, and BX holds the original AX value
            assemblyCodeBox.AppendText("PUSH AX\r\n"); // Clean up the stack by popping the saved values (optional, depending on your stack management)
            assemblyCodeBox.AppendText("PUSH BX\r\n"); // Clean up the stack by popping the saved values (optional, depending on your stack management)
            assemblyCodeBox.AppendText("XOR\r\n"); // Push the final swapped value onto the stack to view in output
        }

        private void popedRegister_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //Video Display initialization and refresh methods
        public void UpdateVideoDisplay()
        {
            // 8 columns and 8 rows for an 8x8 pixel display
            for (int i = 0; i < 8; i++)
            {
                // 8 bit data for each row is stored in 2 consecutive RAM addresses (4 bits per address)
                // i*2 address for the first 4 bits of the row, i*2+1 for the next 4 bits
                bool[] firstPart = WinFormsApp1.Models.DataMemory.Read(i * 2);
                bool[] secondPart = WinFormsApp1.Models.DataMemory.Read(i * 2 + 1);

                for (int j = 0; j < 8; j++)
                {
                    // if j < 4 we take bits from the firstPart, else from the secondPart
                    bool isPixelOn = (j < 4) ? firstPart[j] : secondPart[j - 4];

                    if (isPixelOn)
                    {
                        videoGrid.Rows[i].Cells[j].Style.BackColor = Color.Gold;
                    }
                    else
                    {
                        videoGrid.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    }
                }
            }
            videoGrid.Invalidate();
            videoGrid.Update();
        }

        private void resetScreenButton_Click(object sender, EventArgs e)
        {
            videoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            videoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            // Clear existing rows and columns to reset fully
            videoGrid.Rows.Clear();
            videoGrid.Columns.Clear();

            // Setup 8 columns with width 50
            for (int i = 0; i < 8; i++)
            {
                videoGrid.Columns.Add($"col{i}", "");
                videoGrid.Columns[i].Width = 30;
            }

            // Setup 8 rows with height 30
            for (int i = 0; i < 8; i++)
            {
                videoGrid.Rows.Add();
                videoGrid.Rows[i].Height = 30;
            }

            // Clear selection to avoid visual bugs
            videoGrid.ClearSelection();
            videoGrid.CurrentCell = null;
        }

        private void tURBOMODEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cpuClock.Interval = 20;
        }

        private void hZSLOWToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cpuClock.Interval = 500;
        }

        private void counterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assemblyCodeBox.Clear();

            assemblyCodeBox.AppendText("main_program:\r\n");
            assemblyCodeBox.AppendText("CALL zero_screen\r\n");
            assemblyCodeBox.AppendText("CALL one_screen\r\n");
            assemblyCodeBox.AppendText("CALL two_screen\r\n");
            assemblyCodeBox.AppendText("CALL three_screen\r\n");
            assemblyCodeBox.AppendText("CALL four_screen\r\n");
            assemblyCodeBox.AppendText("CALL five_screen\r\n");
            assemblyCodeBox.AppendText("CALL six_screen\r\n");
            assemblyCodeBox.AppendText("CALL seven_screen\r\n");
            assemblyCodeBox.AppendText("CALL eight_screen\r\n");
            assemblyCodeBox.AppendText("CALL nine_screen\r\n");
            assemblyCodeBox.AppendText("JMP main_program\r\n");

            assemblyCodeBox.AppendText("zero_screen:\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0001\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0101\r\n");
            assemblyCodeBox.AppendText("STORE 0003\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0101\r\n");
            assemblyCodeBox.AppendText("STORE 0005\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0101\r\n");
            assemblyCodeBox.AppendText("STORE 0007\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0009\r\n");
            assemblyCodeBox.AppendText("RET\r\n");

            assemblyCodeBox.AppendText("one_screen:\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0001\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0003\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0005\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0007\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0009\r\n");
            assemblyCodeBox.AppendText("RET\r\n");

            assemblyCodeBox.AppendText("two_screen:\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0001\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0003\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0005\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0100\r\n");
            assemblyCodeBox.AppendText("STORE 0007\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0009\r\n");
            assemblyCodeBox.AppendText("RET\r\n");

            assemblyCodeBox.AppendText("three_screen:\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0001\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0003\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0005\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0007\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0009\r\n");
            assemblyCodeBox.AppendText("RET\r\n");

            assemblyCodeBox.AppendText("four_screen:\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0101\r\n");
            assemblyCodeBox.AppendText("STORE 0001\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0101\r\n");
            assemblyCodeBox.AppendText("STORE 0003\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0005\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0007\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0009\r\n");
            assemblyCodeBox.AppendText("RET\r\n");

            assemblyCodeBox.AppendText("five_screen:\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0001\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0100\r\n");
            assemblyCodeBox.AppendText("STORE 0003\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0005\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0007\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0009\r\n");
            assemblyCodeBox.AppendText("RET\r\n");

            assemblyCodeBox.AppendText("six_screen:\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0001\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0100\r\n");
            assemblyCodeBox.AppendText("STORE 0003\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0005\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0101\r\n");
            assemblyCodeBox.AppendText("STORE 0007\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0009\r\n");
            assemblyCodeBox.AppendText("RET\r\n");

            assemblyCodeBox.AppendText("seven_screen:\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0001\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0003\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0005\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0007\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0009\r\n");
            assemblyCodeBox.AppendText("RET\r\n");

            assemblyCodeBox.AppendText("eight_screen:\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0001\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0101\r\n");
            assemblyCodeBox.AppendText("STORE 0003\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0005\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0101\r\n");
            assemblyCodeBox.AppendText("STORE 0007\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0009\r\n");
            assemblyCodeBox.AppendText("RET\r\n");

            assemblyCodeBox.AppendText("nine_screen:\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0001\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0101\r\n");
            assemblyCodeBox.AppendText("STORE 0003\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0005\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0001\r\n");
            assemblyCodeBox.AppendText("STORE 0007\r\n");
            assemblyCodeBox.AppendText("PUSH AX,0111\r\n");
            assemblyCodeBox.AppendText("STORE 0009\r\n");
            assemblyCodeBox.AppendText("RET\r\n");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoGrid.BackgroundColor = Color.Blue;
        }

        private void hZNORMALToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cpuClock.Interval = 800;
        }

        private void jUMPNOTZEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assemblyCodeBox.Clear();
            assemblyCodeBox.AppendText("PUSH AX,1111\r\n");
            assemblyCodeBox.AppendText("STORE 0000\r\n");
            assemblyCodeBox.AppendText("COUNTDOWN:\r\n");
            assemblyCodeBox.AppendText("LOAD 0000\r\n");
            assemblyCodeBox.AppendText("DEC\r\n");
            assemblyCodeBox.AppendText("STORE 0000\r\n");
            assemblyCodeBox.AppendText("JNZ COUNTDOWN\r\n");

        }
    }
}
