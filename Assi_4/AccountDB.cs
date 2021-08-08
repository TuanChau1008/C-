using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assi_4
{
    public class AccountDB
    {
        string StringConnection = @"server=JUNZHU;database=BookStore;uid=sa;pwd=12345";

        public Account CheckLogin(string userName, string password)
        {
            SqlConnection con = new SqlConnection(StringConnection);
            string sql = "Select EmpID, EmpPassword, EmpRole from Employee where EmpID = @id and EmpPassword = @password";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", userName);
            cmd.Parameters.AddWithValue("@password", password);
            con.Open();
            SqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    string username = dataReader.GetString(0);
                    string pass = dataReader.GetString(1);
                    Boolean role = (bool)dataReader["EmpRole"];
                    Account account = new Account(username, pass, role);
                    return account;

                }
            }
            return null;
        }

        public void ChangePassword(Account account)
        {
            SqlConnection con = new SqlConnection(StringConnection);
            string sql = "Update Employee set EmpPassword = @password where EmpID = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@password",account.EmpPassword1 );
            cmd.Parameters.AddWithValue("@id", account.EmpID1);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successful");
        }

    }
}
