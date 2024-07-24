using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapasm2
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string password = khungmatkhau.Text;
            string user = khungdangnhap.Text;
            if (this.khungdangnhap.Text == "sinhvien")
                if (password == "123456789")
                {
                    // Mật khẩu đúng, chuyển sang form 2
                    Formstudent formstudent = new Formstudent();
                    formstudent.Show();

                }
                else
                    MessageBox.Show("Please try again", "notification ");
            this.khungdangnhap.Focus();
                    MessageBox.Show("Please try again", "notification ");
            this.khungmatkhau .Focus();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("do you want to exit?", "attention !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void chb_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_hienthi.Checked == true)
            {
                khungmatkhau.PasswordChar = (char)0;
            }
            else
            {
                khungmatkhau.PasswordChar = '*';
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
