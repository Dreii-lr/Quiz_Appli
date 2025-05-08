using System;
using System.Data;
using MySqlConnector;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class frmAdminTeacherManagement : Form
    {
        private string connectionString = "Server=mysql-quizapp.alwaysdata.net;Port=3306;Database=quizapp_app;Uid=quizapp;Pwd=quizappcsharp;Allow User Variables=true;";
        private int editingTeacherId = -1;

        public frmAdminTeacherManagement()
        {
            InitializeComponent();
            LoadTeacherData();
        }

        private void LoadTeacherData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    //  Query the teachers table to get all teacher details
                    string query = "SELECT id_teacher, FirstName_tc, MiddleName_tc, LastName_tc, BirthDate_tc, Username_tc, Password_tc FROM teacher";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTeacher.DataSource = dt;

                    // Optional: Set column headers for better user experience
                    dgvTeacher.Columns["id_teacher"].Visible = false; // Hide the teacher ID, as users don't usually need to see it
                     dgvTeacher.Columns["FirstName_tc"].HeaderText = "First Name";
                     dgvTeacher.Columns["MiddleName_tc"].HeaderText = "Middle Name";
                    dgvTeacher.Columns["LastName_tc"].HeaderText = "Last Name";
                    dgvTeacher.Columns["BirthDate_tc"].HeaderText = "Birth Date";
                    dgvTeacher.Columns["Username_tc"].HeaderText = "Username";
                    dgvTeacher.Columns["Password_tc"].HeaderText = "Password";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading teacher data: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            //  Clear all the input fields on the form
            txtFirstName_tc.Text = "";
            txtMidlleName_tc.Text = "";
            txtLastName_tc.Text = "";
            dtpTeacher.Value = DateTime.Today;
            txtEmail_Tc.Text = "";
            txtPassword_TC.Text = "";
            editingTeacherId = -1;            // Reset the editingTeacherId to indicate a new teacher is being added
            btnSave.Text = "Save";  // Reset the Save button text
        }

        private void btnTeacherSave_Click(object sender, EventArgs e)
        {
            //  Check if required fields are empty
            if (string.IsNullOrEmpty(txtFirstName_tc.Text) || string.IsNullOrEmpty(txtLastName_tc.Text) ||
                string.IsNullOrEmpty(txtEmail_Tc.Text) || string.IsNullOrEmpty(txtPassword_TC.Text))
            {
                MessageBox.Show("First Name, Last Name, Username, and Password are required.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query;
                    //  Determine if we are inserting a new teacher or updating an existing one
                    if (editingTeacherId == -1)
                    {
                        //  Insert a new teacher record into the teachers table
                        query = "INSERT INTO teacher (FirstName_tc, MiddleName_tc, LastName_tc, BirthDate_tc, Username_tc, Password_tc) " +
                                "VALUES (@FirstName, @MiddleName, @LastName, @BirthDate, @Username, @Password)";
                    }
                    else
                    {
                        //  Update an existing teacher record in the teachers table
                        query = "UPDATE teacher SET FirstName_tc=@FirstName, MiddleName_tc=@MiddleName, LastName_tc=@LastName, " +
                                "BirthDate_tc=@BirthDate, Username_tc=@Username, Password_tc=@Password WHERE id_teacher=@Id";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        //  Add parameters to the SQL command to prevent SQL injection and pass data
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName_tc.Text);
                        cmd.Parameters.AddWithValue("@MiddleName", txtMidlleName_tc.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLastName_tc.Text);
                        cmd.Parameters.AddWithValue("@BirthDate", dtpTeacher.Value.Date);
                        cmd.Parameters.AddWithValue("@Username", txtEmail_Tc.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword_TC.Text);
                        if (editingTeacherId != -1)
                        {
                            cmd.Parameters.AddWithValue("@Id", editingTeacherId); // Add the ID parameter for updates
                        }

                        cmd.ExecuteNonQuery();    // Execute the SQL command (INSERT or UPDATE)
                        LoadTeacherData();       // Refresh the DataGridView to show the updated data
                        ClearFields();           // Clear the input fields
                        MessageBox.Show("Teacher saved successfully.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error saving teacher data: " + ex.Message);
                }
            }
        }

        private void btnTeacherUpdate_Click(object sender, EventArgs e)
        {
            //  Check if a row is selected in the DataGridView
            if (dgvTeacher.CurrentRow != null)
            {
                //  Get the ID of the selected teacher from the DataGridView
                editingTeacherId = Convert.ToInt32(dgvTeacher.CurrentRow.Cells["id_teacher"].Value);
                //  Populate the input fields with the data from the selected row
                txtFirstName_tc.Text = dgvTeacher.CurrentRow.Cells["FirstName_tc"].Value.ToString();
                txtMidlleName_tc.Text = dgvTeacher.CurrentRow.Cells["MiddleName_tc"].Value.ToString();
                txtLastName_tc.Text = dgvTeacher.CurrentRow.Cells["LastName_tc"].Value.ToString();
                dtpTeacher.Value = Convert.ToDateTime(dgvTeacher.CurrentRow.Cells["BirthDate_tc"].Value);
                txtEmail_Tc.Text = dgvTeacher.CurrentRow.Cells["Username_tc"].Value.ToString();
                txtPassword_TC.Text = dgvTeacher.CurrentRow.Cells["Password_tc"].Value.ToString();

                btnSave.Text = "Update";  // Change the Save button text to indicate an update
            }
            else
            {
                MessageBox.Show("Please select a teacher to update.");
            }
        }

        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            //  Check if a row is selected in the DataGridView
            if (dgvTeacher.CurrentRow != null)
            {
                // Get the ID of the teacher to delete
                int idToDelete = Convert.ToInt32(dgvTeacher.CurrentRow.Cells["id_teacher"].Value);
                //  Show a confirmation message to the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            //  SQL query to delete the teacher record
                            string query = "DELETE FROM teacher WHERE id_teacher = @Id";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Id", idToDelete);  // Add the ID parameter
                                cmd.ExecuteNonQuery();            // Execute the delete query
                                LoadTeacherData();               // Refresh the DataGridView
                                ClearFields();                   // Clear the input fields
                                MessageBox.Show("Teacher deleted successfully.");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error deleting teacher: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a teacher to delete.");
            }
        }

        private void btnTeacherClear_Click(object sender, EventArgs e)
        {
            ClearFields(); // Call the ClearFields method to reset the form
        }

        private void btnTeacherAddNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            editingTeacherId = -1;
            btnSave.Text = "Save";
        }

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row was clicked
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTeacher.Rows[e.RowIndex];
                // Populate the form fields with the data from the clicked row
                txtFirstName_tc.Text = row.Cells["FirstName_tc"].Value.ToString();
                txtMidlleName_tc.Text = row.Cells["MiddleName_tc"].Value.ToString();
                txtLastName_tc.Text = row.Cells["LastName_tc"].Value.ToString();
                dtpTeacher.Value = Convert.ToDateTime(row.Cells["BirthDate_tc"].Value);
                txtEmail_Tc.Text = row.Cells["Username_tc"].Value.ToString();
                txtPassword_TC.Text = row.Cells["Password_tc"].Value.ToString();
                editingTeacherId = Convert.ToInt32(row.Cells["id_teacher"].Value);
                btnSave.Text = "Update"; // Change to update
            }
        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnTeacherManagement_Click(object sender, EventArgs e)
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
