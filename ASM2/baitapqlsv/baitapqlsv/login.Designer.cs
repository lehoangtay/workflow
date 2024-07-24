namespace baitapqlsv
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.chb_show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(385, 199);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(263, 22);
            this.tb_username.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(385, 252);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(263, 22);
            this.tb_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(267, 391);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(157, 55);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(520, 391);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(145, 55);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // chb_show
            // 
            this.chb_show.AutoSize = true;
            this.chb_show.BackColor = System.Drawing.Color.Transparent;
            this.chb_show.Location = new System.Drawing.Point(374, 309);
            this.chb_show.Name = "chb_show";
            this.chb_show.Size = new System.Drawing.Size(124, 20);
            this.chb_show.TabIndex = 10;
            this.chb_show.Text = "Show password";
            this.chb_show.UseVisualStyleBackColor = false;
            this.chb_show.CheckedChanged += new System.EventHandler(this.chb_show_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 548);
            this.Controls.Add(this.chb_show);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.CheckBox chb_show;
    }
}

