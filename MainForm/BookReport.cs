using Assi_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class BookReport : Form
    {
        public List<Books> searchBooks { get; set; }
        public BookReport()
        {
            InitializeComponent();
        }
        public void LoadDataSearch()
        {
            List<Books> datasearch = searchBooks;
            for (int i = 0; i < datasearch.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgvSortData.Rows[0].Clone();
                row.Cells[0].Value = datasearch.ElementAt(i).BookID;
                row.Cells[1].Value = datasearch.ElementAt(i).BookName;
                row.Cells[2].Value = datasearch.ElementAt(i).BookPrice;
                row.Cells[3].Value = datasearch.ElementAt(i).Quantity;
                dgvSortData.Rows.Add(row);
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            BooksDB booksDB = new BooksDB();
            booksDB.sortBook(searchBooks);
            dgvSortData.Rows.Clear();
            LoadDataSearch();
            
        }

        private void BookReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MaintainBooks maintainBooks = new MaintainBooks();
            maintainBooks.ShowDialog();
            Application.Exit();
        }
    }
}
