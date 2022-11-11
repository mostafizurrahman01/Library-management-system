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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsernameLogin.Text == "Username")
            {
                txtUsernameLogin.Clear();
            }
            txtUsernameLogin.ForeColor = Color.White;
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtPasswordLogin.Text == "Password")
            {
                txtPasswordLogin.Clear();
                txtPasswordLogin.PasswordChar = '*';
            }
            txtPasswordLogin.ForeColor = Color.White;
        }

        private void pbFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void pbTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/");
        }

        private void pbInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void linkLabelSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignupForm().Show();
            this.Hide();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            EntitiesSignUp entitiesS = new EntitiesSignUp();
            Operation operationS = new Operation();
       

            entitiesS.UserName = txtUsernameLogin.Text;
            entitiesS.Password = txtPasswordLogin.Text;


            SqlDataAdapter flag = operationS.Login(entitiesS);
            SqlDataAdapter flag2 = operationS.checkAdmin(entitiesS);
            SqlDataAdapter flag3 = operationS.checkLibrarian(entitiesS);


            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();


            flag.Fill(ds);
            flag2.Fill(ds1);
            flag3.Fill(ds2);

            if (txtUsernameLogin.Text == "Username" || txtUsernameLogin.Text == "" ||
                txtPasswordLogin.Text == "Password" || txtPasswordLogin.Text == "")
            {
                MessageBox.Show("Fill up all the requrements.");
            }
            else
            {
                if (ds.Tables[0].Rows.Count != 0) //For user login
                {
                    
                    new HomePageForm().Show();         
                    this.Hide();
                }
                else if (ds1.Tables[0].Rows.Count !=0) //For Admin login
                {
                    new AdminPage().Show();
                    this.Hide();
                }
                else if (ds2.Tables[0].Rows.Count != 0) //For Librarian login
                {
                    new LibrarianPageForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username/password");
                }
            }

            

        }
    }
}
