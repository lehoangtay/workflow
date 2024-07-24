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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Student());
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new dministrator());
            label1.Text = button2.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
