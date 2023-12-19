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

namespace library
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "confirm", MessageBoxButtons.YesNo,
MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textStudentName.Text = "";
            textEnroll.Text = "";
            textDep.Text = "";
            textSem.Text = "";
            textContact.Text = "";
            textEmail.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sname = textStudentName.Text;
            string enroll = textEnroll.Text;
            string dep = textDep.Text;
            string sem = textSem.Text;
            int contact = int.Parse(textContact.Text); // Parse the price as decimal
            string email = textEmail.Text;// Parse the quantity as int

            string connectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string insertQuery = "INSERT INTO AddStudent (sname, enroll, dep, sem, contact, email) VALUES (@name, @enroll, @dep, @sem, @contact, @email)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@name", sname);
                    cmd.Parameters.AddWithValue("@enroll", enroll);
                    cmd.Parameters.AddWithValue("@dep", dep);
                    cmd.Parameters.AddWithValue("@sem", sem);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@email", email);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textStudentName.Clear();
                        textEnroll.Clear();
                        textDep.Clear();
                        textSem.Clear();
                        textContact.Clear();
                        textEmail.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
