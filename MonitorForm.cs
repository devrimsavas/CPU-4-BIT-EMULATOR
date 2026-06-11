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
            monitorBox = new PictureBox();
            monitorBox.Dock = DockStyle.Fill;
            monitorBox.BackColor = Color.Black;
            monitorBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(monitorBox);
            this.ClientSize=new Size(512,512);
            //keyboard
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
            //focus 
            /*
            if (!this.ContainsFocus)
            {
                this.Focus();
            }
            */
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