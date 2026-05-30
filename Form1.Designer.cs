namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            saveFileDialog1 = new SaveFileDialog();
            RegisterAxBox = new GroupBox();
            resetAx = new Button();
            regAxPush = new Button();
            ax0 = new Button();
            ax1 = new Button();
            ax2 = new Button();
            ax3 = new Button();
            stackList = new ListBox();
            RegisterBxBox = new GroupBox();
            resetBx = new Button();
            regBxPush = new Button();
            bx0 = new Button();
            bx1 = new Button();
            bx2 = new Button();
            bx3 = new Button();
            registersBox = new GroupBox();
            oppcodebox = new GroupBox();
            oppResetButton = new Button();
            oppPush = new Button();
            op0 = new Button();
            op1 = new Button();
            op2 = new Button();
            op3 = new Button();
            popStackButton = new Button();
            groupBox1 = new GroupBox();
            popedRegister = new Label();
            clearStackButton = new Button();
            oppCommandBox = new GroupBox();
            label1 = new Label();
            executebutton = new Button();
            oppCom = new ListBox();
            OUTPUT = new GroupBox();
            clearOutput = new Button();
            OutputRegister = new ListBox();
            assemblyCodeBox = new RichTextBox();
            runCodeButton = new Button();
            clearEditorButton = new Button();
            MemoryGrid = new DataGridView();
            loadToMemoryButton = new Button();
            saveToFileButton = new Button();
            cpuClock = new System.Windows.Forms.Timer(components);
            btnStep = new Button();
            btnStartClock = new Button();
            groupBox2 = new GroupBox();
            resetButton = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            menuStrip1 = new MenuStrip();
            hELPToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            architectureToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            isaReferenceToolStripMenuItem = new ToolStripMenuItem();
            oppGuideToolStripMenuItem = new ToolStripMenuItem();
            hARDWARERESETToolStripMenuItem = new ToolStripMenuItem();
            cLOCKSPEEDToolStripMenuItem = new ToolStripMenuItem();
            hZSLOWToolStripMenuItem = new ToolStripMenuItem();
            hZNORMALToolStripMenuItem = new ToolStripMenuItem();
            tURBOMODEToolStripMenuItem = new ToolStripMenuItem();
            RegisterAxBox.SuspendLayout();
            RegisterBxBox.SuspendLayout();
            registersBox.SuspendLayout();
            oppcodebox.SuspendLayout();
            groupBox1.SuspendLayout();
            oppCommandBox.SuspendLayout();
            OUTPUT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MemoryGrid).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterAxBox
            // 
            RegisterAxBox.BackColor = Color.CadetBlue;
            RegisterAxBox.Controls.Add(resetAx);
            RegisterAxBox.Controls.Add(regAxPush);
            RegisterAxBox.Controls.Add(ax0);
            RegisterAxBox.Controls.Add(ax1);
            RegisterAxBox.Controls.Add(ax2);
            RegisterAxBox.Controls.Add(ax3);
            RegisterAxBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterAxBox.Location = new Point(31, 22);
            RegisterAxBox.Name = "RegisterAxBox";
            RegisterAxBox.Size = new Size(249, 115);
            RegisterAxBox.TabIndex = 0;
            RegisterAxBox.TabStop = false;
            RegisterAxBox.Text = "REGISTER AX";
            // 
            // resetAx
            // 
            resetAx.BackColor = Color.Green;
            resetAx.ForeColor = SystemColors.ButtonHighlight;
            resetAx.Location = new Point(138, 68);
            resetAx.Name = "resetAx";
            resetAx.Size = new Size(98, 30);
            resetAx.TabIndex = 9;
            resetAx.Text = "RESET";
            resetAx.UseVisualStyleBackColor = false;
            resetAx.Click += resetAx_Click;
            // 
            // regAxPush
            // 
            regAxPush.BackColor = Color.FromArgb(0, 192, 192);
            regAxPush.Location = new Point(6, 68);
            regAxPush.Name = "regAxPush";
            regAxPush.Size = new Size(98, 30);
            regAxPush.TabIndex = 8;
            regAxPush.Text = "PUSH";
            regAxPush.UseVisualStyleBackColor = false;
            regAxPush.Click += regAxPush_Click;
            // 
            // ax0
            // 
            ax0.ForeColor = Color.Black;
            ax0.Location = new Point(180, 28);
            ax0.Name = "ax0";
            ax0.Size = new Size(56, 34);
            ax0.TabIndex = 5;
            ax0.Text = "0";
            ax0.UseVisualStyleBackColor = true;
            ax0.Click += ax0_Click;
            // 
            // ax1
            // 
            ax1.ForeColor = Color.Black;
            ax1.Location = new Point(122, 28);
            ax1.Name = "ax1";
            ax1.Size = new Size(52, 34);
            ax1.TabIndex = 4;
            ax1.Text = "0";
            ax1.UseVisualStyleBackColor = true;
            ax1.Click += ax1_Click;
            // 
            // ax2
            // 
            ax2.ForeColor = Color.Black;
            ax2.Location = new Point(64, 28);
            ax2.Name = "ax2";
            ax2.Size = new Size(52, 34);
            ax2.TabIndex = 7;
            ax2.Text = "0";
            ax2.UseVisualStyleBackColor = true;
            ax2.Click += ax2_Click;
            // 
            // ax3
            // 
            ax3.ForeColor = Color.Black;
            ax3.Location = new Point(6, 28);
            ax3.Name = "ax3";
            ax3.Size = new Size(52, 34);
            ax3.TabIndex = 6;
            ax3.Text = "0";
            ax3.UseVisualStyleBackColor = true;
            ax3.Click += ax3_Click;
            // 
            // stackList
            // 
            stackList.BackColor = Color.FromArgb(0, 0, 64);
            stackList.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stackList.ForeColor = SystemColors.HighlightText;
            stackList.FormattingEnabled = true;
            stackList.Location = new Point(18, 20);
            stackList.Name = "stackList";
            stackList.Size = new Size(275, 118);
            stackList.TabIndex = 1;
            // 
            // RegisterBxBox
            // 
            RegisterBxBox.BackColor = Color.CadetBlue;
            RegisterBxBox.Controls.Add(resetBx);
            RegisterBxBox.Controls.Add(regBxPush);
            RegisterBxBox.Controls.Add(bx0);
            RegisterBxBox.Controls.Add(bx1);
            RegisterBxBox.Controls.Add(bx2);
            RegisterBxBox.Controls.Add(bx3);
            RegisterBxBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterBxBox.Location = new Point(31, 143);
            RegisterBxBox.Name = "RegisterBxBox";
            RegisterBxBox.Size = new Size(249, 121);
            RegisterBxBox.TabIndex = 10;
            RegisterBxBox.TabStop = false;
            RegisterBxBox.Text = "REGISTER BX";
            // 
            // resetBx
            // 
            resetBx.BackColor = Color.Green;
            resetBx.ForeColor = SystemColors.ButtonHighlight;
            resetBx.Location = new Point(138, 68);
            resetBx.Name = "resetBx";
            resetBx.Size = new Size(98, 30);
            resetBx.TabIndex = 9;
            resetBx.Text = "RESET";
            resetBx.UseVisualStyleBackColor = false;
            resetBx.Click += resetBx_Click;
            // 
            // regBxPush
            // 
            regBxPush.BackColor = Color.FromArgb(0, 192, 192);
            regBxPush.Location = new Point(6, 68);
            regBxPush.Name = "regBxPush";
            regBxPush.Size = new Size(98, 30);
            regBxPush.TabIndex = 8;
            regBxPush.Text = "PUSH";
            regBxPush.UseVisualStyleBackColor = false;
            regBxPush.Click += button2_Click;
            // 
            // bx0
            // 
            bx0.ForeColor = Color.Black;
            bx0.Location = new Point(180, 28);
            bx0.Name = "bx0";
            bx0.Size = new Size(56, 34);
            bx0.TabIndex = 5;
            bx0.Text = "0";
            bx0.UseVisualStyleBackColor = true;
            bx0.Click += bx0_Click;
            // 
            // bx1
            // 
            bx1.ForeColor = Color.Black;
            bx1.Location = new Point(122, 28);
            bx1.Name = "bx1";
            bx1.Size = new Size(52, 34);
            bx1.TabIndex = 4;
            bx1.Text = "0";
            bx1.UseVisualStyleBackColor = true;
            bx1.Click += bx1_Click;
            // 
            // bx2
            // 
            bx2.ForeColor = Color.Black;
            bx2.Location = new Point(64, 28);
            bx2.Name = "bx2";
            bx2.Size = new Size(52, 34);
            bx2.TabIndex = 7;
            bx2.Text = "0";
            bx2.UseVisualStyleBackColor = true;
            bx2.Click += bx2_Click;
            // 
            // bx3
            // 
            bx3.ForeColor = Color.Black;
            bx3.Location = new Point(6, 28);
            bx3.Name = "bx3";
            bx3.Size = new Size(52, 34);
            bx3.TabIndex = 6;
            bx3.Text = "0";
            bx3.UseVisualStyleBackColor = true;
            bx3.Click += bx3_Click;
            // 
            // registersBox
            // 
            registersBox.BackColor = Color.Silver;
            registersBox.Controls.Add(oppcodebox);
            registersBox.Controls.Add(RegisterBxBox);
            registersBox.Controls.Add(RegisterAxBox);
            registersBox.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registersBox.ForeColor = Color.FromArgb(192, 64, 0);
            registersBox.Location = new Point(12, 58);
            registersBox.Name = "registersBox";
            registersBox.Size = new Size(324, 411);
            registersBox.TabIndex = 11;
            registersBox.TabStop = false;
            registersBox.Text = "Registers ";
            // 
            // oppcodebox
            // 
            oppcodebox.BackColor = Color.CadetBlue;
            oppcodebox.Controls.Add(oppResetButton);
            oppcodebox.Controls.Add(oppPush);
            oppcodebox.Controls.Add(op0);
            oppcodebox.Controls.Add(op1);
            oppcodebox.Controls.Add(op2);
            oppcodebox.Controls.Add(op3);
            oppcodebox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oppcodebox.Location = new Point(31, 270);
            oppcodebox.Name = "oppcodebox";
            oppcodebox.Size = new Size(249, 115);
            oppcodebox.TabIndex = 11;
            oppcodebox.TabStop = false;
            oppcodebox.Text = "OPPCODE BOX";
            // 
            // oppResetButton
            // 
            oppResetButton.BackColor = Color.Green;
            oppResetButton.ForeColor = SystemColors.ButtonHighlight;
            oppResetButton.Location = new Point(122, 68);
            oppResetButton.Name = "oppResetButton";
            oppResetButton.Size = new Size(98, 30);
            oppResetButton.TabIndex = 9;
            oppResetButton.Text = "OPP RESET";
            oppResetButton.UseVisualStyleBackColor = false;
            oppResetButton.Click += oppResetButton_Click;
            // 
            // oppPush
            // 
            oppPush.BackColor = Color.FromArgb(0, 192, 192);
            oppPush.Location = new Point(6, 68);
            oppPush.Name = "oppPush";
            oppPush.Size = new Size(98, 30);
            oppPush.TabIndex = 8;
            oppPush.Text = "OPP PUSH";
            oppPush.UseVisualStyleBackColor = false;
            oppPush.Click += oppPush_Click;
            // 
            // op0
            // 
            op0.ForeColor = Color.Black;
            op0.Location = new Point(180, 28);
            op0.Name = "op0";
            op0.Size = new Size(56, 34);
            op0.TabIndex = 5;
            op0.Text = "0";
            op0.UseVisualStyleBackColor = true;
            op0.Click += op0_Click;
            // 
            // op1
            // 
            op1.ForeColor = Color.Black;
            op1.Location = new Point(122, 28);
            op1.Name = "op1";
            op1.Size = new Size(52, 34);
            op1.TabIndex = 4;
            op1.Text = "0";
            op1.UseVisualStyleBackColor = true;
            op1.Click += op1_Click;
            // 
            // op2
            // 
            op2.ForeColor = Color.Black;
            op2.Location = new Point(64, 28);
            op2.Name = "op2";
            op2.Size = new Size(52, 34);
            op2.TabIndex = 7;
            op2.Text = "0";
            op2.UseVisualStyleBackColor = true;
            op2.Click += op2_Click;
            // 
            // op3
            // 
            op3.ForeColor = Color.Black;
            op3.Location = new Point(6, 28);
            op3.Name = "op3";
            op3.Size = new Size(52, 34);
            op3.TabIndex = 6;
            op3.Text = "0";
            op3.UseVisualStyleBackColor = true;
            op3.Click += op3_Click;
            // 
            // popStackButton
            // 
            popStackButton.BackColor = Color.Red;
            popStackButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            popStackButton.ForeColor = SystemColors.ActiveCaption;
            popStackButton.Location = new Point(18, 164);
            popStackButton.Name = "popStackButton";
            popStackButton.Size = new Size(115, 30);
            popStackButton.TabIndex = 12;
            popStackButton.Text = "POP";
            popStackButton.UseVisualStyleBackColor = false;
            popStackButton.Click += popStackButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(popedRegister);
            groupBox1.Controls.Add(clearStackButton);
            groupBox1.Controls.Add(popStackButton);
            groupBox1.Controls.Add(stackList);
            groupBox1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 481);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 197);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "STACK LIST";
            // 
            // popedRegister
            // 
            popedRegister.AutoSize = true;
            popedRegister.BackColor = Color.FromArgb(255, 192, 255);
            popedRegister.ForeColor = SystemColors.ActiveCaptionText;
            popedRegister.Location = new Point(18, 143);
            popedRegister.Name = "popedRegister";
            popedRegister.Size = new Size(140, 14);
            popedRegister.TabIndex = 14;
            popedRegister.Text = "Last Poped Register";
            // 
            // clearStackButton
            // 
            clearStackButton.BackColor = Color.Firebrick;
            clearStackButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearStackButton.ForeColor = SystemColors.ActiveCaption;
            clearStackButton.Location = new Point(178, 161);
            clearStackButton.Name = "clearStackButton";
            clearStackButton.Size = new Size(115, 33);
            clearStackButton.TabIndex = 13;
            clearStackButton.Text = "CLEAR STACK";
            clearStackButton.UseVisualStyleBackColor = false;
            clearStackButton.Click += clearStackButton_Click;
            // 
            // oppCommandBox
            // 
            oppCommandBox.BackColor = Color.Silver;
            oppCommandBox.Controls.Add(label1);
            oppCommandBox.Controls.Add(executebutton);
            oppCommandBox.Controls.Add(oppCom);
            oppCommandBox.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oppCommandBox.Location = new Point(12, 680);
            oppCommandBox.Name = "oppCommandBox";
            oppCommandBox.Size = new Size(324, 117);
            oppCommandBox.TabIndex = 14;
            oppCommandBox.TabStop = false;
            oppCommandBox.Text = "OPP COMMAND";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(86, 64);
            label1.Name = "label1";
            label1.Size = new Size(144, 19);
            label1.TabIndex = 2;
            label1.Text = "MANUAL STEPPING";
            // 
            // executebutton
            // 
            executebutton.BackColor = Color.FromArgb(192, 64, 0);
            executebutton.Font = new Font("Consolas", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            executebutton.Location = new Point(95, 86);
            executebutton.Name = "executebutton";
            executebutton.Size = new Size(117, 28);
            executebutton.TabIndex = 1;
            executebutton.Text = "EXECUTE";
            executebutton.UseVisualStyleBackColor = false;
            executebutton.Click += executebutton_Click;
            // 
            // oppCom
            // 
            oppCom.BackColor = Color.FromArgb(0, 0, 64);
            oppCom.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oppCom.ForeColor = Color.White;
            oppCom.FormattingEnabled = true;
            oppCom.Location = new Point(20, 15);
            oppCom.Name = "oppCom";
            oppCom.Size = new Size(298, 46);
            oppCom.TabIndex = 0;
            // 
            // OUTPUT
            // 
            OUTPUT.BackColor = Color.Silver;
            OUTPUT.Controls.Add(clearOutput);
            OUTPUT.Controls.Add(OutputRegister);
            OUTPUT.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OUTPUT.Location = new Point(1027, 58);
            OUTPUT.Name = "OUTPUT";
            OUTPUT.Size = new Size(387, 437);
            OUTPUT.TabIndex = 15;
            OUTPUT.TabStop = false;
            OUTPUT.Text = "OUTPUT ";
            // 
            // clearOutput
            // 
            clearOutput.BackColor = Color.Fuchsia;
            clearOutput.Location = new Point(337, 486);
            clearOutput.Name = "clearOutput";
            clearOutput.Size = new Size(75, 23);
            clearOutput.TabIndex = 1;
            clearOutput.Text = "CLEAR OUTPUT SCREEN";
            clearOutput.UseVisualStyleBackColor = false;
            clearOutput.Click += clearOutput_Click;
            // 
            // OutputRegister
            // 
            OutputRegister.BackColor = Color.FromArgb(0, 0, 64);
            OutputRegister.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OutputRegister.ForeColor = Color.White;
            OutputRegister.FormattingEnabled = true;
            OutputRegister.Location = new Point(6, 25);
            OutputRegister.Name = "OutputRegister";
            OutputRegister.Size = new Size(360, 403);
            OutputRegister.TabIndex = 0;
            // 
            // assemblyCodeBox
            // 
            assemblyCodeBox.BackColor = Color.FromArgb(0, 0, 64);
            assemblyCodeBox.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assemblyCodeBox.ForeColor = Color.Lime;
            assemblyCodeBox.Location = new Point(18, 42);
            assemblyCodeBox.Name = "assemblyCodeBox";
            assemblyCodeBox.Size = new Size(652, 643);
            assemblyCodeBox.TabIndex = 17;
            assemblyCodeBox.Text = "";
            // 
            // runCodeButton
            // 
            runCodeButton.BackColor = Color.FromArgb(192, 192, 0);
            runCodeButton.ForeColor = SystemColors.ActiveCaptionText;
            runCodeButton.Location = new Point(0, 17);
            runCodeButton.Name = "runCodeButton";
            runCodeButton.Size = new Size(130, 40);
            runCodeButton.TabIndex = 18;
            runCodeButton.Text = "RUN CODE";
            runCodeButton.UseVisualStyleBackColor = false;
            runCodeButton.Click += runCodeButton_Click;
            // 
            // clearEditorButton
            // 
            clearEditorButton.BackColor = Color.FromArgb(192, 192, 0);
            clearEditorButton.ForeColor = SystemColors.ActiveCaptionText;
            clearEditorButton.Location = new Point(137, 17);
            clearEditorButton.Name = "clearEditorButton";
            clearEditorButton.Size = new Size(130, 40);
            clearEditorButton.TabIndex = 19;
            clearEditorButton.Text = "CLEAR EDITOR";
            clearEditorButton.UseVisualStyleBackColor = false;
            clearEditorButton.Click += clearEditorButton_Click;
            // 
            // MemoryGrid
            // 
            MemoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemoryGrid.Location = new Point(6, 21);
            MemoryGrid.Name = "MemoryGrid";
            MemoryGrid.Size = new Size(361, 260);
            MemoryGrid.TabIndex = 20;
            // 
            // loadToMemoryButton
            // 
            loadToMemoryButton.BackColor = Color.FromArgb(192, 192, 0);
            loadToMemoryButton.ForeColor = SystemColors.ActiveCaptionText;
            loadToMemoryButton.Location = new Point(712, 17);
            loadToMemoryButton.Name = "loadToMemoryButton";
            loadToMemoryButton.Size = new Size(187, 40);
            loadToMemoryButton.TabIndex = 21;
            loadToMemoryButton.Text = "LOAD TO MEMORY";
            loadToMemoryButton.UseVisualStyleBackColor = false;
            loadToMemoryButton.Click += loadToMemoryButton_Click;
            // 
            // saveToFileButton
            // 
            saveToFileButton.BackColor = Color.FromArgb(192, 192, 0);
            saveToFileButton.ForeColor = SystemColors.ActiveCaptionText;
            saveToFileButton.Location = new Point(448, 17);
            saveToFileButton.Name = "saveToFileButton";
            saveToFileButton.Size = new Size(130, 40);
            saveToFileButton.TabIndex = 22;
            saveToFileButton.Text = "SAVE TO FILE";
            saveToFileButton.UseVisualStyleBackColor = false;
            saveToFileButton.Click += saveToFileButton_Click;
            // 
            // cpuClock
            // 
            cpuClock.Interval = 500;
            cpuClock.Tick += cpuClock_Tick;
            // 
            // btnStep
            // 
            btnStep.BackColor = Color.FromArgb(255, 192, 128);
            btnStep.ForeColor = SystemColors.ActiveCaptionText;
            btnStep.Location = new Point(584, 17);
            btnStep.Name = "btnStep";
            btnStep.Size = new Size(122, 40);
            btnStep.TabIndex = 23;
            btnStep.Text = "STEP";
            btnStep.UseVisualStyleBackColor = false;
            btnStep.Click += btnStep_Click;
            // 
            // btnStartClock
            // 
            btnStartClock.BackColor = Color.FromArgb(0, 64, 0);
            btnStartClock.ForeColor = Color.White;
            btnStartClock.Location = new Point(327, 17);
            btnStartClock.Name = "btnStartClock";
            btnStartClock.Size = new Size(115, 40);
            btnStartClock.TabIndex = 24;
            btnStartClock.Text = "AUTO RUN";
            btnStartClock.UseVisualStyleBackColor = false;
            btnStartClock.Click += btnStartClock_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 128, 0);
            groupBox2.Controls.Add(resetButton);
            groupBox2.Controls.Add(btnStartClock);
            groupBox2.Controls.Add(btnStep);
            groupBox2.Controls.Add(saveToFileButton);
            groupBox2.Controls.Add(loadToMemoryButton);
            groupBox2.Controls.Add(clearEditorButton);
            groupBox2.Controls.Add(runCodeButton);
            groupBox2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(190, 805);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1076, 69);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "OPERATIONS";
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(0, 64, 0);
            resetButton.ForeColor = Color.White;
            resetButton.Location = new Point(905, 17);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(115, 40);
            resetButton.TabIndex = 25;
            resetButton.Text = "RESET ";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(0, 192, 192);
            groupBox3.Controls.Add(assemblyCodeBox);
            groupBox3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(337, 58);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(684, 739);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "ASSEMBLER EDITOR";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(224, 224, 224);
            groupBox4.Controls.Add(MemoryGrid);
            groupBox4.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(1027, 509);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(387, 288);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "MEMORY";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 192, 192);
            menuStrip1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hELPToolStripMenuItem, architectureToolStripMenuItem, helpToolStripMenuItem1, isaReferenceToolStripMenuItem, oppGuideToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1441, 27);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // hELPToolStripMenuItem
            // 
            hELPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            hELPToolStripMenuItem.Size = new Size(165, 23);
            hELPToolStripMenuItem.Text = "Mnemonic/Program";
            hELPToolStripMenuItem.Click += hELPToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(249, 24);
            aboutToolStripMenuItem.Text = "LOAD SAMPLE PROGRAM";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // architectureToolStripMenuItem
            // 
            architectureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hARDWARERESETToolStripMenuItem, cLOCKSPEEDToolStripMenuItem });
            architectureToolStripMenuItem.Name = "architectureToolStripMenuItem";
            architectureToolStripMenuItem.Size = new Size(129, 23);
            architectureToolStripMenuItem.Text = "Architecture";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(66, 23);
            helpToolStripMenuItem1.Text = "About";
            helpToolStripMenuItem1.Click += helpToolStripMenuItem1_Click;
            // 
            // isaReferenceToolStripMenuItem
            // 
            isaReferenceToolStripMenuItem.Name = "isaReferenceToolStripMenuItem";
            isaReferenceToolStripMenuItem.Size = new Size(138, 23);
            isaReferenceToolStripMenuItem.Text = "Isa Reference";
            isaReferenceToolStripMenuItem.Click += isaReferenceToolStripMenuItem_Click;
            // 
            // oppGuideToolStripMenuItem
            // 
            oppGuideToolStripMenuItem.Name = "oppGuideToolStripMenuItem";
            oppGuideToolStripMenuItem.Size = new Size(93, 23);
            oppGuideToolStripMenuItem.Text = "OppGuide";
            oppGuideToolStripMenuItem.Click += oppGuideToolStripMenuItem_Click;
            // 
            // hARDWARERESETToolStripMenuItem
            // 
            hARDWARERESETToolStripMenuItem.Name = "hARDWARERESETToolStripMenuItem";
            hARDWARERESETToolStripMenuItem.Size = new Size(204, 24);
            hARDWARERESETToolStripMenuItem.Text = "HARDWARE RESET";
            hARDWARERESETToolStripMenuItem.Click += hARDWARERESETToolStripMenuItem_Click;
            // 
            // cLOCKSPEEDToolStripMenuItem
            // 
            cLOCKSPEEDToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hZSLOWToolStripMenuItem, hZNORMALToolStripMenuItem, tURBOMODEToolStripMenuItem });
            cLOCKSPEEDToolStripMenuItem.Name = "cLOCKSPEEDToolStripMenuItem";
            cLOCKSPEEDToolStripMenuItem.Size = new Size(204, 24);
            cLOCKSPEEDToolStripMenuItem.Text = "CLOCK SPEED";
            // 
            // hZSLOWToolStripMenuItem
            // 
            hZSLOWToolStripMenuItem.Name = "hZSLOWToolStripMenuItem";
            hZSLOWToolStripMenuItem.Size = new Size(180, 24);
            hZSLOWToolStripMenuItem.Text = "1 HZ SLOW";
            // 
            // hZNORMALToolStripMenuItem
            // 
            hZNORMALToolStripMenuItem.Name = "hZNORMALToolStripMenuItem";
            hZNORMALToolStripMenuItem.Size = new Size(180, 24);
            hZNORMALToolStripMenuItem.Text = "2 HZ NORMAL";
            // 
            // tURBOMODEToolStripMenuItem
            // 
            tURBOMODEToolStripMenuItem.Name = "tURBOMODEToolStripMenuItem";
            tURBOMODEToolStripMenuItem.Size = new Size(180, 24);
            tURBOMODEToolStripMenuItem.Text = "TURBO MODE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1441, 888);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(OUTPUT);
            Controls.Add(oppCommandBox);
            Controls.Add(groupBox1);
            Controls.Add(registersBox);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ButtonFace;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            RegisterAxBox.ResumeLayout(false);
            RegisterBxBox.ResumeLayout(false);
            registersBox.ResumeLayout(false);
            oppcodebox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            oppCommandBox.ResumeLayout(false);
            oppCommandBox.PerformLayout();
            OUTPUT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MemoryGrid).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private GroupBox RegisterAxBox;
        private Button ax7;
        private Button ax0;
        private Button ax1;
        private Button ax4;
        private Button ax5;
        private Button ax2;
        private Button ax3;
        private Button ax6;
        private ListBox stackList;
        private Button resetAx;
        private Button regAxPush;
        private GroupBox RegisterBxBox;
        private Button resetBx;
        private Button regBxPush;
        private Button bx0;
        private Button bx1;
        private Button bx2;
        private Button bx3;
        private GroupBox registersBox;
        private Button popStackButton;
        private GroupBox groupBox1;
        private Button clearStackButton;
        private Label popedRegister;
        private GroupBox oppcodebox;
        private Button oppResetButton;
        private Button oppPush;
        private Button op0;
        private Button op1;
        private Button op2;
        private Button op3;
        private GroupBox oppCommandBox;
        private ListBox oppCom;
        private Button executebutton;
        private GroupBox OUTPUT;
        private ListBox OutputRegister;
        private Label label1;
        private RichTextBox assemblyCodeBox;
        private Button runCodeButton;
        private Button clearEditorButton;
        private DataGridView MemoryGrid;
        private Button loadToMemoryButton;
        private Button saveToFileButton;
        private Button clearOutput;
        private System.Windows.Forms.Timer cpuClock;
        private Button btnStep;
        private Button btnStartClock;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button resetButton;
        private GroupBox groupBox4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hELPToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem architectureToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem isaReferenceToolStripMenuItem;
        private ToolStripMenuItem oppGuideToolStripMenuItem;
        private ToolStripMenuItem hARDWARERESETToolStripMenuItem;
        private ToolStripMenuItem cLOCKSPEEDToolStripMenuItem;
        private ToolStripMenuItem hZSLOWToolStripMenuItem;
        private ToolStripMenuItem hZNORMALToolStripMenuItem;
        private ToolStripMenuItem tURBOMODEToolStripMenuItem;
    }
}
