namespace Flight_Reservation_System
{
    partial class Main_Login_Form
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
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Guest = new System.Windows.Forms.Button();
            this.btn_Signup = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_Customer
            // 
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.Location = new System.Drawing.Point(66, 111);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(288, 65);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Log in";
            this.toolTip1.SetToolTip(this.btn_Customer, "Log in as a member");
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.Location = new System.Drawing.Point(66, 276);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(288, 64);
            this.btn_Admin.TabIndex = 2;
            this.btn_Admin.Text = "Administator";
            this.toolTip1.SetToolTip(this.btn_Admin, "administators log in");
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Guest
            // 
            this.btn_Guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guest.Location = new System.Drawing.Point(66, 28);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(288, 65);
            this.btn_Guest.TabIndex = 0;
            this.btn_Guest.Text = "Search";
            this.toolTip1.SetToolTip(this.btn_Guest, "Search for flights");
            this.btn_Guest.UseVisualStyleBackColor = true;
            this.btn_Guest.Click += new System.EventHandler(this.btn_Guest_Click);
            // 
            // btn_Signup
            // 
            this.btn_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signup.Location = new System.Drawing.Point(66, 193);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(288, 65);
            this.btn_Signup.TabIndex = 3;
            this.btn_Signup.Text = "Sign Up";
            this.toolTip1.SetToolTip(this.btn_Signup, "sign up to the system");
            this.btn_Signup.UseVisualStyleBackColor = true;
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // Main_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 368);
            this.Controls.Add(this.btn_Signup);
            this.Controls.Add(this.btn_Guest);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_Customer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Reservation System Login";
            this.Load += new System.EventHandler(this.Main_Login_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_Guest;
        private System.Windows.Forms.Button btn_Signup;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

