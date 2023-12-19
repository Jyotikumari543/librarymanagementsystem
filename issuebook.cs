using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class issuebook : Form
    {
        private int count;

        public issuebook()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Clear all text fields and reset count
            //textSearchEnrollment.Text = "";
            textSearchEnrollnment.Clear();
            textstudentname.Clear();
            textdepartment.Clear();
            textemail.Clear();
            textcontact.Clear();
            textsemester.Clear();
            dateissue.Value = DateTime.Now; // Reset the date

            count = 0; // Reset count to 0
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textSearchEnrollnment.Text))
            {
                string eid = textSearchEnrollnment.Text;
                string connectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM AddStudent WHERE enroll = @eid", con))
                    {
                        cmd.Parameters.AddWithValue("@eid", eid);

                        using (SqlDataAdapter DA = new SqlDataAdapter(cmd))
                        {
                            DataSet DS = new DataSet();
                            DA.Fill(DS);

                            if (DS.Tables[0].Rows.Count != 0)
                            {
                                textstudentname.Text = DS.Tables[0].Rows[0]["sname"].ToString();
                                textdepartment.Text = DS.Tables[0].Rows[0]["dep"].ToString();
                                textsemester.Text = DS.Tables[0].Rows[0]["sem"].ToString();
                                textcontact.Text = DS.Tables[0].Rows[0]["contact"].ToString();
                                textemail.Text = DS.Tables[0].Rows[0]["email"].ToString();
                            }
                            else
                            {
                                textcontact.Clear();
                                textemail.Clear();
                                textstudentname.Clear();
                                textdepartment.Clear();
                                textsemester.Clear();
                                MessageBox.Show("Invalid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter an Enrollment No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnIssue_Click(object sender, EventArgs e)
        {
            // Get the values from the form controls
            string enrollment = textSearchEnrollnment.Text.Trim();
            string studentName = textstudentname.Text.Trim();
            string department = textdepartment.Text.Trim();
            string semester = textsemester.Text.Trim();
            string contact = textcontact.Text.Trim();
            string email = textemail.Text.Trim();
            string bookname = comboBoxBook.SelectedItem?.ToString(); // Selected item from the combo box
            string bookIssueDate = dateissue.Value.ToString("yyyy-MM-dd");

            // Validate the input
            if (string.IsNullOrEmpty(enrollment) || string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(bookname))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the input is not valid
            }

            // Check if the maximum number of books has been issued
            if (count > 2)
            {
                MessageBox.Show("Maximum number of books has been issued.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the method if the maximum books have been issued
            }

            // Perform database operation to issue the book
            try
            {
                string connectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO IRBook (std_enroll, std_name, std_dep, std_sem, std_contact, std_email, book_name, book_issue_date) VALUES (@enroll, @sname, @sdep, @sem, @contact, @email, @bookname, @bookIssueDate)", con))
                    {
                        cmd.Parameters.AddWithValue("@enroll", enrollment);
                        cmd.Parameters.AddWithValue("@sname", studentName);
                        cmd.Parameters.AddWithValue("@sdep", department);
                        cmd.Parameters.AddWithValue("@sem", semester);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@bookname", bookname);
                        cmd.Parameters.AddWithValue("@bookIssueDate", bookIssueDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnRefresh_Click(sender, e); // Clear the form after issuing the book
                        }
                        else
                        {
                            MessageBox.Show("Failed to issue the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void issuebook_Load(object sender, EventArgs e)
        {

            string connectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT bName FROM AddBook", con))
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        comboBoxBook.Items.Add(sdr.GetString(0));
                    }
                }
            }
        }
    }
}
