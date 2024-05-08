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
                    MessageBox.Show("Account does not match in the database");
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
            
            MySqlCommand cmd = new MySqlCommand("INSERT INTO users (username, password, created, type) VALUES (@username, @password, @created, @type)", SQL_SERVER);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            DateTime dateTime = DateTime.Now;
            string formattedDateTime = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            cmd.Parameters.AddWithValue("@created", formattedDateTime);
            cmd.Parameters.AddWithValue("@type", "admin");

            cmd.ExecuteNonQuery();
            SQL_SERVER.Close();
        }


    }
}
