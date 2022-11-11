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
    public partial class IssueBooksForm : Form
    {
        public IssueBooksForm()
        {
            InitializeComponent();
        }

        private void btnExitIssueBooksForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning
                )== DialogResult.OK)
            {
                this.Close();
            }
            

            AdminPage.multiWindows5 = 0;
            LibrarianPageForm.multiWindows5 = 0;
        }

        private void IssueBooksForm_Load(object sender, EventArgs e)
        {
            Operation operationIssueBooks = new Operation();
            SqlDataReader sDR = operationIssueBooks.issueBooksComboBox();

            while (sDR.Read())
            {
                for(int i = 0; i <sDR.FieldCount; i++)
                {
                    cobBookNameIssueBooksForm.Items.Add(sDR.GetString(i));
                }
            }
            sDR.Close();
            
           

        }

        int count;

        private void btnSearchStudentIssueBooksForm_Click(object sender, EventArgs e)
        {
            Operation operationIssueBooks = new Operation();

            if(txtStudentIdIssueBooksForm.Text != "")
            {
                string stdId = txtStudentIdIssueBooksForm.Text;

                SqlDataAdapter sDA = operationIssueBooks.showStdInfoIssueBooks(stdId);
                DataSet DS = new DataSet();
                sDA.Fill(DS);

                //books issued count based on the id number
                SqlDataAdapter sDA1 = operationIssueBooks.studentIssueBooksCount(stdId);
                DataSet DS1 = new DataSet();
                sDA1.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());


                if(DS.Tables[0].Rows.Count != 0)
                {
                    txtStudentNameIssueBooksForm.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtStudentEmailIssueBooksForm.Text = DS.Tables[0].Rows[0][2].ToString();
                    txtStudentDepartmentIssueBooksForm.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtStudentSemesterIssueBooksForm.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtStudentMobileNumberIssueBooksForm.Text = DS.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    txtStudentNameIssueBooksForm.Clear();
                    txtStudentEmailIssueBooksForm.Clear();
                    txtStudentDepartmentIssueBooksForm.Clear();
                    txtStudentSemesterIssueBooksForm.Clear();
                    txtStudentMobileNumberIssueBooksForm.Clear();

                    MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private void btnRefreshIssueBooksForm_Click(object sender, EventArgs e)
        {
            txtStudentIdIssueBooksForm.Clear();

        }

        private void txtStudentIdIssueBooksForm_TextChanged(object sender, EventArgs e)
        {
            if(txtStudentIdIssueBooksForm.Text == "")
            {
                txtStudentNameIssueBooksForm.Clear();
                txtStudentEmailIssueBooksForm.Clear();
                txtStudentDepartmentIssueBooksForm.Clear();
                txtStudentSemesterIssueBooksForm.Clear();
                txtStudentMobileNumberIssueBooksForm.Clear();
            }
        }

        private void btnIssueBooksForm_Click(object sender, EventArgs e)
        {
            if (txtStudentNameIssueBooksForm.Text != "")
            {
                if (cobBookNameIssueBooksForm.SelectedIndex != -1 && count <= 1)
                {
                    EntitiesIssueBooks entitiesIssueBooks = new EntitiesIssueBooks();
                    Operation operationIssueBooks = new Operation();

                    entitiesIssueBooks.StdId = txtStudentIdIssueBooksForm.Text;
                    entitiesIssueBooks.StdName = txtStudentNameIssueBooksForm.Text;
                    entitiesIssueBooks.StdEmail = txtStudentEmailIssueBooksForm.Text;
                    entitiesIssueBooks.StdDept = txtStudentDepartmentIssueBooksForm.Text;
                    entitiesIssueBooks.StdSemester = txtStudentSemesterIssueBooksForm.Text;
                    entitiesIssueBooks.StdMobileNum = txtStudentMobileNumberIssueBooksForm.Text;
                    entitiesIssueBooks.BookName = cobBookNameIssueBooksForm.Text;
                    entitiesIssueBooks.BookIssueDate = dtpBookIssueDateIssueBooksForm.Text;

                    string stdId = txtStudentIdIssueBooksForm.Text;

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
    }
}
