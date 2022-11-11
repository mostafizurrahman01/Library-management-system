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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }
        private void btnXSignup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void txtFirstName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtIDSignUp.Text == "First Name")
            {
                txtIDSignUp.Clear();
            }
            txtIDSignUp.ForeColor = Color.White;
        }

        private void txtLastName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Clear();
            }
            txtLastName.ForeColor = Color.White;
        }

        private void txtMobileNumber_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtMobileNumber.Text == "Mobile Number")
            {
                txtMobileNumber.Clear();
            }
            txtMobileNumber.ForeColor = Color.White;
        }

        private void txtEmailAddress_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmailAddress.Text == "Email Address")
            {
                txtEmailAddress.Clear();
            }
            txtEmailAddress.ForeColor = Color.White;
        }

        private void txtUserNameSignup_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserNameSignup.Text == "Username")
            {
                txtUserNameSignup.Clear();
            }
            txtUserNameSignup.ForeColor = Color.White;
        }

        private void txtPasswordSignup_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPasswordSignup.Text == "Password")
            {
                txtPasswordSignup.Clear();
                txtPasswordSignup.PasswordChar = '*';
            }
            txtPasswordSignup.ForeColor = Color.White;
        }

        private void txtConfirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm Password")
            {
                txtConfirmPassword.Clear();
                txtConfirmPassword.PasswordChar = '*';
            }
            txtConfirmPassword.ForeColor = Color.White;
        }
      
        private void btnSignup_Click(object sender, EventArgs e)
        {
            EntitiesSignUp entitiesS = new EntitiesSignUp();
            Operation operationS = new Operation();

            entitiesS.ID = txtIDSignUp.Text;
            entitiesS.FirstName = txtFirstName.Text;
            entitiesS.LastName = txtLastName.Text;
            entitiesS.MobileNum = txtMobileNumber.Text;
            entitiesS.Email = txtEmailAddress.Text;
            entitiesS.UserName = txtUserNameSignup.Text;
       
            if (robMale.Checked)
            {
                entitiesS.Gender = "Male";
            }
            else if (robFemale.Checked)
            {
                entitiesS.Gender = "Female";
            }
            else if(robOthers.Checked)
            {
                entitiesS.Gender = "Others";
            }
            else
            {
                entitiesS.Gender = null;
            }
            entitiesS.Password = txtPasswordSignup.Text;
            entitiesS.ConfirmPass = txtConfirmPassword.Text;

            if(txtIDSignUp.Text == "First Name" || txtIDSignUp.Text == "" ||
                txtLastName.Text == "Last Name" || txtLastName.Text == "" ||
                txtIDSignUp.Text == "ID" || txtIDSignUp.Text == "" ||
                txtMobileNumber.Text == "Mobile Number" || txtMobileNumber.Text == "" ||
                txtEmailAddress.Text == "Email Address" || txtEmailAddress.Text == "" ||
                txtUserNameSignup.Text == "Username" || txtUserNameSignup.Text == "" ||
                entitiesS.Gender == null ||
                txtPasswordSignup.Text == "Password" || txtPasswordSignup.Text == "" ||
                txtConfirmPassword.Text == "Confirm Password" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Fill up all the requrements.");
            }
            else
            {
                SqlDataAdapter checkUser = operationS.CheckUsername(entitiesS);
                DataSet ds = new DataSet();
                checkUser.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("Username already exist");
                }
                else
                {
                    if (Convert.ToInt32(PasswordCheck.CheckStrength(txtPasswordSignup.Text)) > 5)
                    {
                        if (txtPasswordSignup.Text == txtConfirmPassword.Text)
                        {
                            int flag = operationS.SignUp(entitiesS);
                            if (flag > 0)
                            {
                                MessageBox.Show("Sign Up Successfully", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                new LoginForm().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Sign Up Unsuccessfully", "Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password haven't matched");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password weak");
                    }      
                }               
            }                     
        }

        private void txtFirstName_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
               txtFirstName.Clear();
            }
            txtFirstName.ForeColor = Color.White;
        }

        private void txtIDSignUp_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtIDSignUp.Text == "ID")
            {
               txtIDSignUp.Clear();
            }
            txtIDSignUp.ForeColor = Color.White;
        }
    }
}
