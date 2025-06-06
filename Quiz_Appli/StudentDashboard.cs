﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Guna.UI2.WinForms;

namespace Quiz_Appli
{
    public partial class frmStudentDashboard : Form
    {
        private string connectionString = "Server=mysql-quizapp.alwaysdata.net;Port=3306;Database=quizapp_app;Uid=quizapp;Pwd=quizappcsharp;Allow User Variables=true;";
        
        private int borderSize = 2;
        private int userId;
        
        public frmStudentDashboard(int id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = true;
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(950, 400);

            CollapseMenu();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 0, 64);
            userId = id;
            LoadStudentData();
            LoadDashboardCounts();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        

        private void dgvCompletedQuizzes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            dgvCompletedQuizzes.Rows.Add("Science Quiz", "Apr 14, 2025", "8/10", "80%");
            dgvCompletedQuizzes.Rows.Add("Math Quiz", "Apr 12, 2025", "7/10", "70%");
            dgvCompletedQuizzes.Rows.Add("History Quiz", "Apr 10, 2025", "10/10", "100%");
        }
        
        

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //overriden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int WM_NCCALCSIZE = 0x83;
            const int resizeArea = 10;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                if (WindowState == FormWindowState.Normal)
                {
                    Point cursor = PointToClient(new Point(m.LParam.ToInt32()));

                    if (cursor.X <= resizeArea)
                    {
                        if (cursor.Y <= resizeArea)
                            m.Result = (IntPtr)13; // Top-left
                        else if (cursor.Y >= ClientSize.Height - resizeArea)
                            m.Result = (IntPtr)16; // Bottom-left
                        else
                            m.Result = (IntPtr)10; // Left
                    }
                    else if (cursor.X >= ClientSize.Width - resizeArea)
                    {
                        if (cursor.Y <= resizeArea)
                            m.Result = (IntPtr)14; // Top-right
                        else if (cursor.Y >= ClientSize.Height - resizeArea)
                            m.Result = (IntPtr)17; // Bottom-right
                        else
                            m.Result = (IntPtr)11; // Right
                    }
                    else if (cursor.Y <= resizeArea)
                        m.Result = (IntPtr)12; // Top
                    else if (cursor.Y >= ClientSize.Height - resizeArea)
                        m.Result = (IntPtr)15; // Bottom
                }
                return;
            }

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.pnlMenu.Width > 200)
            {
                pnlMenu.Width = 100;
                pcbLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                pnlMenu.Width = 230;
                pcbLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnZooming_CheckedChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            frmStudentTakeQuiz frm = new frmStudentTakeQuiz();
            frm.Show();
            if (this.WindowState == FormWindowState.Maximized)
            {
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
            }

            this.Hide();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            frmStudentResults frm = new frmStudentResults();
            frm.Show();
            if (this.WindowState == FormWindowState.Maximized)
            {
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
            }

            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmStudentProfile profileForm = new frmStudentProfile(userId);
            profileForm.Show();
            if (this.WindowState == FormWindowState.Maximized)
            {
                profileForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                profileForm.WindowState = FormWindowState.Normal;
            }

            this.Hide();
        }
        
        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
        private void LoadStudentData()
        {
            
        }
        public class Quiz
        {
            public int QuizId { get; set; }
            
        }

        public class Question
        {
            public int QuestionId { get; set; }
            
        }
        private void LoadDashboardCounts()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Get total quizzes
                    string quizQuery = "SELECT COUNT(*) FROM quizzes";
                    MySqlCommand quizCmd = new MySqlCommand(quizQuery, conn);
                    object quizResult = quizCmd.ExecuteScalar();
                    lblTotalQuizzes.Text = quizResult.ToString();

                    // Get total questions
                    string questionQuery = "SELECT COUNT(*) FROM questions";
                    MySqlCommand questionCmd = new MySqlCommand(questionQuery, conn);
                    object questionResult = questionCmd.ExecuteScalar();
                    lblTotalQuestions.Text = questionResult.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

    }
}