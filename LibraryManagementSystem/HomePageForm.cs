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
    public partial class HomePageForm : Form
    {
        public static int multiWindows1 = 0, multiWindows2 = 0, multiWindows3 = 0;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (multiWindows3 == 0)
            {
                new StudentProfileForm().Show();
                multiWindows3 = 1;
            }
            else
            {
                MessageBox.Show("Windows already opened");
            }
        }

        public HomePageForm()
        {
            InitializeComponent();
        }
        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (multiWindows1 == 0)
            {
                new BorrowBookForm().Show();
                multiWindows1 = 1;
            }
            else
            {
                MessageBox.Show("Windows already opened");
            }
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (multiWindows2 == 0)
            {
                new SearchBookStudent().Show();
                multiWindows2 = 1;
            }
            else
            {
                MessageBox.Show("Windows already opened");
            }
        }
    }
}
