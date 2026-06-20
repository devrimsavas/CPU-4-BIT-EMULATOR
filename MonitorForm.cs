using System.Drawing;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class MonitorForm : Form
    {
        private PictureBox monitorBox;
        //private static bool[] _keyBuffer = new bool[4];


        public MonitorForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Padding = new Padding(54, 54, 54, 80);

            monitorBox = new PictureBox();
            monitorBox.Dock = DockStyle.Fill;
            monitorBox.BackColor = Color.Black;
            monitorBox.SizeMode = PictureBoxSizeMode.Zoom;
            monitorBox.TabStop = false;
            monitorBox.Click += (s, e) => this.Focus();
            this.Controls.Add(monitorBox);

            Panel btnPanel = new Panel();
            btnPanel.Dock = DockStyle.Bottom;
            btnPanel.Height = 60;
            btnPanel.BackColor = Color.FromArgb(30, 30, 30);
            btnPanel.TabStop = false;
            this.Controls.Add(btnPanel);

            string[] effects = { "NONE", "SCANLINE", "GLOW", "RGB", "VIGNETTE", "CRT" };
            for (int i = 0; i < effects.Length; i++)
            {
                Button btn = new Button();
                btn.Text = effects[i];
                btn.Width = 80;
                btn.Height = 30;
                btn.Location = new Point(10 + i * 88, 15);
                btn.BackColor = Color.FromArgb(40, 40, 40);
                btn.ForeColor = Color.FromArgb(255, 255, 85);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
                btn.Tag = (RenderEffects.Effect)(i + 1);
                btn.TabStop= false;

                btn.Click += (s, e) => {
                    RenderEffects.ActiveEffect = (RenderEffects.Effect)((Button)s).Tag;
                    this.Focus(); // give focus back to form 
                };
                btnPanel.Controls.Add(btn);
            }

            //power button 
            Button pwrBtn = new Button();
            pwrBtn.Text = "PWR OFF";
            pwrBtn.Width = 80;
            pwrBtn.Height = 30;
            pwrBtn.Location = new Point(10 + effects.Length * 88, 15);
            pwrBtn.BackColor = Color.FromArgb(60, 0, 0);
            pwrBtn.ForeColor = Color.FromArgb(255, 85, 85);
            pwrBtn.FlatStyle = FlatStyle.Flat;
            pwrBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 85, 85);
            pwrBtn.TabStop = false;
            pwrBtn.Click += (s, e) => this.Hide();
            btnPanel.Controls.Add(pwrBtn);

            //cls screen button 
            Button clsBtn = new Button();
            clsBtn.Text = "CLS";
            clsBtn.Width = 80;
            clsBtn.Height = 30;
            clsBtn.Location = new Point(10 + (effects.Length + 1) * 88, 15);
            clsBtn.BackColor = Color.FromArgb(0, 40, 60);
            clsBtn.ForeColor = Color.FromArgb(85, 200, 255);
            clsBtn.FlatStyle = FlatStyle.Flat;
            clsBtn.FlatAppearance.BorderColor = Color.FromArgb(85, 200, 255);
            clsBtn.TabStop = false;
            clsBtn.Click += (s, e) => {
                DataMemory.ScreenHardware.ProcessCommand(10, new bool[4]);
                this.ActiveControl = null;
            };
            clsBtn.GotFocus += (s, e) => this.Focus();
            btnPanel.Controls.Add(clsBtn);

            this.KeyPreview = true;

            

        }

        public void UpdateFrame(Bitmap newFrame)
        {
            if (InvokeRequired)
            {
                Invoke(() => UpdateFrame(newFrame));
                return;
            }
            if (monitorBox.Image != null)
            {
                monitorBox.Image.Dispose();
            }
            monitorBox.Image = newFrame;
            monitorBox.Invalidate();
            
        }
        // 1. KEY PRESSED
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            var (page, code) = KeyMapper.GetHardwareSignal(e.KeyCode);
            InputPort.SetKey(page, code);
        }

        // 2. KEY RELEASED
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            InputPort.ClearKey();
        }

        // CLOSE STATE
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            base.OnFormClosing(e);
        }

    }
}