using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MonitorForm : Form
    {
        private PictureBox monitorBox;
        private static bool[] _keyBuffer = new bool[4];


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
        }
        // 1. KEY PRESSED
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.KeyCode)
            {
                case Keys.Up:
                    _keyBuffer = new bool[] { false, false, false, true }; // 0001
                    break;
                case Keys.Down:
                    _keyBuffer = new bool[] { false, false, true, false }; // 0010
                    break;
                case Keys.Left:
                    _keyBuffer = new bool[] { false, false, true, true }; // 0011
                    break;
                case Keys.Right:
                    _keyBuffer = new bool[] { false, true, false, false }; // 0100
                    break;
                case Keys.Space:
                    _keyBuffer = new bool[] { false, true, false, true }; // 0101
                    break;
                case Keys.Z:
                    _keyBuffer = new bool[] { false, true, true, false }; // 0110
                    break;
                case Keys.X:
                    _keyBuffer = new bool[] { false, true, true, true }; // 0111
                    break;
                
                default:
                    _keyBuffer = new bool[] { false, false, false, false }; // 0000 none
                    break;
            }

            // Write directly to the shared hardware port
            WinFormsApp1.Models.InputPort.SetKey(_keyBuffer);
        }

        // 2. KEY RELEASED
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            // Cut the power to the port
            WinFormsApp1.Models.InputPort.SetKey(new bool[] { false, false, false, false });
        }

    }
}