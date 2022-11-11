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
    public partial class StudentInformationForm : Form
    {
        public StudentInformationForm()
        {
            InitializeComponent();
        }

        private void btnCancelStudentInformationForm_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPage.multiWindows4 = 0;
        }


        private void StudentInformationForm_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            Operation operationStudents = new Operation();
            SqlDataAdapter allStudent = operationStudents.studentLoad();
            DataSet ds = new DataSet();
            allStudent.Fill(ds);
            dgvStudentInformation.DataSource = ds.Tables[0];
        }

        
        private void txtIdTopStudentInformation_TextChanged(object sender, EventArgs e)
        {
            Operation operationStudent = new Operation();
            SqlDataAdapter studentSearch = operationStudent.studentSearch(txtIdTopStudentInformation.Text);
            if (txtIdTopStudentInformation.Text != "")
            {
                DataSet ds = new DataSet();
                studentSearch.Fill(ds);

                dgvStudentInformation.DataSource = ds.Tables[0];
            }

            else
            {
                SqlDataAdapter allStudent = operationStudent.studentLoad();
                DataSet ds = new DataSet();
                allStudent.Fill(ds);
                dgvStudentInformation.DataSource = ds.Tables[0];

            }
        }

        private void btnRefreshStudentInformation_Click(object sender, EventArgs e)
        {
            txtIdTopStudentInformation.Clear();
            panel2.Visible = false;
        }

        string rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EntitiesStudent entitiesStudent = new EntitiesStudent();
            if(dgvStudentInformation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                entitiesStudent.StdId = dgvStudentInformation.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            panel2.Visible = true;

            Operation operationStudent = new Operation();
            SqlDataAdapter clickStudentShow = operationStudent.clickStudentShow(entitiesStudent.StdId);
            DataSet das = new DataSet();
            clickStudentShow.Fill(das);

            rowId = das.Tables[0].Rows[0][0].ToString();

            txtStudentNameStudentInformationForm.Text = das.Tables[0].Rows[0][1].ToString();
            txtStudentIdStudentInformationForm.Text = das.Tables[0].Rows[0][0].ToString();
            txtStudentEmailStudentInformationForm.Text = das.Tables[0].Rows[0][2].ToString();
            txtStudentDepartmentStudentInformationForm.Text = das.Tables[0].Rows[0][3].ToString();
            txtStudentSemesterStudentInformationForm.Text = das.Tables[0].Rows[0][4].ToString();
            txtStudentMobileNumberStudentInformationForm.Text = das.Tables[0].Rows[0][5].ToString();
        }

        private void btnUpdateStudentInformationForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm to Update This Data?", "Success", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question) == DialogResult.OK)
            {
                EntitiesStudent entitiesStudent = new EntitiesStudent();
                Operation operationStudent = new Operation();

                entitiesStudent.StdId = txtStudentIdStudentInformationForm.Text; ;
                entitiesStudent.StdName = txtStudentNameStudentInformationForm.Text;
                entitiesStudent.StdEmail = txtStudentEmailStudentInformationForm.Text;
                entitiesStudent.StdDept = txtStudentDepartmentStudentInformationForm.Text;
                entitiesStudent.StdSemester = txtStudentSemesterStudentInformationForm.Text;
                entitiesStudent.StdMobileNum = txtStudentMobileNumberStudentInformationForm.Text;


                int flag = operationStudent.studentInformationUpdate(entitiesStudent,rowId);
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

        private void btnDeleteStudentInformationForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm to Delete This Data?", "Confirmation Dialog",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                EntitiesStudent entitiesStudent = new EntitiesStudent();
                Operation operationStudent = new Operation();

                entitiesStudent.StdId = txtStudentIdStudentInformationForm.Text; ;
                entitiesStudent.StdName = txtStudentNameStudentInformationForm.Text;
                entitiesStudent.StdEmail = txtStudentEmailStudentInformationForm.Text;
                entitiesStudent.StdDept = txtStudentDepartmentStudentInformationForm.Text;
                entitiesStudent.StdSemester = txtStudentSemesterStudentInformationForm.Text;
                entitiesStudent.StdMobileNum = txtStudentMobileNumberStudentInformationForm.Text;

                int flag = operationStudent.studentInformationDelete(rowId);
                if (flag > 0)
                {
                    MessageBox.Show("Successfully Students Deleted");
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
