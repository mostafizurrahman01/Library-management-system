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
    public partial class LibrarianPageForm : Form
    {
        public static int multiWindows1=0, multiWindows2 = 0, multiWindows3 = 0, multiWindows4 = 0, multiWindows5 = 0,
            multiWindows6=0;

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (multiWindows5 == 0)
            {
                new IssueBooksForm().Show();
                multiWindows5 = 1;
            }
            else
            {
                MessageBox.Show("Windows already opened");
            }
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (multiWindows6 == 0)
            {
                new ReturnBooksForm().Show();
                multiWindows6 = 1;
            }
            else
            {
                MessageBox.Show("Windows already opened");
            }
        }

        private void leaveApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (multiWindows4 == 0)
            {
                new StudentInformationForm().Show();
                multiWindows4 = 1;
            }
            else
            {
                MessageBox.Show("Windows already opened");
            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (multiWindows3 == 0)
            {
                new AddStudentForm().Show();
                multiWindows3 = 1;
            }
            else
            {
                MessageBox.Show("Windows already opened");
            }
        }

        public LibrarianPageForm()
        {
            InitializeComponent();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (multiWindows1 == 0)
            {
                new AddBooksForm().Show();
                multiWindows1 = 1;
            }
            else
            {
                MessageBox.Show("Windows already opened");
            }
        }

        private void searchBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (multiWindows2 == 0)
            {
                new SearchBooksFormAdmin().Show();
                multiWindows2 = 1;
            }
            else
            {
                MessageBox.Show("Windows already opened");
            }
        }

    }
}
