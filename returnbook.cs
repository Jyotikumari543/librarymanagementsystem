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
    public partial class returnbook : Form
    {
        public returnbook()
        {
            InitializeComponent();
        }
        String bname;
        String bdate;
        Int64 rowid;

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "confirm", MessageBoxButtons.YesNo,
MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where std_enroll = '" + textenrollnment.Text + "' and book_return_date IS NULL ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {

                MessageBox.Show("Invalid ID or NO Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textenrollnment.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IRBook set book_return_date='"+textreturndate.Text+"'where std_enroll='"+textenrollnment.Text+"' and id ='"+rowid+"' ";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return Successful","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            returnbook_Load(this, null);


            
        }


        private void returnbook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            textenrollnment.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

            }
            textbookname.Text = bname;
            textbookissuedate.Text = bdate;


        }

        private void textenrollnment_TextChanged(object sender, EventArgs e)
        {
            if (textenrollnment.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }
    }
}
