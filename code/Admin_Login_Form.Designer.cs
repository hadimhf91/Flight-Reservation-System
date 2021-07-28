namespace Flight_Reservation_System
{
    partial class Admin_Login_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login_Form));
            this.pic_Admin = new System.Windows.Forms.PictureBox();
            this.btn_AdminLogin = new System.Windows.Forms.Button();
            this.txtBox_AdminPass = new System.Windows.Forms.TextBox();
            this.txtBox_AdminName = new System.Windows.Forms.TextBox();
            this.btn_AdminExit = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Admin
            // 
            this.pic_Admin.Image = ((System.Drawing.Image)(resources.GetObject("pic_Admin.Image")));
            this.pic_Admin.Location = new System.Drawing.Point(27, 53);
            this.pic_Admin.Name = "pic_Admin";
            this.pic_Admin.Size = new System.Drawing.Size(74, 63);
            this.pic_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Admin.TabIndex = 23;
            this.pic_Admin.TabStop = false;
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.AutoEllipsis = true;
            this.btn_AdminLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AdminLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_AdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_AdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminLogin.Location = new System.Drawing.Point(62, 178);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.Size = new System.Drawing.Size(134, 40);
            this.btn_AdminLogin.TabIndex = 2;
            this.btn_AdminLogin.Text = "Login";
            this.toolTip1.SetToolTip(this.btn_AdminLogin, "Press to log in");
            this.btn_AdminLogin.UseVisualStyleBackColor = true;
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            // 
            // txtBox_AdminPass
            // 
            this.txtBox_AdminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_AdminPass.Location = new System.Drawing.Point(202, 102);
            this.txtBox_AdminPass.Name = "txtBox_AdminPass";
            this.txtBox_AdminPass.Size = new System.Drawing.Size(190, 31);
            this.txtBox_AdminPass.TabIndex = 1;
            this.txtBox_AdminPass.UseSystemPasswordChar = true;
            // 
            // txtBox_AdminName
            // 
            this.txtBox_AdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_AdminName.Location = new System.Drawing.Point(202, 34);
            this.txtBox_AdminName.Name = "txtBox_AdminName";
            this.txtBox_AdminName.Size = new System.Drawing.Size(190, 31);
            this.txtBox_AdminName.TabIndex = 0;
            // 
            // btn_AdminExit
            // 
            this.btn_AdminExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminExit.Location = new System.Drawing.Point(258, 178);
            this.btn_AdminExit.Name = "btn_AdminExit";
            this.btn_AdminExit.Size = new System.Drawing.Size(133, 40);
            this.btn_AdminExit.TabIndex = 3;
            this.btn_AdminExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btn_AdminExit, "press to exit form");
            this.btn_AdminExit.UseVisualStyleBackColor = true;
            this.btn_AdminExit.Click += new System.EventHandler(this.btn_AdminExit_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(107, 109);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 20);
            this.lbl_Password.TabIndex = 18;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(107, 41);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(89, 20);
            this.lbl_UserName.TabIndex = 17;
            this.lbl_UserName.Text = "User Name";
            // 
            // Admin_Login_Form
            // 
            this.AcceptButton = this.btn_AdminLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 260);
            this.Controls.Add(this.pic_Admin);
            this.Controls.Add(this.btn_AdminLogin);
            this.Controls.Add(this.txtBox_AdminPass);
            this.Controls.Add(this.txtBox_AdminName);
            this.Controls.Add(this.btn_AdminExit);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login_Form";
            this.Load += new System.EventHandler(this.Admin_Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Admin;
        private System.Windows.Forms.Button btn_AdminLogin;
        private System.Windows.Forms.TextBox txtBox_AdminPass;
        private System.Windows.Forms.TextBox txtBox_AdminName;
        private System.Windows.Forms.Button btn_AdminExit;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}