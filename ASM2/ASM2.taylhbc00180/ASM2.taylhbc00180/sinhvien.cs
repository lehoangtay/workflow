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
    public partial class sinhvien : Form
    {
        public sinhvien()
        {
            InitializeComponent();
        }
        classsinhvien[] listclasssinhvien = new classsinhvien[20];
        DataTable sv = new DataTable();
        int StudentID_auto = 0;

        private void sinhvien_Load(object sender, EventArgs e)
        {
            txb_StudentID.Text= StudentID_auto.ToString();

            sv.Columns.Add(new DataColumn("Student Name", typeof(string)));
            sv.Columns.Add(new DataColumn("lass",typeof(string)));
            sv.Columns.Add(new DataColumn("Course", typeof(string)));
            sv.Columns.Add(new DataColumn("Date of birth", typeof(int)));

            dataGridView1.DataSource = sv;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            classsinhvien p = new classsinhvien();
            p.StudentID = StudentID_auto;
            p.Date_of_birth = txb_date.Text;
            p.Course = txb_course.Text;
            p.Student_Name = txb_name.Text;
            p.Class = txb_class.Text;

            listclasssinhvien[StudentID_auto] = p;
            StudentID_auto++;
            LoadData(listclasssinhvien);
        }
        private void LoadData(classsinhvien[] listclasssinhvien)
        {
            sv.Clear();
            for (int i = 0; i < StudentID_auto;i++)
            {
                classsinhvien p = listclasssinhvien[i];
                if (p != null)
                {
                    DataRow dr = sv.NewRow();
                    dr[0] = p.StudentID;
                    dr[1] = p.Student_Name;
                    dr[2] = p.Class;
                    dr[3] = p.Course;
                    dr[4] = p.Date_of_birth;
                    sv.Rows.Add(dr);
                }
            }
            dataGridView1.DataSource = sv.DefaultView;

            txb_StudentID.Text = StudentID_auto.ToString();
            txb_name.Clear();
            txb_class.Clear();
            txb_course.Clear();
            txb_date.Clear();

        }
    }
    
}
