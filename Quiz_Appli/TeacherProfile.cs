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
using Org.BouncyCastle.Asn1.Cmp;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Quiz_Appli
{
    public partial class frmTeacherProfile : Form
    {
        private string connectionString = "Server=mysql-quizapp.alwaysdata.net;Port=3306;Database=quizapp_app;Uid=quizapp;Pwd=quizappcsharp;Allow User Variables=true;";
        
        private int borderSize = 2;
        private int teacherId;
        private int _teacherId;
        public frmTeacherProfile(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = true;
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(950, 400);

            CollapseMenu();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 0, 64);

            InitializeProfileControls();
            LoadTeacherData();
            this.Load += TeacherProfile_Load;
            _teacherId = teacherId;
            txtNewPassword.PasswordChar = '●';
            txtConfirmPassword.PasswordChar = '●';
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Step 1: Get the student ID from the database
                string idQuery = "SELECT id_teacher FROM teacher WHERE username = @Username_tc";
                MySqlCommand idCmd = new MySqlCommand(idQuery, conn);
                idCmd.Parameters.AddWithValue("@Username_tc", AppContext.CurrentTeacherUsername);

                int teacherId = Convert.ToInt32(idCmd.ExecuteScalar());

                
                AppContext.CurrentTeacherId = teacherId;
                AppContext.CurrentTeacherUsername = AppContext.CurrentTeacherUsername;

                
                
                TeacherDashboard profileForm = new TeacherDashboard(teacherId);
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
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            frmTeacherQuizPage frm = new frmTeacherQuizPage();
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
        private void InitializeProfileControls()
        {
            // Initialize all controls with proper layout
            // Add them to your form's Controls collection
            // Set their properties (location, size, etc.)
        }
        private void LoadTeacherData()
        {
            try
            {
                string query = "SELECT FirstName_tc, MiddleName_tc, LastName_tc, Username_tc, BirthDate_tc FROM teacher WHERE id_teacher = @teacherId";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@teacherId", teacherId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtFirstname.Text = row["FirstName_tc"].ToString();
                    txtMiddlename.Text = row["MiddleName_tc"].ToString();
                    txtLastname.Text = row["LastName_tc"].ToString();
                    txtUsername.Text = row["Username_tc"].ToString();
                    txtUsername.Enabled = true;
                    txtNewPassword.Enabled = false;
                    txtConfirmPassword.Enabled = false;


                    if (DateTime.TryParse(row["BirthDate_tc"].ToString(), out DateTime birthDate))
                    {
                        dtpBirthdate.Value = birthDate;
                    }
                }
                else
                {
                    MessageBox.Show("Teacher data not found");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }

        

        
        private void TeacherProfile_Load(object sender, EventArgs e)
        {
            // Use _studentId to fetch student data from the database
            Teacher teacherData = GetTeacherDataFromDatabase(_teacherId);

            if (teacherData != null)
            {
                txtFirstname.Text = teacherData.FirstName;
                txtMiddlename.Text = teacherData.MiddleName;
                txtLastname.Text = teacherData.LastName;
                txtUsername.Text = teacherData.Username;
                dtpBirthdate.Value = teacherData.Birthdate;
                // ... populate other fields
            }
            
        }

        private Teacher GetTeacherDataFromDatabase(int teacherId)
        {
            
            string query = "SELECT FirstName_tc, MiddleName_tc, LastName_tc, Username_tc, BirthDate_tc FROM teacher WHERE id_teacher = @teacherId";
            MySqlParameter[] parameters = { new MySqlParameter("@id", teacherId) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new Teacher
                    {
                        FirstName = row["FirstName_tc"].ToString(),
                        MiddleName = row["MiddleName_tc"].ToString(),
                        LastName = row["LastName_tc"].ToString(),
                        Username = row["Username_tc"].ToString(),
                        Birthdate = Convert.ToDateTime(row["BirthDate_tc"])

                    };
                }

                return null;
            }
        }

        
        public class Teacher
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string Username { get; set; }
            public DateTime Birthdate { get; set; }
            
        }
        

        private void btnUpdateInfo_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtMiddlename.Text) || string.IsNullOrWhiteSpace(txtLastname.Text)
                || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Full information are required");

                return;
            }

            try
            {
                string query = @"UPDATE teacher
                               SET FirstName_tc = @FirstName, 
                                   MiddleName_tc = @MiddleName, 
                                   LastName_tc = @LastName, 
                                   BirthDate_tc = @BirthDate 
                               WHERE id_teacher = @id_teacher";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@FirstName", txtFirstname.Text.Trim()),
                    new MySqlParameter("@MiddleName", txtMiddlename.Text.Trim()),
                    new MySqlParameter("@LastName", txtLastname.Text.Trim()),
                    new MySqlParameter("@BirthDate", dtpBirthdate.Value.Date),
                    new MySqlParameter("@id_teacher", teacherId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully");


                }
                else
                {
                    MessageBox.Show("No changes were made to the profile");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);

            }
        }

        private void btnChangePass_Click_1(object sender, EventArgs e)
        {
            txtFirstname.Enabled = false;
            txtMiddlename.Enabled = false;
            txtLastname.Enabled = false;
            txtUsername.Enabled = false;
            dtpBirthdate.Enabled = false;

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("New password cannot be empty");

                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match");

                return;
            }

            if (txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters");

                return;
            }

            try
            {
                // In production, you should hash the password before storing
                string query = "UPDATE teacher SET Password_tc = @Password WHERE id_teacher = @teacherId";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@Password", txtNewPassword.Text),
                    new MySqlParameter("@teacherId", teacherId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password changed successfully");

                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();
                    txtFirstname.Enabled = true;
                    txtMiddlename.Enabled = true;
                    txtLastname.Enabled = true;
                    txtUsername.Enabled = true;
                    dtpBirthdate.Enabled = true;


                }
                else
                {
                    MessageBox.Show("Failed to change password");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing password: " + ex.Message);

            }
        }

        private void btnEnabledPasswordChange_Click_1(object sender, EventArgs e)
        {
            txtNewPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;

            txtFirstname.Enabled = false;
            txtMiddlename.Enabled = false;
            txtLastname.Enabled = false;
            txtUsername.Enabled = false;
            dtpBirthdate.Enabled = false;

            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btnNewShow_Hide_CheckedChanged_1(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = btnNewShow_Hide.Checked ? '\0' : '●';
        }

        private void btnConfirmShow_Hide_CheckedChanged_1(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = btnConfirmShow_Hide.Checked ? '\0' : '●';
        }
    }
}
