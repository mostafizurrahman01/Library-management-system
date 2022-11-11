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
    public partial class StudentProfileForm : Form
    {
        public StudentProfileForm()
        {
            InitializeComponent();
        }

        private void btnCloseStudentProfileForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                
            }

            HomePageForm.multiWindows3 = 0;
           
        }
        private void StudentProfileForm_Load(object sender, EventArgs e)
        {
            Operation operationStudentProfile = new Operation();
            
            SqlDataAdapter sDA = operationStudentProfile.studentProfile();

            DataSet ds = new DataSet();
            sDA.Fill(ds, "StudentsTable");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                
                txtNameStudentProfileForm.Text = ds.Tables["StudentsTable"].Rows[i]["stdName"].ToString();
                txtIDStudentProfileForm.Text = ds.Tables["StudentsTable"].Rows[i]["stdID"].ToString();
                txtSemesterNoStudentProfileForm.Text = ds.Tables["StudentsTable"].Rows[i]["stdSemester"].ToString();
                txtDepartmentStudentProfileForm.Text = ds.Tables["StudentsTable"].Rows[i]["stdDept"].ToString();
            }
           


            
        }

        
    }
   }
