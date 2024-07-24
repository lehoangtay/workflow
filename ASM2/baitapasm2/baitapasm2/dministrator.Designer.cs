namespace baitapasm2
{
    partial class dministrator
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
            this.chb_show = new System.Windows.Forms.CheckBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chb_show
            // 
            this.chb_show.AutoSize = true;
            this.chb_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_show.Location = new System.Drawing.Point(331, 145);
            this.chb_show.Name = "chb_show";
            this.chb_show.Size = new System.Drawing.Size(122, 20);
            this.chb_show.TabIndex = 13;
            this.chb_show.Text = "show password";
            this.chb_show.UseVisualStyleBackColor = true;
            this.chb_show.CheckedChanged += new System.EventHandler(this.chb_show_CheckedChanged);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(331, 100);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(268, 22);
            this.tb_password.TabIndex = 12;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(331, 31);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(268, 22);
            this.tb_user.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "user";
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.SystemColors.Info;
            this.bt_exit.Location = new System.Drawing.Point(475, 194);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(192, 50);
            this.bt_exit.TabIndex = 8;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(217, 194);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(183, 50);
            this.bt_login.TabIndex = 7;
            this.bt_login.Text = "Log in";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // dministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chb_show);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_login);
            this.Name = "dministrator";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.dministrator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_show;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_login;
    }
}