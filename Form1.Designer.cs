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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
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
            OUTPUT = new GroupBox();
            OutputRegister = new ListBox();
            btnSaveDebug = new Button();
            clearOutputRegisterBtn = new Button();
            assemblyCodeBox = new RichTextBox();
            clearEditorButton = new Button();
            MemoryGrid = new DataGridView();
            loadToMemoryButton = new Button();
            cpuClock = new System.Windows.Forms.Timer(components);
            btnStartClock = new Button();
            groupBox2 = new GroupBox();
            pauseButton = new Button();
            resetButton = new Button();
            groupBox3 = new GroupBox();
            memoryBankGrid = new DataGridView();
            groupBox4 = new GroupBox();
            fileNameLabel = new Label();
            groupBox6 = new GroupBox();
            resetScreenButton = new Button();
            videoGrid = new DataGridView();
            dataMemoryGrid = new DataGridView();
            Address = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            cpuSpeedLabel = new Label();
            menuStrip1 = new MenuStrip();
            hELPToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            lOADSAMPLE2ToolStripMenuItem = new ToolStripMenuItem();
            fastDivisionUsingSHR82ToolStripMenuItem = new ToolStripMenuItem();
            storeToMemoryToolStripMenuItem = new ToolStripMenuItem();
            xorSwapTestToolStripMenuItem = new ToolStripMenuItem();
            counterToolStripMenuItem = new ToolStripMenuItem();
            jUMPNOTZEROToolStripMenuItem = new ToolStripMenuItem();
            architectureToolStripMenuItem = new ToolStripMenuItem();
            hARDWARERESETToolStripMenuItem = new ToolStripMenuItem();
            cLOCKSPEEDToolStripMenuItem = new ToolStripMenuItem();
            hZSLOWToolStripMenuItem = new ToolStripMenuItem();
            hZNORMALToolStripMenuItem = new ToolStripMenuItem();
            tURBOMODEToolStripMenuItem = new ToolStripMenuItem();
            isaReferenceToolStripMenuItem = new ToolStripMenuItem();
            oppGuideToolStripMenuItem = new ToolStripMenuItem();
            saveCodeToFileToolStripMenuItem = new ToolStripMenuItem();
            lOADFROMFILEToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            rETROEFFECTSToolStripMenuItem = new ToolStripMenuItem();
            activeEffectToolStripMenuItem = new ToolStripMenuItem();
            scanlineToolStripMenuItem = new ToolStripMenuItem();
            phosphorGlowToolStripMenuItem = new ToolStripMenuItem();
            rGBMaskToolStripMenuItem = new ToolStripMenuItem();
            vignetteToolStripMenuItem = new ToolStripMenuItem();
            cRTFullToolStripMenuItem = new ToolStripMenuItem();
            groupBox5 = new GroupBox();
            debugToggleButton = new Button();
            btnMonitorPower = new Button();
            screenClock = new System.Windows.Forms.Timer(components);
            resetMonitorBtn = new Button();
            RegisterAxBox.SuspendLayout();
            RegisterBxBox.SuspendLayout();
            registersBox.SuspendLayout();
            OUTPUT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MemoryGrid).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memoryBankGrid).BeginInit();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataMemoryGrid).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterAxBox
            // 
            RegisterAxBox.BackColor = SystemColors.WindowFrame;
            RegisterAxBox.Controls.Add(resetAx);
            RegisterAxBox.Controls.Add(regAxPush);
            RegisterAxBox.Controls.Add(ax0);
            RegisterAxBox.Controls.Add(ax1);
            RegisterAxBox.Controls.Add(ax2);
            RegisterAxBox.Controls.Add(ax3);
            RegisterAxBox.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterAxBox.ForeColor = SystemColors.ActiveCaptionText;
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
            stackList.BackColor = Color.Black;
            stackList.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stackList.ForeColor = SystemColors.HighlightText;
            stackList.FormattingEnabled = true;
            stackList.Location = new Point(0, 231);
            stackList.Name = "stackList";
            stackList.Size = new Size(218, 88);
            stackList.TabIndex = 1;
            // 
            // RegisterBxBox
            // 
            RegisterBxBox.BackColor = SystemColors.WindowFrame;
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
            registersBox.BackColor = SystemColors.ControlDarkDark;
            registersBox.Controls.Add(RegisterBxBox);
            registersBox.Controls.Add(stackList);
            registersBox.Controls.Add(RegisterAxBox);
            registersBox.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registersBox.ForeColor = Color.Black;
            registersBox.Location = new Point(7, 17);
            registersBox.Name = "registersBox";
            registersBox.Size = new Size(224, 340);
            registersBox.TabIndex = 11;
            registersBox.TabStop = false;
            registersBox.Text = "Registers ";
            // 
            // OUTPUT
            // 
            OUTPUT.BackColor = SystemColors.WindowFrame;
            OUTPUT.Controls.Add(OutputRegister);
            OUTPUT.Controls.Add(btnSaveDebug);
            OUTPUT.Controls.Add(clearOutputRegisterBtn);
            OUTPUT.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OUTPUT.Location = new Point(662, 25);
            OUTPUT.Name = "OUTPUT";
            OUTPUT.Size = new Size(436, 1142);
            OUTPUT.TabIndex = 15;
            OUTPUT.TabStop = false;
            // 
            // OutputRegister
            // 
            OutputRegister.BackColor = Color.Black;
            OutputRegister.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutputRegister.ForeColor = Color.Transparent;
            OutputRegister.FormattingEnabled = true;
            OutputRegister.HorizontalScrollbar = true;
            OutputRegister.Location = new Point(6, 15);
            OutputRegister.Name = "OutputRegister";
            OutputRegister.ScrollAlwaysVisible = true;
            OutputRegister.Size = new Size(430, 1012);
            OutputRegister.TabIndex = 1;
            // 
            // btnSaveDebug
            // 
            btnSaveDebug.BackColor = Color.FromArgb(192, 192, 0);
            btnSaveDebug.ForeColor = Color.Black;
            btnSaveDebug.Location = new Point(151, 1089);
            btnSaveDebug.Name = "btnSaveDebug";
            btnSaveDebug.Size = new Size(123, 41);
            btnSaveDebug.TabIndex = 3;
            btnSaveDebug.Text = "SAVE DEBUG LOG";
            btnSaveDebug.UseVisualStyleBackColor = false;
            btnSaveDebug.Click += btnSaveDebug_Click;
            // 
            // clearOutputRegisterBtn
            // 
            clearOutputRegisterBtn.BackColor = Color.FromArgb(192, 192, 0);
            clearOutputRegisterBtn.ForeColor = SystemColors.ActiveCaptionText;
            clearOutputRegisterBtn.Location = new Point(17, 1089);
            clearOutputRegisterBtn.Name = "clearOutputRegisterBtn";
            clearOutputRegisterBtn.Size = new Size(128, 41);
            clearOutputRegisterBtn.TabIndex = 2;
            clearOutputRegisterBtn.Text = "CLEAR CONSOLE";
            clearOutputRegisterBtn.UseVisualStyleBackColor = false;
            clearOutputRegisterBtn.Click += clearOutputRegisterBtn_Click;
            // 
            // assemblyCodeBox
            // 
            assemblyCodeBox.BackColor = Color.FromArgb(0, 0, 32);
            assemblyCodeBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assemblyCodeBox.ForeColor = Color.Lime;
            assemblyCodeBox.Location = new Point(12, 22);
            assemblyCodeBox.Name = "assemblyCodeBox";
            assemblyCodeBox.Size = new Size(632, 1018);
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
            dataGridViewCellStyle1.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            MemoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            MemoryGrid.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MemoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MemoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            MemoryGrid.DefaultCellStyle = dataGridViewCellStyle3;
            MemoryGrid.GridColor = Color.DarkGray;
            MemoryGrid.Location = new Point(24, 21);
            MemoryGrid.Name = "MemoryGrid";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            MemoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            MemoryGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            MemoryGrid.Size = new Size(359, 984);
            MemoryGrid.TabIndex = 20;
            // 
            // loadToMemoryButton
            // 
            loadToMemoryButton.BackColor = Color.FromArgb(192, 192, 0);
            loadToMemoryButton.ForeColor = SystemColors.Desktop;
            loadToMemoryButton.Location = new Point(127, 20);
            loadToMemoryButton.Name = "loadToMemoryButton";
            loadToMemoryButton.Size = new Size(162, 40);
            loadToMemoryButton.TabIndex = 21;
            loadToMemoryButton.Text = "&LOAD TO MEMORY";
            loadToMemoryButton.UseVisualStyleBackColor = false;
            loadToMemoryButton.Click += loadToMemoryButton_Click;
            // 
            // cpuClock
            // 
            cpuClock.Interval = 1;
            cpuClock.Tick += cpuClock_Tick;
            // 
            // btnStartClock
            // 
            btnStartClock.BackColor = Color.FromArgb(192, 192, 0);
            btnStartClock.ForeColor = SystemColors.Desktop;
            btnStartClock.Location = new Point(295, 20);
            btnStartClock.Name = "btnStartClock";
            btnStartClock.Size = new Size(128, 39);
            btnStartClock.TabIndex = 24;
            btnStartClock.Text = "&AUTO RUN";
            btnStartClock.UseVisualStyleBackColor = false;
            btnStartClock.Click += btnStartClock_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox2.Controls.Add(pauseButton);
            groupBox2.Controls.Add(resetButton);
            groupBox2.Controls.Add(clearEditorButton);
            groupBox2.Controls.Add(loadToMemoryButton);
            groupBox2.Controls.Add(btnStartClock);
            groupBox2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 1046);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(632, 121);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "OPERATIONS";
            // 
            // pauseButton
            // 
            pauseButton.BackColor = Color.FromArgb(0, 64, 0);
            pauseButton.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pauseButton.ForeColor = Color.White;
            pauseButton.Location = new Point(127, 73);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(162, 36);
            pauseButton.TabIndex = 26;
            pauseButton.Text = "PAUSE";
            pauseButton.UseVisualStyleBackColor = false;
            pauseButton.Click += pauseButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(0, 64, 0);
            resetButton.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetButton.ForeColor = Color.White;
            resetButton.Location = new Point(6, 73);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(115, 36);
            resetButton.TabIndex = 25;
            resetButton.Text = "RESET /STOP";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.BackColor = Color.Black;
            groupBox3.Controls.Add(memoryBankGrid);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(fileNameLabel);
            groupBox3.Controls.Add(groupBox6);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(dataMemoryGrid);
            groupBox3.Controls.Add(OUTPUT);
            groupBox3.Controls.Add(assemblyCodeBox);
            groupBox3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(237, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(2217, 1192);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "ASSEMBLER EDITOR";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // memoryBankGrid
            // 
            memoryBankGrid.BackgroundColor = SystemColors.ActiveBorder;
            memoryBankGrid.BorderStyle = BorderStyle.None;
            memoryBankGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memoryBankGrid.Location = new Point(1547, 849);
            memoryBankGrid.Name = "memoryBankGrid";
            memoryBankGrid.Size = new Size(664, 318);
            memoryBankGrid.TabIndex = 33;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ControlDarkDark;
            groupBox4.Controls.Add(MemoryGrid);
            groupBox4.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(1104, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(437, 1029);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "MEMORY";
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(174, 0);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(72, 19);
            fileNameLabel.TabIndex = 32;
            fileNameLabel.Text = "FILE : ";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.WindowFrame;
            groupBox6.Controls.Add(resetScreenButton);
            groupBox6.Controls.Add(videoGrid);
            groupBox6.ForeColor = Color.Black;
            groupBox6.Location = new Point(1547, 22);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(354, 340);
            groupBox6.TabIndex = 31;
            groupBox6.TabStop = false;
            groupBox6.Text = "CPU RAM MONITOR BANK 0";
            // 
            // resetScreenButton
            // 
            resetScreenButton.BackColor = Color.FromArgb(192, 192, 0);
            resetScreenButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetScreenButton.Location = new Point(6, 289);
            resetScreenButton.Name = "resetScreenButton";
            resetScreenButton.Size = new Size(143, 33);
            resetScreenButton.TabIndex = 30;
            resetScreenButton.Text = "RESET CPU MONITOR";
            resetScreenButton.UseVisualStyleBackColor = false;
            resetScreenButton.Click += resetScreenButton_Click;
            // 
            // videoGrid
            // 
            videoGrid.AllowUserToAddRows = false;
            videoGrid.AllowUserToDeleteRows = false;
            videoGrid.AllowUserToOrderColumns = true;
            videoGrid.BackgroundColor = Color.Black;
            videoGrid.BorderStyle = BorderStyle.None;
            videoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            videoGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Black;
            dataGridViewCellStyle6.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            videoGrid.DefaultCellStyle = dataGridViewCellStyle6;
            videoGrid.GridColor = Color.DarkOrange;
            videoGrid.Location = new Point(6, 30);
            videoGrid.Name = "videoGrid";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Black;
            dataGridViewCellStyle7.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            videoGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            videoGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            videoGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            videoGrid.Size = new Size(323, 253);
            videoGrid.TabIndex = 28;
            // 
            // dataMemoryGrid
            // 
            dataMemoryGrid.AllowUserToAddRows = false;
            dataMemoryGrid.AllowUserToDeleteRows = false;
            dataMemoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMemoryGrid.BackgroundColor = SystemColors.ControlDarkDark;
            dataMemoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMemoryGrid.Columns.AddRange(new DataGridViewColumn[] { Address, Data });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataMemoryGrid.DefaultCellStyle = dataGridViewCellStyle11;
            dataMemoryGrid.GridColor = Color.FromArgb(255, 128, 128);
            dataMemoryGrid.Location = new Point(1547, 374);
            dataMemoryGrid.Name = "dataMemoryGrid";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataMemoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataMemoryGrid.RowHeadersVisible = false;
            dataMemoryGrid.Size = new Size(514, 457);
            dataMemoryGrid.TabIndex = 29;
            // 
            // Address
            // 
            dataGridViewCellStyle9.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle9.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.Control;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.Control;
            Address.DefaultCellStyle = dataGridViewCellStyle9;
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // Data
            // 
            dataGridViewCellStyle10.BackColor = SystemColors.Desktop;
            dataGridViewCellStyle10.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Desktop;
            Data.DefaultCellStyle = dataGridViewCellStyle10;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // cpuSpeedLabel
            // 
            cpuSpeedLabel.AutoSize = true;
            cpuSpeedLabel.BackColor = Color.Transparent;
            cpuSpeedLabel.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpuSpeedLabel.ForeColor = SystemColors.ButtonFace;
            cpuSpeedLabel.Location = new Point(8, 489);
            cpuSpeedLabel.Name = "cpuSpeedLabel";
            cpuSpeedLabel.Size = new Size(99, 19);
            cpuSpeedLabel.TabIndex = 28;
            cpuSpeedLabel.Text = "CPU SPEED ";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateGray;
            menuStrip1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hELPToolStripMenuItem, architectureToolStripMenuItem, isaReferenceToolStripMenuItem, oppGuideToolStripMenuItem, saveCodeToFileToolStripMenuItem, lOADFROMFILEToolStripMenuItem, helpToolStripMenuItem1, rETROEFFECTSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2487, 27);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // hELPToolStripMenuItem
            // 
            hELPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, lOADSAMPLE2ToolStripMenuItem, fastDivisionUsingSHR82ToolStripMenuItem, storeToMemoryToolStripMenuItem, xorSwapTestToolStripMenuItem, counterToolStripMenuItem, jUMPNOTZEROToolStripMenuItem });
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
            // jUMPNOTZEROToolStripMenuItem
            // 
            jUMPNOTZEROToolStripMenuItem.Name = "jUMPNOTZEROToolStripMenuItem";
            jUMPNOTZEROToolStripMenuItem.Size = new Size(375, 24);
            jUMPNOTZEROToolStripMenuItem.Text = "JUMP If not Zero";
            jUMPNOTZEROToolStripMenuItem.Click += jUMPNOTZEROToolStripMenuItem_Click;
            // 
            // architectureToolStripMenuItem
            // 
            architectureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hARDWARERESETToolStripMenuItem, cLOCKSPEEDToolStripMenuItem });
            architectureToolStripMenuItem.ForeColor = Color.Black;
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
            hZNORMALToolStripMenuItem.Click += hZNORMALToolStripMenuItem_Click_1;
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
            isaReferenceToolStripMenuItem.ForeColor = Color.Black;
            isaReferenceToolStripMenuItem.Name = "isaReferenceToolStripMenuItem";
            isaReferenceToolStripMenuItem.Size = new Size(138, 23);
            isaReferenceToolStripMenuItem.Text = "ISA REFERENCE";
            isaReferenceToolStripMenuItem.Click += isaReferenceToolStripMenuItem_Click;
            // 
            // oppGuideToolStripMenuItem
            // 
            oppGuideToolStripMenuItem.ForeColor = Color.Black;
            oppGuideToolStripMenuItem.Name = "oppGuideToolStripMenuItem";
            oppGuideToolStripMenuItem.Size = new Size(93, 23);
            oppGuideToolStripMenuItem.Text = "OPPGUIDE";
            oppGuideToolStripMenuItem.Click += oppGuideToolStripMenuItem_Click;
            // 
            // saveCodeToFileToolStripMenuItem
            // 
            saveCodeToFileToolStripMenuItem.ForeColor = Color.Black;
            saveCodeToFileToolStripMenuItem.Name = "saveCodeToFileToolStripMenuItem";
            saveCodeToFileToolStripMenuItem.Size = new Size(66, 23);
            saveCodeToFileToolStripMenuItem.Text = "&SAVE ";
            saveCodeToFileToolStripMenuItem.Click += saveCodeToFileToolStripMenuItem_Click;
            // 
            // lOADFROMFILEToolStripMenuItem
            // 
            lOADFROMFILEToolStripMenuItem.ForeColor = Color.Black;
            lOADFROMFILEToolStripMenuItem.Name = "lOADFROMFILEToolStripMenuItem";
            lOADFROMFILEToolStripMenuItem.Size = new Size(66, 23);
            lOADFROMFILEToolStripMenuItem.Text = "LOAD ";
            lOADFROMFILEToolStripMenuItem.Click += lOADFROMFILEToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.ForeColor = Color.Black;
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(66, 23);
            helpToolStripMenuItem1.Text = "ABOUT";
            helpToolStripMenuItem1.Click += helpToolStripMenuItem1_Click;
            // 
            // rETROEFFECTSToolStripMenuItem
            // 
            rETROEFFECTSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { activeEffectToolStripMenuItem, scanlineToolStripMenuItem, phosphorGlowToolStripMenuItem, rGBMaskToolStripMenuItem, vignetteToolStripMenuItem, cRTFullToolStripMenuItem });
            rETROEFFECTSToolStripMenuItem.Name = "rETROEFFECTSToolStripMenuItem";
            rETROEFFECTSToolStripMenuItem.Size = new Size(138, 23);
            rETROEFFECTSToolStripMenuItem.Text = "RETRO EFFECTS";
            // 
            // activeEffectToolStripMenuItem
            // 
            activeEffectToolStripMenuItem.Name = "activeEffectToolStripMenuItem";
            activeEffectToolStripMenuItem.Size = new Size(195, 24);
            activeEffectToolStripMenuItem.Text = "Active Effect";
            activeEffectToolStripMenuItem.Click += activeEffectToolStripMenuItem_Click;
            // 
            // scanlineToolStripMenuItem
            // 
            scanlineToolStripMenuItem.Name = "scanlineToolStripMenuItem";
            scanlineToolStripMenuItem.Size = new Size(195, 24);
            scanlineToolStripMenuItem.Text = "Scanline";
            scanlineToolStripMenuItem.Click += scanlineToolStripMenuItem_Click;
            // 
            // phosphorGlowToolStripMenuItem
            // 
            phosphorGlowToolStripMenuItem.Name = "phosphorGlowToolStripMenuItem";
            phosphorGlowToolStripMenuItem.Size = new Size(195, 24);
            phosphorGlowToolStripMenuItem.Text = "Phosphor Glow";
            phosphorGlowToolStripMenuItem.Click += phosphorGlowToolStripMenuItem_Click;
            // 
            // rGBMaskToolStripMenuItem
            // 
            rGBMaskToolStripMenuItem.Name = "rGBMaskToolStripMenuItem";
            rGBMaskToolStripMenuItem.Size = new Size(195, 24);
            rGBMaskToolStripMenuItem.Text = "RGB Mask";
            rGBMaskToolStripMenuItem.Click += rGBMaskToolStripMenuItem_Click;
            // 
            // vignetteToolStripMenuItem
            // 
            vignetteToolStripMenuItem.Name = "vignetteToolStripMenuItem";
            vignetteToolStripMenuItem.Size = new Size(195, 24);
            vignetteToolStripMenuItem.Text = "Vignette";
            vignetteToolStripMenuItem.Click += vignetteToolStripMenuItem_Click;
            // 
            // cRTFullToolStripMenuItem
            // 
            cRTFullToolStripMenuItem.Name = "cRTFullToolStripMenuItem";
            cRTFullToolStripMenuItem.Size = new Size(195, 24);
            cRTFullToolStripMenuItem.Text = "CRT Full";
            cRTFullToolStripMenuItem.Click += cRTFullToolStripMenuItem_Click;
            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.BackColor = SystemColors.Desktop;
            groupBox5.Controls.Add(resetMonitorBtn);
            groupBox5.Controls.Add(debugToggleButton);
            groupBox5.Controls.Add(btnMonitorPower);
            groupBox5.Controls.Add(cpuSpeedLabel);
            groupBox5.Controls.Add(groupBox3);
            groupBox5.Controls.Add(registersBox);
            groupBox5.ForeColor = SystemColors.HighlightText;
            groupBox5.Location = new Point(12, 30);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(2471, 1231);
            groupBox5.TabIndex = 30;
            groupBox5.TabStop = false;
            // 
            // debugToggleButton
            // 
            debugToggleButton.BackColor = Color.FromArgb(192, 192, 0);
            debugToggleButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            debugToggleButton.ForeColor = SystemColors.Desktop;
            debugToggleButton.Location = new Point(6, 391);
            debugToggleButton.Name = "debugToggleButton";
            debugToggleButton.Size = new Size(185, 33);
            debugToggleButton.TabIndex = 30;
            debugToggleButton.Text = "DEBUG TOGGLE";
            debugToggleButton.UseVisualStyleBackColor = false;
            debugToggleButton.Click += debugToggleButton_Click;
            // 
            // btnMonitorPower
            // 
            btnMonitorPower.BackColor = SystemColors.ControlDarkDark;
            btnMonitorPower.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMonitorPower.ForeColor = Color.Black;
            btnMonitorPower.Location = new Point(6, 430);
            btnMonitorPower.Name = "btnMonitorPower";
            btnMonitorPower.Size = new Size(185, 31);
            btnMonitorPower.TabIndex = 29;
            btnMonitorPower.Text = "Turn On Screen";
            btnMonitorPower.UseVisualStyleBackColor = false;
            btnMonitorPower.Click += btnMonitorPower_Click;
            // 
            // screenClock
            // 
            screenClock.Enabled = true;
            screenClock.Interval = 1;
            screenClock.Tick += screenClock_Tick;
            // 
            // resetMonitorBtn
            // 
            resetMonitorBtn.BackColor = SystemColors.ControlDarkDark;
            resetMonitorBtn.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetMonitorBtn.ForeColor = Color.Black;
            resetMonitorBtn.Location = new Point(6, 563);
            resetMonitorBtn.Name = "resetMonitorBtn";
            resetMonitorBtn.Size = new Size(185, 31);
            resetMonitorBtn.TabIndex = 31;
            resetMonitorBtn.Text = "Clear Screen";
            resetMonitorBtn.UseVisualStyleBackColor = false;
            resetMonitorBtn.Click += resetMonitorBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(2487, 1226);
            Controls.Add(groupBox5);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.Window;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "4 Bit CPU";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            RegisterAxBox.ResumeLayout(false);
            RegisterBxBox.ResumeLayout(false);
            registersBox.ResumeLayout(false);
            OUTPUT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MemoryGrid).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memoryBankGrid).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)videoGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataMemoryGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
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
        //private Button oppPush;
        //private Button op0;
        private Button op1;
        //private Button op2;
        //private Button op3;
        private GroupBox OUTPUT;
        private ListBox OutputRegister;
        private RichTextBox assemblyCodeBox;
        private Button clearEditorButton;
        private DataGridView MemoryGrid;
        private Button loadToMemoryButton;
        private System.Windows.Forms.Timer cpuClock;
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
        private GroupBox groupBox6;
        private ToolStripMenuItem counterToolStripMenuItem;
        private ToolStripMenuItem jUMPNOTZEROToolStripMenuItem;
        //private Label popedRegister;
        //private Button clearStackButton;
        //private Button popStackButton;
        private Button clearOutputRegisterBtn;
        private Label cpuSpeedLabel;
        //private Button oppResetButton;
        private System.Windows.Forms.Timer screenClock;
        private Button btnMonitorPower;
        private Button debugToggleButton;
        private Button pauseButton;
        private Label fileNameLabel;
        private ToolStripMenuItem rETROEFFECTSToolStripMenuItem;
        private ToolStripMenuItem activeEffectToolStripMenuItem;
        private ToolStripMenuItem scanlineToolStripMenuItem;
        private ToolStripMenuItem phosphorGlowToolStripMenuItem;
        private ToolStripMenuItem rGBMaskToolStripMenuItem;
        private ToolStripMenuItem vignetteToolStripMenuItem;
        private ToolStripMenuItem cRTFullToolStripMenuItem;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Data;
        private Button btnSaveDebug;
        private DataGridView memoryBankGrid;
        private Button resetMonitorBtn;
    }
}
