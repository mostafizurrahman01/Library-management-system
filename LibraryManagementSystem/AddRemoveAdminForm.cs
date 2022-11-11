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
    public partial class AddRemoveAdminForm : Form
    {
        public AddRemoveAdminForm()
        {
            InitializeComponent();
        }

        private void btnCloseAddRemoveAdminForm_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPage.multiWindows7 = 0;
        }

        private void btnAddAddAdminForm_Click(object sender, EventArgs e)
        {
            EntitiesAdmin entitiesAdmin = new EntitiesAdmin();
            Operation operationAdmin = new Operation();

            entitiesAdmin.adminID = txtAdminIDAddAdminForm.Text;
            entitiesAdmin.adminUsername = txtUsernameAddAdminForm.Text;
            entitiesAdmin.adminPassword = txtPasswordAddAdminForm.Text;


           if (txtAdminIDAddAdminForm.Text == "ID" || txtAdminIDAddAdminForm.Text == "" ||
                txtUsernameAddAdminForm.Text == "Username" || txtUsernameAddAdminForm.Text == "" ||
                txtPasswordAddAdminForm.Text == "Password" || txtPasswordAddAdminForm.Text == "" )
            {
                MessageBox.Show("Fill up all the requrements.");
            }
            else
            {
                SqlDataAdapter checkAdminUsername = operationAdmin.checkAdminUsername(entitiesAdmin);
                DataSet ds = new DataSet();
                checkAdminUsername.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("This Username for admin already exist");
                }
                else
                {
                        int flag = operationAdmin.addAdmin(entitiesAdmin);
                        if (flag > 0)
                        {
                            MessageBox.Show("A New Admin is Added");
                            txtAdminIDAddAdminForm.Clear();
                            txtUsernameAddAdminForm.Clear();
                            txtPasswordAddAdminForm.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error! Please Check Again");
                        }
                    }
                    
                }



            }

        private void btnRemoveAddAdminForm_Click(object sender, EventArgs e)
        {
            EntitiesAdmin entitiesAdmin = new EntitiesAdmin();
            Operation operationAdmin = new Operation();

            entitiesAdmin.adminID = txtAdminIDAddAdminForm.Text;
            entitiesAdmin.adminUsername = txtUsernameAddAdminForm.Text;
            entitiesAdmin.adminPassword = txtPasswordAddAdminForm.Text;

            int flag = operationAdmin.removeAdmin(entitiesAdmin);

            if(flag > 0)
            {
                MessageBox.Show("Admin is removed");
                txtAdminIDAddAdminForm.Clear();
                txtUsernameAddAdminForm.Clear();
                txtPasswordAddAdminForm.Clear();

            }
            else
            {
                MessageBox.Show("Error! Admin is not removed");
            }

        }
    }
}
