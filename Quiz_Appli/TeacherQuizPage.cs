using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quiz_Appli
{
    public partial class frmTeacherQuizPage : Form
    {
        private string connectionString = "Server = 127.0.0.1; Port = 3306; Database = quiz_application; Uid = root; Pwd = ;";

        private int borderSize = 2;
        private Helper helper = new Helper(); 

        public frmTeacherQuizPage()
        {
            InitializeComponent();
            Console.WriteLine(ConnectionState.Open);

            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = true;
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(950, 400);

            CollapseMenu();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 0, 64);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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

        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmTeacherHomepage frm = new frmTeacherHomepage();
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

        private void btnResult_Click(object sender, EventArgs e)
        {
            frmTeacherResult frm = new frmTeacherResult();
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmTeacherProfile frm = new frmTeacherProfile();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string question = txtQuestions.Text.Trim();
            string choice1 = txtChoice_A.Text.Trim();
            string choice2 = txtChoice_B.Text.Trim();
            string choice3 = txtChoice_C.Text.Trim();
            string answer = txtAnswer.Text.Trim();

            if (string.IsNullOrEmpty(question))
            {
                MessageBox.Show("This field are required to filledup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(choice1))
            {
                MessageBox.Show("This field are required to filledup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(choice2))
            {
                MessageBox.Show("This field are required to filledup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(choice3))
            {
                MessageBox.Show("This field are required to filledup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("This field are required to filledup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();


            try
            {


                string quizID = helper.GenerateQuizesaId();
                    string teacherId = helper.GetUSerIdInNFile();
                    string query1 = "INSERT INTO quizzes(QuizID , Title, CreatedBy)" +
                                   "VALUES (@QuizID, @Title, @CreatedBy)";

                    string query2 = "INSERT INTO questions(QuizID , QuestionText)" +
                                  "VALUES (@QuizID, @QuestionText)";

                    string query3 = "INSERT INTO choices(QuizID , choices_a, choices_b, choices_c, answer)" +
                                 "VALUES (@QuizID, @choices_a, @choices_b, @choices_c, @answer)";


                    // for quizess
                    MySqlCommand cmd = new MySqlCommand(query1, conn);
                    cmd.Parameters.AddWithValue("@QuizID", quizID);
                    cmd.Parameters.AddWithValue("@Title", txtQuizTitle.Text);
                    cmd.Parameters.AddWithValue("@CreatedBy", teacherId);

                    //for questions
                    MySqlCommand cmd1 = new MySqlCommand(query2, conn);
                    cmd1.Parameters.AddWithValue("@QuizID", quizID);
                    cmd1.Parameters.AddWithValue("@QuestionText", txtQuestions.Text);

                    //choices
                    MySqlCommand cmd2 = new MySqlCommand(query3, conn);
                    cmd2.Parameters.AddWithValue("@QuizID", quizID);
                    cmd2.Parameters.AddWithValue("@choices_a", txtChoice_A.Text);
                    cmd2.Parameters.AddWithValue("@choices_b", txtChoice_B.Text);
                    cmd2.Parameters.AddWithValue("@choices_c", txtChoice_C.Text);
                    cmd2.Parameters.AddWithValue("@answer", txtAnswer.Text);

                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    transaction.Commit();


                    MessageBox.Show("The Quiz Successfully Added! Want to Add Again?", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtQuestions.Text = "";
                    txtChoice_A.Text = "";
                    txtChoice_B.Text = "";
                    txtChoice_C.Text = "";
                    txtAnswer.Text = "";

                //Setdataintable();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        public void Setdataintable()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string id = helper.GenerateTeachersId();
                conn.Open();
                string query = "SELECT id as ID, student_id as 'Student ID', questions as Question" +
                    ", choices_a as 'Choices 1', choices_b as 'Choices 2', choices_c as 'Choices 3', " +
                    "answer as Answer FROM quizzes";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    dgvCreateQuiz.Columns.Clear();
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCreateQuiz.DataSource = dt;
                }
            }
        }

        private void frmTeacherQuizPage_Load(object sender, EventArgs e)
        {
            //Setdataintable();
        }
     
    }       
}
