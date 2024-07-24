namespace baitapasm2
{
    partial class Formstudent
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
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_initialization = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.dtime_date = new System.Windows.Forms.DateTimePicker();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.tb_course = new System.Windows.Forms.TextBox();
            this.tb_class = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tb_studentname = new System.Windows.Forms.TextBox();
            this.tb_studentID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Studentinformation = new System.Windows.Forms.Button();
            this.bt_Scoreinformation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(624, 50);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(528, 22);
            this.tb_timkiem.TabIndex = 12;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt_timkiem.Location = new System.Drawing.Point(515, 48);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(98, 24);
            this.bt_timkiem.TabIndex = 11;
            this.bt_timkiem.Text = "Search";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.LawnGreen;
            this.bt_delete.Location = new System.Drawing.Point(281, 392);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(134, 36);
            this.bt_delete.TabIndex = 16;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            // 
            // bt_initialization
            // 
            this.bt_initialization.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_initialization.Location = new System.Drawing.Point(281, 309);
            this.bt_initialization.Name = "bt_initialization";
            this.bt_initialization.Size = new System.Drawing.Size(134, 37);
            this.bt_initialization.TabIndex = 15;
            this.bt_initialization.Text = "Initialization";
            this.bt_initialization.UseVisualStyleBackColor = false;
            // 
            // bt_Update
            // 
            this.bt_Update.BackColor = System.Drawing.SystemColors.Desktop;
            this.bt_Update.Location = new System.Drawing.Point(33, 392);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(128, 36);
            this.bt_Update.TabIndex = 14;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = false;
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.DarkSalmon;
            this.bt_add.Location = new System.Drawing.Point(33, 309);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(128, 37);
            this.bt_add.TabIndex = 13;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dtime_date
            // 
            this.dtime_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_date.Location = new System.Drawing.Point(185, 249);
            this.dtime_date.Name = "dtime_date";
            this.dtime_date.Size = new System.Drawing.Size(202, 27);
            this.dtime_date.TabIndex = 12;
            // 
            // cb_Gender
            // 
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "male",
            "female "});
            this.cb_Gender.Location = new System.Drawing.Point(185, 206);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(202, 28);
            this.cb_Gender.TabIndex = 11;
            // 
            // tb_course
            // 
            this.tb_course.Location = new System.Drawing.Point(185, 166);
            this.tb_course.Name = "tb_course";
            this.tb_course.Size = new System.Drawing.Size(202, 27);
            this.tb_course.TabIndex = 10;
            // 
            // tb_class
            // 
            this.tb_class.Location = new System.Drawing.Point(185, 124);
            this.tb_class.Name = "tb_class";
            this.tb_class.Size = new System.Drawing.Size(202, 27);
            this.tb_class.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(515, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 401);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 21);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(876, 380);
            this.dgv.TabIndex = 0;
            // 
            // tb_studentname
            // 
            this.tb_studentname.Location = new System.Drawing.Point(185, 79);
            this.tb_studentname.Name = "tb_studentname";
            this.tb_studentname.Size = new System.Drawing.Size(202, 27);
            this.tb_studentname.TabIndex = 8;
            // 
            // tb_studentID
            // 
            this.tb_studentID.Location = new System.Drawing.Point(185, 38);
            this.tb_studentID.Name = "tb_studentID";
            this.tb_studentID.Size = new System.Drawing.Size(202, 27);
            this.tb_studentID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date of birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_delete);
            this.groupBox2.Controls.Add(this.bt_initialization);
            this.groupBox2.Controls.Add(this.bt_Update);
            this.groupBox2.Controls.Add(this.bt_add);
            this.groupBox2.Controls.Add(this.dtime_date);
            this.groupBox2.Controls.Add(this.cb_Gender);
            this.groupBox2.Controls.Add(this.tb_course);
            this.groupBox2.Controls.Add(this.tb_class);
            this.groupBox2.Controls.Add(this.tb_studentname);
            this.groupBox2.Controls.Add(this.tb_studentID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 440);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bt_Studentinformation
            // 
            this.bt_Studentinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Studentinformation.Location = new System.Drawing.Point(20, 24);
            this.bt_Studentinformation.Name = "bt_Studentinformation";
            this.bt_Studentinformation.Size = new System.Drawing.Size(178, 32);
            this.bt_Studentinformation.TabIndex = 23;
            this.bt_Studentinformation.Text = "Student information";
            this.bt_Studentinformation.UseVisualStyleBackColor = true;
            // 
            // bt_Scoreinformation
            // 
            this.bt_Scoreinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Scoreinformation.Location = new System.Drawing.Point(219, 23);
            this.bt_Scoreinformation.Name = "bt_Scoreinformation";
            this.bt_Scoreinformation.Size = new System.Drawing.Size(181, 33);
            this.bt_Scoreinformation.TabIndex = 22;
            this.bt_Scoreinformation.Text = "Score information";
            this.bt_Scoreinformation.UseVisualStyleBackColor = true;
            this.bt_Scoreinformation.Click += new System.EventHandler(this.bt_Scoreinformation_Click);
            // 
            // Formstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 543);
            this.Controls.Add(this.bt_Studentinformation);
            this.Controls.Add(this.bt_Scoreinformation);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Formstudent";
            this.Text = "Formstudent";
            this.Load += new System.EventHandler(this.Formstudent_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_initialization;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DateTimePicker dtime_date;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.TextBox tb_course;
        private System.Windows.Forms.TextBox tb_class;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tb_studentname;
        private System.Windows.Forms.TextBox tb_studentID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_Studentinformation;
        private System.Windows.Forms.Button bt_Scoreinformation;
    }
}