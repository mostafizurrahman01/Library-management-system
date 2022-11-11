using DataAccessLayerSignUp.Entities;
using DataAccessLayerSignUp.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnCloseStudentForm_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Confirm?","Alert",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
            AdminPage.multiWindows3 = 0;
            LibrarianPageForm.multiWindows3 = 0;
        }

        private void btnSaveAddStudentForm_Click(object sender, EventArgs e)
        {
            EntitiesStudent entitiesStudent = new EntitiesStudent();
            Operation operationStudent = new Operation();

            entitiesStudent.StdName = txtStudentName.Text;
            entitiesStudent.StdId = txtStudentId.Text;
            entitiesStudent.StdEmail = txtStudentEmail.Text;
            entitiesStudent.StdDept = txtStudentDepartment.Text;
            entitiesStudent.StdSemester = txtStudentSemester.Text;
            entitiesStudent.StdMobileNum = txtStudentMobileNumber.Text;
            entitiesStudent.StdUsername = txtstdUsernameAdminForm.Text;

            if (txtStudentName.Text == "Student Name" || txtStudentName.Text == "" ||
                txtStudentId.Text == "Student ID" || txtStudentId.Text == "" ||
                txtStudentEmail.Text == "Student Email" || txtStudentEmail.Text == "" ||
                txtStudentDepartment.Text == "Student Department" || txtStudentDepartment.Text == "" ||
                txtStudentSemester.Text == "Student Semester" || txtStudentSemester.Text == "" ||
                txtStudentMobileNumber.Text == "Student Mobile Number" || txtStudentMobileNumber.Text == "" ||
                txtstdUsernameAdminForm.Text == "Student Username" || txtstdUsernameAdminForm.Text == "")
            {
                MessageBox.Show("Please Fill up all the requrements.","Suggest",MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

            }

            else
            {
                int flag = operationStudent.addStudent(entitiesStudent);

                if (flag > 0)
                {
                    MessageBox.Show("Data Saved","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtStudentName.Clear();
                    txtStudentId.Clear();
                    txtStudentEmail.Clear();
                    txtStudentDepartment.Clear();
                    txtStudentSemester.Clear();
                    txtStudentMobileNumber.Clear();
                    txtstdUsernameAdminForm.Clear();

                }
                else
                {
                    MessageBox.Show("Something is error");
                }

            }
        }

        private void btnRefreshAddStudentForm_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtStudentId.Clear();
            txtStudentEmail.Clear();
            txtStudentDepartment.Clear();
            txtStudentSemester.Clear();
            txtStudentMobileNumber.Clear();
            txtstdUsernameAdminForm.Clear();
        }
    }
}
