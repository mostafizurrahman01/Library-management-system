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
    public partial class ReturnBooksForm : Form
    {
        public ReturnBooksForm()
        {
            InitializeComponent();
        }

        private void btnExitReturnBooksForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning
                ) == DialogResult.OK)
            {
                this.Close();
            }

            AdminPage.multiWindows6 = 0;
            LibrarianPageForm.multiWindows6 = 0;
        }

        private void btnSearchStudentReturnBooksForm_Click(object sender, EventArgs e)
        {
            Operation operationReturnBooks = new Operation();

            string stdId = txtStudentIdReturnBooksForm.Text;

            SqlDataAdapter sDA = operationReturnBooks.stdSearchForRtnBooks(stdId);
            DataSet DS = new DataSet();

            sDA.Fill(DS);

            if(DS.Tables[0].Rows.Count != 0)
            {
                dgvReturnBooksForm.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid Id or No book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ReturnBooksForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtStudentIdReturnBooksForm.Clear();
        }

        string bookName;
        string bookDate;
        Int64 rowId;
        private void dgvReturnBooksForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;

            if(dgvReturnBooksForm.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowId = Int64.Parse(dgvReturnBooksForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                bookName = dgvReturnBooksForm.Rows[e.RowIndex].Cells[7].Value.ToString();
                bookDate = dgvReturnBooksForm.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBooksNameReturnBooksForm.Text = bookName;
            txtBookIssueDateReturnForm.Text = bookDate;
        }

        private void btnReturnBooksForm_Click(object sender, EventArgs e)
        {
            Operation operationReturnBooks = new Operation();

            string book_return_date = dtpBookReturnDateReturnBooksForm.Text;
            string stdId = txtStudentIdReturnBooksForm.Text;


            int flag = operationReturnBooks.returnBooksFixed(book_return_date,stdId,rowId);
           

            if (flag > 0)
            {
                MessageBox.Show("Return Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReturnBooksForm_Load(this, null);
            }
            else
            {
                MessageBox.Show("Something is wrong! Please try again later..");
            }
         
        }

        private void txtStudentIdReturnBooksForm_TextChanged(object sender, EventArgs e)
        {
            if(txtStudentIdReturnBooksForm.Text == "")
            {
                panel1.Visible = false;
                dgvReturnBooksForm.DataSource = null;
            }
        }

        private void btnRefreshReturnBooksForm_Click(object sender, EventArgs e)
        {
            txtStudentIdReturnBooksForm.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

    }
}
