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

        public static void AddBooks(string title, string author, string isbn, string category, string publisher, DateTime year, int totalCopies)
        {
            start();
            if (totalCopies <= 0)
            {
                MessageBox.Show("Invalid copies of books");
                return;
            }
            string query = "INSERT INTO books (title, author, isbn, category, publisher, published, totalCopies, availableCopies) " +
                "VALUES (@title, @author, @isbn, @category, @publisher, @published, @totalCopies, @availableCopies)";

            MySqlCommand cmd = new MySqlCommand(query, SQL_SERVER);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@publisher", publisher);
            cmd.Parameters.AddWithValue("@published", year);
            cmd.Parameters.AddWithValue("@totalcopies", totalCopies);
            cmd.Parameters.AddWithValue("@availablecopies", totalCopies);


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

        public static void UpdateReturnDate(string title, DateTime returnDate)
        {
            start();

            try
            {
                string query = "UPDATE borrowedbooks SET returnDate = @returnDate WHERE bookId = (SELECT id FROM books WHERE title = @title)";
                using (MySqlCommand command = new MySqlCommand(query, SQL_SERVER))
                {
                    command.Parameters.AddWithValue("@returnDate", returnDate);
                    command.Parameters.AddWithValue("@title", title);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating return date: " + ex.Message);
            }
        }


        public static void IncrementAvailableCopies(string title)
        {
            start();

            try
            {
                // Get the current available copies
                int currentAvailableCopies = GetCurrentAvailableCopies(title);

                // Increment available copies by 1
                int newAvailableCopies = currentAvailableCopies + 1;

                // Update books table with the new available copies
                string updateQuery = "UPDATE books SET availableCopies = @availablecopies WHERE title = @title";
                using (MySqlCommand command = new MySqlCommand(updateQuery, SQL_SERVER))
                {
                    command.Parameters.AddWithValue("@availablecopies", newAvailableCopies);
                    command.Parameters.AddWithValue("@title", title);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating available copies: " + ex.Message);
            }
        }

        public static int GetCurrentAvailableCopies(string title)
        {
            start();

            try
            {
                string query = "SELECT availableCopies FROM books WHERE title = @title";
                using (MySqlCommand command = new MySqlCommand(query, SQL_SERVER))
                {
                    command.Parameters.AddWithValue("@title", title);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving current available copies: " + ex.Message);
            }
            return 0;
        }
    }
}
