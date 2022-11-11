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
    public partial class SearchBookStudent : Form
    {
        public SearchBookStudent()
        {
            InitializeComponent();
        }

        private void SearchBookStudent_Load(object sender, EventArgs e)
        {
            
            Operation operationBooks = new Operation();
            SqlDataAdapter allbook = operationBooks.bookLoad();
            DataSet ds = new DataSet();
            allbook.Fill(ds);
            dgvSearchBooksForStudent.DataSource = ds.Tables[0];
        }

        private void txtBookNameTopSearchBookForStudent_TextChanged(object sender, EventArgs e)
        {
            Operation operationBooks = new Operation();
            SqlDataAdapter bookSearch = operationBooks.bookSearch(txtBookNameTopSearchBookForStudent.Text);
            if (txtBookNameTopSearchBookForStudent.Text != "")
            {
                DataSet ds = new DataSet();
                bookSearch.Fill(ds);

                dgvSearchBooksForStudent.DataSource = ds.Tables[0];
            }

            else
            {
                SqlDataAdapter allbook = operationBooks.bookLoad();
                DataSet ds = new DataSet();
                allbook.Fill(ds);
                dgvSearchBooksForStudent.DataSource = ds.Tables[0];
            }
        }

        private void btnRefreshSearchBookForStudent_Click(object sender, EventArgs e)
        {
            txtBookNameTopSearchBookForStudent.Clear();
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
