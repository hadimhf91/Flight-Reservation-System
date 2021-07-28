namespace Flight_Reservation_System
{
    partial class Customer_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Login_Form));
            this.pic_Customer = new System.Windows.Forms.PictureBox();
            this.btn_CustomerLogin = new System.Windows.Forms.Button();
            this.txtBox_CustomerPass = new System.Windows.Forms.TextBox();
            this.txtBox_CustomerName = new System.Windows.Forms.TextBox();
            this.btn_CustomerExit = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Customer
            // 
            this.pic_Customer.Image = ((System.Drawing.Image)(resources.GetObject("pic_Customer.Image")));
            this.pic_Customer.Location = new System.Drawing.Point(31, 56);
            this.pic_Customer.Name = "pic_Customer";
            this.pic_Customer.Size = new System.Drawing.Size(74, 63);
            this.pic_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Customer.TabIndex = 22;
            this.pic_Customer.TabStop = false;
            // 
            // btn_CustomerLogin
            // 
            this.btn_CustomerLogin.AutoEllipsis = true;
            this.btn_CustomerLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_CustomerLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_CustomerLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_CustomerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerLogin.Location = new System.Drawing.Point(66, 181);
            this.btn_CustomerLogin.Name = "btn_CustomerLogin";
            this.btn_CustomerLogin.Size = new System.Drawing.Size(134, 40);
            this.btn_CustomerLogin.TabIndex = 21;
            this.btn_CustomerLogin.Text = "Login";
            this.btn_CustomerLogin.UseVisualStyleBackColor = true;
            this.btn_CustomerLogin.Click += new System.EventHandler(this.btn_CustomerLogin_Click);
            // 
            // txtBox_CustomerPass
            // 
            this.txtBox_CustomerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerPass.Location = new System.Drawing.Point(206, 105);
            this.txtBox_CustomerPass.Name = "txtBox_CustomerPass";
            this.txtBox_CustomerPass.Size = new System.Drawing.Size(190, 31);
            this.txtBox_CustomerPass.TabIndex = 20;
            this.txtBox_CustomerPass.UseSystemPasswordChar = true;
            // 
            // txtBox_CustomerName
            // 
            this.txtBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerName.Location = new System.Drawing.Point(206, 37);
            this.txtBox_CustomerName.Name = "txtBox_CustomerName";
            this.txtBox_CustomerName.Size = new System.Drawing.Size(190, 31);
            this.txtBox_CustomerName.TabIndex = 19;
            // 
            // btn_CustomerExit
            // 
            this.btn_CustomerExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerExit.Location = new System.Drawing.Point(262, 181);
            this.btn_CustomerExit.Name = "btn_CustomerExit";
            this.btn_CustomerExit.Size = new System.Drawing.Size(133, 40);
            this.btn_CustomerExit.TabIndex = 18;
            this.btn_CustomerExit.Text = "Exit";
            this.btn_CustomerExit.UseVisualStyleBackColor = true;
            this.btn_CustomerExit.Click += new System.EventHandler(this.btn_CustomerExit_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(111, 112);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 20);
            this.lbl_Password.TabIndex = 17;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(111, 44);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(89, 20);
            this.lbl_UserName.TabIndex = 16;
            this.lbl_UserName.Text = "User Name";
            // 
            // Customer_Login_Form
            // 
            this.AcceptButton = this.btn_CustomerLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 258);
            this.Controls.Add(this.pic_Customer);
            this.Controls.Add(this.btn_CustomerLogin);
            this.Controls.Add(this.txtBox_CustomerPass);
            this.Controls.Add(this.txtBox_CustomerName);
            this.Controls.Add(this.btn_CustomerExit);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Customer_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Login_Form";
            this.Load += new System.EventHandler(this.Customer_Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Customer;
        private System.Windows.Forms.Button btn_CustomerLogin;
        private System.Windows.Forms.TextBox txtBox_CustomerPass;
        private System.Windows.Forms.TextBox txtBox_CustomerName;
        private System.Windows.Forms.Button btn_CustomerExit;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
    }
}