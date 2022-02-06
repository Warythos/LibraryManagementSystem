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
    public partial class loginForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ege\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database1.mdf;Integrated Security=True");
        int count = 0;
        public loginForm()
        {
            InitializeComponent();
        }

        private void usernameTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlCommand comm = connection.CreateCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM library_person where username ='" + usernameTBox.Text + "' and password= '" + passwordTBox.Text + "'";
            comm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("Username or password is incorrect. Please try again");
            }
            else
            {
                this.Hide();
                mdi_user mu = new mdi_user();
                mu.Show();

            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
        }
    }
}
