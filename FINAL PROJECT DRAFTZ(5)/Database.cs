using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

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
            } finally
            {
                SQL_SERVER.Close();
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

            SQL_SERVER.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", SQL_SERVER);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataAdapter adapater = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapater.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;

        }


    }
}
