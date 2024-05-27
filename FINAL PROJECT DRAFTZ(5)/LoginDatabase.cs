using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    internal class LoginDatabase
    {
        public static MySqlConnection SQL_SERVER;

        public static string currentUserId;
        public static string currentUsername;
        public static bool admin;
        

        public static void start()
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

        public static bool isUsersEmpty()
        {
            start();
            MySqlCommand query = new MySqlCommand("SELECT * FROM users", SQL_SERVER);
            MySqlDataReader reader = query.ExecuteReader();

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

        public static string getUserId(string username)
        {
            string id = "";
            start();

            MySqlCommand cmd = new MySqlCommand("SELECT id from users WHERE username = @username",SQL_SERVER);
            cmd.Parameters.AddWithValue("@username", username);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read()) return id;

            id = reader.GetValue(0).ToString();
            reader.Close();
            SQL_SERVER.Close();

            return id;           
        }

        public static string getUsername(string id)
        {
            string username = "";
            start();

            MySqlCommand cmd = new MySqlCommand("SELECT username from users WHERE id = @id", SQL_SERVER);
            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read()) return username;

            username = reader.GetValue(0).ToString();
            reader.Close();
            SQL_SERVER.Close();

            return id;
        }

        public static bool checkLogin(string username, string password, bool isAdmin)
        {
            start();

            string query = "SELECT * FROM users WHERE username = @username";
            query = isAdmin? query + " AND type = 'admin'" : query;

            MySqlCommand cmd = new MySqlCommand(query, SQL_SERVER);
            cmd.Parameters.AddWithValue("@username", username);

            string hashPasswordDB;
            MySqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read()) return false;
                
            hashPasswordDB = reader.GetString("password");

            reader.Close();
            SQL_SERVER.Close();

            if (BCrypt.Net.BCrypt.EnhancedVerify(password, hashPasswordDB))
            {
                currentUserId = getUserId(username).ToString();
                currentUsername = username;
                
                return true;
            }
            else return false;
            
        }

        public static bool isAdmin(string username)
        {
            start();
            string query = "SELECT * FROM users WHERE username = @username AND type = 'admin'";

            MySqlCommand cmd = new MySqlCommand(query, SQL_SERVER);
            cmd.Parameters.AddWithValue("@username", username);

            MySqlDataReader reader = cmd.ExecuteReader();
            
            


            
            if (reader.Read())
            {
                admin = true;
                return true;
            } else
            {
                admin = false;
                return false;
            }
        }

        public static bool checkAccount(string username)
        {
            start();
            
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

        public static void addAccount(string username, string password, bool isAdmin)
        {
            start();
            
            MySqlCommand cmd = new MySqlCommand("INSERT INTO users (username, password, created, type) VALUES (@username, @password, @created, @type)", SQL_SERVER);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            DateTime dateTime = DateTime.Now;
            string formattedDateTime = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            cmd.Parameters.AddWithValue("@created", formattedDateTime);
            cmd.Parameters.AddWithValue("@type", isAdmin? "admin" : "standard");

            cmd.ExecuteNonQuery();
            SQL_SERVER.Close();
        }


    }
}
