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
    public partial class AddRemoveLibrarianForm : Form
    {
        public AddRemoveLibrarianForm()
        {
            InitializeComponent();
        }

        private void btnAddAddRemoveLibrarianForm_Click(object sender, EventArgs e)
        {
            EntitiesLibrarian entitiesLibrarian = new EntitiesLibrarian();
            Operation operationLibrarian = new Operation();

            entitiesLibrarian.LibrarianID= txtLibrarianIDAddRemoveLibrarianForm.Text;
            entitiesLibrarian.LibrarianUsername = txtUsernameAddRemoveLibrarianForm.Text;
            entitiesLibrarian.LibrarianPassword = txtPasswordAddRemoveLibrarianForm.Text;


            if (txtLibrarianIDAddRemoveLibrarianForm.Text == "ID" || txtLibrarianIDAddRemoveLibrarianForm.Text == "" ||
                 txtUsernameAddRemoveLibrarianForm.Text == "Username" || txtUsernameAddRemoveLibrarianForm.Text == "" ||
                 txtPasswordAddRemoveLibrarianForm.Text == "Password" || txtPasswordAddRemoveLibrarianForm.Text == "")
            {
                MessageBox.Show("Fill up all the requrements.");
            }
            else
            {
                SqlDataAdapter checkAdminUsername = operationLibrarian.checkLibrarianUsername(entitiesLibrarian);
                DataSet ds = new DataSet();
                checkAdminUsername.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("This Username for admin already exist");
                }
                else
                {
                    int flag = operationLibrarian.addLibrarian(entitiesLibrarian);
                    if (flag > 0)
                    {
                        MessageBox.Show("A New Librarian is Added");
                        txtLibrarianIDAddRemoveLibrarianForm.Clear();
                        txtUsernameAddRemoveLibrarianForm.Clear();
                        txtPasswordAddRemoveLibrarianForm.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error! Please Check Again");
                    }
                }
            }
        }

        private void btnRemoveAddRemoveLibrarianForm_Click(object sender, EventArgs e)
        {
            EntitiesLibrarian entitiesLibrarian = new EntitiesLibrarian();
            Operation operationLibrarian = new Operation();

            entitiesLibrarian.LibrarianID = txtLibrarianIDAddRemoveLibrarianForm.Text;
            entitiesLibrarian.LibrarianUsername = txtUsernameAddRemoveLibrarianForm.Text;
            entitiesLibrarian.LibrarianPassword = txtPasswordAddRemoveLibrarianForm.Text;

            int flag = operationLibrarian.removeLibrarian(entitiesLibrarian);

            if (flag > 0)
            {
                MessageBox.Show("Librarian is removed");
                txtLibrarianIDAddRemoveLibrarianForm.Clear();
                txtUsernameAddRemoveLibrarianForm.Clear();
                txtPasswordAddRemoveLibrarianForm.Clear();

            }
            else
            {
                MessageBox.Show("Error! Librarian is not removed");
            }

        }

        private void btnCloseAddRemoveLibrarianForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
 }
