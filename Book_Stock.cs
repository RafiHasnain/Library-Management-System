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
using System.Net.Mail;
using System.Net;
using System.Net.Mail;
using System.Net;

namespace Library_ManagementSystem
{
    
    public partial class Book_Stock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AT5O2MS\MICROSOFTSQL;Initial Catalog=Library_managment;Integrated Security=True;Pooling=False");

        public Book_Stock()
        {
            InitializeComponent();
        }

        private void Book_Stock_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_book_info();
        }

        public void fill_book_info()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT books_name, books_author_name, books_quantity, available_qty From books_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String i;
            i = dataGridView1.SelectedCells[0].Value.ToString();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from issue_books WHERE  books_name ='"+ i.ToString() +"' and book_return_date = ''";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT books_name, books_author_name, books_quantity, available_qty From books_info where books_name like ('%"+textBox1.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String i;
            i = dataGridView2.SelectedCells[6].Value.ToString();
            textBox2.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            //(username,password)
            smtp.Credentials = new NetworkCredential("xxxxx@gmail.com", "xxxxx");
            //(from, to, subject, body)
            MailMessage mail = new MailMessage("xxxxxxx@gmail.com", textBox2.Text, "This is for book return notice",textBox3.Text);
            mail.Priority = MailPriority.High;
            smtp.Send(mail);
            MessageBox.Show("mail sent");
        }
    }
}
