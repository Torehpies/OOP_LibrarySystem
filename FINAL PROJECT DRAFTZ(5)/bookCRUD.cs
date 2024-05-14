using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    internal class bookCRUD
    {
        static MySqlConnection SQL_SERVER;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to database failed!");
            }
        }

        public static void AddBooks(string title, string author, string isbn, string category, string publisher, int year, int totalCopies, string image)
        {
            start();
            if (totalCopies <= 0)
            {
                MessageBox.Show("Invalid copies of books");
                return;
            }
            string query = "INSERT INTO books (title, author, isbn, category, publisher, published, totalCopies, availableCopies, picturePath) " +
                "VALUES (@title, @author, @isbn, @category, @publisher, @published, @totalCopies, @availableCopies, @image)";

            MySqlCommand cmd = new MySqlCommand(query, SQL_SERVER);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@publisher", publisher);
            cmd.Parameters.AddWithValue("@published", year);
            cmd.Parameters.AddWithValue("@totalcopies", totalCopies);
            cmd.Parameters.AddWithValue("@availablecopies", totalCopies);
            cmd.Parameters.AddWithValue("@image", image);


            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Update Success!");
            }
            else
            {
                MessageBox.Show("No table is affected");
            }
        }

        public static DataTable ReadBooks()
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

        // Single update
        public static void UpdateBooks(string columnToUpdate, object newValue, string conditionColumn, string conditionValue)
        {

            start();

            string query = $"UPDATE books SET {columnToUpdate} = @newvalue WHERE {conditionColumn} = @conditionvalue";
            using (MySqlCommand cmd = new MySqlCommand(query, SQL_SERVER))
            {

                cmd.Parameters.AddWithValue("@newvalue", newValue);
                cmd.Parameters.AddWithValue(@"conditionvalue", conditionValue);

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

        // Multi update
        public static void UpdateInfos(string[] columnsToUpdate, string[] newValue, string conditionColumn, object conditionValue) 
        {
            start();

            int columns = columnsToUpdate.Length;
            StringBuilder query = new StringBuilder($"UPDATE books SET ");

            for (int i = 0; i < columns; i++)
            {
                query.AppendLine(columnsToUpdate[i] + " = " + '"' + newValue[i] + '"');

                if ( i < columns - 1)
                {
                    query.Append(',');
                }
            }
            query.AppendLine(" WHERE " + conditionColumn + " = " +  '"' + conditionValue + '"');
            MessageBox.Show(query.ToString());

            using (MySqlCommand cmd = new MySqlCommand(query.ToString(), SQL_SERVER))
            {
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



            MessageBox.Show(query.ToString());
        }

        public static void DeleteBooks(string column, string columnValue)
        {
            start();

            string query = $"DELETE FROM books WHERE {column} = @value";

            MySqlCommand cmd = new MySqlCommand(query, SQL_SERVER);
            cmd.Parameters.AddWithValue("@value", columnValue);


            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Update successful");
            }
            else
            {
                MessageBox.Show("No rows updated.");
            }
        }
    }
}
