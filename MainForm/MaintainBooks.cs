using Assi_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MaintainBooks : Form
    {
        public MaintainBooks()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            List<Books> list = new BooksDB().BooksList();
            dgvData.Rows.Clear();
            for (int i = 0; i < new BooksDB().BooksList().Count; i++)
            {
                DataGridViewRow viewRow = (DataGridViewRow)dgvData.Rows[0].Clone();
                viewRow.Cells[0].Value = list.ElementAt(i).BookID;
                viewRow.Cells[1].Value = list.ElementAt(i).BookName;
                viewRow.Cells[2].Value = list.ElementAt(i).BookPrice;
                viewRow.Cells[3].Value = list.ElementAt(i).Quantity;
                dgvData.Rows.Add(viewRow);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BooksDB booksDB = new BooksDB();
            Books books = new Books();
            books.BookID = int.Parse(txtBookID.Text);
            books.BookName = txtBookName.Text;
            books.BookPrice = float.Parse(txtPrice.Text);
            books.Quantity = int.Parse(txtQuantity.Text);
            booksDB.AddNew(books);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BooksDB prodb = new BooksDB();
            Books books = new Books();
            books.BookID = int.Parse(txtBookID.Text);
            prodb.Delete(books);
            dgvData.Rows.Clear();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BooksDB booksDB = new BooksDB();
            Books books = new Books();
            books.BookID = int.Parse(txtBookID.Text);
            books.BookName = txtBookName.Text;
            books.BookPrice = float.Parse(txtPrice.Text);
            books.Quantity = int.Parse(txtQuantity.Text);
            booksDB.Update(books);
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
         
            BooksDB booksDB = new BooksDB();
            string bookName = txtBookName.Text;
            booksDB.Search(bookName);
            this.Hide();
            BookReport bookReport = new BookReport();
            bookReport.searchBooks = booksDB.Search(bookName);
            bookReport.LoadDataSearch();
            bookReport.ShowDialog();
            
        }

        private void MaintainBooks_Load(object sender, EventArgs e)
        {

        }

        private void dgvData_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dr = dgvData.SelectedRows;
            txtBookID.Text = dr[0].Cells[0].Value.ToString();
            txtBookName.Text = dr[0].Cells[1].Value.ToString();
            txtPrice.Text = dr[0].Cells[2].Value.ToString();
            txtQuantity.Text = dr[0].Cells[3].Value.ToString();
        }

        private void dgvData_CurrentCellChanged(object sender, EventArgs e)
        {
            if(dgvData.CurrentRow != null)
            {
                txtBookID.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
                txtBookName.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
                txtQuantity.Text = dgvData.CurrentRow.Cells[3].Value.ToString();
                btnNext.Enabled = dgvData.CurrentRow.Index < dgvData.Rows.Count - 2;
                btnPrivious.Enabled = dgvData.CurrentRow.Index > 0;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            dgvData.CurrentCell = dgvData.Rows[0].Cells[dgvData.CurrentCell.ColumnIndex];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int next = dgvData.CurrentRow.Index + 1;
            dgvData.CurrentCell = dgvData.Rows[next].Cells[dgvData.CurrentCell.ColumnIndex];

        }

        private void btnPrivious_Click(object sender, EventArgs e)
        {
            int privious = dgvData.CurrentRow.Index - 1;
            dgvData.CurrentCell = dgvData.Rows[privious].Cells[dgvData.CurrentCell.ColumnIndex];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int last = dgvData.Rows.Count -2;
            dgvData.CurrentCell = dgvData.Rows[last].Cells[dgvData.CurrentCell.ColumnIndex];
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MaintainBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            Application.Exit();
        }
    }
}
