using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Appli
{
    public partial class frmAdmin : Form
    {
        private Timer timer;
        private int targetPosition;
        private int speed = 100;
        private bool movingRight = true;

        public frmAdmin()
        {
            InitializeComponent();

            cmbGender_Ad.Items.Add("Male");
            cmbGender_Ad.Items.Add("Female");

            timer = new Timer();
            timer.Interval = 1; //para maging smooth ha
            timer.Tick += timer1_Tick;

            targetPosition = 400;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmUser_Admin frm1 = new frmUser_Admin();
            frm1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (movingRight)
            {
                if (pnlBox.Left < targetPosition)
                {
                    pnlBox.Left += speed; //move right
                }
                else
                {
                    timer.Stop(); // titigil na yan pag na reach na si right
                }
            }
            else
            {
                if (pnlBox.Left > targetPosition)
                {
                    pnlBox.Left -= speed; // move to left yan
                }
                else
                {
                    timer.Stop(); // titigil sa sya pag na reach na nya yung left
                }
            }
        }

        private void btnRegister_Login_Click(object sender, EventArgs e)
        {
            movingRight = !movingRight; // toggle direction
            targetPosition = movingRight ? 400 : 0; // x-axis yan para ma indicate kung san sya i move
            btnRegister_Login.Text = movingRight ? "Back to Login" : "Register"; // syempre bawat click mag change yungtext
            lblPanelTitle1.Text = movingRight ? "You have an \nAccount?" : "Want to be\r\nan Admin?";
            lblPanelTitle2.Text = movingRight ? "" : "To keep connected with us please login\r\nwith your pesonal info.\r\n";
            timer.Start();
        }
    }
}
