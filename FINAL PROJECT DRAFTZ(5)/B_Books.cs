using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class B_Books : UserControl
    {
        private DataTable originalDataTable;

        public B_Books()
        {
            InitializeComponent();
            listView1.Region = Region.FromHrgn(RoundEdge.CreateRoundRectRgn(0, 0, listView1.Width, listView1.Height, 30, 30));
            originalDataTable = new DataTable();
            LoadUsersData();
        }

        private void LoadUsersData()
        {
            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=test; password=;Convert Zero Datetime=True"))
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT b.isbn, b.title, b.author, m.name, bb.borrowDate, bb.dueDate, returnDate FROM BorrowedBooks bb INNER JOIN Books b ON bb.bookId = b.id INNER JOIN Members m ON bb.borrowerId = m.id", con);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                listView1.View = View.Details;
                listView1.Columns[0].Width = -1;
                listView1.Columns[1].Width = 450;
                listView1.Columns[2].Width = 170;
                listView1.Columns[3].Width = 170;
                listView1.Columns[4].Width = 100;
                listView1.Columns[5].Width = 100;

                foreach (DataRow dr in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["isbn"].ToString());
                    item.SubItems.Add(dr["title"].ToString());
                    item.SubItems.Add(dr["author"].ToString());
                    item.SubItems.Add(dr["name"].ToString());
                    item.SubItems.Add(((DateTime)dr["borrowDate"]).ToString("yyyy-MM-dd"));
                    item.SubItems.Add(((DateTime)dr["dueDate"]).ToString("yyyy-MM-dd"));

                    item.SubItems.Add(dr["returnDate"] == DBNull.Value ? "BORROWED" : ((DateTime)dr["returnDate"]).ToString("yyyy-MM-dd"));


                    //item.SubItems.Add(((DateTime)dr["returnDate"]).ToString("yyyy-MM-dd"));
                    listView1.Items.Add(item);
                }
            }
        }

        private void UpdateListView(DataTable dataTable)
        {
            listView1.Items.Clear();
            foreach (DataRow dr in dataTable.Rows)
            {
                ListViewItem listitem = new ListViewItem(dr["isbn"].ToString());
                listitem.SubItems.Add(dr["title"].ToString());
                listitem.SubItems.Add(dr["author"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["borrowDate"].ToString());
                listitem.SubItems.Add(dr["dueDate"].ToString());

                if (dr["returnDate"] == DBNull.Value)
                {
                    listitem.SubItems.Add("BORROWED");
                }
                else
                {
                    listitem.SubItems.Add(Convert.ToDateTime(dr["returnDate"]).ToString("yyyy-MM-dd HH:mm:ss"));
                }


                listView1.Items.Add(listitem);
            }
        }

        private void B_Books_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void B_Books_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ResetListView()
        {
            listView1.Items.Clear();
            LoadUsersData();
        }

        private void sortComboBox()
        {
            // Run sum query
            //datePicker;
            MessageBox.Show(sortCombo.Text);
            string searchText = sortCombo.Text.Trim();
            string query = "";
            if (searchText == "BORROWED BOOKS")
            {
                query = "SELECT bb.*, b.isbn, b.title, b.author, m.name FROM `borrowedbooks` bb JOIN books b ON bb.bookId = b.id JOIN members m ON bb.borrowerId = m.id WHERE bb.returnDate IS NULL";
            }
            else if (searchText == "RETURNED BOOKS")
            {
                query = "SELECT bb.*, b.isbn, b.title, b.author, m.name FROM `borrowedbooks` bb JOIN books b ON bb.bookId = b.id JOIN members m ON bb.borrowerId = m.id WHERE bb.returnDate IS NOT NULL";
            }
            else
            {
                query = "SELECT bb.*, b.isbn, b.title, b.author, m.name FROM `borrowedbooks` bb JOIN books b ON bb.bookId = b.id JOIN members m ON bb.borrowerId = m.id";
            }


            if (string.IsNullOrEmpty(searchText))
            {
                ResetListView();
                return;
            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=test; password="))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    DataTable filteredDataTable = new DataTable();
                    adapter.Fill(filteredDataTable);

                    UpdateListView(filteredDataTable);
                }
            }
        }

        private void searchFilter()
        {
            string searchText = textBox1.Text.Trim();
            string query = "";

            if (sortCombo.Text == "BORROWED BOOKS")
            {
                query = $"SELECT bb.bookId, bb.borrowerId, " +
                $"DATE_FORMAT(bb.borrowDate, '%Y-%m-%d %H:%i:%s') AS borrowDate, " +
                $"DATE_FORMAT(bb.returnDate, '%Y-%m-%d %H:%i:%s') AS returnDate, " +
                $"DATE_FORMAT(bb.dueDate, '%Y-%m-%d %H:%i:%s') AS dueDate, " +
                $"b.isbn AS ISBN, b.title AS Title, b.author AS Author, " +
                $"m.name AS Name " +
                $"FROM borrowedbooks bb " +
                $"INNER JOIN books b ON bb.bookId = b.id " +
                $"INNER JOIN members m ON bb.borrowerId = m.id " +
                $"WHERE " +
                $"LOWER(m.name) LIKE '%{searchText.ToLower()}%'" +
                "IS NULL";

            }
            else if (sortCombo.Text == "RETURNED BOOKS")
            {
                query = $"SELECT bb.bookId, bb.borrowerId, " +
                $"DATE_FORMAT(bb.borrowDate, '%Y-%m-%d %H:%i:%s') AS borrowDate, " +
                $"DATE_FORMAT(bb.returnDate, '%Y-%m-%d %H:%i:%s') AS returnDate, " +
                $"DATE_FORMAT(bb.dueDate, '%Y-%m-%d %H:%i:%s') AS dueDate, " +
                $"b.isbn AS ISBN, b.title AS Title, b.author AS Author, " +
                $"m.name AS Name " +
                $"FROM borrowedbooks bb " +
                $"INNER JOIN books b ON bb.bookId = b.id " +
                $"INNER JOIN members m ON bb.borrowerId = m.id " +
                $"WHERE " +
                $"LOWER(m.name) LIKE '%{searchText.ToLower()}%'" +
                "IS NOT NULL";
            }
            else
            {
                query = $"SELECT bb.bookId, bb.borrowerId, " +
                $"DATE_FORMAT(bb.borrowDate, '%Y-%m-%d %H:%i:%s') AS borrowDate, " +
                $"DATE_FORMAT(bb.returnDate, '%Y-%m-%d %H:%i:%s') AS returnDate, " +
                $"DATE_FORMAT(bb.dueDate, '%Y-%m-%d %H:%i:%s') AS dueDate, " +
                $"b.isbn AS ISBN, b.title AS Title, b.author AS Author, " +
                $"m.name AS Name " +
                $"FROM borrowedbooks bb " +
                $"INNER JOIN books b ON bb.bookId = b.id " +
                $"INNER JOIN members m ON bb.borrowerId = m.id " +
                $"WHERE " +
                $"LOWER(m.name) LIKE '%{searchText.ToLower()}%'";

            }

            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=test; password="))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {

                    DataTable filteredDataTable = new DataTable();
                    adapter.Fill(filteredDataTable);


                    UpdateListView(filteredDataTable);

                }
            }
        }

        private void selectedIndexChange(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0)
            {
                //MessageBox.Show("Text box is empty");
                sortComboBox();
            }
            else
            {
                //MessageBox.Show("Text box is not empty");

                string searchText = textBox1.Text.Trim();

                // Kapag nag select lang ng shet tapos wala namang searchtext
                if (sortCombo.SelectedIndex >= 0)
                {
                    sortComboBox();
                    return;
                }

                // Kapag nag select sa combo box at may searchbox
                else if (sortCombo.SelectedIndex < -1 && searchText.Length > 0)
                {
                    searchFilter();
                    return;
                }

                // Kapag searhbox lang
                else
                {
                    string query = $"SELECT bb.bookId, bb.borrowerId, " +
                     $"DATE_FORMAT(bb.borrowDate, '%Y-%m-%d %H:%i:%s') AS borrowDate, " +
                     $"DATE_FORMAT(bb.returnDate, '%Y-%m-%d %H:%i:%s') AS returnDate, " +
                     $"DATE_FORMAT(bb.dueDate, '%Y-%m-%d %H:%i:%s') AS dueDate, " +
                     $"b.isbn AS ISBN, b.title AS Title, b.author AS Author, " +
                     $"m.name AS Name " +
                     $"FROM borrowedbooks bb " +
                     $"INNER JOIN books b ON bb.bookId = b.id " +
                     $"INNER JOIN members m ON bb.borrowerId = m.id " +
                     $"WHERE " +
                     $"LOWER(m.name) LIKE '%{searchText.ToLower()}%' OR " +
                     $"DATE_FORMAT(bb.borrowDate, '%Y-%m-%d %H:%i:%s') LIKE '%{searchText.ToLower()}%' OR " +
                     $"DATE_FORMAT(bb.returnDate, '%Y-%m-%d %H:%i:%s') LIKE '%{searchText.ToLower()}%' OR " +
                     $"DATE_FORMAT(bb.dueDate, '%Y-%m-%d %H:%i:%s') LIKE '%{searchText.ToLower()}%'";

                    using (MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=test; password="))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                        {

                            DataTable filteredDataTable = new DataTable();
                            adapter.Fill(filteredDataTable);

                            UpdateListView(filteredDataTable);
                        }
                    }
                }

                if (string.IsNullOrEmpty(searchText))
                {
                    ResetListView();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            // Kapag nag select lang ng shet tapos wala namang searchtext
            if (sortCombo.SelectedIndex >= 0)
            {
                sortComboBox();
                return;
            }

            // Kapag nag select sa combo box at may searchbox
            else if (sortCombo.SelectedIndex < -1 && searchText.Length > 0)
            {
                searchFilter();
                return;
            }

            // Kapag searhbox lang
            else
            {
                string query = $"SELECT bb.bookId, bb.borrowerId, " +
                 $"DATE_FORMAT(bb.borrowDate, '%Y-%m-%d %H:%i:%s') AS borrowDate, " +
                 $"DATE_FORMAT(bb.returnDate, '%Y-%m-%d %H:%i:%s') AS returnDate, " +
                 $"DATE_FORMAT(bb.dueDate, '%Y-%m-%d %H:%i:%s') AS dueDate, " +
                 $"b.isbn AS ISBN, b.title AS Title, b.author AS Author, " +
                 $"m.name AS Name " +
                 $"FROM borrowedbooks bb " +
                 $"INNER JOIN books b ON bb.bookId = b.id " +
                 $"INNER JOIN members m ON bb.borrowerId = m.id " +
                 $"WHERE " +
                 $"LOWER(m.name) LIKE '%{searchText.ToLower()}%' OR " +
                 $"DATE_FORMAT(bb.borrowDate, '%Y-%m-%d %H:%i:%s') LIKE '%{searchText.ToLower()}%' OR " +
                 $"DATE_FORMAT(bb.returnDate, '%Y-%m-%d %H:%i:%s') LIKE '%{searchText.ToLower()}%' OR " +
                 $"DATE_FORMAT(bb.dueDate, '%Y-%m-%d %H:%i:%s') LIKE '%{searchText.ToLower()}%'";

                using (MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=test; password="))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                    {

                        DataTable filteredDataTable = new DataTable();
                        adapter.Fill(filteredDataTable);

                        UpdateListView(filteredDataTable);
                    }
                }
            }

            if (string.IsNullOrEmpty(searchText))
            {
                ResetListView();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }

        
    }
}
