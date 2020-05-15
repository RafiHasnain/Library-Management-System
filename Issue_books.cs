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
using System.Threading;

namespace Library_ManagementSystem
{
    public partial class Issue_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AT5O2MS\MICROSOFTSQL;Initial Catalog=Library_managment;Integrated Security=True;Pooling=False");

        public Issue_books()
        {
            InitializeComponent();
        }

        private void Issue_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from student_info where student_id='" +txt_student_ID.Text+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            
            if (i == 0)
            {
                MessageBox.Show("This ID is not found");
            }
            else
            {

                foreach (DataRow dr in dt.Rows)
                {
                    txt_StudentName.Text = dr["student_name"].ToString();
                    txt_Department.Text = dr["student_dept"].ToString();
                    txt_Semester.Text = dr["student_sem"].ToString();
                    txt_Contact.Text = dr["student_contact"].ToString();
                    txt_Email.Text = dr["student_email"].ToString();


                }
            }

        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_BookName_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;
            if (e.KeyCode != Keys.Enter)
            {
                listBox1.Items.Clear();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * from books_info where books_name like('%" + txt_BookName.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count > 0)
                {
                    listBox1.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["books_name"].ToString());
                    }
                }

            }
        }

        private void txt_BookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                //you might need to select one value  to allow  arrow keys
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BookName.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_BookName.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int books_qty = 0;
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT * from books_info WHERE books_name ='"+ txt_BookName.Text +"'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter
            da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                books_qty = Convert.ToInt32(dr2["available_qty"].ToString());
            }
            if (books_qty>0)
            {


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into issue_books values('" + txt_student_ID.Text + "','" + txt_StudentName.Text + "','" + txt_Department.Text + "','" + txt_Semester.Text + "','" + txt_Contact.Text + "','" + txt_Email.Text + "','" + txt_BookName.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','')";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "UPDATE books_info set available_qty=available_qty - 1 WHERE books_name = '" + txt_BookName.Text + "'";
                cmd1.ExecuteNonQuery();

                MessageBox.Show("The book is issued successfully");
            }
            else
            {
                MessageBox.Show("This book is not available");
            }
        }
    }
}
