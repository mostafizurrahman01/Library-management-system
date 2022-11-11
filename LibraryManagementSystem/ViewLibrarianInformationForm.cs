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
    public partial class ViewLibrarianInformationForm : Form
    {
        public ViewLibrarianInformationForm()
        {
            InitializeComponent();
        }

        private void ViewLibrarianInformationForm_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Operation operationLibrarian = new Operation();
            SqlDataAdapter allLibrarian = operationLibrarian.librarianLoad();
            DataSet ds = new DataSet();
            allLibrarian.Fill(ds);
            dgvLibrarianInfo.DataSource = ds.Tables[0];
        }


        string rowId;
        private void dgvLibrarianInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EntitiesLibrarian entitiesLibrarian = new EntitiesLibrarian();

            if (dgvLibrarianInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                entitiesLibrarian.LibrarianID = dgvLibrarianInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            panel2.Visible = true;

            Operation operationLibrarian = new Operation();
            SqlDataAdapter clicklibrarianShow = operationLibrarian.clicklibrarianShow(entitiesLibrarian.LibrarianID);
            DataSet das = new DataSet();
            clicklibrarianShow.Fill(das);

            rowId = das.Tables[0].Rows[0][0].ToString();

            txtLibrarianIDViewLibrarianInformationForm.Text = das.Tables[0].Rows[0][0].ToString();
            txtUsernameViewLibrarianInformationForm.Text = das.Tables[0].Rows[0][1].ToString();
            txtPasswordViewLibrarianInformationForm.Text = das.Tables[0].Rows[0][2].ToString();
        }

        private void btnRefreshViewLibrarianInformationForm_Click(object sender, EventArgs e)
        {
            txtIdTopViewLibrarianInformationForm.Clear();
            panel2.Visible = false;
        }

        private void txtIdTopViewLibrarianInformationForm_TextChanged(object sender, EventArgs e)
        {
            Operation operationLibrarian = new Operation();
            SqlDataAdapter librarianSearch = operationLibrarian.librarianSearch(txtIdTopViewLibrarianInformationForm.Text);
            if (txtIdTopViewLibrarianInformationForm.Text != "")
            {
                DataSet ds = new DataSet();
                librarianSearch.Fill(ds);

                dgvLibrarianInfo.DataSource = ds.Tables[0];
            }

            else
            {
                SqlDataAdapter allLibrarian = operationLibrarian.librarianLoad();
                DataSet ds = new DataSet();
                allLibrarian.Fill(ds);
                dgvLibrarianInfo.DataSource = ds.Tables[0];

            }
        }

        private void btnUpdateViewLibrarianInformationForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Confirm to Update This Data?", "Success", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question) == DialogResult.OK)
            {
                EntitiesLibrarian entitiesLibrarian = new EntitiesLibrarian();
                Operation operationLibrarian = new Operation();

                entitiesLibrarian.LibrarianID = txtLibrarianIDViewLibrarianInformationForm.Text; ;
                entitiesLibrarian.LibrarianUsername = txtUsernameViewLibrarianInformationForm.Text;
                entitiesLibrarian.LibrarianPassword = txtPasswordViewLibrarianInformationForm.Text;


                int flag = operationLibrarian.librarianInfoUpdate(entitiesLibrarian, rowId);
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

        private void btnCancelViewLibrarianInformationForm_Click(object sender, EventArgs e)
        {
            this.Close();
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
