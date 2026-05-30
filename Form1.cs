using WinFormsApp1.Models;
using System.Media;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        // Simulated Program Counter to track current instruction in memory
        private int programCounter = 0;
        // Flag to indicate if the CPU is halted (e.g., after executing a HLT instruction or reaching end of memory)
        private bool isHalted = false;
        //Core hardware cycle for fetch-decode-execute
        private void ExecuteNextInstruction()
        {
            if (isHalted) return; // If CPU is halted, do not execute further instructions

            //Hardware Error: Check if there are instructions in memory and if the program counter is within bounds
            if (MemoryGrid.Rows.Count == 0)
            {
                isHalted = true;
                cpuClock.Stop();
                MessageBox.Show("No instructions in memory!", "Hardware Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Successful fetch-decode-execute cycle:Program counter reaches the end of loaded instructions, halting the CPU to prevent out-of-bounds access
            if (programCounter >= MemoryGrid.Rows.Count)
            {
                isHalted = true;
                cpuClock.Stop();
                MessageBox.Show("End of program memory reached. CPU halted.", "Program Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Fetch
            string assemblyLine = MemoryGrid.Rows[programCounter].Cells[1].Value.ToString();
            //highlight current instruction in grid
            MemoryGrid.ClearSelection();
            MemoryGrid.Rows[programCounter].Selected = true;

            //execute
            Assembler.RunCode(assemblyLine);
            programCounter++;
        }

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
            opguide.Items.Clear();

            // Populate the ListBox line by line to map your exact ALU hardware logic
            opguide.Items.Add("0000: AND (Logical)");
            opguide.Items.Add("0001: OR  (Logical)");
            opguide.Items.Add("0010: XOR (Logical)");
            opguide.Items.Add("0011: NOT A (Invert A)");
            opguide.Items.Add("0100: A + B (Addition)");
            opguide.Items.Add("0101: A - B (Subtraction)");
            opguide.Items.Add("0110: NOT B (Invert B)");       // Shifted down safely
            opguide.Items.Add("0111: B - A (Reverse Sub)");
            opguide.Items.Add("1000: A << 1 (Shift Left)");
            opguide.Items.Add("1001: A >> 1 (Shift Right)");
            opguide.Items.Add("1010: Increment A");

            opguide.Items.Add("1011: Decrement A");
            opguide.Items.Add("1100: Increment B");
            opguide.Items.Add("1101: Decrement B");
            opguide.Items.Add("1110: NOP (No Operation)");
            opguide.Items.Add("1111: Custom/Undefined");
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
            Assembler.OnExecutionComplete = (resultText) =>
            {
                OutputRegister.Items.Add(resultText);
                RefreshUI();
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
            assemblyCodeBox.Clear();
        }

        private void loadToMemoryButton_Click(object sender, EventArgs e)
        {
            // Reset both UI and the static RAM class
            MemoryGrid.Rows.Clear();
            ProgramMemory.ClearMemory();

            string[] lines = assemblyCodeBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            int address = 0;
            int overflowLimit = 256; // Hardware RAM limit configuration

            foreach (string line in lines)
            {
                string cleanLine = line.Trim().ToUpper();
                string binaryInstruction = "00000000"; // Default fallback (NOP)

                // Encoding dynamic instructions: 4-bit Opcode + 4-bit Immediate Data
                if (cleanLine.StartsWith("PUSH AX,"))
                {
                    string dataBits = cleanLine.Substring(8).Trim();
                    binaryInstruction = "1110" + dataBits; // Opcode 1110 + 4-bit data
                }
                else if (cleanLine.StartsWith("PUSH BX,"))
                {
                    string dataBits = cleanLine.Substring(8).Trim();
                    binaryInstruction = "1111" + dataBits; // Opcode 1111 + 4-bit data
                }
                // Encoding standalone instructions: 4-bit Opcode + 4-bit Padding (0000)
                else
                {
                    switch (cleanLine)
                    {
                        //Logical operations
                        case "AND": binaryInstruction = "00000000"; break;
                        case "OR": binaryInstruction = "00010000"; break;
                        case "XOR": binaryInstruction = "00100000"; break;
                        case "NOT": binaryInstruction = "00110000"; break;
                        //Arithmetic operations
                        case "ADD": binaryInstruction = "01000000"; break;
                        case "SUB": binaryInstruction = "01010000"; break;
                        //4 bit limit for immediate data means we can only encode values from 0 to 15, so we use the last 4 bits for data and the first 4 bits for opcode   
                        //case "NOT B": binaryInstruction = "01100000"; break;
                        //case "SUB BA": binaryInstruction = "01110000"; break;
                        //Advanced operations
                        case "SHL": binaryInstruction = "10000000"; break;
                        case "SHR": binaryInstruction = "10010000"; break;
                        case "INC": binaryInstruction = "10100000"; break;
                        case "DEC": binaryInstruction = "10110000"; break;
                        //case "INC B": binaryInstruction = "11000000"; break;
                        //case "DEC B": binaryInstruction = "11010000"; break;
                        //Stack Operations 
                        case "PUSH AX": binaryInstruction = "11100000"; break; // Custom opcode
                        case "PUSH BX": binaryInstruction = "11110000"; break; // Custom opcode
                        case "POP AX": binaryInstruction = "11100000"; break; // Custom opcode for popping into AX from the Stack
                        case "POP BX": binaryInstruction = "11110000"; break; // Custom opcode for popping into BX from the Stack
                        //case "OUT AX":binaryInstruction="11101111"; break; // Custom opcode for outputting AX to the OutputRegister
                        //4 bit limit for immediate data means we can only encode values from 0 to 15, so we use the last 4 bits for data and the first 4 bits for opcode
                        //case "OUT BX":binaryInstruction="11111111"; break; // Custom opcode for outputting BX to the OutputRegister 
                        //4 bit limit for immediate data means we can only encode values from 0 to 15, so we use the last 4 bits for data and the first 4 bits for opcode
                        default: binaryInstruction = "00000000"; break; // Unknown commands act as NOP
                    }
                }

                // Push the 8-bit binary word into the simulated hardware RAM
                ProgramMemory.PushToMemory(binaryInstruction, overflowLimit);

                // Display formatted Hex address and binary word in the grid
                string hexAddress = $"0x{address:X2}";
                AddInstructionToMemory(hexAddress, line.Trim(), binaryInstruction);

                address++;
                programCounter = 0; // Reset program counter to start of memory after loading new instructions  
                isHalted = false; // Reset halt state in case it was previously set 
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
            //reset 
            programCounter = 0;
            isHalted = false;
        }
    }
}
