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
    public class BooksDB
    {
        string StringConnection = @"server=JUNZHU;database=BookStore;uid=sa;pwd=12345";

        public List<Books> BooksList()
        {
            SqlConnection con = new SqlConnection(StringConnection);
            List<Books> booklist = new List<Books>();
            string SQL = "Select BookID, BookName, BookPrice, BookQuantity from Books";
            SqlCommand cmd = new SqlCommand(SQL, con);
            con.Open();
            SqlDataReader data = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (data.Read())
            {
                int id = data.GetInt32(0);
                string bookName = data.GetString(1);
                float price = (float)(double)data["BookPrice"];
                int quantity = data.GetInt32(3);
                Books book = new Books(id, bookName, price, quantity);
                booklist.Add(book);

            }
            return booklist;
        }
        public void AddNew(Books book)
        {
            SqlConnection con = new SqlConnection(StringConnection);
            string SQL = "Insert Books values(@id, @bookName, @price, @quantity) ";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("id", book.BookID);
            cmd.Parameters.AddWithValue("bookName", book.BookName);
            cmd.Parameters.AddWithValue("price", book.BookPrice);
            cmd.Parameters.AddWithValue("quantity", book.Quantity);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(Books book)
        {
            SqlConnection con = new SqlConnection(StringConnection);
            string SQL = "Delete Books where BookID = @id";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("id", book.BookID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void Update(Books book)
        {
            SqlConnection con = new SqlConnection(StringConnection);
            string SQL = "Update Books Set BookName = @name, BookPrice = @price, BookQuantity= @quantity where BookID = @id";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("id", book.BookID);
            cmd.Parameters.AddWithValue("name", book.BookName );
            cmd.Parameters.AddWithValue("price",book.BookPrice);
            cmd.Parameters.AddWithValue("quantity", book.Quantity );
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<Books> Search(string bookName)
        {
            List<Books> listsearch = new List<Books>();
            SqlConnection con = new SqlConnection(StringConnection);
            string SQL = "select BookID, BookName, BookPrice, BookQuantity from Books where BookName like '%'+@name+'%' ";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@name", bookName);
            con.Open();
            SqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    int bookID = dataReader.GetInt32(0);
                    string name = dataReader.GetString(1);
                    float price = (float)(double)dataReader["BookPrice"];
                    int quantity = dataReader.GetInt32(3);
                    Books books = new Books(bookID, name, price, quantity);
                    listsearch.Add(books);

                }
            }
            return listsearch;

        }
        public void sortBook(List<Books> listsearch)
        {
            Books temp;
            for (int i = 0; i < listsearch.Count; i++)
            {
                for (int j = i + 1; j < listsearch.Count; j++)
                {
                    if (listsearch[i].BookPrice < listsearch[j].BookPrice)
                    {
                        temp = listsearch[i];
                        listsearch[i] = listsearch[j];
                        listsearch[j] = temp;
                    }
                }
            }
        }
    }
}
