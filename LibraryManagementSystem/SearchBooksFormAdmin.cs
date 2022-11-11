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
    public partial class SearchBooksFormAdmin : Form
    {
        public SearchBooksFormAdmin()
        {
            InitializeComponent();
        }

        private void btnCancelSearchBooksForm_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        private void SearchBooksForm_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Operation operationBooks = new Operation();
            SqlDataAdapter allbook = operationBooks.bookLoad();
            DataSet ds = new DataSet();
            allbook.Fill(ds);
            dgvSearchBooks.DataSource = ds.Tables[0];
        }

        int bid;
        Int64 rowId;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearchBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dgvSearchBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;

            Operation operationBooks = new Operation();
            SqlDataAdapter clickBookShow = operationBooks.clickBookShow(bid);
            DataSet das = new DataSet();
            clickBookShow.Fill(das);

            rowId = Int64.Parse(das.Tables[0].Rows[0][0].ToString());

            txtBookNameSearchBooksForm.Text = das.Tables[0].Rows[0][1].ToString();
            txtBookAuthorNameSearchBooksForm.Text = das.Tables[0].Rows[0][2].ToString();
            txtBookPublicationSearchBooksForm.Text = das.Tables[0].Rows[0][3].ToString();
            dtpBookPurchasedDateSearchBooksForm.Text = das.Tables[0].Rows[0][4].ToString();
            txtBookPriceSearchBooksForm.Text = das.Tables[0].Rows[0][5].ToString();
            txtBookQuantitySearchBooksForm.Text = das.Tables[0].Rows[0][6].ToString();
        }

        private void txtBookNameTopSearchBook_TextChanged(object sender, EventArgs e)
        {
            Operation operationBooks = new Operation();
            SqlDataAdapter bookSearch = operationBooks.bookSearch(txtBookNameTopSearchBook.Text);
            if (txtBookNameTopSearchBook.Text != "")
            {
                DataSet ds = new DataSet();
                bookSearch.Fill(ds);

                dgvSearchBooks.DataSource = ds.Tables[0];
            }

            else
            {
                SqlDataAdapter allbook = operationBooks.bookLoad();
                DataSet ds = new DataSet();
                allbook.Fill(ds);
                dgvSearchBooks.DataSource = ds.Tables[0];
            }
        }

        private void btnRefreshSearchBook_Click(object sender, EventArgs e)
        {
            txtBookNameTopSearchBook.Clear();
            panel2.Visible = false;
        }

        private void btnUpdateSearchBooksForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm to Update This Data?", "Success", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question) == DialogResult.OK)
            {
                EntitiesBooks entitiesBooks = new EntitiesBooks();
                Operation operationBooks = new Operation();

                entitiesBooks.BookName = txtBookNameSearchBooksForm.Text;
                entitiesBooks.BookAuthor = txtBookAuthorNameSearchBooksForm.Text;
                entitiesBooks.BookPublication = txtBookPublicationSearchBooksForm.Text;
                entitiesBooks.BookPurchaseDate = dtpBookPurchasedDateSearchBooksForm.Text;
                entitiesBooks.BookPrice = txtBookPriceSearchBooksForm.Text;
                entitiesBooks.BookQuantity = txtBookQuantitySearchBooksForm.Text;

                int flag = operationBooks.searchBooksUpdate(entitiesBooks, rowId);
                if (flag > 0)
                {
                    MessageBox.Show("Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }
            }
        }

        private void btnDeleteSearchBooksForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm to Delete This Data?", "Confirmation Dialog", 
                MessageBoxButtons.OKCancel , MessageBoxIcon.Warning) == DialogResult.OK)
            {
                EntitiesBooks entitiesBooks = new EntitiesBooks();
                Operation operationBooks = new Operation();

                entitiesBooks.BookName = txtBookNameSearchBooksForm.Text;
                entitiesBooks.BookAuthor = txtBookAuthorNameSearchBooksForm.Text;
                entitiesBooks.BookPublication = txtBookPublicationSearchBooksForm.Text;
                entitiesBooks.BookPurchaseDate = dtpBookPurchasedDateSearchBooksForm.Text;
                entitiesBooks.BookPrice = txtBookPriceSearchBooksForm.Text;
                entitiesBooks.BookQuantity = txtBookQuantitySearchBooksForm.Text;

                int flag = operationBooks.booksDelete(rowId);
                if (flag > 0)
                {
                    MessageBox.Show("Successfully Books Deleted");
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
