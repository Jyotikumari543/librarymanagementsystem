using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "confirm", MessageBoxButtons.YesNo,
MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks abs = new AddBooks();
            abs.Show();
        }

        private void deleteBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook abs = new ViewBook();
            abs.Show();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent abs = new AddStudent();
            abs.Show();
        }

        private void viewStudentsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewstudent abs = new viewstudent();
            abs.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issuebook abs = new issuebook();
            abs.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnbook abs = new returnbook();
            abs.Show();
        }

        private void completeBooksDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            completeBookDetail abs = new completeBookDetail();
            abs.Show();
        }
    }
}
