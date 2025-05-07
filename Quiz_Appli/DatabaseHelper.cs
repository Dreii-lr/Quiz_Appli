using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Quiz_Appli
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=mysql-quizapp.alwaysdata.net;Port=3306;" +
                                              "Database=quizapp_app;Uid=quizapp;Pwd=quizappcsharp;" +
                                              "Allow User Variables=true;";

        public static DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Query cannot be empty");

            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (MySqlException myEx)
                {
                    throw new Exception($"MySQL Error ({myEx.Number}): {myEx.Message}");
                }
                catch (Exception ex)
                {
                    throw new Exception("Database error: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }

            return dt;
        }

        public static int ExecuteNonQuery(string query, MySqlParameter[] parameters = null, MySqlTransaction transaction = null)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Query cannot be empty");

            int rowsAffected = 0;

            using (MySqlConnection conn = transaction?.Connection ?? new MySqlConnection(connectionString))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException myEx)
                {
                    throw new Exception($"MySQL Error ({myEx.Number}): {myEx.Message}");
                }
                catch (Exception ex)
                {
                    throw new Exception("Database error: " + ex.Message);
                }
                finally
                {
                    if (transaction == null && conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }

            return rowsAffected;
        }

        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

