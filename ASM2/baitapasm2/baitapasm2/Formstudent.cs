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

namespace baitapasm2
{
    public partial class Formstudent : Form
    {
        public Formstudent()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void Formstudent_Load(object sender, EventArgs e)
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
            dgv.DataSource = dt;
        }
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            string sqlsearch = "SELECT * FROM tb_student WHERE StudentID = @StudentID";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            cmd.Parameters.AddWithValue("StudentID", tb_timkiem.Text);
            cmd.Parameters.AddWithValue("Student_name", tb_studentname.Text);
            cmd.Parameters.AddWithValue("Class", tb_class.Text);
            cmd.Parameters.AddWithValue("Course", tb_course.Text);
            cmd.Parameters.AddWithValue("Gender", cb_Gender.Text);
            cmd.Parameters.AddWithValue("Date_of_birth", dtime_date.Text);
            _ = cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv.DataSource = dt;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bt_Scoreinformation_Click(object sender, EventArgs e)
        {
            FormstudentScore Score = new FormstudentScore();
            Score.ShowDialog();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {

        }
    }
}
