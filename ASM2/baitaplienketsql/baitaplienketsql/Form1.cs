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
using System.Linq.Expressions;

namespace baitaplienketsql
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String str = @"Data Source=MSI\\TAYSQL;Initial Catalog=qlsv;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * form Thongtinsinhvie ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(str);
                connection.Open();

                loaddata();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tb_masv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_tensv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cb_gioitinh.Text = dgv.Rows[i].Cells[3].Value.ToString();
            dtime_ngaysinh.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_lop.Text = dgv.Rows[i].Cells[5].Value.ToString();
            tb_khoahoc.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Thongtinsinhvien valeus('"+tb_masv.Text+"', '"+tb_tensv.Text +"', '"+dtime_ngaysinh.Text+"', '"+cb_gioitinh.Text+"', '"+tb_lop.Text+"', '"+tb_khoahoc.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
