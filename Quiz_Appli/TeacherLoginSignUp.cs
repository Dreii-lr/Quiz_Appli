using MySqlConnector;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Quiz_Appli
{
    public partial class frmTeacher : Form
    {
        private string connectionString = "Server = 127.0.0.1; Port = 3306; Database = quiz_application; Uid = root; Pwd = ;";

        private Timer timer;
        private int targetPosition; // eto posisyon kung san yung panel mag momove
        private int speed = 100; // tanchahan ko lang yan kung gano bilis
        private bool movingRight = true;
        private Helper helper = new Helper();
        public frmTeacher()
        {
            InitializeComponent();
            Console.WriteLine(ConnectionState.Open);

            cmbGender_Tc.Items.Add("Male"); //para sa comboBox ng gender
            cmbGender_Tc.Items.Add("Female");

            timer = new Timer();
            timer.Interval = 1; //para maging smooth ha
            timer.Tick += timer1_Tick;

            targetPosition = 400; //move right first yan ha
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void btnRegister_Click(object sender, EventArgs e)
        {
            movingRight = !movingRight; // toggle direction
            targetPosition = movingRight ? 400 : 0; // x-axis yan para ma indicate kung san sya i move
            btnRegister.Text = movingRight ? "Back to Login" : "Register"; // syempre bawat click mag change yungtext
            lblPanelTitle1.Text = movingRight ? "You have an \nAccount?" : "Start your \r\nQuiz now\r\n";
            lblPanelTitle2.Text = movingRight ? "" : "To keep connected with us please login\r\nwith your pesonal info.\r\n";
            timer.Start();
        }

        private void btnCreateAcc_Tc_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstname_Tc.Text.Trim();
            string middleName = txtMiddlename_Tc.Text.Trim();
            string lastName = txtLastname_Tc.Text.Trim();
            string birthDate = dtpBirthdate_Tc.Value.ToString("yyyy-MM-dd");
            string gender = cmbGender_Tc.Text;
            string username = txtUsername_Cr_Tc.Text.Trim();
            string password = txtPassword_Cr_Tc.Text;
            string confirmPassword = txtConfirmPassword_Cr_Tc.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(middleName) ||
                string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(gender))
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
               //
                string query = "INSERT INTO teacher(id_teacher , FirstName_tc, MiddleName_tc, LastName_tc, BirthDate_tc, Gender_tc, Username_tc, Password_tc)" +
                               "VALUES (@id_teacher, @FirstName_tc, @MiddleName_tc, @LastName_tc, @BirthDate_tc, @Gender_tc, @Username_tc, @Password_tc)";

                string id = helper.GenerateTeachersId();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_teacher", id);
                cmd.Parameters.AddWithValue("@FirstName_tc", firstName);
                cmd.Parameters.AddWithValue("@MiddleName_tc", middleName);
                cmd.Parameters.AddWithValue("@LastName_tc", lastName);
                cmd.Parameters.AddWithValue("@BirthDate_tc", birthDate);
                cmd.Parameters.AddWithValue("@Gender_tc", gender);
                cmd.Parameters.AddWithValue("@Username_tc", username);
                cmd.Parameters.AddWithValue("@Password_tc", password);

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

        private void btnLogin_User_Tc_Click(object sender, EventArgs e)
        {
            string username1 = txtUsername_Tc.Text.Trim();
            string password1 = txtPassword_Tc.Text;

            if (string.IsNullOrEmpty(username1) || string.IsNullOrEmpty(password1))
            {
                MessageBox.Show("Please enter username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM teacher WHERE Username_tc = @Username_tc AND Password_tc = @Password_tc";
                MySqlCommand cmd1 = new MySqlCommand(query, conn);
                cmd1.Parameters.AddWithValue("@Username_tc", username1);
                cmd1.Parameters.AddWithValue("@Password_tc", password1);

                var reader = cmd1.ExecuteReader();

                    if (reader.Read())
                    {
                        string id = (string) reader["id_teacher"];
                    helper.SetUserIdInFile(id);
                    MessageBox.Show("Login successfully!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmTeacherHomepage frm = new frmTeacherHomepage();
                    frm.Show();
                    this.Hide();
                }
               
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnShow_Hide_Ad_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword_Tc.PasswordChar = btnShow_Hide_Tc.Checked ? '\0' : '●';
        }

        private void btnC_Hide_Show_Tc_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPassword_Cr_Tc.PasswordChar = btnC_Hide_Show_Tc.Checked ? '\0' : '●';
        }

        private void txtPassword_Cr_Tc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpPassword_R_Tc_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword_Cr_Tc.PasswordChar = btnpPassword_R_Tc.Checked ? '\0' : '●';
        }

        
    }
}
