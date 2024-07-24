namespace baitaplienketsql
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tensv = new System.Windows.Forms.Label();
            this.masv = new System.Windows.Forms.Label();
            this.tb_ngaysinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.khoahoc = new System.Windows.Forms.Label();
            this.tb_tensv = new System.Windows.Forms.TextBox();
            this.tb_masv = new System.Windows.Forms.TextBox();
            this.dtime_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.tb_lop = new System.Windows.Forms.TextBox();
            this.tb_khoahoc = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_ = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_khoitao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(56, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_khoahoc);
            this.groupBox2.Controls.Add(this.tb_lop);
            this.groupBox2.Controls.Add(this.cb_gioitinh);
            this.groupBox2.Controls.Add(this.dtime_ngaysinh);
            this.groupBox2.Controls.Add(this.tb_masv);
            this.groupBox2.Controls.Add(this.tb_tensv);
            this.groupBox2.Controls.Add(this.khoahoc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_ngaysinh);
            this.groupBox2.Controls.Add(this.masv);
            this.groupBox2.Controls.Add(this.tensv);
            this.groupBox2.Location = new System.Drawing.Point(56, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 32);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(709, 270);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // tensv
            // 
            this.tensv.AutoSize = true;
            this.tensv.Location = new System.Drawing.Point(21, 33);
            this.tensv.Name = "tensv";
            this.tensv.Size = new System.Drawing.Size(49, 16);
            this.tensv.TabIndex = 0;
            this.tensv.Text = "TenSV";
            // 
            // masv
            // 
            this.masv.AutoSize = true;
            this.masv.Location = new System.Drawing.Point(24, 98);
            this.masv.Name = "masv";
            this.masv.Size = new System.Drawing.Size(44, 16);
            this.masv.TabIndex = 1;
            this.masv.Text = "MaSV";
            // 
            // tb_ngaysinh
            // 
            this.tb_ngaysinh.AutoSize = true;
            this.tb_ngaysinh.Location = new System.Drawing.Point(269, 36);
            this.tb_ngaysinh.Name = "tb_ngaysinh";
            this.tb_ngaysinh.Size = new System.Drawing.Size(64, 16);
            this.tb_ngaysinh.TabIndex = 2;
            this.tb_ngaysinh.Text = "ngay sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gioi tinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lop";
            // 
            // khoahoc
            // 
            this.khoahoc.AutoSize = true;
            this.khoahoc.Location = new System.Drawing.Point(516, 98);
            this.khoahoc.Name = "khoahoc";
            this.khoahoc.Size = new System.Drawing.Size(63, 16);
            this.khoahoc.TabIndex = 5;
            this.khoahoc.Text = "Khoa hoc";
            // 
            // tb_tensv
            // 
            this.tb_tensv.Location = new System.Drawing.Point(85, 33);
            this.tb_tensv.Name = "tb_tensv";
            this.tb_tensv.Size = new System.Drawing.Size(142, 22);
            this.tb_tensv.TabIndex = 6;
            // 
            // tb_masv
            // 
            this.tb_masv.Location = new System.Drawing.Point(85, 98);
            this.tb_masv.Name = "tb_masv";
            this.tb_masv.Size = new System.Drawing.Size(142, 22);
            this.tb_masv.TabIndex = 7;
            // 
            // dtime_ngaysinh
            // 
            this.dtime_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_ngaysinh.Location = new System.Drawing.Point(339, 36);
            this.dtime_ngaysinh.Name = "dtime_ngaysinh";
            this.dtime_ngaysinh.Size = new System.Drawing.Size(121, 22);
            this.dtime_ngaysinh.TabIndex = 8;
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(339, 95);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(121, 24);
            this.cb_gioitinh.TabIndex = 9;
            // 
            // tb_lop
            // 
            this.tb_lop.Location = new System.Drawing.Point(615, 36);
            this.tb_lop.Name = "tb_lop";
            this.tb_lop.Size = new System.Drawing.Size(154, 22);
            this.tb_lop.TabIndex = 10;
            // 
            // tb_khoahoc
            // 
            this.tb_khoahoc.Location = new System.Drawing.Point(615, 97);
            this.tb_khoahoc.Name = "tb_khoahoc";
            this.tb_khoahoc.Size = new System.Drawing.Size(154, 22);
            this.tb_khoahoc.TabIndex = 11;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(873, 270);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(192, 42);
            this.bt_them.TabIndex = 2;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_
            // 
            this.bt_.Location = new System.Drawing.Point(873, 340);
            this.bt_.Name = "bt_";
            this.bt_.Size = new System.Drawing.Size(192, 48);
            this.bt_.TabIndex = 3;
            this.bt_.Text = "Sửa";
            this.bt_.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(873, 419);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(192, 46);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // bt_khoitao
            // 
            this.bt_khoitao.Location = new System.Drawing.Point(873, 494);
            this.bt_khoitao.Name = "bt_khoitao";
            this.bt_khoitao.Size = new System.Drawing.Size(192, 46);
            this.bt_khoitao.TabIndex = 5;
            this.bt_khoitao.Text = "Khởi tạo";
            this.bt_khoitao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 593);
            this.Controls.Add(this.bt_khoitao);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Thông Tin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label khoahoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tb_ngaysinh;
        private System.Windows.Forms.Label masv;
        private System.Windows.Forms.Label tensv;
        private System.Windows.Forms.TextBox tb_masv;
        private System.Windows.Forms.TextBox tb_tensv;
        private System.Windows.Forms.TextBox tb_khoahoc;
        private System.Windows.Forms.TextBox tb_lop;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.DateTimePicker dtime_ngaysinh;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_khoitao;
    }
}

