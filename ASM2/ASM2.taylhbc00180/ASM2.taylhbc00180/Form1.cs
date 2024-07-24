using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2.taylhbc00180
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txb_user.Text) || !string.IsNullOrWhiteSpace(txb_password.Text))
            {
                MessageBox.Show("Đăng nhập thành công !!!");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
            }
            sinhvien insideForm = new sinhvien();
            insideForm.TopLevel = true;
            insideForm.Show();
        }

        private void chb_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_hienthi.Checked == true)
            {
                txb_password.PasswordChar = (char)0;
            }
            else
            {
                txb_password.PasswordChar = '*';
            }
        }
    }
}
