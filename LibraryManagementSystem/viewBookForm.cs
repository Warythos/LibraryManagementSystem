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
    public partial class viewBookForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ege\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database1.mdf;Integrated Security=True");

        public viewBookForm()
        {
            InitializeComponent();
        }

        private void viewBookForm_Load(object sender, EventArgs e)
        {
            display_books();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE book_name like('%"+searchTBox.Text+"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
                
                if (Convert.ToInt32(dt.Rows.Count.ToString()) == 0)
                {
                    MessageBox.Show("No books found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE book_author_name like('%" + authorTBox.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();

                if(Convert.ToInt32(dt.Rows.Count.ToString()) == 0)
                {
                    MessageBox.Show("No books found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            int i;
            var a = dataGridView1.SelectedRows[0].Cells[0].Value;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE id="+i+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();

                foreach(DataRow dr in dt.Rows)
                {
                    nameTBox.Text = dr["book_name"].ToString();
                    authorUpdateTBox.Text = dr["book_author_name"].ToString();
                    publicationTBox.Text = dr["book_publication_name"].ToString();
                    priceTBox.Text = dr["book_price"].ToString();
                    purchaseTBox.Text = Convert.ToDateTime(dr["book_purchase_date"]).ToString();
                    quantityTBox.Text = dr["book_quantity"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE books_info SET book_name= '"+ nameTBox.Text +"', book_author_name='"+ authorUpdateTBox.Text +"', book_publication_name='"+ publicationTBox.Text +"',book_purchase_date='"+purchaseTBox.Text+"', book_price='"+priceTBox.Text+"', book_quantity='"+quantityTBox.Text+"'WHERE id ="+i+"";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_books();
                MessageBox.Show("Updated successfully!");
                panel3.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void display_books()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
