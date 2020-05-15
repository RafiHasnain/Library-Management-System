using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_ManagementSystem
{
    public partial class Return_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AT5O2MS\MICROSOFTSQL;Initial Catalog=Library_managment;Integrated Security=True;Pooling=False");

        public Return_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            fill_grid(textBox1.Text);
        }

        private void Return_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
        public void fill_grid(String ID)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from issue_books where student_id='" + ID.ToString() + "'and book_return_date =''";
            cmd.ExecuteNonQuery(); 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from issue_books where Id = "+i+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                lbl_BookName.Text = dr["books_name"].ToString();
                lbl_IssueDate.Text = dr["books_issue_date"].ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE issue_books set book_return_date ='"+dateTimePicker1.Value.ToString()+"'  where Id = " + i + "";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "UPDATE books_info set available_qty = available_qty + 1 where books_name = '"+lbl_BookName.Text+"'";
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Book has retured successfully");
            
            panel3.Visible = true;

            fill_grid(textBox1.Text);
        }
    }
}
