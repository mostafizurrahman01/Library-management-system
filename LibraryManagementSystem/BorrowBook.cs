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
    public partial class BorrowBookForm : Form
    {
        public BorrowBookForm()
        {
            InitializeComponent();
        }
        int count;
        private void btnEnterBorrowBookForm_Click(object sender, EventArgs e)
        {
            Operation operationIssueBooks = new Operation();

            if (txtStudentIdBorrowBookForm.Text != "")
            {
                string stdId = txtStudentIdBorrowBookForm.Text;

                SqlDataAdapter sDA = operationIssueBooks.showStdInfoIssueBooks(stdId);
                DataSet DS = new DataSet();
                sDA.Fill(DS);

                //books issued count based on the id number
                SqlDataAdapter sDA1 = operationIssueBooks.studentIssueBooksCount(stdId);
                DataSet DS1 = new DataSet();
                sDA1.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());


                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtStudentNameBorrowBookForm.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtStudentEmailBorrowBookForm.Text = DS.Tables[0].Rows[0][2].ToString();
                    txtStudentDepartmentBorrowBookForm.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtStudentSemesterBorrowBookForm.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtStudentMobileNumberBorrowBookForm.Text = DS.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    txtStudentNameBorrowBookForm.Clear();
                    txtStudentEmailBorrowBookForm.Clear();
                    txtStudentDepartmentBorrowBookForm.Clear();
                    txtStudentSemesterBorrowBookForm.Clear();
                    txtStudentMobileNumberBorrowBookForm.Clear();

                    MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            Operation operationIssueBooks = new Operation();
            SqlDataReader sDR = operationIssueBooks.issueBooksComboBox();

            while (sDR.Read())
            {
                for (int i = 0; i < sDR.FieldCount; i++)
                {
                    cobBookNameBorrowBook.Items.Add(sDR.GetString(i));
                }
            }
            sDR.Close();
        }

        private void btnExitBorrowBookForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning
               ) == DialogResult.OK)
            {
                this.Close();
            }


            HomePageForm.multiWindows1 = 0;
        }

        private void btnBorrowBooksForm_Click(object sender, EventArgs e)
        {
            if (txtStudentNameBorrowBookForm.Text != "")
            {
                if (cobBookNameBorrowBook.SelectedIndex != -1 && count <= 1)
                {
                    EntitiesIssueBooks entitiesIssueBooks = new EntitiesIssueBooks();
                    Operation operationIssueBooks = new Operation();

                    entitiesIssueBooks.StdId = txtStudentIdBorrowBookForm.Text;
                    entitiesIssueBooks.StdName = txtStudentNameBorrowBookForm.Text;
                    entitiesIssueBooks.StdEmail = txtStudentEmailBorrowBookForm.Text;
                    entitiesIssueBooks.StdDept = txtStudentDepartmentBorrowBookForm.Text;
                    entitiesIssueBooks.StdSemester = txtStudentSemesterBorrowBookForm.Text;
                    entitiesIssueBooks.StdMobileNum = txtStudentMobileNumberBorrowBookForm.Text;
                    entitiesIssueBooks.BookName = cobBookNameBorrowBook.Text;
                    entitiesIssueBooks.BookIssueDate = dtpBookBorrowBookForm.Text;

                    string stdId = txtStudentIdBorrowBookForm.Text;

                    int flag = operationIssueBooks.recordIssueBooks(entitiesIssueBooks);

                    if (flag > 0)
                    {
                        MessageBox.Show("Book Issued Successfully", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something is error");
                    }
                }
                else
                {
                    MessageBox.Show("Select Book or Maximum Number of Book has been issued ", "No book selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter valid student no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshBorrowBookForm_Click(object sender, EventArgs e)
        {
            txtStudentIdBorrowBookForm.Clear();
        }

        private void txtStudentIdBorrowBookForm_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentIdBorrowBookForm.Text == "")
            {
                txtStudentNameBorrowBookForm.Clear();
                txtStudentEmailBorrowBookForm.Clear();
                txtStudentDepartmentBorrowBookForm.Clear();
                txtStudentSemesterBorrowBookForm.Clear();
                txtStudentMobileNumberBorrowBookForm.Clear();
            }
        }
    }
}
