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

            string query = "SELECT `members`.`name`, `members`.`details`, COUNT(`borrowedbooks`.`bookId`) AS `quantity` " +
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



        public static void DisplayBorrowedBooks(string id, out DataTable borrowedBooksTable)
        {
            start();
            borrowedBooksTable = new DataTable();

            string query = "SELECT `books`.`title`, `books`.`author`, `borrowedbooks`.`dueDate`, `members`.`name`, `members`.`details`, `borrowedbooks`.`quantity`" +
                           "FROM `books`" +
                           "LEFT JOIN `borrowedbooks` ON `borrowedbooks`.`bookId` = `books`.`id`" +
                           "LEFT JOIN `members` ON `borrowedbooks`.`borrowerId` = `members`.`id`" +
                           "WHERE borrowedbooks.borrowerId = @id AND borrowedbooks.returnDate is null";

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
