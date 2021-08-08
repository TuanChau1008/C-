using Assi_4;
using System;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ChangeAccount : Form
    {
        public Account acc { get; set; }
        public ChangeAccount()
        {
            InitializeComponent();
        }
        public ChangeAccount(Account account)
        {
            InitializeComponent();
            acc = account;
            txtUserChange.Text = acc.EmpID1;
            txtPasswordChange.Text = acc.EmpPassword1;
            txtRole.Text = acc.EmpRole1.ToString();
            txtUserChange.Enabled = false;
            txtRole.Enabled = false;

        }



        private void btnChange_Click(object sender, EventArgs e)
        {
            AccountDB accountDB = new AccountDB();
            acc.EmpPassword1 = txtPasswordChange.Text;
            accountDB.ChangePassword(acc);

        }

        private void ChangeAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
