namespace baitapasm2
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
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.khungdangnhap = new System.Windows.Forms.TextBox();
            this.khungmatkhau = new System.Windows.Forms.TextBox();
            this.chb_hienthi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(215, 194);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(183, 50);
            this.bt_login.TabIndex = 0;
            this.bt_login.Text = "Log in";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.SystemColors.Info;
            this.bt_exit.Location = new System.Drawing.Point(473, 194);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(192, 50);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // khungdangnhap
            // 
            this.khungdangnhap.Location = new System.Drawing.Point(329, 31);
            this.khungdangnhap.Name = "khungdangnhap";
            this.khungdangnhap.Size = new System.Drawing.Size(268, 22);
            this.khungdangnhap.TabIndex = 4;
            // 
            // khungmatkhau
            // 
            this.khungmatkhau.Location = new System.Drawing.Point(329, 100);
            this.khungmatkhau.Name = "khungmatkhau";
            this.khungmatkhau.Size = new System.Drawing.Size(268, 22);
            this.khungmatkhau.TabIndex = 5;
            // 
            // chb_hienthi
            // 
            this.chb_hienthi.AutoSize = true;
            this.chb_hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_hienthi.Location = new System.Drawing.Point(329, 145);
            this.chb_hienthi.Name = "chb_hienthi";
            this.chb_hienthi.Size = new System.Drawing.Size(122, 20);
            this.chb_hienthi.TabIndex = 6;
            this.chb_hienthi.Text = "show password";
            this.chb_hienthi.UseVisualStyleBackColor = true;
            this.chb_hienthi.CheckedChanged += new System.EventHandler(this.chb_hienthi_CheckedChanged);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 524);
            this.Controls.Add(this.chb_hienthi);
            this.Controls.Add(this.khungmatkhau);
            this.Controls.Add(this.khungdangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_login);
            this.Name = "Student";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox khungdangnhap;
        private System.Windows.Forms.TextBox khungmatkhau;
        private System.Windows.Forms.CheckBox chb_hienthi;
    }
}