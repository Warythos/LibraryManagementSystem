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
using System.IO;

namespace LibraryManagementSystem
{
    public partial class viewStudentInfoForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ege\source\repos\LibraryManagementSystem\LibraryManagementSystem\Database1.mdf;Integrated Security=True");
        string pwd = Class1.GetRandomPassword(20);
        string wanted_path;
        DialogResult result;
        public viewStudentInfoForm()
        {
            InitializeComponent();
        }

        private void viewStudentInfoForm_Load(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            fillGrid();
        }

        private void fillGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM student_info";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM student_info WHERE student_name like('%"+ textBox1.Text +"%')";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM student_info where id="+i+"";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            
            foreach(DataRow dr in dt.Rows)
            {
                nameTBox.Text = dr["student_name"].ToString();
                enrollmentTBox.Text = dr["student_enrollment_no"].ToString();
                departmentTBox.Text = dr["student_department"].ToString();
                semTBox.Text = dr["student_sem"].ToString();
                contactTBox.Text = dr["student_contact"].ToString();
                emailTBox.Text = dr["student_email"].ToString();
            }
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (result == DialogResult.OK)
            {
                int i;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                string image_path;
                File.Copy(openFileDialog1.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");
                image_path = "\\student_images\\" + pwd + ".jpg";

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE student_info SET student_name='"+ nameTBox.Text +"',student_image ='" + image_path.ToString() + "',student_enrollment_no='" + enrollmentTBox.Text + "',student_department='" + departmentTBox.Text + "',student_sem='"+ semTBox.Text +"',student_contact='"+ contactTBox.Text +"',student_email='"+ emailTBox.Text +"' WHERE id="+ i +"";
                command.ExecuteNonQuery();

                fillGrid();
                MessageBox.Show("Updated Successfully");
            }
            else
            {
                int i;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE student_info SET student_name='" + nameTBox.Text +"',student_enrollment_no='" + enrollmentTBox.Text + "',student_department='" + departmentTBox.Text + "',student_sem='" + semTBox.Text + "',student_contact='" + contactTBox.Text + "',student_email='" + emailTBox.Text + "' WHERE id=" + i + "";
                command.ExecuteNonQuery();

                fillGrid();
                MessageBox.Show("Updated Successfully");
            }
        }
    }
}
