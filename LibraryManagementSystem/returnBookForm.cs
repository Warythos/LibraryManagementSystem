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

namespace LibraryManagementSystem
{
    public partial class returnBookForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ege\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database1.mdf;Integrated Security=True");

        public returnBookForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            gridFill(textBox1.Text);
        }

        private void returnBookForm_Load(object sender, EventArgs e)
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
        }

        private void gridFill(string enrollment_no)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM issue_books WHERE student_enrollment='"+ enrollment_no.ToString() +"'and book_return_date=''";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM issue_books WHERE id =" + i + "";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                bookNameLabel.Text = dr["book_name"].ToString();
                issueDateLabel.Text = dr["book_issue_date"].ToString();
            }
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE issue_books SET book_return_date='"+ textBox2.Text + "'WHERE id =" + i + "";
            command.ExecuteNonQuery();

            SqlCommand command2 = connection.CreateCommand();
            command2.CommandType = CommandType.Text;
            command2.CommandText = "UPDATE books_info SET available_quantity=available_quantity+1 WHERE book_name='" + bookNameLabel.Text + "'";
            command2.ExecuteNonQuery();

            MessageBox.Show("Books Returned Successfully!");
            
            panel3.Visible = true;

            gridFill(textBox1.Text);
        }
    }
}
