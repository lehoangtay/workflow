using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace baitapasm2
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void Form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=MSI\TAYSQL;Initial Catalog=asm2;Integrated Security=True");
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
            dgv1.DataSource = dt;
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        private void bt_search_Click_1(object sender, EventArgs e)
        {

        }
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            string sqlsearch = "SELECT * FROM tb_student WHERE StudentID = @StudentID";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            cmd.Parameters.AddWithValue("StudentID", tb_search.Text);
            cmd.Parameters.AddWithValue("Student_name", tb_studentname.Text);
            cmd.Parameters.AddWithValue("Class", tb_class.Text);
            cmd.Parameters.AddWithValue("Course", tb_course.Text);
            cmd.Parameters.AddWithValue("Gender", cb_Gender.Text);
            cmd.Parameters.AddWithValue("Date_of_birth", dtime_date.Text);
            _ = cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv1.DataSource = dt;
        }
        private void bt_Scoreinformation_Click(object sender, EventArgs e)
        {
            FormAdminScore Score = new FormAdminScore();
            Score.Show();
        }

        private void bt_Studentinformation_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string sqlTadd = "INSERT INTO tb_student VALUES (@StudentID, @Student_name, @Class, @Course, @Gender, @Date_of_birth)";
            SqlCommand cmd = new SqlCommand(sqlTadd, con);
            cmd.Parameters.AddWithValue("StudentID", tb_studentID.Text);
            cmd.Parameters.AddWithValue("Student_name", tb_studentname.Text);
            cmd.Parameters.AddWithValue("Class", tb_class.Text);
            cmd.Parameters.AddWithValue("Course", tb_course.Text);
            cmd.Parameters.AddWithValue("Gender", cb_Gender.Text);
            cmd.Parameters.AddWithValue("Date_of_birth", dtime_date.Text);
            _ = cmd.ExecuteNonQuery();
            hienthi();
        }

        private void bt_initialization_Click(object sender, EventArgs e)
        {
            tb_course.Text = "";
            tb_class.Text = "";
            tb_studentID.Text = "";
            tb_studentname.Text = "";
            cb_Gender.Text = "";
            dtime_date.Text = "1/1/1900";
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string sqldelete = "DELETE FROM tb_student WHERE StudentID = @StudentID";
            SqlCommand cmd = new SqlCommand(sqldelete, con);
            cmd.Parameters.AddWithValue("StudentID", tb_studentID.Text);
            cmd.Parameters.AddWithValue("Student_Name", tb_studentname.Text);
            cmd.Parameters.AddWithValue("Class", tb_class.Text);
            cmd.Parameters.AddWithValue("Course", tb_course.Text);
            cmd.Parameters.AddWithValue("Gender", cb_Gender.Text);
            cmd.Parameters.AddWithValue("Date_of_birth", dtime_date.Text);
            _ = cmd.ExecuteNonQuery();
            hienthi();
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            string sqlupdate = "UPDATE tb_student SET StudentID = @StudentID, Date_of_birth = @Date_of_birth, Class = @Class, Course = @Course, Gender = @Gender WHERE StudentID = @StudentID";
            SqlCommand cmd = new SqlCommand(sqlupdate, con);
            cmd.Parameters.AddWithValue("StudentID", tb_studentID.Text);
            cmd.Parameters.AddWithValue("Student_name", tb_studentname.Text);
            cmd.Parameters.AddWithValue("Class", tb_class.Text);
            cmd.Parameters.AddWithValue("Course", tb_course.Text);
            cmd.Parameters.AddWithValue("Gender", cb_Gender.Text);
            cmd.Parameters.AddWithValue("Date_of_birth", dtime_date.Text);
            _ = cmd.ExecuteNonQuery();
            hienthi();
        }

        private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv1.CurrentRow.Index;
            tb_studentID.Text = dgv1.Rows[i].Cells[0].Value.ToString();
            tb_studentname.Text = dgv1.Rows[i].Cells[1].Value.ToString();
            tb_class.Text = dgv1.Rows[i].Cells[2].Value.ToString();
            tb_course.Text = dgv1.Rows[i].Cells[3].Value.ToString();
            cb_Gender.Text = dgv1.Rows[i].Cells[4].Value.ToString();
            dtime_date.Text = dgv1.Rows[i].Cells[5].Value.ToString();
        }
    }
}


