using MySqlConnector;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quiz_Appli
{
    public partial class frmUser : Form
    {
        private string connectionString = "Server = 127.0.0.1; Port = 3306; Database = quiz_application; Uid = root; Pwd = ;";

        private Timer timer;
        private int targetPosition; // eto posisyon kung san yung panel mag momove
        private int speed = 100; // tanchahan ko lang yan kung gano bilis
        private bool movingRight = true; //direction yan ng flag
        public frmUser()
        {
            InitializeComponent();
            Console.WriteLine(ConnectionState.Open);

            cmbGender.Items.Add("Male"); //para sa comboBox ng gender
            cmbGender.Items.Add("Female");

            cmbGradelvl.Items.Add("1nd Year"); //para sa comboBox ng gradelvl
            cmbGradelvl.Items.Add("2nd Year");
            cmbGradelvl.Items.Add("3nd Year");
            cmbGradelvl.Items.Add("4nd Year");

            cmbCourse.Items.Add("BSCS"); //para sa comboBox ng course
            cmbCourse.Items.Add("BSIT");

            timer = new Timer();
            timer.Interval = 1; //para maging smooth ha
            timer.Tick += tmPanel1_Tick;

            targetPosition = 400; //move right first yan ha
        }

        

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmPanel1_Tick(object sender, EventArgs e)
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
        private void btnRegister_Click(object sender, EventArgs e)
        {
            movingRight = !movingRight; // toggle direction
            targetPosition = movingRight ? 400 : 0; // x-axis yan para ma indicate kung san sya i move
            btnRegister.Text = movingRight ? "Back to Login" : "Register"; // syempre bawat click mag change yungtext
            lblPanelTitle1.Text = movingRight ? "You have an \nAccount?" : "Start your \r\nQuiz now\r\n";
            lblPanelTitle2.Text = movingRight ? "" : "To keep connected with us please login\r\nwith your pesonal info.\r\n";
            timer.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmUser_Admin frm1 = new frmUser_Admin();
            frm1.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Hide_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = btnShow_Hide.Checked ? '\0' : '●';
        }

        private void btnGo_Login_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstname.Text.Trim();
            string middleName = txtMiddlename.Text.Trim();
            string lastName = txtLastname.Text.Trim();
            string birthDate = dtpBirthdate.Value.ToString("yyyy-MM-dd");
            string gender = cmbGender.Text;
            string gradelevel = cmbGradelvl.Text;
            string course = cmbCourse.Text;
            string username = txtUsername_Cr.Text.Trim();
            string password = txtPassword_Cr.Text;
            string confirmPassword = txtConfirmPassword_Cr.Text;
            
            // validation pag nag register ng di na fifillupan tas nag submit agad
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(middleName) ||
                string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(gradelevel) ||
                string.IsNullOrEmpty(course))
            {
                MessageBox.Show("All fields are required to filledup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password dont match! Enter the same password again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO users(FirstName, MiddleName, LastName, BirthDate, Gender, GradeLevel, Course, Username, Password)" +
                               "VALUES (@FirstName, @MiddleName, @LastName, @BirthDate, @Gender, @GradeLevel, @Course, @Username, @Password)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@MiddleName", middleName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@GradeLevel", gradelevel);
                cmd.Parameters.AddWithValue("@Course", course);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful! Go back to Login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Username already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void txtPassword_Cr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_Cr_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPassword_R_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword_Cr.PasswordChar = btnPassword_R.Checked ? '\0' : '●';
        }

        private void btnC_Password_R_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPassword_Cr.PasswordChar = btnC_Password_R.Checked ? '\0' : '●';
        }

        private void btnLogin_User_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @Username AND password = @Password";
                MySqlCommand cmd1 = new MySqlCommand(query, conn);
                cmd1.Parameters.AddWithValue("@Username", username);
                cmd1.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(cmd1.ExecuteScalar());
                if (count > 0) 
                {
                    MessageBox.Show("Login successfully!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    frmStudentDashboard frm = new frmStudentDashboard();
                    frm.Show();
                }
                else 
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}