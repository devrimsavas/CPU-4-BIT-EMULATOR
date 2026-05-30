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
            OutputRegister = new ListBox();
            opguide = new ListBox();
            assemblyCodeBox = new RichTextBox();
            runCodeButton = new Button();
            clearEditorButton = new Button();
            MemoryGrid = new DataGridView();
            loadToMemoryButton = new Button();
            saveToFileButton = new Button();
            clearOutput = new Button();
            RegisterAxBox.SuspendLayout();
            RegisterBxBox.SuspendLayout();
            registersBox.SuspendLayout();
            oppcodebox.SuspendLayout();
            groupBox1.SuspendLayout();
            oppCommandBox.SuspendLayout();
            OUTPUT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MemoryGrid).BeginInit();
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
            RegisterAxBox.Size = new Size(317, 134);
            RegisterAxBox.TabIndex = 0;
            RegisterAxBox.TabStop = false;
            RegisterAxBox.Text = "REGISTER AX";
            // 
            // resetAx
            // 
            resetAx.BackColor = Color.Green;
            resetAx.ForeColor = SystemColors.ButtonHighlight;
            resetAx.Location = new Point(176, 89);
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
            regAxPush.Location = new Point(44, 89);
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
            ax0.Location = new Point(218, 39);
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
            ax1.Location = new Point(160, 39);
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
            ax2.Location = new Point(102, 39);
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
            ax3.Location = new Point(44, 39);
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
            stackList.Size = new Size(422, 289);
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
            RegisterBxBox.Location = new Point(31, 175);
            RegisterBxBox.Name = "RegisterBxBox";
            RegisterBxBox.Size = new Size(317, 134);
            RegisterBxBox.TabIndex = 10;
            RegisterBxBox.TabStop = false;
            RegisterBxBox.Text = "REGISTER BX";
            // 
            // resetBx
            // 
            resetBx.BackColor = Color.Green;
            resetBx.ForeColor = SystemColors.ButtonHighlight;
            resetBx.Location = new Point(176, 89);
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
            regBxPush.Location = new Point(44, 89);
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
            bx0.Location = new Point(218, 39);
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
            bx1.Location = new Point(160, 39);
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
            bx2.Location = new Point(102, 39);
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
            bx3.Location = new Point(44, 39);
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
            registersBox.ForeColor = Color.FromArgb(192, 64, 0);
            registersBox.Location = new Point(12, 12);
            registersBox.Name = "registersBox";
            registersBox.Size = new Size(393, 514);
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
            oppcodebox.Location = new Point(31, 334);
            oppcodebox.Name = "oppcodebox";
            oppcodebox.Size = new Size(317, 134);
            oppcodebox.TabIndex = 11;
            oppcodebox.TabStop = false;
            oppcodebox.Text = "OPPCODE BOX";
            // 
            // oppResetButton
            // 
            oppResetButton.BackColor = Color.Green;
            oppResetButton.ForeColor = SystemColors.ButtonHighlight;
            oppResetButton.Location = new Point(176, 89);
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
            oppPush.Location = new Point(44, 89);
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
            op0.Location = new Point(218, 39);
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
            op1.Location = new Point(160, 39);
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
            op2.Location = new Point(102, 39);
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
            op3.Location = new Point(44, 39);
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
            popStackButton.Location = new Point(18, 343);
            popStackButton.Name = "popStackButton";
            popStackButton.Size = new Size(154, 33);
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
            groupBox1.Location = new Point(411, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 385);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "STACK LIST";
            // 
            // popedRegister
            // 
            popedRegister.AutoSize = true;
            popedRegister.ForeColor = SystemColors.ActiveCaptionText;
            popedRegister.Location = new Point(26, 317);
            popedRegister.Name = "popedRegister";
            popedRegister.Size = new Size(110, 15);
            popedRegister.TabIndex = 14;
            popedRegister.Text = "Last Poped Register";
            // 
            // clearStackButton
            // 
            clearStackButton.BackColor = Color.Firebrick;
            clearStackButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearStackButton.ForeColor = SystemColors.ActiveCaption;
            clearStackButton.Location = new Point(286, 343);
            clearStackButton.Name = "clearStackButton";
            clearStackButton.Size = new Size(154, 33);
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
            oppCommandBox.Location = new Point(411, 403);
            oppCommandBox.Name = "oppCommandBox";
            oppCommandBox.Size = new Size(469, 123);
            oppCommandBox.TabIndex = 14;
            oppCommandBox.TabStop = false;
            oppCommandBox.Text = "OPP COMMAND";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(182, 81);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 2;
            label1.Text = "MANUAL STEPPING";
            // 
            // executebutton
            // 
            executebutton.BackColor = Color.FromArgb(192, 64, 0);
            executebutton.Font = new Font("Consolas", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            executebutton.Location = new Point(20, 81);
            executebutton.Name = "executebutton";
            executebutton.Size = new Size(156, 37);
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
            oppCom.Size = new Size(424, 60);
            oppCom.TabIndex = 0;
            // 
            // OUTPUT
            // 
            OUTPUT.BackColor = Color.Silver;
            OUTPUT.Controls.Add(clearOutput);
            OUTPUT.Controls.Add(OutputRegister);
            OUTPUT.Location = new Point(899, 12);
            OUTPUT.Name = "OUTPUT";
            OUTPUT.Size = new Size(418, 514);
            OUTPUT.TabIndex = 15;
            OUTPUT.TabStop = false;
            OUTPUT.Text = "OUTPUT ";
            // 
            // OutputRegister
            // 
            OutputRegister.BackColor = Color.Black;
            OutputRegister.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OutputRegister.ForeColor = Color.White;
            OutputRegister.FormattingEnabled = true;
            OutputRegister.Location = new Point(11, 26);
            OutputRegister.Name = "OutputRegister";
            OutputRegister.Size = new Size(391, 460);
            OutputRegister.TabIndex = 0;
            // 
            // opguide
            // 
            opguide.BackColor = Color.Black;
            opguide.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opguide.ForeColor = Color.Lime;
            opguide.FormattingEnabled = true;
            opguide.Location = new Point(12, 533);
            opguide.Name = "opguide";
            opguide.Size = new Size(415, 251);
            opguide.TabIndex = 16;
            // 
            // assemblyCodeBox
            // 
            assemblyCodeBox.BackColor = Color.Black;
            assemblyCodeBox.Font = new Font("Consolas", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assemblyCodeBox.ForeColor = Color.Lime;
            assemblyCodeBox.Location = new Point(437, 536);
            assemblyCodeBox.Name = "assemblyCodeBox";
            assemblyCodeBox.Size = new Size(331, 279);
            assemblyCodeBox.TabIndex = 17;
            assemblyCodeBox.Text = "";
            // 
            // runCodeButton
            // 
            runCodeButton.BackColor = Color.FromArgb(192, 192, 0);
            runCodeButton.ForeColor = SystemColors.ActiveCaptionText;
            runCodeButton.Location = new Point(437, 821);
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
            clearEditorButton.Location = new Point(638, 821);
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
            MemoryGrid.Location = new Point(792, 536);
            MemoryGrid.Name = "MemoryGrid";
            MemoryGrid.Size = new Size(509, 279);
            MemoryGrid.TabIndex = 20;
            // 
            // loadToMemoryButton
            // 
            loadToMemoryButton.BackColor = Color.FromArgb(192, 192, 0);
            loadToMemoryButton.ForeColor = SystemColors.ActiveCaptionText;
            loadToMemoryButton.Location = new Point(792, 821);
            loadToMemoryButton.Name = "loadToMemoryButton";
            loadToMemoryButton.Size = new Size(130, 40);
            loadToMemoryButton.TabIndex = 21;
            loadToMemoryButton.Text = "LOAD TO MEMORY";
            loadToMemoryButton.UseVisualStyleBackColor = false;
            loadToMemoryButton.Click += loadToMemoryButton_Click;
            // 
            // saveToFileButton
            // 
            saveToFileButton.BackColor = Color.FromArgb(192, 192, 0);
            saveToFileButton.ForeColor = SystemColors.ActiveCaptionText;
            saveToFileButton.Location = new Point(1171, 821);
            saveToFileButton.Name = "saveToFileButton";
            saveToFileButton.Size = new Size(130, 40);
            saveToFileButton.TabIndex = 22;
            saveToFileButton.Text = "SAVE TO FILE";
            saveToFileButton.UseVisualStyleBackColor = false;
            saveToFileButton.Click += saveToFileButton_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1523, 873);
            Controls.Add(saveToFileButton);
            Controls.Add(loadToMemoryButton);
            Controls.Add(MemoryGrid);
            Controls.Add(clearEditorButton);
            Controls.Add(runCodeButton);
            Controls.Add(assemblyCodeBox);
            Controls.Add(opguide);
            Controls.Add(OUTPUT);
            Controls.Add(oppCommandBox);
            Controls.Add(groupBox1);
            Controls.Add(registersBox);
            ForeColor = SystemColors.ButtonFace;
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
            ResumeLayout(false);
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
        private ListBox opguide;
        private Label label1;
        private RichTextBox assemblyCodeBox;
        private Button runCodeButton;
        private Button clearEditorButton;
        private DataGridView MemoryGrid;
        private Button loadToMemoryButton;
        private Button saveToFileButton;
        private Button clearOutput;
    }
}
