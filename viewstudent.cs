using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class viewstudent : Form
    {
        Int64 rowid;

        public viewstudent()
        {
            InitializeComponent();
        }

        private void viewstudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AddStudent where enroll LIKE @enroll";
            cmd.Parameters.AddWithValue("@enroll", "%" + textSearchEnrollnment.Text + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted, Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from AddStudent where enroll = @enroll";
                cmd.Parameters.AddWithValue("@enroll", textenrollnment.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textSearchEnrollnment.Clear();
            panel2.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated, Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String sname = textstudentname.Text;
                String enroll = textenrollnment.Text;
                String dep = textdepartment.Text;
                String sem = textsemester.Text;
                String email = textemail.Text;
                Int64 contact = Int64.Parse(textcontact.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update AddStudent set sname= @sname, enroll= @enroll, dep= @dep, sem= @sem, contact= @contact, email= @email where stuid= @rowid";
                cmd.Parameters.AddWithValue("@sname", sname);
                cmd.Parameters.AddWithValue("@enroll", enroll);
                cmd.Parameters.AddWithValue("@dep", dep);
                cmd.Parameters.AddWithValue("@sem", sem);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@rowid", rowid);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                panel2.Visible = true;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddStudent where stuid = @rowid";
                cmd.Parameters.AddWithValue("@rowid", rowid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                textstudentname.Text = ds.Tables[0].Rows[0][1].ToString();
                textenrollnment.Text = ds.Tables[0].Rows[0][2].ToString();
                textdepartment.Text = ds.Tables[0].Rows[0][3].ToString();
                textsemester.Text = ds.Tables[0].Rows[0][4].ToString();
                textcontact.Text = ds.Tables[0].Rows[0][5].ToString();
                textemail.Text = ds.Tables[0].Rows[0][6].ToString();
            }
        }

        private void textSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textSearchEnrollnment.Text))
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from AddStudent where enroll LIKE @enroll";
                cmd.Parameters.AddWithValue("@enroll", "%" + textSearchEnrollnment.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-206RHD19\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from AddStudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
