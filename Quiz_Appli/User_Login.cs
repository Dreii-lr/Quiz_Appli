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
    public partial class frmUser_Admin : Form
    {
        public frmUser_Admin()
        {
            InitializeComponent();

        }
        
        private void frmUser_Admin_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUser frm2 = new frmUser();
            frm2.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frm3 = new frmAdmin();
            frm3.Show();
            this.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            frmTeacher frm4 = new frmTeacher();
            frm4.Show();
            this.Hide();
        }
    }
}
