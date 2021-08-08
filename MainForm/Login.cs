using Assi_4;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        AccountDB accountDB = new AccountDB();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            Account account = accountDB.CheckLogin(userName, password);
            if ( account != null)
            {
                if(account.EmpRole1 == true)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    MaintainBooks mb = new MaintainBooks();
                    mb.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Login Fail!");
                    this.Hide();
                    ChangeAccount change = new ChangeAccount(account);
                    change.ShowDialog();
                    Application.Exit();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
