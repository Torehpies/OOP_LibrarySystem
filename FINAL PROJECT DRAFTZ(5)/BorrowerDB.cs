using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    internal static class BorrowerDB
    {
        public static bool DoesMemberExists(string id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM members WHERE id = @id", LoginDatabase.SQL_SERVER);
            cmd.Parameters.AddWithValue("@id", id);

            LoginDatabase.start();
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.Read()) return true;
                else return false;
            }
            finally
            {
                reader.Close();
                LoginDatabase.SQL_SERVER.Close();
            }

        }
        public static Member GetMemberDetails(string id)
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM members WHERE id = @id", LoginDatabase.SQL_SERVER);
            cmd.Parameters.AddWithValue("@id", id);

            LoginDatabase.start();
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    Member member = new Member(reader.GetString(0),
                                                reader.GetString(1),
                                                reader.GetString(2),
                                                reader.GetString(3),
                                                reader.GetString(4));

                    return member;
                }
            }
            finally
            {
                reader.Close();
                LoginDatabase.SQL_SERVER.Close();
            }
            return new Member();

        }
    }
}
