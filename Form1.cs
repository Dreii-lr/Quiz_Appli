using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Appli
{
    public partial class frmQuizMaker : Form
    {
        private int borderSize = 2;
        public frmQuizMaker()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 0, 64);
        }

        [DllImport("useer32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("useer32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
