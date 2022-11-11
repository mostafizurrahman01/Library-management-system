using DataAccessLayerSignUp.Entities;
using DataAccessLayerSignUp.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBooksForm : Form
    {
        public AddBooksForm()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelAddBooks_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPage.multiWindows1 = 0;
            LibrarianPageForm.multiWindows1 = 0;
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            EntitiesBooks entitesBooks = new EntitiesBooks();
            Operation operationBooks = new Operation();

            entitesBooks.BookName = txtBookName.Text;
            entitesBooks.BookAuthor = txtBookAuthorName.Text;
            entitesBooks.BookPublication = txtBookPublication.Text;
            entitesBooks.BookPurchaseDate = dtpBookPurchaseDate.Text;
            entitesBooks.BookPrice = txtBookPrice.Text;
            entitesBooks.BookQuantity = txtBookQuantity.Text;

            if (txtBookName.Text == "Book Name" || txtBookName.Text == "" ||
                txtBookAuthorName.Text == "Author Name" || txtBookAuthorName.Text == "" ||
                txtBookPublication.Text == "Book Publication" || txtBookPublication.Text == "" ||
                dtpBookPurchaseDate.Text == "Book Purchase Date" || dtpBookPurchaseDate.Text == "" ||
                txtBookPrice.Text == "Book Price" || txtBookPrice.Text == "" ||
                txtBookQuantity.Text == "Book Quantity" || txtBookQuantity.Text == "")
            {
                MessageBox.Show("Fill up all the requrements.");
            }
            else
            {
                SqlDataAdapter checkBookName = operationBooks.checkBookName(entitesBooks);
                DataSet ds = new DataSet();
                checkBookName.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("This Book is already exist");
                }
                else
                {
                    
                        int flag = operationBooks.addBooks(entitesBooks);
                        if (flag > 0)
                        {
                            MessageBox.Show("Successfully Book Added");
                            txtBookName.Clear();
                            txtBookAuthorName.Clear();
                            txtBookPublication.Clear();
                            txtBookPrice.Clear();
                            txtBookQuantity.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Not Inserted");
                        }
                }

            }
        }
    }
}
