using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Quiz_Appli
{
    public partial class frmStartQuiz : Form
    {
        private List<Quizes> questions = new List<Quizes>();
        private Helper helper = new Helper();
        private string quizId;
        private int studentID = 1; // Set this based on login
        private int currentQuestionIndex = 0;

        public frmStartQuiz()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //frmStudentTakeQuiz frm1 = new frmStudentTakeQuiz();
            //frm1.Show();
            //this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void frmStartQuiz_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=mysql-quizapp.alwaysdata.net;Port=3306;Database=quizapp_app;Uid=quizapp;Pwd=quizappcsharp;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT q.QuestionID, q.QuestionText, c.Choice1, c.Choice2, c.Choice3, c.Answer "+ 
                                     "FROM questions q "+
                                     "JOIN choices c ON q.QuestionID = c.QuestionID "+
                                     "ORDER BY q.QuestionID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                    while (reader.Read())
                        {
                            var choices = new List<string>
                            {
                                reader["Choice1"].ToString(),
                                reader["Choice2"].ToString(),
                                reader["Choice3"].ToString(),
                                reader["Answer"].ToString()
                            };

                            var correctAnswer = reader["Answer"].ToString();
                            var shuffled = choices.OrderBy(x => Guid.NewGuid()).ToList();
                            int correctIndex = shuffled.IndexOf(correctAnswer);

                        questions.Add(new Quizes
                        { 
                            QuestionID = (string)reader["QuestionID"],
                            QuestionText = reader["QuestionText"].ToString(),
                            ShuffledChoices = shuffled,
                            CorrectIndex = correctIndex
                        });
                        }
                    }
                }

                DisplayQuestion(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedRadioButtonIndex();
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select an answer before proceeding.");
                return;
            }

            var currentQ = questions[currentQuestionIndex];
            string selectedAnswer = currentQ.ShuffledChoices[selectedIndex];
            bool isCorrect = selectedIndex == currentQ.CorrectIndex;

            SaveAnswerToDatabase(studentID, currentQ.QuestionID, selectedAnswer, isCorrect);

            currentQuestionIndex++;

            if (currentQuestionIndex < questions.Count)
            {
                DisplayQuestion(currentQuestionIndex);

                lblCounter.Text = $"Question {currentQuestionIndex} of {questions.Count}";
            }
            else
            {
                ShowFinalScore();
            }
        }

        private void SaveAnswerToDatabase(int studentId, string questionId, string selectedAnswer, bool isCorrect)
        {
            quizId = helper.GenerateQuizesaId();
            string connectionString = "Server=mysql-quizapp.alwaysdata.net;Port=3306;Database=quizapp_app;Uid=quizapp;Pwd=quizappcsharp;";
            string insertQuery = @"INSERT INTO student_answers (StudentID, QuizID, QuestionID, SelectedAnswer, IsCorrect)
                                   VALUES (@StudentID, @QuizID, @QuestionID, @SelectedAnswer, @IsCorrect)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.Parameters.AddWithValue("@QuizID", quizId);
                    cmd.Parameters.AddWithValue("@QuestionID", questionId);
                    cmd.Parameters.AddWithValue("@SelectedAnswer", selectedAnswer);
                    cmd.Parameters.AddWithValue("@IsCorrect", isCorrect);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving answer: " + ex.Message);
            }
        }

        private void ShowFinalScore()
        {
            string connectionString = "Server=mysql-quizapp.alwaysdata.net;Port=3306;Database=quizapp_app;Uid=quizapp;Pwd=quizappcsharp;";
            string query = "SELECT COUNT(*) FROM student_answers WHERE StudentID = @StudentID AND QuizID = @QuizID AND IsCorrect = 1";

            int score = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@QuizID", quizId);
                    conn.Open();
                    score = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating score: " + ex.Message);
                return;
            }

            MessageBox.Show($"Quiz Completed!\nYour score: {score} out of {questions.Count}");
            this.Close();
        }

        private void DisplayQuestion(int index)
        {
            if (index >= 0 && index < questions.Count)
            {
                txtQuestions.Text = questions[index].QuestionText;
                rdbChoices1.Text = questions[index].ShuffledChoices[0];
                rdbChoices2.Text = questions[index].ShuffledChoices[1];
                rdbChoices3.Text = questions[index].ShuffledChoices[2];
                rdbChoices4.Text = questions[index].ShuffledChoices[3];

                rdbChoices1.Checked = false;
                rdbChoices2.Checked = false;
                rdbChoices3.Checked = false;
                rdbChoices4.Checked = false;
            }
        }

        private int GetSelectedRadioButtonIndex()
        {
            if (rdbChoices1.Checked) return 0;
            if (rdbChoices2.Checked) return 1;
            if (rdbChoices3.Checked) return 2;
            if (rdbChoices4.Checked) return 3;
            return -1;
        }
    }
}
