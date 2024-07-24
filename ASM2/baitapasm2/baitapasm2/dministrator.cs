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
    public partial class dministrator : Form
    {
        public dministrator()
        {
            InitializeComponent();
        }

        private void dministrator_Load(object sender, EventArgs e)
        {
          
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("do you want to exit?", "attention !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
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

        private void bt_login_Click(object sender, EventArgs e)
        {
            string password = tb_password.Text;
            string user = tb_user.Text;
            if (this.tb_user.Text == "quanly")
                if (password == "123456789")
                {
                    // Mật khẩu đúng, chuyển sang form 2
                    FormAdmin information = new FormAdmin();
                    information.Show();

                }
                else
                    MessageBox.Show("Please try again", "notification ");
            this.tb_user.Focus();
                    MessageBox.Show("Please try again", "notification ");
            this.tb_password.Focus();
        }
    }
}
