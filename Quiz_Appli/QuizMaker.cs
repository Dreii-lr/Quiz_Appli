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
    public partial class frmAdd_Quiz : Form
    {
        private bool isPanelVisible = false;
        private int panelTargetHeight = 120;
        private int panelCollapsedHeight = 0;
        private int animationSpeed = 5;

        private bool isPannelExpanded = false;
        private int panelSpeed = 70;
        private int PanelHiddenX = -140;
        private int PanelVisibleX = -35;
        public frmAdd_Quiz()
        {
            InitializeComponent();
            pnlProfile.Height = panelCollapsedHeight;
            pnlProfile.Visible = false;

            pnlSlideBar.Left = PanelHiddenX;
        }

        private void frmAdd_Quiz_Load(object sender, EventArgs e)
        {

        }

        private void frmAdd_Quiz_Click(object sender, EventArgs e)
        {
            if (isPanelVisible)
                timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool moving = false;

            if (isPannelExpanded)
            {
                if (pnlSlideBar.Left > PanelHiddenX)
                {
                    pnlSlideBar.Left -= panelSpeed;
                    btnSideBar.Left -= panelSpeed; 
                    moving = true;
                }
            }
            
            else
            {
                if (pnlSlideBar.Left < PanelVisibleX)
                {
                    pnlSlideBar.Left += panelSpeed;
                    btnSideBar.Left += panelSpeed; 
                    moving = true;
                }
            }

            if (!moving)
            {
                timer1.Stop();
                isPannelExpanded = !isPannelExpanded;
            }
        }

        private void btnSideBar_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isPanelVisible)
            {
                if (pnlProfile.Height > panelCollapsedHeight)
                {
                    pnlProfile.Height -= animationSpeed;
                }
                else
                {
                    timer2.Stop();
                    pnlProfile.Visible = false;
                    isPanelVisible = false;
                }
            }
            else
            {
                if(pnlProfile.Height < panelTargetHeight)
                {
                    pnlProfile.Height += animationSpeed;
                }
                else
                {
                    timer2.Stop();
                    isPanelVisible = true;
                }  
            }
        }

        private void btnProfile_Icon_Click(object sender, EventArgs e)
        {
            if (!isPanelVisible)
            {
                timer2.Start();
            }
            else
            {
                timer2.Start();
            }
        }
    }
}
