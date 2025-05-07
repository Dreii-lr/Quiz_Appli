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
    public partial class frmStudentProfile : Form
    {
        private string connectionString = "Server=mysql-quizapp.alwaysdata.net;Port=3306;Database=quizapp_app;Uid=quizapp;Pwd=quizappcsharp;Allow User Variables=true;";


        private int borderSize = 2;
        private int studentId;
        private int _studentId;
        public frmStudentProfile(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = true;
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(950, 400);

            CollapseMenu();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(64, 0, 64);
            
            InitializeProfileControls();
            LoadStudentData();
            this.Load += StudentProfile_Load;
            _studentId = studentId;
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

                
                string idQuery = "SELECT id_users FROM users WHERE username = @Username";
                MySqlCommand idCmd = new MySqlCommand(idQuery, conn);
                idCmd.Parameters.AddWithValue("@Username", AppContext.CurrentUsername);

                int studentId = Convert.ToInt32(idCmd.ExecuteScalar());

                
                AppContext.CurrentStudentId = studentId;
                AppContext.CurrentUsername = AppContext.CurrentUsername;

                
                frmStudentDashboard profileForm = new frmStudentDashboard(studentId);
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

        private void btnTakeQuiz_Click_1(object sender, EventArgs e)
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
        private void InitializeProfileControls()
        {
            // Initialize all controls with proper layout
            // Add them to your form's Controls collection
            // Set their properties (location, size, etc.)
        }
        private void LoadStudentData()
        {
            try
            {
                string query = "SELECT Firstname, Middlename, Lastname, Username, BirthDate FROM users WHERE id_users = @studentId";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@studentId", studentId)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtFirstname.Text = row["Firstname"].ToString();
                    txtMiddlename.Text = row["Middlename"].ToString();
                    txtLastname.Text = row["Lastname"].ToString();
                    txtUsername.Text = row["Username"].ToString();
                    txtUsername.Enabled = true;
                    txtNewPassword.Enabled = false;
                    txtConfirmPassword.Enabled = false;


                    if (DateTime.TryParse(row["BirthDate"].ToString(), out DateTime birthDate))
                    {
                        dtpBirthdate.Value = birthDate;
                    }
                }
                else
                {
                    MessageBox.Show("Student data not found");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtMiddlename.Text) || string.IsNullOrWhiteSpace(txtLastname.Text)
                || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Full information are required");
                
                return;
            }

            try
            {
                string query = @"UPDATE users
                               SET FirstName = @FirstName, 
                                   MiddleName = @MiddleName, 
                                   LastName = @LastName, 
                                   BirthDate = @BirthDate 
                               WHERE id_users = @id_users";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@FirstName", txtFirstname.Text.Trim()),
                    new MySqlParameter("@MiddleName", txtMiddlename.Text.Trim()),
                    new MySqlParameter("@LastName", txtLastname.Text.Trim()),
                    new MySqlParameter("@BirthDate", dtpBirthdate.Value.Date),
                    new MySqlParameter("@id_users", studentId)
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

        private void btnChangePass_Click(object sender, EventArgs e)
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
                string query = "UPDATE users SET Password = @Password WHERE id_users = @studentId";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@Password", txtNewPassword.Text),
                    new MySqlParameter("@studentId", studentId)
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
        private void StudentProfile_Load(object sender, EventArgs e)
        {
            // Use _studentId to fetch student data from the database
            Student studentData = GetStudentDataFromDatabase(_studentId);

            if (studentData != null)
            {
                txtFirstname.Text = studentData.FirstName;
                txtMiddlename.Text = studentData.MiddleName;
                txtLastname.Text = studentData.LastName;
                txtUsername.Text = studentData.Username;
                dtpBirthdate.Value = studentData.Birthdate;
                // ... populate other fields
            }
            else
            {
                MessageBox.Show("Error loading profile information.");
            }
        }

        private Student GetStudentDataFromDatabase(int studentId)
        {
            // Implement your database retrieval logic here
            // Example using your DatabaseHelper:
            string query = "SELECT FirstName, MiddleName, LastName, Username, BirthDate FROM users WHERE id_users = @id";
            MySqlParameter[] parameters = { new MySqlParameter("@id", studentId) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new Student
                    {
                        FirstName = row["FirstName"].ToString(),
                        MiddleName = row["MiddleName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        Username = row["Username"].ToString(),
                        Birthdate = Convert.ToDateTime(row["BirthDate"])

                    };
                }

                return null;
            }
        }

        // Assuming you have a Student class defined
        public class Student
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string Username { get; set; }
            public DateTime Birthdate { get; set; }
            // ... other properties
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiddlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEnabledPasswordChange_Click(object sender, EventArgs e)
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

        private void btnNewShow_Hide_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = btnNewShow_Hide.Checked ? '\0' : '●';
        }

        private void btnConfirmShow_Hide_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = btnConfirmShow_Hide.Checked ? '\0' : '●';
        }
    }
}
