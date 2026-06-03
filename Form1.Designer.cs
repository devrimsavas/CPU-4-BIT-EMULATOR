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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            btnStep = new Button();
            executebutton = new Button();
            runCodeButton = new Button();
            oppCom = new ListBox();
            OUTPUT = new GroupBox();
            clearOutput = new Button();
            OutputRegister = new ListBox();
            assemblyCodeBox = new RichTextBox();
            clearEditorButton = new Button();
            MemoryGrid = new DataGridView();
            loadToMemoryButton = new Button();
            cpuClock = new System.Windows.Forms.Timer(components);
            btnStartClock = new Button();
            groupBox2 = new GroupBox();
            resetButton = new Button();
            groupBox3 = new GroupBox();
            groupBox6 = new GroupBox();
            button1 = new Button();
            resetScreenButton = new Button();
            videoGrid = new DataGridView();
            dataMemoryGrid = new DataGridView();
            Address = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            menuStrip1 = new MenuStrip();
            hELPToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            lOADSAMPLE2ToolStripMenuItem = new ToolStripMenuItem();
            fastDivisionUsingSHR82ToolStripMenuItem = new ToolStripMenuItem();
            storeToMemoryToolStripMenuItem = new ToolStripMenuItem();
            xorSwapTestToolStripMenuItem = new ToolStripMenuItem();
            counterToolStripMenuItem = new ToolStripMenuItem();
            architectureToolStripMenuItem = new ToolStripMenuItem();
            hARDWARERESETToolStripMenuItem = new ToolStripMenuItem();
            cLOCKSPEEDToolStripMenuItem = new ToolStripMenuItem();
            hZSLOWToolStripMenuItem = new ToolStripMenuItem();
            hZNORMALToolStripMenuItem = new ToolStripMenuItem();
            tURBOMODEToolStripMenuItem = new ToolStripMenuItem();
            isaReferenceToolStripMenuItem = new ToolStripMenuItem();
            oppGuideToolStripMenuItem = new ToolStripMenuItem();
            saveCodeToFileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            lOADFROMFILEToolStripMenuItem = new ToolStripMenuItem();
            groupBox5 = new GroupBox();
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
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataMemoryGrid).BeginInit();
            groupBox4.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox5.SuspendLayout();
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
            RegisterAxBox.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterAxBox.Location = new Point(6, 22);
            RegisterAxBox.Name = "RegisterAxBox";
            RegisterAxBox.Size = new Size(207, 96);
            RegisterAxBox.TabIndex = 0;
            RegisterAxBox.TabStop = false;
            RegisterAxBox.Text = "REGISTER AX";
            // 
            // resetAx
            // 
            resetAx.BackColor = Color.Green;
            resetAx.Font = new Font("Consolas", 9F);
            resetAx.ForeColor = SystemColors.ButtonHighlight;
            resetAx.Location = new Point(97, 54);
            resetAx.Name = "resetAx";
            resetAx.Size = new Size(82, 30);
            resetAx.TabIndex = 9;
            resetAx.Text = "RESET";
            resetAx.UseVisualStyleBackColor = false;
            resetAx.Click += resetAx_Click;
            // 
            // regAxPush
            // 
            regAxPush.BackColor = Color.FromArgb(0, 192, 192);
            regAxPush.Font = new Font("Consolas", 9F);
            regAxPush.Location = new Point(6, 54);
            regAxPush.Name = "regAxPush";
            regAxPush.Size = new Size(73, 30);
            regAxPush.TabIndex = 8;
            regAxPush.Text = "PUSH";
            regAxPush.UseVisualStyleBackColor = false;
            regAxPush.Click += regAxPush_Click;
            // 
            // ax0
            // 
            ax0.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            ax0.ForeColor = Color.Black;
            ax0.Location = new Point(146, 28);
            ax0.Name = "ax0";
            ax0.Size = new Size(40, 20);
            ax0.TabIndex = 5;
            ax0.Text = "0";
            ax0.UseVisualStyleBackColor = true;
            ax0.Click += ax0_Click;
            // 
            // ax1
            // 
            ax1.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            ax1.ForeColor = Color.Black;
            ax1.Location = new Point(100, 28);
            ax1.Name = "ax1";
            ax1.Size = new Size(40, 20);
            ax1.TabIndex = 4;
            ax1.Text = "0";
            ax1.UseVisualStyleBackColor = true;
            ax1.Click += ax1_Click;
            // 
            // ax2
            // 
            ax2.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            ax2.ForeColor = Color.Black;
            ax2.Location = new Point(54, 28);
            ax2.Name = "ax2";
            ax2.Size = new Size(40, 20);
            ax2.TabIndex = 7;
            ax2.Text = "0";
            ax2.UseVisualStyleBackColor = true;
            ax2.Click += ax2_Click;
            // 
            // ax3
            // 
            ax3.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            ax3.ForeColor = Color.Black;
            ax3.Location = new Point(6, 28);
            ax3.Name = "ax3";
            ax3.Size = new Size(42, 20);
            ax3.TabIndex = 6;
            ax3.Text = "0";
            ax3.UseVisualStyleBackColor = true;
            ax3.Click += ax3_Click;
            // 
            // stackList
            // 
            stackList.BackColor = Color.FromArgb(0, 0, 64);
            stackList.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stackList.ForeColor = SystemColors.HighlightText;
            stackList.FormattingEnabled = true;
            stackList.Location = new Point(0, 21);
            stackList.Name = "stackList";
            stackList.Size = new Size(218, 46);
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
            RegisterBxBox.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterBxBox.Location = new Point(5, 124);
            RegisterBxBox.Name = "RegisterBxBox";
            RegisterBxBox.Size = new Size(208, 91);
            RegisterBxBox.TabIndex = 10;
            RegisterBxBox.TabStop = false;
            RegisterBxBox.Text = "REGISTER BX";
            // 
            // resetBx
            // 
            resetBx.BackColor = Color.Green;
            resetBx.Font = new Font("Consolas", 9F);
            resetBx.ForeColor = SystemColors.ButtonHighlight;
            resetBx.Location = new Point(98, 53);
            resetBx.Name = "resetBx";
            resetBx.Size = new Size(82, 30);
            resetBx.TabIndex = 9;
            resetBx.Text = "RESET";
            resetBx.UseVisualStyleBackColor = false;
            resetBx.Click += resetBx_Click;
            // 
            // regBxPush
            // 
            regBxPush.BackColor = Color.FromArgb(0, 192, 192);
            regBxPush.Font = new Font("Consolas", 9F);
            regBxPush.Location = new Point(6, 53);
            regBxPush.Name = "regBxPush";
            regBxPush.Size = new Size(74, 30);
            regBxPush.TabIndex = 8;
            regBxPush.Text = "PUSH";
            regBxPush.UseVisualStyleBackColor = false;
            regBxPush.Click += button2_Click;
            // 
            // bx0
            // 
            bx0.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            bx0.ForeColor = Color.Black;
            bx0.Location = new Point(148, 25);
            bx0.Name = "bx0";
            bx0.Size = new Size(39, 22);
            bx0.TabIndex = 5;
            bx0.Text = "0";
            bx0.UseVisualStyleBackColor = true;
            bx0.Click += bx0_Click;
            // 
            // bx1
            // 
            bx1.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            bx1.ForeColor = Color.Black;
            bx1.Location = new Point(101, 25);
            bx1.Name = "bx1";
            bx1.Size = new Size(41, 22);
            bx1.TabIndex = 4;
            bx1.Text = "0";
            bx1.UseVisualStyleBackColor = true;
            bx1.Click += bx1_Click;
            // 
            // bx2
            // 
            bx2.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            bx2.ForeColor = Color.Black;
            bx2.Location = new Point(55, 25);
            bx2.Name = "bx2";
            bx2.Size = new Size(40, 22);
            bx2.TabIndex = 7;
            bx2.Text = "0";
            bx2.UseVisualStyleBackColor = true;
            bx2.Click += bx2_Click;
            // 
            // bx3
            // 
            bx3.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            bx3.ForeColor = Color.Black;
            bx3.Location = new Point(6, 25);
            bx3.Name = "bx3";
            bx3.Size = new Size(43, 22);
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
            registersBox.Location = new Point(7, 17);
            registersBox.Name = "registersBox";
            registersBox.Size = new Size(224, 340);
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
            oppcodebox.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oppcodebox.Location = new Point(6, 221);
            oppcodebox.Name = "oppcodebox";
            oppcodebox.Size = new Size(207, 109);
            oppcodebox.TabIndex = 11;
            oppcodebox.TabStop = false;
            oppcodebox.Text = "OPPCODE BOX";
            // 
            // oppResetButton
            // 
            oppResetButton.BackColor = Color.Green;
            oppResetButton.Font = new Font("Consolas", 9F);
            oppResetButton.ForeColor = SystemColors.ButtonHighlight;
            oppResetButton.Location = new Point(100, 61);
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
            oppPush.Font = new Font("Consolas", 9F);
            oppPush.Location = new Point(6, 61);
            oppPush.Name = "oppPush";
            oppPush.Size = new Size(88, 30);
            oppPush.TabIndex = 8;
            oppPush.Text = "OPP PUSH";
            oppPush.UseVisualStyleBackColor = false;
            oppPush.Click += oppPush_Click;
            // 
            // op0
            // 
            op0.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            op0.ForeColor = Color.Black;
            op0.Location = new Point(146, 28);
            op0.Name = "op0";
            op0.Size = new Size(40, 27);
            op0.TabIndex = 5;
            op0.Text = "0";
            op0.UseVisualStyleBackColor = true;
            op0.Click += op0_Click;
            // 
            // op1
            // 
            op1.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            op1.ForeColor = Color.Black;
            op1.Location = new Point(100, 28);
            op1.Name = "op1";
            op1.Size = new Size(41, 27);
            op1.TabIndex = 4;
            op1.Text = "0";
            op1.UseVisualStyleBackColor = true;
            op1.Click += op1_Click;
            // 
            // op2
            // 
            op2.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            op2.ForeColor = Color.Black;
            op2.Location = new Point(54, 28);
            op2.Name = "op2";
            op2.Size = new Size(40, 27);
            op2.TabIndex = 7;
            op2.Text = "0";
            op2.UseVisualStyleBackColor = true;
            op2.Click += op2_Click;
            // 
            // op3
            // 
            op3.Font = new Font("Consolas", 6.75F, FontStyle.Bold);
            op3.ForeColor = Color.Black;
            op3.Location = new Point(6, 28);
            op3.Name = "op3";
            op3.Size = new Size(42, 27);
            op3.TabIndex = 6;
            op3.Text = "0";
            op3.UseVisualStyleBackColor = true;
            op3.Click += op3_Click;
            // 
            // popStackButton
            // 
            popStackButton.BackColor = Color.Red;
            popStackButton.Font = new Font("Segoe UI Light", 9F);
            popStackButton.ForeColor = SystemColors.ActiveCaption;
            popStackButton.Location = new Point(6, 73);
            popStackButton.Name = "popStackButton";
            popStackButton.Size = new Size(79, 26);
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
            groupBox1.Location = new Point(7, 363);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 123);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "STACK LIST";
            // 
            // popedRegister
            // 
            popedRegister.AutoSize = true;
            popedRegister.BackColor = Color.FromArgb(255, 192, 255);
            popedRegister.ForeColor = SystemColors.ActiveCaptionText;
            popedRegister.Location = new Point(6, 102);
            popedRegister.Name = "popedRegister";
            popedRegister.Size = new Size(140, 14);
            popedRegister.TabIndex = 14;
            popedRegister.Text = "Last Poped Register";
            popedRegister.Click += popedRegister_Click;
            // 
            // clearStackButton
            // 
            clearStackButton.BackColor = Color.Firebrick;
            clearStackButton.Font = new Font("Segoe UI Light", 9F);
            clearStackButton.ForeColor = SystemColors.ActiveCaption;
            clearStackButton.Location = new Point(91, 73);
            clearStackButton.Name = "clearStackButton";
            clearStackButton.Size = new Size(94, 26);
            clearStackButton.TabIndex = 13;
            clearStackButton.Text = "CLEAR STACK";
            clearStackButton.UseVisualStyleBackColor = false;
            clearStackButton.Click += clearStackButton_Click;
            // 
            // oppCommandBox
            // 
            oppCommandBox.BackColor = Color.Silver;
            oppCommandBox.Controls.Add(label1);
            oppCommandBox.Controls.Add(btnStep);
            oppCommandBox.Controls.Add(executebutton);
            oppCommandBox.Controls.Add(runCodeButton);
            oppCommandBox.Controls.Add(oppCom);
            oppCommandBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oppCommandBox.Location = new Point(7, 498);
            oppCommandBox.Name = "oppCommandBox";
            oppCommandBox.Size = new Size(225, 281);
            oppCommandBox.TabIndex = 14;
            oppCommandBox.TabStop = false;
            oppCommandBox.Text = "OPP COMMAND";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(1, 79);
            label1.Name = "label1";
            label1.Size = new Size(112, 14);
            label1.TabIndex = 2;
            label1.Text = "MANUAL STEPPING";
            // 
            // btnStep
            // 
            btnStep.BackColor = Color.FromArgb(255, 192, 128);
            btnStep.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStep.ForeColor = SystemColors.ActiveCaptionText;
            btnStep.Location = new Point(1, 129);
            btnStep.Name = "btnStep";
            btnStep.Size = new Size(112, 24);
            btnStep.TabIndex = 23;
            btnStep.Text = "STEP";
            btnStep.UseVisualStyleBackColor = false;
            btnStep.Click += btnStep_Click;
            // 
            // executebutton
            // 
            executebutton.BackColor = Color.FromArgb(192, 64, 0);
            executebutton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            executebutton.Location = new Point(0, 50);
            executebutton.Name = "executebutton";
            executebutton.Size = new Size(117, 28);
            executebutton.TabIndex = 1;
            executebutton.Text = "EXECUTE";
            executebutton.UseVisualStyleBackColor = false;
            executebutton.Click += executebutton_Click;
            // 
            // runCodeButton
            // 
            runCodeButton.BackColor = Color.FromArgb(192, 192, 0);
            runCodeButton.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            runCodeButton.ForeColor = SystemColors.ActiveCaptionText;
            runCodeButton.Location = new Point(0, 99);
            runCodeButton.Name = "runCodeButton";
            runCodeButton.Size = new Size(113, 24);
            runCodeButton.TabIndex = 18;
            runCodeButton.Text = "RUN CODE";
            runCodeButton.UseVisualStyleBackColor = false;
            runCodeButton.Click += runCodeButton_Click;
            // 
            // oppCom
            // 
            oppCom.BackColor = Color.FromArgb(0, 0, 64);
            oppCom.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oppCom.ForeColor = Color.White;
            oppCom.FormattingEnabled = true;
            oppCom.Location = new Point(1, 15);
            oppCom.Name = "oppCom";
            oppCom.Size = new Size(224, 32);
            oppCom.TabIndex = 0;
            // 
            // OUTPUT
            // 
            OUTPUT.BackColor = Color.Silver;
            OUTPUT.Controls.Add(clearOutput);
            OUTPUT.Controls.Add(OutputRegister);
            OUTPUT.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OUTPUT.Location = new Point(489, 22);
            OUTPUT.Name = "OUTPUT";
            OUTPUT.Size = new Size(442, 262);
            OUTPUT.TabIndex = 15;
            OUTPUT.TabStop = false;
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
            OutputRegister.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutputRegister.ForeColor = Color.White;
            OutputRegister.FormattingEnabled = true;
            OutputRegister.HorizontalScrollbar = true;
            OutputRegister.Location = new Point(6, 14);
            OutputRegister.Name = "OutputRegister";
            OutputRegister.ScrollAlwaysVisible = true;
            OutputRegister.Size = new Size(430, 228);
            OutputRegister.TabIndex = 1;
            // 
            // assemblyCodeBox
            // 
            assemblyCodeBox.BackColor = Color.FromArgb(0, 0, 64);
            assemblyCodeBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assemblyCodeBox.ForeColor = Color.Lime;
            assemblyCodeBox.Location = new Point(6, 22);
            assemblyCodeBox.Name = "assemblyCodeBox";
            assemblyCodeBox.Size = new Size(477, 734);
            assemblyCodeBox.TabIndex = 17;
            assemblyCodeBox.Text = "";
            // 
            // clearEditorButton
            // 
            clearEditorButton.BackColor = Color.FromArgb(192, 192, 0);
            clearEditorButton.ForeColor = SystemColors.ActiveCaptionText;
            clearEditorButton.Location = new Point(6, 20);
            clearEditorButton.Name = "clearEditorButton";
            clearEditorButton.Size = new Size(115, 41);
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
            MemoryGrid.Size = new Size(372, 713);
            MemoryGrid.TabIndex = 20;
            // 
            // loadToMemoryButton
            // 
            loadToMemoryButton.BackColor = Color.FromArgb(192, 192, 0);
            loadToMemoryButton.ForeColor = SystemColors.ActiveCaptionText;
            loadToMemoryButton.Location = new Point(127, 20);
            loadToMemoryButton.Name = "loadToMemoryButton";
            loadToMemoryButton.Size = new Size(162, 40);
            loadToMemoryButton.TabIndex = 21;
            loadToMemoryButton.Text = "LOAD TO MEMORY";
            loadToMemoryButton.UseVisualStyleBackColor = false;
            loadToMemoryButton.Click += loadToMemoryButton_Click;
            // 
            // cpuClock
            // 
            cpuClock.Interval = 2;
            cpuClock.Tick += cpuClock_Tick;
            // 
            // btnStartClock
            // 
            btnStartClock.BackColor = Color.FromArgb(0, 64, 0);
            btnStartClock.ForeColor = Color.White;
            btnStartClock.Location = new Point(295, 20);
            btnStartClock.Name = "btnStartClock";
            btnStartClock.Size = new Size(128, 39);
            btnStartClock.TabIndex = 24;
            btnStartClock.Text = "AUTO RUN";
            btnStartClock.UseVisualStyleBackColor = false;
            btnStartClock.Click += btnStartClock_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Olive;
            groupBox2.Controls.Add(resetButton);
            groupBox2.Controls.Add(clearEditorButton);
            groupBox2.Controls.Add(loadToMemoryButton);
            groupBox2.Controls.Add(btnStartClock);
            groupBox2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(6, 764);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(477, 121);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "OPERATIONS";
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(0, 64, 0);
            resetButton.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetButton.ForeColor = Color.White;
            resetButton.Location = new Point(6, 73);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(104, 36);
            resetButton.TabIndex = 25;
            resetButton.Text = "RESET /STOP";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(0, 192, 192);
            groupBox3.Controls.Add(groupBox6);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(dataMemoryGrid);
            groupBox3.Controls.Add(OUTPUT);
            groupBox3.Controls.Add(assemblyCodeBox);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(237, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1388, 891);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "ASSEMBLER EDITOR";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.LightGray;
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(resetScreenButton);
            groupBox6.Controls.Add(videoGrid);
            groupBox6.Location = new Point(562, 508);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(289, 362);
            groupBox6.TabIndex = 31;
            groupBox6.TabStop = false;
            groupBox6.Text = "OUTPUT SCREEN";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(176, 298);
            button1.Name = "button1";
            button1.Size = new Size(95, 47);
            button1.TabIndex = 31;
            button1.Text = "Color Mode";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // resetScreenButton
            // 
            resetScreenButton.BackColor = Color.FromArgb(255, 192, 128);
            resetScreenButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetScreenButton.Location = new Point(28, 298);
            resetScreenButton.Name = "resetScreenButton";
            resetScreenButton.Size = new Size(142, 47);
            resetScreenButton.TabIndex = 30;
            resetScreenButton.Text = "Reset Screen";
            resetScreenButton.UseVisualStyleBackColor = false;
            resetScreenButton.Click += resetScreenButton_Click;
            // 
            // videoGrid
            // 
            videoGrid.AllowUserToOrderColumns = true;
            videoGrid.BackgroundColor = Color.Black;
            videoGrid.BorderStyle = BorderStyle.None;
            videoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            videoGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            videoGrid.DefaultCellStyle = dataGridViewCellStyle1;
            videoGrid.GridColor = Color.DimGray;
            videoGrid.Location = new Point(28, 25);
            videoGrid.Name = "videoGrid";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            videoGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            videoGrid.RowHeadersVisible = false;
            videoGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            videoGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            videoGrid.Size = new Size(243, 267);
            videoGrid.TabIndex = 28;
            // 
            // dataMemoryGrid
            // 
            dataMemoryGrid.AllowUserToAddRows = false;
            dataMemoryGrid.AllowUserToDeleteRows = false;
            dataMemoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMemoryGrid.BackgroundColor = Color.White;
            dataMemoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMemoryGrid.Columns.AddRange(new DataGridViewColumn[] { Address, Data });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataMemoryGrid.DefaultCellStyle = dataGridViewCellStyle6;
            dataMemoryGrid.GridColor = Color.FromArgb(255, 128, 128);
            dataMemoryGrid.Location = new Point(489, 291);
            dataMemoryGrid.Name = "dataMemoryGrid";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataMemoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataMemoryGrid.RowHeadersVisible = false;
            dataMemoryGrid.Size = new Size(442, 211);
            dataMemoryGrid.TabIndex = 29;
            // 
            // Address
            // 
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            Address.DefaultCellStyle = dataGridViewCellStyle4;
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // Data
            // 
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            Data.DefaultCellStyle = dataGridViewCellStyle5;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(224, 224, 224);
            groupBox4.Controls.Add(MemoryGrid);
            groupBox4.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(937, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(384, 740);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "MEMORY";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.ForestGreen;
            menuStrip1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hELPToolStripMenuItem, architectureToolStripMenuItem, isaReferenceToolStripMenuItem, oppGuideToolStripMenuItem, saveCodeToFileToolStripMenuItem, helpToolStripMenuItem1, lOADFROMFILEToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1663, 27);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // hELPToolStripMenuItem
            // 
            hELPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, lOADSAMPLE2ToolStripMenuItem, fastDivisionUsingSHR82ToolStripMenuItem, storeToMemoryToolStripMenuItem, xorSwapTestToolStripMenuItem, counterToolStripMenuItem });
            hELPToolStripMenuItem.ForeColor = Color.Black;
            hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            hELPToolStripMenuItem.Size = new Size(165, 23);
            hELPToolStripMenuItem.Text = "Mnemonic/Program";
            hELPToolStripMenuItem.Click += hELPToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(375, 24);
            aboutToolStripMenuItem.Text = "General Sample Program";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // lOADSAMPLE2ToolStripMenuItem
            // 
            lOADSAMPLE2ToolStripMenuItem.Name = "lOADSAMPLE2ToolStripMenuItem";
            lOADSAMPLE2ToolStripMenuItem.Size = new Size(375, 24);
            lOADSAMPLE2ToolStripMenuItem.Text = "Fast Multiplication Using SHL 3x2";
            lOADSAMPLE2ToolStripMenuItem.Click += lOADSAMPLE2ToolStripMenuItem_Click;
            // 
            // fastDivisionUsingSHR82ToolStripMenuItem
            // 
            fastDivisionUsingSHR82ToolStripMenuItem.Name = "fastDivisionUsingSHR82ToolStripMenuItem";
            fastDivisionUsingSHR82ToolStripMenuItem.Size = new Size(375, 24);
            fastDivisionUsingSHR82ToolStripMenuItem.Text = "Fast Division Using SHR 8/2";
            fastDivisionUsingSHR82ToolStripMenuItem.Click += fastDivisionUsingSHR82ToolStripMenuItem_Click;
            // 
            // storeToMemoryToolStripMenuItem
            // 
            storeToMemoryToolStripMenuItem.Name = "storeToMemoryToolStripMenuItem";
            storeToMemoryToolStripMenuItem.Size = new Size(375, 24);
            storeToMemoryToolStripMenuItem.Text = "Store To Memory";
            storeToMemoryToolStripMenuItem.Click += storeToMemoryToolStripMenuItem_Click;
            // 
            // xorSwapTestToolStripMenuItem
            // 
            xorSwapTestToolStripMenuItem.Name = "xorSwapTestToolStripMenuItem";
            xorSwapTestToolStripMenuItem.Size = new Size(375, 24);
            xorSwapTestToolStripMenuItem.Text = "Xor Swap Test";
            xorSwapTestToolStripMenuItem.Click += xorSwapTestToolStripMenuItem_Click;
            // 
            // counterToolStripMenuItem
            // 
            counterToolStripMenuItem.Name = "counterToolStripMenuItem";
            counterToolStripMenuItem.Size = new Size(375, 24);
            counterToolStripMenuItem.Text = "Counter";
            counterToolStripMenuItem.Click += counterToolStripMenuItem_Click;
            // 
            // architectureToolStripMenuItem
            // 
            architectureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hARDWARERESETToolStripMenuItem, cLOCKSPEEDToolStripMenuItem });
            architectureToolStripMenuItem.Name = "architectureToolStripMenuItem";
            architectureToolStripMenuItem.Size = new Size(129, 23);
            architectureToolStripMenuItem.Text = "Architecture";
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
            hZSLOWToolStripMenuItem.Size = new Size(177, 24);
            hZSLOWToolStripMenuItem.Text = "1 HZ SLOW";
            hZSLOWToolStripMenuItem.Click += hZSLOWToolStripMenuItem_Click_1;
            // 
            // hZNORMALToolStripMenuItem
            // 
            hZNORMALToolStripMenuItem.Name = "hZNORMALToolStripMenuItem";
            hZNORMALToolStripMenuItem.Size = new Size(177, 24);
            hZNORMALToolStripMenuItem.Text = "2 HZ NORMAL";
            // 
            // tURBOMODEToolStripMenuItem
            // 
            tURBOMODEToolStripMenuItem.Name = "tURBOMODEToolStripMenuItem";
            tURBOMODEToolStripMenuItem.Size = new Size(177, 24);
            tURBOMODEToolStripMenuItem.Text = "TURBO MODE";
            tURBOMODEToolStripMenuItem.Click += tURBOMODEToolStripMenuItem_Click_1;
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
            // saveCodeToFileToolStripMenuItem
            // 
            saveCodeToFileToolStripMenuItem.Name = "saveCodeToFileToolStripMenuItem";
            saveCodeToFileToolStripMenuItem.Size = new Size(174, 23);
            saveCodeToFileToolStripMenuItem.Text = "Save Code To File";
            saveCodeToFileToolStripMenuItem.Click += saveCodeToFileToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(66, 23);
            helpToolStripMenuItem1.Text = "About";
            helpToolStripMenuItem1.Click += helpToolStripMenuItem1_Click;
            // 
            // lOADFROMFILEToolStripMenuItem
            // 
            lOADFROMFILEToolStripMenuItem.Name = "lOADFROMFILEToolStripMenuItem";
            lOADFROMFILEToolStripMenuItem.Size = new Size(147, 23);
            lOADFROMFILEToolStripMenuItem.Text = "LOAD FROM FILE";
            lOADFROMFILEToolStripMenuItem.Click += lOADFROMFILEToolStripMenuItem_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(128, 64, 64);
            groupBox5.Controls.Add(groupBox3);
            groupBox5.Controls.Add(oppCommandBox);
            groupBox5.Controls.Add(groupBox1);
            groupBox5.Controls.Add(registersBox);
            groupBox5.ForeColor = Color.Black;
            groupBox5.Location = new Point(0, 30);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1663, 914);
            groupBox5.TabIndex = 30;
            groupBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1663, 946);
            Controls.Add(groupBox5);
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
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)videoGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataMemoryGrid).EndInit();
            groupBox4.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox5.ResumeLayout(false);
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
        private ToolStripMenuItem saveCodeToFileToolStripMenuItem;
        private GroupBox groupBox5;
        private ToolStripMenuItem lOADFROMFILEToolStripMenuItem;
        private DataGridView dataMemoryGrid;
        private ToolStripMenuItem lOADSAMPLE2ToolStripMenuItem;
        private ToolStripMenuItem fastDivisionUsingSHR82ToolStripMenuItem;
        private ToolStripMenuItem storeToMemoryToolStripMenuItem;
        private ToolStripMenuItem xorSwapTestToolStripMenuItem;
        private DataGridView videoGrid;
        private Button resetScreenButton;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Data;
        private GroupBox groupBox6;
        private ToolStripMenuItem counterToolStripMenuItem;
        private Button button1;
    }
}
