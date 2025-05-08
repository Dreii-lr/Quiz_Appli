//using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Appli
{
    internal class Helper
    {
        private string connectionString = "Server = mysql-quizapp.alwaysdata.net; Port = 3306; Database = quizapp_app; Uid = quizapp; Pwd = quizappcsharp;";
        // NOT USABLE
        public void SetUserIdInFile(string id)
        {
            string dir = Path.Combine(Directory.GetCurrentDirectory());
            string filepath = dir + "/userid.tmp";
            FileStream fs = File.Create(filepath);
            fs.Close();

            using (FileStream fsReader = new FileStream(filepath, FileMode.Open, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fsReader))
                {
                    writer.Write(id);  // write to the file


                }
            }
        }


        public String GetUSerIdInNFile()
        {
            string id = "";
            string dir = Path.Combine(Directory.GetCurrentDirectory());
            string filepath = dir + "/userid.tmp";

            FileStream fsReader = new FileStream(filepath, FileMode.Open, FileAccess.Read); // open the file
            StreamReader reader = new StreamReader(fsReader);
            id = reader.ReadToEnd();

            fsReader.Close();
            reader.Close();

            return id;
        }
        //NOT USABLE
        public void DeleteUserId()
        {
            //string id = "";
            string dir = Path.Combine(Directory.GetCurrentDirectory());
            string filepath = dir + "/userid.tmp";

            File.Delete(filepath); // open the file
 
        }
        public string GenerateTeachersId()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string id = "";
                string stmt = "SELECT LPAD(IFNULL(MAX(id_teacher), 0) + 1, 4, '0') as nextId from teacher";

                using (var cmd = new MySqlCommand(stmt, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetString("nextId");
                        }
                    }
                    return id;
                }
            }
        }

        public string GenerateQuizesaId()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open ();
                string id = "";
                string stmt = "SELECT LPAD(IFNULL(MAX(QuizID), 0) + 1, 4, '0') as nextId from quizzes";

                using (var cmd = new MySqlCommand(stmt, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetString("nextId");
                        }
                    }
                    return id;
                }
            }
        }
        public string GeneratQuestionId()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string id = "";
                string stmt = "SELECT LPAD(IFNULL(MAX(QuestionID), 0) + 1, 4, '0') as nextId from questions";

                using (var cmd = new MySqlCommand(stmt, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetString("nextId");
                        }
                    }
                    return id;
                }
            }
        }
    }
}
