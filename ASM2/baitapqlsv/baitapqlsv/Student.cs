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

namespace baitapqlsv
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=MSI\TAYSQL;Initial Catalog=Assignment2;Integrated Security=True");
            con.Open();
            hienthi();
        }
        public void hienthi()
        {
            string sqlselect = "SELECT *FROM tb_student";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv.DataSource = dt;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tb_studentID.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_studentname.Text = dgv.Rows[i].Cells[1].Value.ToString();
            dtime_date.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_class.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_course.Text = dgv.Rows[i].Cells[4].Value.ToString();
            cb_gender.Text = dgv.Rows[i].Cells[5].Value.ToString();
        }
        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string sqlTadd = "INSERT INTO tb_student VALUES (@StudentID, @Student_Name, @Date_of_birth, @Class, @Course, @Gender)";
            SqlCommand cmd = new SqlCommand(sqlTadd, con);
            cmd.Parameters.AddWithValue("StudentID", tb_studentID.Text);
            cmd.Parameters.AddWithValue("Student_Name", tb_studentname.Text);
            cmd.Parameters.AddWithValue("Date_of_birth", dtime_date.Text);
            cmd.Parameters.AddWithValue("Class", tb_class.Text);
            cmd.Parameters.AddWithValue("Course", tb_course.Text);
            cmd.Parameters.AddWithValue("Gender", cb_gender.Text);
            _ = cmd.ExecuteNonQuery();
            hienthi();
        }


        private void bt_update_Click(object sender, EventArgs e)
        {
            string sqladd = "UPDATE tb_student SET StudentID = @StudentID, Student_Name = @Student_name, Date_of_birth = @Date_of_birth, Class = @Class, Course = @Course, Gender = @Gender WHERE StudentID = @StudentID";
            SqlCommand cmd = new SqlCommand(sqladd, con);
            cmd.Parameters.AddWithValue("StudentID", tb_studentID.Text);
            cmd.Parameters.AddWithValue("Student_Name", tb_studentname.Text);
            cmd.Parameters.AddWithValue("Date_of_birth", dtime_date.Value);
            cmd.Parameters.AddWithValue("Class", tb_class.Text);
            cmd.Parameters.AddWithValue("Course", tb_course.Text);
            cmd.Parameters.AddWithValue("Gender", cb_gender.Text);
            _ = cmd.ExecuteNonQuery();
            hienthi();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string sqldelete = "DELETE FROM tb_student WHERE StudentID = @StudentID";
            SqlCommand cmd = new SqlCommand(sqldelete, con);
            cmd.Parameters.AddWithValue("StudentID", tb_studentID.Text);
            cmd.Parameters.AddWithValue("Student_Name", tb_studentname.Text);
            cmd.Parameters.AddWithValue("Date_of_birth", dtime_date.Text);
            cmd.Parameters.AddWithValue("Class", tb_class.Text);
            cmd.Parameters.AddWithValue("Course", tb_course.Text);
            cmd.Parameters.AddWithValue("Gender", cb_gender.Text);
            _ = cmd.ExecuteNonQuery();
            hienthi();
        }

        private void bt_initialization_Click(object sender, EventArgs e)
        {
            tb_studentID.Text = "";
            tb_studentname.Text = "";
            dtime_date.Text = "1/1/1900";
            tb_class.Text = "";
            tb_course.Text = "";            
            cb_gender.Text = "";
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            string sqlsearch = "SELECT * FROM tb_student WHERE StudentID = @StudentID";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            cmd.Parameters.AddWithValue("StudentID", tb_search.Text);
            cmd.Parameters.AddWithValue("Student_name", tb_studentname.Text);
            cmd.Parameters.AddWithValue("Date_of_birth", dtime_date.Text);
            cmd.Parameters.AddWithValue("Class", tb_class.Text);
            cmd.Parameters.AddWithValue("Course", tb_course.Text);
            cmd.Parameters.AddWithValue("Gender", cb_gender.Text);
            _ = cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv.DataSource = dt;
        }
    }
}
