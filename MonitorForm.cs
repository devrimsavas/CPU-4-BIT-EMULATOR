using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MonitorForm : Form
    {
        private PictureBox monitorBox;

        public MonitorForm()
        {
            InitializeComponent();
            monitorBox = new PictureBox();
            monitorBox.Dock = DockStyle.Fill;
            monitorBox.BackColor = Color.Black;
            monitorBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(monitorBox);
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
    }
}