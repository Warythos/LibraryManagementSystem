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
    public partial class issueBooksForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ege\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database1.mdf;Integrated Security=True");

        public issueBooksForm()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            int i;
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM student_info WHERE student_enrollment_no = '"+enrollmentTBox.Text+"'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            
            if(i == 0)
            {
                MessageBox.Show("Enrollment no not found!");
            }
            else
            {
                foreach(DataRow dr in dt.Rows)
                {
                    studentNameTBox.Text = dr["student_name"].ToString();
                    departmentTBox.Text = dr["student_department"].ToString();
                    semTBox.Text = dr["student_sem"].ToString();
                    contactTBox.Text = dr["student_contact"].ToString();
                    emailTBox.Text = dr["student_email"].ToString();
                }
            }
        }

        private void issueBooksForm_Load(object sender, EventArgs e)
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
        }

        private void bookNameTBox_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;

            if(e.KeyCode != Keys.Enter)
            {
                listBox1.Items.Clear();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM books_info WHERE book_name LIKE('%" + bookNameTBox.Text + "%')";
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if(count > 0)
                {
                    listBox1.Visible = true;
                    foreach(DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["book_name"].ToString());
                    }
                }
            }
        }

        private void bookNameTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bookNameTBox.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            bookNameTBox.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            listBox1.Focus();
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int book_quantity = 0;
            SqlCommand commandCheck = connection.CreateCommand();
            commandCheck.CommandType = CommandType.Text;
            commandCheck.CommandText = "SELECT * FROM books_info WHERE book_name = '" + bookNameTBox.Text + "'";
            commandCheck.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(commandCheck);
            da2.Fill(dt2);
            foreach(DataRow dr2 in dt2.Rows)
            {
                book_quantity = Convert.ToInt32(dr2["available_quantity"].ToString());
            }

            if (book_quantity > 0)
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO issue_books values ('" + enrollmentTBox.Text + "','" + studentNameTBox.Text + "','" + departmentTBox.Text + "','" + semTBox.Text + "','" + contactTBox.Text + "','" + emailTBox.Text + "','" + bookNameTBox.Text + "','" + issueDateTBox.Text + "'',')";
                command.ExecuteNonQuery();

                SqlCommand commandUpdate = connection.CreateCommand();
                commandUpdate.CommandType = CommandType.Text;
                commandUpdate.CommandText = "UPDATE books_info SET available_quantity=available_quantity-1 WHERE book_name= '" + bookNameTBox.Text + "'";
                commandUpdate.ExecuteNonQuery();

                MessageBox.Show("Book issued successfully!");
            }
            else
            {
                MessageBox.Show("Not any books available at this moment!");
            }
            
        }
    }
}
