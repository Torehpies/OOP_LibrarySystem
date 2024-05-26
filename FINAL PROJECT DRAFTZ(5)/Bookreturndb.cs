using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Reflection.Metadata.BlobBuilder;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    internal class Bookreturndb
    {
        static MySqlConnection SQL_SERVER;

        public static void start()
        {
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


        public static void DisplayBorrowerInfo(string id, out string borrowerName, out string details, out string borrowedbookcounts, out string lastreturn)
        {
            start();

            borrowerName = "";
            details = "";
            borrowedbookcounts = "";
            lastreturn = "";

            string query = "SELECT `members`.`name`, `members`.`details`, IFNULL(SUM(`borrowedbooks`.`quantity`), 0) AS `quantity` " +
                           "FROM `members` " +
                           "LEFT JOIN `borrowedbooks` ON `borrowedbooks`.`borrowerId` = `members`.`id` " +
                           "AND (`borrowedbooks`.`returnDate` IS NULL OR `borrowedbooks`.`returnDate` = '') " +
                           "WHERE `members`.`id` = @id " +
                           "GROUP BY `members`.`name`, `members`.`details`;";

            using (MySqlCommand command = new MySqlCommand(query, SQL_SERVER))
            {
                command.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Retrieve data from reader
                        borrowerName = reader["name"].ToString();
                        details = reader["details"].ToString();
                        borrowedbookcounts = reader["quantity"].ToString();
                        // Optionally, you can handle the lastreturn here if needed
                        // lastreturn = reader["returnDate"].ToString();
                    }
                }
            }
        }

        public static int GetCurrentBorrowedBooksCount(string borrowerId)
        {
            start();

            int borrowedBooksCount = 0;

            string query = "SELECT COUNT(*) AS `quantity` " +
                           "FROM `borrowedbooks` " +
                           "WHERE `borrowerId` = @borrowerId AND `returnDate` IS NULL";

            using (MySqlCommand command = new MySqlCommand(query, SQL_SERVER))
            {
                command.Parameters.AddWithValue("@borrowerId", borrowerId);

                borrowedBooksCount = Convert.ToInt32(command.ExecuteScalar());
            }

            return borrowedBooksCount;
        }


        public static void DisplayBorrowedBooks(string id, out DataTable borrowedBooksTable)
        {
            start();
            borrowedBooksTable = new DataTable();

            string query = "SELECT `borrowedbooks`.`id`, `books`.`title`, `books`.`author`, `borrowedbooks`.`dueDate`, `members`.`name`, `members`.`details`, `borrowedbooks`.`quantity`, `borrowedbooks`.`borrowDate` " +
                   "FROM `books` " +
                   "LEFT JOIN `borrowedbooks` ON `borrowedbooks`.`bookId` = `books`.`id` " +
                   "LEFT JOIN `members` ON `borrowedbooks`.`borrowerId` = `members`.`id` " +
                   "WHERE `borrowedbooks`.`borrowerId` = @id AND `borrowedbooks`.`returnDate` IS NULL";

            using (MySqlCommand command = new MySqlCommand(query, SQL_SERVER))
            {
                command.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    borrowedBooksTable.Load(reader);
                }
            }
        }

        public static void UpdateReturnDateById(int borrowedBookId, DateTime returnDate)
        {
            start();

            try
            {
                string updateQuery = "UPDATE borrowedbooks SET returnDate = @returnDate WHERE id = @borrowedBookId AND returnDate IS NULL";
                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, SQL_SERVER))
                {
                    updateCommand.Parameters.AddWithValue("@returnDate", returnDate);
                    updateCommand.Parameters.AddWithValue("@borrowedBookId", borrowedBookId);
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    Database database = new Database();
                    database.recordTransaction(LoginDatabase.currentUser);

                    if (rowsAffected == 0)
                    {
                        //MessageBox.Show("No rows updated. The book might have already been returned.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating return date: " + ex.Message);
            }
        }



        /*public static void UpdateReturnDate(string title, string borrowerId, DateTime returnDate)
        {
            start();

            try
            {
                // Fetch the bookId for the given title from the books table
                string bookIdQuery = "SELECT id FROM books WHERE title = @title LIMIT 1";
                int bookId = 0;

                using (MySqlCommand bookIdCommand = new MySqlCommand(bookIdQuery, SQL_SERVER))
                {
                    bookIdCommand.Parameters.AddWithValue("@title", title);
                    object result = bookIdCommand.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        bookId = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Book title not found in books table.");
                        return;
                    }
                }

                // Check if the row exists before attempting to update
                string checkQuery = "SELECT COUNT(*) FROM borrowedbooks WHERE bookId = @bookId AND borrowerId = @borrowerId AND returnDate IS NULL";
                int rowCount = 0;

                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, SQL_SERVER))
                {
                    checkCommand.Parameters.AddWithValue("@bookId", bookId);
                    checkCommand.Parameters.AddWithValue("@borrowerId", borrowerId);

                    rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                }

                if (rowCount == 0)
                {
                    MessageBox.Show("No matching row found in borrowedbooks table. The book might have already been returned or borrower ID is incorrect.");
                    return;
                }

                // Update the returnDate in the borrowedbooks table using the fetched bookId and borrowerId
                string updateQuery = "UPDATE borrowedbooks SET returnDate = @returnDate " +
                                     "WHERE bookId = @bookId AND borrowerId = @borrowerId AND returnDate IS NULL";

                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, SQL_SERVER))
                {
                    updateCommand.Parameters.AddWithValue("@returnDate", returnDate);
                    updateCommand.Parameters.AddWithValue("@bookId", bookId);
                    updateCommand.Parameters.AddWithValue("@borrowerId", borrowerId);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No rows updated. The book might have already been returned or borrower ID is incorrect.");
                    }
                    else
                    {
                        MessageBox.Show("Database Updated.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating return date: " + ex.Message);
            }
        }*/



        public static void IncrementAvailableCopies(string title, int quantity)
        {
            start();

            try
            {
                // Increment available copies by the quantity
                string updateQuery = "UPDATE books SET availableCopies = availableCopies + @quantity WHERE title = @title";
                using (MySqlCommand command = new MySqlCommand(updateQuery, SQL_SERVER))
                {
                    command.Parameters.AddWithValue("@quantity", quantity);
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

        public static int GetCurrentTotalBorrowedBooksCount(string borrowerId)
        {
            start();

            int totalBorrowedBooksCount = 0;

            string query = "SELECT IFNULL(SUM(quantity), 0) AS totalQuantity " +
                           "FROM borrowedbooks " +
                           "WHERE borrowerId = @borrowerId AND returnDate IS NULL";

            using (MySqlCommand command = new MySqlCommand(query, SQL_SERVER))
            {
                command.Parameters.AddWithValue("@borrowerId", borrowerId);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    totalBorrowedBooksCount = Convert.ToInt32(result);
                }
            }

            return totalBorrowedBooksCount;
        }

    }
}