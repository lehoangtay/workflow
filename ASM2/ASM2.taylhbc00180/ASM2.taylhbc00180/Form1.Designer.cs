namespace ASM2.taylhbc00180
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
            this.txb_user = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.chb_hienthi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txb_user
            // 
            this.txb_user.Location = new System.Drawing.Point(267, 147);
            this.txb_user.Name = "txb_user";
            this.txb_user.Size = new System.Drawing.Size(217, 22);
            this.txb_user.TabIndex = 0;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(267, 203);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(217, 22);
            this.txb_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(151, 208);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(66, 16);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(356, 349);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // chb_hienthi
            // 
            this.chb_hienthi.AutoSize = true;
            this.chb_hienthi.Location = new System.Drawing.Point(333, 295);
            this.chb_hienthi.Name = "chb_hienthi";
            this.chb_hienthi.Size = new System.Drawing.Size(133, 20);
            this.chb_hienthi.TabIndex = 5;
            this.chb_hienthi.Text = "Hiển thị mật khẩu ";
            this.chb_hienthi.UseVisualStyleBackColor = true;
            this.chb_hienthi.CheckedChanged += new System.EventHandler(this.chb_hienthi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 505);
            this.Controls.Add(this.chb_hienthi);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_user);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_user;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox chb_hienthi;
    }
}

