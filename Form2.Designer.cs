namespace WinFormsApp1
{
    partial class MonitorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monitorBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)monitorBox).BeginInit();
            SuspendLayout();
            // 
            // monitorBox
            // 
            monitorBox.BackColor = Color.Black;
            monitorBox.Location = new Point(12, 12);
            monitorBox.Name = "monitorBox";
            monitorBox.Size = new Size(836, 667);
            monitorBox.SizeMode = PictureBoxSizeMode.Zoom;
            monitorBox.TabIndex = 31;
            monitorBox.TabStop = false;
            // 
            // MonitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(860, 691);
            Controls.Add(monitorBox);
            Name = "MonitorForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)monitorBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox monitorBox;
    }
}