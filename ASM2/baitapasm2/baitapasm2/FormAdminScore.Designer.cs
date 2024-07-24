namespace baitapasm2
{
    partial class FormAdminScore
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_delete2 = new System.Windows.Forms.Button();
            this.bt_Add2 = new System.Windows.Forms.Button();
            this.tb_studentname2 = new System.Windows.Forms.TextBox();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.tb_score = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.tb_studentid2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.bt_Studentinformation = new System.Windows.Forms.Button();
            this.bt_Scoreinformation = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_delete2);
            this.groupBox4.Controls.Add(this.bt_Add2);
            this.groupBox4.Controls.Add(this.tb_studentname2);
            this.groupBox4.Controls.Add(this.tb_subject);
            this.groupBox4.Controls.Add(this.tb_score);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.l);
            this.groupBox4.Controls.Add(this.tb_studentid2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(56, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 445);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Enter Information";
            // 
            // bt_delete2
            // 
            this.bt_delete2.Location = new System.Drawing.Point(242, 363);
            this.bt_delete2.Name = "bt_delete2";
            this.bt_delete2.Size = new System.Drawing.Size(159, 48);
            this.bt_delete2.TabIndex = 24;
            this.bt_delete2.Text = "Delete";
            this.bt_delete2.UseVisualStyleBackColor = true;
            this.bt_delete2.Click += new System.EventHandler(this.bt_delete2_Click);
            // 
            // bt_Add2
            // 
            this.bt_Add2.Location = new System.Drawing.Point(52, 363);
            this.bt_Add2.Name = "bt_Add2";
            this.bt_Add2.Size = new System.Drawing.Size(155, 48);
            this.bt_Add2.TabIndex = 23;
            this.bt_Add2.Text = "Add";
            this.bt_Add2.UseVisualStyleBackColor = true;
            this.bt_Add2.Click += new System.EventHandler(this.bt_Add2_Click);
            // 
            // tb_studentname2
            // 
            this.tb_studentname2.Location = new System.Drawing.Point(199, 143);
            this.tb_studentname2.Name = "tb_studentname2";
            this.tb_studentname2.Size = new System.Drawing.Size(202, 27);
            this.tb_studentname2.TabIndex = 22;
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(199, 193);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(202, 27);
            this.tb_subject.TabIndex = 21;
            // 
            // tb_score
            // 
            this.tb_score.Location = new System.Drawing.Point(199, 247);
            this.tb_score.Name = "tb_score";
            this.tb_score.Size = new System.Drawing.Size(202, 27);
            this.tb_score.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Score";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Subject";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(49, 149);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(115, 20);
            this.l.TabIndex = 17;
            this.l.Text = "Student Name";
            // 
            // tb_studentid2
            // 
            this.tb_studentid2.Location = new System.Drawing.Point(199, 100);
            this.tb_studentid2.Name = "tb_studentid2";
            this.tb_studentid2.Size = new System.Drawing.Size(202, 27);
            this.tb_studentid2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "StudentID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(590, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(753, 354);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(6, 21);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(741, 327);
            this.dgv2.TabIndex = 0;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bt_search.Location = new System.Drawing.Point(589, 461);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(98, 24);
            this.bt_search.TabIndex = 28;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(693, 461);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(528, 22);
            this.tb_Search.TabIndex = 29;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // bt_Studentinformation
            // 
            this.bt_Studentinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Studentinformation.Location = new System.Drawing.Point(47, 12);
            this.bt_Studentinformation.Name = "bt_Studentinformation";
            this.bt_Studentinformation.Size = new System.Drawing.Size(178, 32);
            this.bt_Studentinformation.TabIndex = 30;
            this.bt_Studentinformation.Text = "Student information";
            this.bt_Studentinformation.UseVisualStyleBackColor = true;
            this.bt_Studentinformation.Click += new System.EventHandler(this.bt_Studentinformation_Click);
            // 
            // bt_Scoreinformation
            // 
            this.bt_Scoreinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Scoreinformation.Location = new System.Drawing.Point(246, 12);
            this.bt_Scoreinformation.Name = "bt_Scoreinformation";
            this.bt_Scoreinformation.Size = new System.Drawing.Size(181, 33);
            this.bt_Scoreinformation.TabIndex = 31;
            this.bt_Scoreinformation.Text = "Score information";
            this.bt_Scoreinformation.UseVisualStyleBackColor = true;
            this.bt_Scoreinformation.Click += new System.EventHandler(this.bt_Scoreinformation_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 552);
            this.Controls.Add(this.bt_Scoreinformation);
            this.Controls.Add(this.bt_Studentinformation);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Score";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_delete2;
        private System.Windows.Forms.Button bt_Add2;
        private System.Windows.Forms.TextBox tb_studentname2;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox tb_studentid2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button bt_Studentinformation;
        private System.Windows.Forms.Button bt_Scoreinformation;
    }
}