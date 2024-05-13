using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string query = "SELECT members.name, members.details, borrowedbooks.quantity, borrowedbooks.returnDate " +
                    "FROM members " +
                    "INNER JOIN borrowedbooks ON members.id = borrowedbooks.id " +
                    "WHERE borrowedbooks.borrowerId = @id;";


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
                        lastreturn = reader["returnDate"].ToString();
                    }
                }
            }
        }

        public static void DisplayBorrowedBooks(string id, out DataTable borrowedBooksTable)
        {
            start();

            borrowedBooksTable = new DataTable();

            string query = "SELECT books.title, books.author, borrowedbooks.dueDate " +
                           "FROM books " +
                           "INNER JOIN borrowedbooks ON books.id = borrowedbooks.id " +
                           "WHERE borrowedbooks.borrowerId = @id;";

            using (MySqlCommand command = new MySqlCommand(query, SQL_SERVER))
            {
                command.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    borrowedBooksTable.Load(reader);
                }
            }
        }
    }
}
