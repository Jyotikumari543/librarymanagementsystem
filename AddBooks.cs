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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string bname = textBookName.Text;
            string bauthor = textAuthorName.Text;
            string publication = textPublication.Text;
            string pdate = PurchaseDate.Text;
            decimal price = decimal.Parse(textPrice.Text); // Parse the price as decimal
            int quan = int.Parse(textQuantity.Text); // Parse the quantity as int

            string connectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string insertQuery = "INSERT INTO AddBook (bName, bAuthor, bpubl, bPDate, bPrice, bQuan) " +
                                     "VALUES (@bname, @bauthor, @publication, @pdate, @price, @quan)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@bname", bname);
                    cmd.Parameters.AddWithValue("@bauthor", bauthor);
                    cmd.Parameters.AddWithValue("@publication", publication);
                    cmd.Parameters.AddWithValue("@pdate", pdate);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quan", quan);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBookName.Clear();
                        textAuthorName.Clear();
                        textPublication.Clear();
                        textPrice.Clear();
                        textQuantity.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "confirm", MessageBoxButtons.YesNo,
MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
