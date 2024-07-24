namespace baitapqlsv
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_course = new System.Windows.Forms.TextBox();
            this.dtime_date = new System.Windows.Forms.DateTimePicker();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.tb_class = new System.Windows.Forms.TextBox();
            this.tb_studentname = new System.Windows.Forms.TextBox();
            this.tb_studentID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lable1 = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_initialization = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.tb_course);
            this.groupBox1.Controls.Add(this.dtime_date);
            this.groupBox1.Controls.Add(this.cb_gender);
            this.groupBox1.Controls.Add(this.tb_class);
            this.groupBox1.Controls.Add(this.tb_studentname);
            this.groupBox1.Controls.Add(this.tb_studentID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tb_course
            // 
            this.tb_course.Location = new System.Drawing.Point(458, 33);
            this.tb_course.Name = "tb_course";
            this.tb_course.Size = new System.Drawing.Size(154, 22);
            this.tb_course.TabIndex = 11;
            // 
            // dtime_date
            // 
            this.dtime_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_date.Location = new System.Drawing.Point(458, 102);
            this.dtime_date.Name = "dtime_date";
            this.dtime_date.Size = new System.Drawing.Size(154, 22);
            this.dtime_date.TabIndex = 10;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cb_gender.Location = new System.Drawing.Point(458, 170);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(154, 24);
            this.cb_gender.TabIndex = 9;
            // 
            // tb_class
            // 
            this.tb_class.Location = new System.Drawing.Point(145, 172);
            this.tb_class.Name = "tb_class";
            this.tb_class.Size = new System.Drawing.Size(167, 22);
            this.tb_class.TabIndex = 8;
            // 
            // tb_studentname
            // 
            this.tb_studentname.Location = new System.Drawing.Point(145, 102);
            this.tb_studentname.Multiline = true;
            this.tb_studentname.Name = "tb_studentname";
            this.tb_studentname.Size = new System.Drawing.Size(167, 22);
            this.tb_studentname.TabIndex = 7;
            // 
            // tb_studentID
            // 
            this.tb_studentID.Location = new System.Drawing.Point(145, 33);
            this.tb_studentID.Multiline = true;
            this.tb_studentID.Name = "tb_studentID";
            this.tb_studentID.Size = new System.Drawing.Size(167, 22);
            this.tb_studentID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(928, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student information";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(15, 21);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(893, 284);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lable1
            // 
            this.lable1.Location = new System.Drawing.Point(681, 388);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(101, 28);
            this.lable1.TabIndex = 6;
            this.lable1.Text = "Search";
            this.lable1.UseVisualStyleBackColor = true;
            this.lable1.Click += new System.EventHandler(this.lable1_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(691, 470);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(195, 50);
            this.bt_add.TabIndex = 9;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.Salmon;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(691, 545);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(195, 50);
            this.bt_delete.TabIndex = 10;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.Location = new System.Drawing.Point(1002, 470);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(195, 50);
            this.bt_update.TabIndex = 11;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_initialization
            // 
            this.bt_initialization.BackColor = System.Drawing.Color.LightGreen;
            this.bt_initialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_initialization.Location = new System.Drawing.Point(1002, 546);
            this.bt_initialization.Name = "bt_initialization";
            this.bt_initialization.Size = new System.Drawing.Size(195, 49);
            this.bt_initialization.TabIndex = 12;
            this.bt_initialization.Text = "Initialization";
            this.bt_initialization.UseVisualStyleBackColor = false;
            this.bt_initialization.Click += new System.EventHandler(this.bt_initialization_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Yi Baiti", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(780, 388);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(417, 28);
            this.tb_search.TabIndex = 13;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1161, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1233, 628);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_initialization);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tb_course;
        private System.Windows.Forms.DateTimePicker dtime_date;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.TextBox tb_class;
        private System.Windows.Forms.TextBox tb_studentname;
        private System.Windows.Forms.TextBox tb_studentID;
        private System.Windows.Forms.Button lable1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_initialization;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}