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

namespace baitapasm2
{
    public partial class FormAdminScore : Form
    {
        public FormAdminScore()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void Score_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=MSI\TAYSQL;Initial Catalog=asm2;Integrated Security=True");
            con.Open();
            hienthi2();
        }
        private void Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void hienthi2()
        {
            string sqlselect = "SELECT *FROM tb_Score";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv2.DataSource = dt;
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv2.CurrentRow.Index;
            tb_studentid2.Text = dgv2.Rows[i].Cells[0].Value.ToString();
            tb_studentname2.Text = dgv2.Rows[i].Cells[1].Value.ToString();
            tb_subject.Text = dgv2.Rows[i].Cells[2].Value.ToString();
            tb_score.Text = dgv2.Rows[i].Cells[3].Value.ToString();
        }
        private void bt_search_Click(object sender, EventArgs e)
        {

        }
        private void bt_Studentinformation_Click(object sender, EventArgs e)
        {
            FormAdmin information = new FormAdmin();
            information.Show();
        }

        private void bt_Scoreinformation_Click(object sender, EventArgs e)
        {
            FormAdminScore Score = new FormAdminScore();
            Score.Show();
        }

        private void bt_delete2_Click(object sender, EventArgs e)
        {
            string sqldelete = "DELETE FROM tb_Score WHERE StudentID = @StudentID";
            SqlCommand cmd = new SqlCommand(sqldelete, con);
            cmd.Parameters.AddWithValue("StudentID", tb_studentid2.Text);
            cmd.Parameters.AddWithValue("Student_name", tb_studentname2.Text);
            cmd.Parameters.AddWithValue("Subject", tb_subject.Text);
            cmd.Parameters.AddWithValue("Score", tb_score.Text);
            _ = cmd.ExecuteNonQuery();
            hienthi2();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string sqlsearch = "SELECT * FROM tb_Score WHERE StudentID = @StudentID";
            SqlCommand cmd = new SqlCommand(sqlsearch, con);
            cmd.Parameters.AddWithValue("StudentID", tb_Search.Text);
            cmd.Parameters.AddWithValue("Student_name", tb_studentname2.Text);
            cmd.Parameters.AddWithValue("Subject", tb_subject.Text);
            cmd.Parameters.AddWithValue("Score", tb_score.Text);
            _ = cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv2.DataSource = dt;
        }

        private void bt_Add2_Click(object sender, EventArgs e)
        {
            string sqlTadd = "INSERT INTO tb_Score VALUES (@StudentID, @Student_name, @Subject, @Score)";
            SqlCommand cmd = new SqlCommand(sqlTadd, con);
            cmd.Parameters.AddWithValue("StudentID", tb_studentid2.Text);
            cmd.Parameters.AddWithValue("Student_name", tb_studentname2.Text);
            cmd.Parameters.AddWithValue("Subject", tb_subject.Text);
            cmd.Parameters.AddWithValue("Score", tb_score.Text);
            _ = cmd.ExecuteNonQuery();
            hienthi2();
        }
    }
}
