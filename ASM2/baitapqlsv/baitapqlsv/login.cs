using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapqlsv
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string password = tb_password.Text;
            string user = tb_username.Text;
            if (this.tb_username.Text == "sinhvien")
                if (password == "123456789")
                {
                    Student form2 = new Student();
                    form2.Show();
                }
                else
                    MessageBox.Show("Please try again", "notification ");
            this.tb_password.Focus();
        }

        private void chb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_show.Checked == true)
            {
                tb_password.PasswordChar = (char)0;
            }
            else
            {
                tb_password.PasswordChar = '*';
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("do you want to exit?", "attention !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }
    }
}
