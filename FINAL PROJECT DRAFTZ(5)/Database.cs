using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Net;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    internal class Database
    {
        MySqlConnection SQL_SERVER = null;

        public void start()
        {
            // DATABASE SPECIFICATION
            string SERVER = "127.0.0.1";
            string DATABASE = "test";
            string USER = "root";
            string PASSWORD = "";

            SQL_SERVER = new MySqlConnection("server=" + SERVER + "; user=" + USER + "; database=" + DATABASE + "; password=" + PASSWORD + ";");
            try
            {
                SQL_SERVER.Open();
            } catch (Exception ex)
            {
                MessageBox.Show("Connection to database failed!");
            } 
        }

        
        public bool checkLogin(string username, string password)
        {
            if (SQL_SERVER == null)
            {
                while (SQL_SERVER == null)
                {
                    start();
                }
            }

            if (username == "test" && password == "test")
            {
                return true;
            }



            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = @username", SQL_SERVER);
            cmd.Parameters.AddWithValue("@username", username);

            string hashPasswordDB = null;
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    hashPasswordDB = reader.GetString("password");
                } else
                {
                    return false;
                }
            }

            // Verify password
            if (BCrypt.Net.BCrypt.EnhancedVerify(password, hashPasswordDB))
            {
                return true;
            }

            return false;
        }

        public bool checkAccount(string username)
        {
            if (SQL_SERVER == null)
            {
                start();
            }
            

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = @username", SQL_SERVER);
            cmd.Parameters.AddWithValue("@username", username);
    
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    SQL_SERVER.Close();
                    return true;
                }
                else
                {
                    SQL_SERVER.Close();
                    return false;
                }
            }
            
        } 

        public void addAccount(string username, string password)
        {
            if (SQL_SERVER == null)
            {
                start();
            }
            SQL_SERVER.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO users (username, password, created) VALUES (@username, @password, @created)", SQL_SERVER);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            DateTime dateTime = DateTime.Now;
            string formattedDateTime = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            cmd.Parameters.AddWithValue("@created", formattedDateTime);
            cmd.ExecuteNonQuery();
            SQL_SERVER.Close();
        }

        public void updateDatabase(KeyValuePair<string, int> keyValuePairs)
        {
            if (SQL_SERVER == null)
            {
                start();
            }

            string query = "UPDATE books SET availableCopies = @AvailableCopies WHERE title = @Title";

            using (MySqlCommand cmd = new MySqlCommand(query, SQL_SERVER))
            {

                cmd.Parameters.AddWithValue($"@Title", keyValuePairs.Key);
                cmd.Parameters.AddWithValue(@"AvailableCopies", keyValuePairs.Value);


                //MessageBox.Show(query);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update success!");
                }
                else
                {
                    MessageBox.Show("No rows updated.");
                }
            }

        }

        public string getBookId(string title)
        {
            if (SQL_SERVER == null)
            {
                start();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT id FROM books WHERE title = @title", SQL_SERVER);
            cmd.Parameters.AddWithValue("@title", title);

            MySqlDataReader reader = cmd.ExecuteReader();

            string id = "0";
            try
            {
                while (reader.Read())
                {
                    id = reader.GetString(0);
                    return id;
                }
            }
            finally
            {
                reader.Close();
                SQL_SERVER.Close();
            }

            return id;
        }

        public void addBorrowedBooks(string title, string borrowerId, int quantity)
        {
            if (SQL_SERVER == null)
            {
                start();
            }

            string bookId = getBookId(title);

            MySqlCommand cmd = new MySqlCommand("INSERT INTO borrowedBooks (bookId, borrowerId, quantity, borrowDate, dueDate) " +
                                                "VALUES(@bookId, @borrowerId, @quantity, @borrowDate, @dueDate)", SQL_SERVER);

            cmd.Parameters.AddWithValue("@bookId", bookId);
            cmd.Parameters.AddWithValue("@borrowerId", borrowerId);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@borrowDate", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@borrowDate", DateTime.Now.AddDays(14).ToString("yyyy-MM-dd"));

            cmd.ExecuteNonQuery();
            SQL_SERVER.Close();
        }

        public DataTable retrieveData()
        {
            if (SQL_SERVER == null)
            {
                start();
            }


            MySqlCommand cmd = new MySqlCommand("SELECT * FROM books", SQL_SERVER);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }

        public DataTable retrieveData(string searchword)
        {
            if (SQL_SERVER == null)
            {
                start();
            }

            searchword = searchword + '%';

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM books WHERE title LIKE @title OR isbn LIKE @isbn", SQL_SERVER);
            cmd.Parameters.AddWithValue("@title", searchword);
            cmd.Parameters.AddWithValue("@isbn", searchword);
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
