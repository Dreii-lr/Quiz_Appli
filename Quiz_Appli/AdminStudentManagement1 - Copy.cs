using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace QuizApp
{
    public partial class frmAdminStudentManagement : Form
    {
        private string connectionString = "Server=mysql-quizapp.alwaysdata.net;Port=3306;Database=quizapp_app;Uid=quizapp;Pwd=quizappcsharp;Allow User Variables=true;";

        public frmAdminStudentManagement()
        {
            InitializeComponent();
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM users";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStudents.DataSource = dt;
            }
        }

        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            dtpBirthDate.Value = DateTime.Today;
            txtGender.Text = "";
            txtCourse.Text = "";
            txtGradeLevel.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

       
        

        
        
            

        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Do you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvStudents.Rows[e.RowIndex].Cells["id_user"].Value);
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Users WHERE id_user=@id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadStudentData();
                }
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtMiddleName.Text = row.Cells["MiddleName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);
                txtGender.Text = row.Cells["Gender"].Value.ToString();
                txtCourse.Text = row.Cells["Course"].Value.ToString();
                txtGradeLevel.Text = row.Cells["GradeLevel"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void lblMidlleName_Click(object sender, EventArgs e)
        {

        }

        private void btnTeacherManagement_Click(object sender, EventArgs e)
        {
            frmAdminTeacherManagement frm = new frmAdminTeacherManagement();
            frm.Show();
            this.Hide();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["id_users"].Value);
                using ( MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE users SET FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, " +
                                   "BirthDate=@BirthDate, Gender=@Gender, Course=@Course, GradeLevel=@GradeLevel, Username=@Username, Password=@Password " +
                                   "WHERE id_users=@id";
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value.Date);
                        cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                        cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                        cmd.Parameters.AddWithValue("@GradeLevel", txtGradeLevel.Text);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                LoadStudentData();
                ClearFields();
            }
   
    }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO users (FirstName, MiddleName, LastName, BirthDate, Gender, Course, GradeLevel, Username, Password) " +
                               "VALUES (@FirstName, @MiddleName, @LastName, @BirthDate, @Gender, @Course, @GradeLevel, @Username, @Password)";
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                    cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                    cmd.Parameters.AddWithValue("@GradeLevel", txtGradeLevel.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    
                    cmd.ExecuteNonQuery();
                }
            }
            LoadStudentData();
            ClearFields();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            frmAdminStudentManagement frm = new frmAdminStudentManagement();
            frm.Show();
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
    }
}
