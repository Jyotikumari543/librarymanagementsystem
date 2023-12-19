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
    public partial class completeBookDetail : Form
    {
        public completeBookDetail()
        {
            InitializeComponent();
        }

        private void completeBookDetail_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

            try
            {
                con.Open(); // Open the database connection

                // Define a parameter for the return date
                string textreturndate = "2023-09-28"; // Replace with your desired date
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;
                cmd1.CommandText = "SELECT * FROM IRBook WHERE book_return_date IS NULL OR book_return_date = @textreturndate";
                cmd1.Parameters.AddWithValue("@textreturndate", textreturndate);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];

                // Query for books with non-null return date (similar to the previous code)
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "SELECT * FROM IRBook WHERE book_return_date IS NOT NULL";
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                dataGridView2.DataSource = ds2.Tables[0];
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during database operations
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close(); // Close the database connection when done
            }
        }

    }
}
