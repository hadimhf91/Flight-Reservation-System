namespace Flight_Reservation_System
{
    partial class Admin_Password_Confirm
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
            this.txtBox_AdminCurrentPass = new System.Windows.Forms.TextBox();
            this.lbl_AdminCurrentPassword = new System.Windows.Forms.Label();
            this.btn_AdminNewPassSave = new System.Windows.Forms.Button();
            this.lbl_AdminNewPassword = new System.Windows.Forms.Label();
            this.lbl_AdminConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtBox_AdminNewPass = new System.Windows.Forms.TextBox();
            this.txtBox_AdminConfirmPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_AdminCurrentPass
            // 
            this.txtBox_AdminCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_AdminCurrentPass.Location = new System.Drawing.Point(258, 44);
            this.txtBox_AdminCurrentPass.Name = "txtBox_AdminCurrentPass";
            this.txtBox_AdminCurrentPass.Size = new System.Drawing.Size(204, 26);
            this.txtBox_AdminCurrentPass.TabIndex = 11;
            this.txtBox_AdminCurrentPass.UseSystemPasswordChar = true;
            // 
            // lbl_AdminCurrentPassword
            // 
            this.lbl_AdminCurrentPassword.AutoSize = true;
            this.lbl_AdminCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminCurrentPassword.Location = new System.Drawing.Point(104, 44);
            this.lbl_AdminCurrentPassword.Name = "lbl_AdminCurrentPassword";
            this.lbl_AdminCurrentPassword.Size = new System.Drawing.Size(135, 20);
            this.lbl_AdminCurrentPassword.TabIndex = 12;
            this.lbl_AdminCurrentPassword.Text = "Current Password";
            // 
            // btn_AdminNewPassSave
            // 
            this.btn_AdminNewPassSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminNewPassSave.Location = new System.Drawing.Point(177, 202);
            this.btn_AdminNewPassSave.Name = "btn_AdminNewPassSave";
            this.btn_AdminNewPassSave.Size = new System.Drawing.Size(186, 37);
            this.btn_AdminNewPassSave.TabIndex = 29;
            this.btn_AdminNewPassSave.Text = "Save";
            this.btn_AdminNewPassSave.UseVisualStyleBackColor = true;
            this.btn_AdminNewPassSave.Click += new System.EventHandler(this.btn_AdminNewPassSave_Click);
            // 
            // lbl_AdminNewPassword
            // 
            this.lbl_AdminNewPassword.AutoSize = true;
            this.lbl_AdminNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminNewPassword.Location = new System.Drawing.Point(126, 91);
            this.lbl_AdminNewPassword.Name = "lbl_AdminNewPassword";
            this.lbl_AdminNewPassword.Size = new System.Drawing.Size(113, 20);
            this.lbl_AdminNewPassword.TabIndex = 30;
            this.lbl_AdminNewPassword.Text = "New Password";
            // 
            // lbl_AdminConfirmNewPassword
            // 
            this.lbl_AdminConfirmNewPassword.AutoSize = true;
            this.lbl_AdminConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminConfirmNewPassword.Location = new System.Drawing.Point(63, 140);
            this.lbl_AdminConfirmNewPassword.Name = "lbl_AdminConfirmNewPassword";
            this.lbl_AdminConfirmNewPassword.Size = new System.Drawing.Size(176, 20);
            this.lbl_AdminConfirmNewPassword.TabIndex = 31;
            this.lbl_AdminConfirmNewPassword.Text = "Confirm  New Password";
            // 
            // txtBox_AdminNewPass
            // 
            this.txtBox_AdminNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_AdminNewPass.Location = new System.Drawing.Point(258, 88);
            this.txtBox_AdminNewPass.Name = "txtBox_AdminNewPass";
            this.txtBox_AdminNewPass.Size = new System.Drawing.Size(204, 26);
            this.txtBox_AdminNewPass.TabIndex = 32;
            this.txtBox_AdminNewPass.UseSystemPasswordChar = true;
            // 
            // txtBox_AdminConfirmPass
            // 
            this.txtBox_AdminConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_AdminConfirmPass.Location = new System.Drawing.Point(258, 137);
            this.txtBox_AdminConfirmPass.Name = "txtBox_AdminConfirmPass";
            this.txtBox_AdminConfirmPass.Size = new System.Drawing.Size(204, 26);
            this.txtBox_AdminConfirmPass.TabIndex = 33;
            this.txtBox_AdminConfirmPass.UseSystemPasswordChar = true;
            // 
            // Admin_Password_Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 268);
            this.Controls.Add(this.txtBox_AdminConfirmPass);
            this.Controls.Add(this.txtBox_AdminNewPass);
            this.Controls.Add(this.lbl_AdminConfirmNewPassword);
            this.Controls.Add(this.lbl_AdminNewPassword);
            this.Controls.Add(this.btn_AdminNewPassSave);
            this.Controls.Add(this.lbl_AdminCurrentPassword);
            this.Controls.Add(this.txtBox_AdminCurrentPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin_Password_Confirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Password_Confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_AdminCurrentPass;
        private System.Windows.Forms.Label lbl_AdminCurrentPassword;
        private System.Windows.Forms.Button btn_AdminNewPassSave;
        private System.Windows.Forms.Label lbl_AdminNewPassword;
        private System.Windows.Forms.Label lbl_AdminConfirmNewPassword;
        private System.Windows.Forms.TextBox txtBox_AdminNewPass;
        private System.Windows.Forms.TextBox txtBox_AdminConfirmPass;
    }
}