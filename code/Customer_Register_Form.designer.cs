namespace Flight_Reservation_System
{
    partial class Customer_Register_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Register_Form));
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_CustomerSave = new System.Windows.Forms.Button();
            this.txtBox_CustomerFirstName = new System.Windows.Forms.TextBox();
            this.txtBox_CustomerLastName = new System.Windows.Forms.TextBox();
            this.cdr_CustomerBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtBox_CustomerEmail = new System.Windows.Forms.TextBox();
            this.lal_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_EmailAddress = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.lbl_CustomerPassword = new System.Windows.Forms.Label();
            this.txtBox_CustomerPassword = new System.Windows.Forms.TextBox();
            this.lbl_CustomerPasswordConfirm = new System.Windows.Forms.Label();
            this.txtBox_CustomerPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_CustomerUserName = new System.Windows.Forms.TextBox();
            this.chkBox_Terms = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_CustomerRegisterHelp = new System.Windows.Forms.Label();
            this.lbl_CustomerOldPassword = new System.Windows.Forms.Label();
            this.txtBox_CustomerOldPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(389, 216);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(112, 38);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "&Clear";
            this.toolTip1.SetToolTip(this.btn_Clear, "clear the form");
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(507, 216);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(112, 38);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btn_Exit, "close the form");
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_CustomerSave
            // 
            this.btn_CustomerSave.Enabled = false;
            this.btn_CustomerSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerSave.Location = new System.Drawing.Point(271, 216);
            this.btn_CustomerSave.Name = "btn_CustomerSave";
            this.btn_CustomerSave.Size = new System.Drawing.Size(112, 38);
            this.btn_CustomerSave.TabIndex = 2;
            this.btn_CustomerSave.Text = "&Save";
            this.toolTip1.SetToolTip(this.btn_CustomerSave, "save information to database");
            this.btn_CustomerSave.UseVisualStyleBackColor = true;
            this.btn_CustomerSave.Click += new System.EventHandler(this.btn_CustomerSave_Click);
            // 
            // txtBox_CustomerFirstName
            // 
            this.txtBox_CustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerFirstName.Location = new System.Drawing.Point(31, 47);
            this.txtBox_CustomerFirstName.Name = "txtBox_CustomerFirstName";
            this.txtBox_CustomerFirstName.Size = new System.Drawing.Size(175, 26);
            this.txtBox_CustomerFirstName.TabIndex = 3;
            this.txtBox_CustomerFirstName.TextChanged += new System.EventHandler(this.txtBox_CustomerFirstName_TextChanged);
            this.txtBox_CustomerFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_CustomerFirstName_KeyPress);
            // 
            // txtBox_CustomerLastName
            // 
            this.txtBox_CustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerLastName.Location = new System.Drawing.Point(239, 47);
            this.txtBox_CustomerLastName.Name = "txtBox_CustomerLastName";
            this.txtBox_CustomerLastName.Size = new System.Drawing.Size(175, 26);
            this.txtBox_CustomerLastName.TabIndex = 4;
            this.txtBox_CustomerLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_CustomerLastName_KeyPress);
            // 
            // cdr_CustomerBirthday
            // 
            this.cdr_CustomerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_CustomerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdr_CustomerBirthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cdr_CustomerBirthday.Location = new System.Drawing.Point(443, 45);
            this.cdr_CustomerBirthday.Name = "cdr_CustomerBirthday";
            this.cdr_CustomerBirthday.Size = new System.Drawing.Size(168, 26);
            this.cdr_CustomerBirthday.TabIndex = 7;
            this.cdr_CustomerBirthday.Value = new System.DateTime(2020, 10, 3, 0, 0, 0, 0);
            // 
            // txtBox_CustomerEmail
            // 
            this.txtBox_CustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerEmail.Location = new System.Drawing.Point(32, 168);
            this.txtBox_CustomerEmail.Name = "txtBox_CustomerEmail";
            this.txtBox_CustomerEmail.Size = new System.Drawing.Size(175, 26);
            this.txtBox_CustomerEmail.TabIndex = 8;
            // 
            // lal_FirstName
            // 
            this.lal_FirstName.AutoSize = true;
            this.lal_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lal_FirstName.Location = new System.Drawing.Point(28, 24);
            this.lal_FirstName.Name = "lal_FirstName";
            this.lal_FirstName.Size = new System.Drawing.Size(81, 20);
            this.lal_FirstName.TabIndex = 9;
            this.lal_FirstName.Text = "Fist Name";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastName.Location = new System.Drawing.Point(235, 24);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(86, 20);
            this.lbl_LastName.TabIndex = 10;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_EmailAddress
            // 
            this.lbl_EmailAddress.AutoSize = true;
            this.lbl_EmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailAddress.Location = new System.Drawing.Point(28, 145);
            this.lbl_EmailAddress.Name = "lbl_EmailAddress";
            this.lbl_EmailAddress.Size = new System.Drawing.Size(52, 20);
            this.lbl_EmailAddress.TabIndex = 12;
            this.lbl_EmailAddress.Text = "Email ";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(439, 24);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(99, 20);
            this.lbl_Birthday.TabIndex = 13;
            this.lbl_Birthday.Text = "Date of Birth";
            // 
            // lbl_CustomerPassword
            // 
            this.lbl_CustomerPassword.AutoSize = true;
            this.lbl_CustomerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerPassword.Location = new System.Drawing.Point(236, 89);
            this.lbl_CustomerPassword.Name = "lbl_CustomerPassword";
            this.lbl_CustomerPassword.Size = new System.Drawing.Size(113, 20);
            this.lbl_CustomerPassword.TabIndex = 15;
            this.lbl_CustomerPassword.Text = "New Password";
            // 
            // txtBox_CustomerPassword
            // 
            this.txtBox_CustomerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerPassword.Location = new System.Drawing.Point(239, 112);
            this.txtBox_CustomerPassword.Name = "txtBox_CustomerPassword";
            this.txtBox_CustomerPassword.Size = new System.Drawing.Size(175, 26);
            this.txtBox_CustomerPassword.TabIndex = 14;
            this.txtBox_CustomerPassword.UseSystemPasswordChar = true;
            // 
            // lbl_CustomerPasswordConfirm
            // 
            this.lbl_CustomerPasswordConfirm.AutoSize = true;
            this.lbl_CustomerPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerPasswordConfirm.Location = new System.Drawing.Point(440, 89);
            this.lbl_CustomerPasswordConfirm.Name = "lbl_CustomerPasswordConfirm";
            this.lbl_CustomerPasswordConfirm.Size = new System.Drawing.Size(172, 20);
            this.lbl_CustomerPasswordConfirm.TabIndex = 17;
            this.lbl_CustomerPasswordConfirm.Text = "Confirm New Password";
            // 
            // txtBox_CustomerPasswordConfirm
            // 
            this.txtBox_CustomerPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerPasswordConfirm.Location = new System.Drawing.Point(444, 112);
            this.txtBox_CustomerPasswordConfirm.Name = "txtBox_CustomerPasswordConfirm";
            this.txtBox_CustomerPasswordConfirm.Size = new System.Drawing.Size(167, 26);
            this.txtBox_CustomerPasswordConfirm.TabIndex = 16;
            this.txtBox_CustomerPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "User Name";
            // 
            // txtBox_CustomerUserName
            // 
            this.txtBox_CustomerUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerUserName.Location = new System.Drawing.Point(32, 112);
            this.txtBox_CustomerUserName.Name = "txtBox_CustomerUserName";
            this.txtBox_CustomerUserName.Size = new System.Drawing.Size(175, 26);
            this.txtBox_CustomerUserName.TabIndex = 18;
            // 
            // chkBox_Terms
            // 
            this.chkBox_Terms.AutoSize = true;
            this.chkBox_Terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_Terms.Location = new System.Drawing.Point(239, 168);
            this.chkBox_Terms.Name = "chkBox_Terms";
            this.chkBox_Terms.Size = new System.Drawing.Size(365, 24);
            this.chkBox_Terms.TabIndex = 20;
            this.chkBox_Terms.Text = "I read terms and conditions carefully and accept";
            this.chkBox_Terms.UseVisualStyleBackColor = true;
            this.chkBox_Terms.CheckedChanged += new System.EventHandler(this.chkBox_Terms_CheckedChanged);
            // 
            // lbl_CustomerRegisterHelp
            // 
            this.lbl_CustomerRegisterHelp.AutoSize = true;
            this.lbl_CustomerRegisterHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerRegisterHelp.Image = ((System.Drawing.Image)(resources.GetObject("lbl_CustomerRegisterHelp.Image")));
            this.lbl_CustomerRegisterHelp.Location = new System.Drawing.Point(603, 0);
            this.lbl_CustomerRegisterHelp.Name = "lbl_CustomerRegisterHelp";
            this.lbl_CustomerRegisterHelp.Size = new System.Drawing.Size(35, 31);
            this.lbl_CustomerRegisterHelp.TabIndex = 25;
            this.lbl_CustomerRegisterHelp.Text = "   ";
            this.lbl_CustomerRegisterHelp.Click += new System.EventHandler(this.lbl_CustomerRegisterHelp_Click);
            // 
            // lbl_CustomerOldPassword
            // 
            this.lbl_CustomerOldPassword.AutoSize = true;
            this.lbl_CustomerOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerOldPassword.Location = new System.Drawing.Point(30, 89);
            this.lbl_CustomerOldPassword.Name = "lbl_CustomerOldPassword";
            this.lbl_CustomerOldPassword.Size = new System.Drawing.Size(106, 20);
            this.lbl_CustomerOldPassword.TabIndex = 26;
            this.lbl_CustomerOldPassword.Text = "Old Password";
            this.lbl_CustomerOldPassword.Visible = false;
            // 
            // txtBox_CustomerOldPassword
            // 
            this.txtBox_CustomerOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomerOldPassword.Location = new System.Drawing.Point(33, 112);
            this.txtBox_CustomerOldPassword.Name = "txtBox_CustomerOldPassword";
            this.txtBox_CustomerOldPassword.Size = new System.Drawing.Size(175, 26);
            this.txtBox_CustomerOldPassword.TabIndex = 27;
            this.txtBox_CustomerOldPassword.UseSystemPasswordChar = true;
            this.txtBox_CustomerOldPassword.Visible = false;
            // 
            // Customer_Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 266);
            this.Controls.Add(this.txtBox_CustomerOldPassword);
            this.Controls.Add(this.lbl_CustomerOldPassword);
            this.Controls.Add(this.lbl_CustomerRegisterHelp);
            this.Controls.Add(this.chkBox_Terms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_CustomerUserName);
            this.Controls.Add(this.lbl_CustomerPasswordConfirm);
            this.Controls.Add(this.txtBox_CustomerPasswordConfirm);
            this.Controls.Add(this.lbl_CustomerPassword);
            this.Controls.Add(this.txtBox_CustomerPassword);
            this.Controls.Add(this.lbl_Birthday);
            this.Controls.Add(this.lbl_EmailAddress);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lal_FirstName);
            this.Controls.Add(this.txtBox_CustomerEmail);
            this.Controls.Add(this.cdr_CustomerBirthday);
            this.Controls.Add(this.txtBox_CustomerLastName);
            this.Controls.Add(this.txtBox_CustomerFirstName);
            this.Controls.Add(this.btn_CustomerSave);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.MaximizeBox = false;
            this.Name = "Customer_Register_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Registeration Form";
            this.Load += new System.EventHandler(this.Customer_Register_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_CustomerSave;
        private System.Windows.Forms.TextBox txtBox_CustomerFirstName;
        private System.Windows.Forms.TextBox txtBox_CustomerLastName;
        private System.Windows.Forms.DateTimePicker cdr_CustomerBirthday;
        private System.Windows.Forms.TextBox txtBox_CustomerEmail;
        private System.Windows.Forms.Label lal_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_EmailAddress;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_CustomerPassword;
        private System.Windows.Forms.TextBox txtBox_CustomerPassword;
        private System.Windows.Forms.Label lbl_CustomerPasswordConfirm;
        private System.Windows.Forms.TextBox txtBox_CustomerPasswordConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_CustomerUserName;
        private System.Windows.Forms.CheckBox chkBox_Terms;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_CustomerRegisterHelp;
        private System.Windows.Forms.Label lbl_CustomerOldPassword;
        private System.Windows.Forms.TextBox txtBox_CustomerOldPassword;
    }
}