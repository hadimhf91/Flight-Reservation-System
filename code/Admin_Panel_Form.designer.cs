namespace Flight_Reservation_System
{
    partial class Admin_Panel_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel_Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgd_FlightInfoAdmin = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_SearchFlight = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comBox_Destination = new System.Windows.Forms.ComboBox();
            this.comBox_Source = new System.Windows.Forms.ComboBox();
            this.btn_AddFlightInfo = new System.Windows.Forms.Button();
            this.lbl_FlightCapacity = new System.Windows.Forms.Label();
            this.txtBox_Capacity = new System.Windows.Forms.TextBox();
            this.lbl_FlightPrice = new System.Windows.Forms.Label();
            this.txtBox_FlightPrice = new System.Windows.Forms.TextBox();
            this.lbl_FlightID = new System.Windows.Forms.Label();
            this.txtBox_FlightId = new System.Windows.Forms.TextBox();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.cdr_FlightDateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbBox_FlightClass = new System.Windows.Forms.ComboBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_EditAdmin = new System.Windows.Forms.Button();
            this.btn_AddAdmin = new System.Windows.Forms.Button();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_UserN = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_AdminPanelHelp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_FlightInfoAdmin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgd_FlightInfoAdmin);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.btn_SearchFlight);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search and Edit Flight Information";
            // 
            // dgd_FlightInfoAdmin
            // 
            this.dgd_FlightInfoAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgd_FlightInfoAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgd_FlightInfoAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgd_FlightInfoAdmin.Location = new System.Drawing.Point(118, 25);
            this.dgd_FlightInfoAdmin.Name = "dgd_FlightInfoAdmin";
            this.dgd_FlightInfoAdmin.Size = new System.Drawing.Size(633, 228);
            this.dgd_FlightInfoAdmin.TabIndex = 38;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(26, 122);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 40);
            this.btn_Save.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btn_Save, "save changes");
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_SearchFlight
            // 
            this.btn_SearchFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchFlight.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchFlight.Image")));
            this.btn_SearchFlight.Location = new System.Drawing.Point(26, 39);
            this.btn_SearchFlight.Name = "btn_SearchFlight";
            this.btn_SearchFlight.Size = new System.Drawing.Size(75, 67);
            this.btn_SearchFlight.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btn_SearchFlight, "search among the database");
            this.btn_SearchFlight.UseVisualStyleBackColor = true;
            this.btn_SearchFlight.Click += new System.EventHandler(this.btn_SearchFlight_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comBox_Destination);
            this.groupBox2.Controls.Add(this.comBox_Source);
            this.groupBox2.Controls.Add(this.btn_AddFlightInfo);
            this.groupBox2.Controls.Add(this.lbl_FlightCapacity);
            this.groupBox2.Controls.Add(this.txtBox_Capacity);
            this.groupBox2.Controls.Add(this.lbl_FlightPrice);
            this.groupBox2.Controls.Add(this.txtBox_FlightPrice);
            this.groupBox2.Controls.Add(this.lbl_FlightID);
            this.groupBox2.Controls.Add(this.txtBox_FlightId);
            this.groupBox2.Controls.Add(this.lbl_Class);
            this.groupBox2.Controls.Add(this.cdr_FlightDateTime);
            this.groupBox2.Controls.Add(this.cmbBox_FlightClass);
            this.groupBox2.Controls.Add(this.lbl_Date);
            this.groupBox2.Controls.Add(this.lbl_to);
            this.groupBox2.Controls.Add(this.lbl_From);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Flight Information";
            // 
            // comBox_Destination
            // 
            this.comBox_Destination.FormattingEnabled = true;
            this.comBox_Destination.Location = new System.Drawing.Point(381, 31);
            this.comBox_Destination.Name = "comBox_Destination";
            this.comBox_Destination.Size = new System.Drawing.Size(175, 28);
            this.comBox_Destination.TabIndex = 37;
            // 
            // comBox_Source
            // 
            this.comBox_Source.FormattingEnabled = true;
            this.comBox_Source.Location = new System.Drawing.Point(170, 31);
            this.comBox_Source.Name = "comBox_Source";
            this.comBox_Source.Size = new System.Drawing.Size(180, 28);
            this.comBox_Source.TabIndex = 36;
            // 
            // btn_AddFlightInfo
            // 
            this.btn_AddFlightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFlightInfo.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddFlightInfo.Image")));
            this.btn_AddFlightInfo.Location = new System.Drawing.Point(26, 38);
            this.btn_AddFlightInfo.Name = "btn_AddFlightInfo";
            this.btn_AddFlightInfo.Size = new System.Drawing.Size(75, 67);
            this.btn_AddFlightInfo.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btn_AddFlightInfo, "Add new flight to database");
            this.btn_AddFlightInfo.UseVisualStyleBackColor = true;
            this.btn_AddFlightInfo.Click += new System.EventHandler(this.btn_AddFlightInfo_Click);
            // 
            // lbl_FlightCapacity
            // 
            this.lbl_FlightCapacity.AutoSize = true;
            this.lbl_FlightCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FlightCapacity.Location = new System.Drawing.Point(629, 67);
            this.lbl_FlightCapacity.Name = "lbl_FlightCapacity";
            this.lbl_FlightCapacity.Size = new System.Drawing.Size(61, 16);
            this.lbl_FlightCapacity.TabIndex = 33;
            this.lbl_FlightCapacity.Text = "Capacity";
            // 
            // txtBox_Capacity
            // 
            this.txtBox_Capacity.AcceptsReturn = true;
            this.txtBox_Capacity.AcceptsTab = true;
            this.txtBox_Capacity.AccessibleName = "";
            this.txtBox_Capacity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBox_Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Capacity.ForeColor = System.Drawing.Color.Black;
            this.txtBox_Capacity.Location = new System.Drawing.Point(632, 84);
            this.txtBox_Capacity.Name = "txtBox_Capacity";
            this.txtBox_Capacity.Size = new System.Drawing.Size(75, 26);
            this.txtBox_Capacity.TabIndex = 32;
            this.txtBox_Capacity.Tag = "";
            this.txtBox_Capacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Capacity_KeyPress);
            // 
            // lbl_FlightPrice
            // 
            this.lbl_FlightPrice.AutoSize = true;
            this.lbl_FlightPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FlightPrice.Location = new System.Drawing.Point(508, 67);
            this.lbl_FlightPrice.Name = "lbl_FlightPrice";
            this.lbl_FlightPrice.Size = new System.Drawing.Size(54, 16);
            this.lbl_FlightPrice.TabIndex = 31;
            this.lbl_FlightPrice.Text = "Price($)";
            // 
            // txtBox_FlightPrice
            // 
            this.txtBox_FlightPrice.AcceptsReturn = true;
            this.txtBox_FlightPrice.AcceptsTab = true;
            this.txtBox_FlightPrice.AccessibleName = "";
            this.txtBox_FlightPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBox_FlightPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_FlightPrice.ForeColor = System.Drawing.Color.Black;
            this.txtBox_FlightPrice.Location = new System.Drawing.Point(511, 84);
            this.txtBox_FlightPrice.Name = "txtBox_FlightPrice";
            this.txtBox_FlightPrice.Size = new System.Drawing.Size(75, 26);
            this.txtBox_FlightPrice.TabIndex = 30;
            this.txtBox_FlightPrice.Tag = "";
            this.txtBox_FlightPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_FlightPrice_KeyPress);
            // 
            // lbl_FlightID
            // 
            this.lbl_FlightID.AutoSize = true;
            this.lbl_FlightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FlightID.Location = new System.Drawing.Point(378, 67);
            this.lbl_FlightID.Name = "lbl_FlightID";
            this.lbl_FlightID.Size = new System.Drawing.Size(56, 16);
            this.lbl_FlightID.TabIndex = 29;
            this.lbl_FlightID.Text = "Flight ID";
            // 
            // txtBox_FlightId
            // 
            this.txtBox_FlightId.AcceptsReturn = true;
            this.txtBox_FlightId.AcceptsTab = true;
            this.txtBox_FlightId.AccessibleName = "";
            this.txtBox_FlightId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBox_FlightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_FlightId.ForeColor = System.Drawing.Color.Black;
            this.txtBox_FlightId.Location = new System.Drawing.Point(381, 84);
            this.txtBox_FlightId.Name = "txtBox_FlightId";
            this.txtBox_FlightId.Size = new System.Drawing.Size(79, 26);
            this.txtBox_FlightId.TabIndex = 28;
            this.txtBox_FlightId.Tag = "";
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Class.Location = new System.Drawing.Point(570, 15);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(42, 16);
            this.lbl_Class.TabIndex = 27;
            this.lbl_Class.Text = "Class";
            // 
            // cdr_FlightDateTime
            // 
            this.cdr_FlightDateTime.AllowDrop = true;
            this.cdr_FlightDateTime.CalendarFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cdr_FlightDateTime.Location = new System.Drawing.Point(170, 84);
            this.cdr_FlightDateTime.Name = "cdr_FlightDateTime";
            this.cdr_FlightDateTime.Size = new System.Drawing.Size(180, 26);
            this.cdr_FlightDateTime.TabIndex = 26;
            // 
            // cmbBox_FlightClass
            // 
            this.cmbBox_FlightClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBox_FlightClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_FlightClass.FormattingEnabled = true;
            this.cmbBox_FlightClass.Items.AddRange(new object[] {
            "Business",
            "Economy",
            "VIP"});
            this.cmbBox_FlightClass.Location = new System.Drawing.Point(573, 31);
            this.cmbBox_FlightClass.MaxDropDownItems = 3;
            this.cmbBox_FlightClass.Name = "cmbBox_FlightClass";
            this.cmbBox_FlightClass.Size = new System.Drawing.Size(134, 28);
            this.cmbBox_FlightClass.Sorted = true;
            this.cmbBox_FlightClass.TabIndex = 21;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(167, 67);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(97, 16);
            this.lbl_Date.TabIndex = 25;
            this.lbl_Date.Text = "Date and Time";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(378, 15);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(27, 16);
            this.lbl_to.TabIndex = 24;
            this.lbl_to.Text = "TO";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(167, 16);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(39, 16);
            this.lbl_From.TabIndex = 22;
            this.lbl_From.Text = "From";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_EditAdmin);
            this.groupBox3.Controls.Add(this.btn_AddAdmin);
            this.groupBox3.Controls.Add(this.textBox_Pass);
            this.groupBox3.Controls.Add(this.textBox_UserN);
            this.groupBox3.Controls.Add(this.lbl_Password);
            this.groupBox3.Controls.Add(this.lbl_UserName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(766, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Admin";
            // 
            // btn_EditAdmin
            // 
            this.btn_EditAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditAdmin.Image")));
            this.btn_EditAdmin.Location = new System.Drawing.Point(26, 99);
            this.btn_EditAdmin.Name = "btn_EditAdmin";
            this.btn_EditAdmin.Size = new System.Drawing.Size(75, 40);
            this.btn_EditAdmin.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btn_EditAdmin, "change password");
            this.btn_EditAdmin.UseVisualStyleBackColor = true;
            this.btn_EditAdmin.Click += new System.EventHandler(this.btn_EditAdmin_Click);
            // 
            // btn_AddAdmin
            // 
            this.btn_AddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddAdmin.Image")));
            this.btn_AddAdmin.Location = new System.Drawing.Point(26, 21);
            this.btn_AddAdmin.Name = "btn_AddAdmin";
            this.btn_AddAdmin.Size = new System.Drawing.Size(75, 73);
            this.btn_AddAdmin.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btn_AddAdmin, "add an new admin");
            this.btn_AddAdmin.UseVisualStyleBackColor = true;
            this.btn_AddAdmin.Click += new System.EventHandler(this.btn_AddAdmin_Click);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pass.Location = new System.Drawing.Point(494, 69);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(186, 26);
            this.textBox_Pass.TabIndex = 10;
            this.textBox_Pass.UseSystemPasswordChar = true;
            // 
            // textBox_UserN
            // 
            this.textBox_UserN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserN.Location = new System.Drawing.Point(219, 68);
            this.textBox_UserN.Name = "textBox_UserN";
            this.textBox_UserN.Size = new System.Drawing.Size(186, 26);
            this.textBox_UserN.TabIndex = 9;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(488, 52);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(68, 16);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(216, 52);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(77, 16);
            this.lbl_UserName.TabIndex = 7;
            this.lbl_UserName.Text = "User Name";
            // 
            // lbl_AdminPanelHelp
            // 
            this.lbl_AdminPanelHelp.AutoSize = true;
            this.lbl_AdminPanelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminPanelHelp.Image = ((System.Drawing.Image)(resources.GetObject("lbl_AdminPanelHelp.Image")));
            this.lbl_AdminPanelHelp.Location = new System.Drawing.Point(760, 0);
            this.lbl_AdminPanelHelp.Name = "lbl_AdminPanelHelp";
            this.lbl_AdminPanelHelp.Size = new System.Drawing.Size(35, 31);
            this.lbl_AdminPanelHelp.TabIndex = 25;
            this.lbl_AdminPanelHelp.Text = "   ";
            this.lbl_AdminPanelHelp.Click += new System.EventHandler(this.lbl_AdminPanelHelp_Click);
            // 
            // Admin_Panel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 589);
            this.Controls.Add(this.lbl_AdminPanelHelp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_Panel_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgd_FlightInfoAdmin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_UserN;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Button btn_AddAdmin;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.DateTimePicker cdr_FlightDateTime;
        private System.Windows.Forms.ComboBox cmbBox_FlightClass;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_FlightCapacity;
        private System.Windows.Forms.TextBox txtBox_Capacity;
        private System.Windows.Forms.Label lbl_FlightPrice;
        private System.Windows.Forms.TextBox txtBox_FlightPrice;
        private System.Windows.Forms.Label lbl_FlightID;
        private System.Windows.Forms.TextBox txtBox_FlightId;
        private System.Windows.Forms.Button btn_AddFlightInfo;
        private System.Windows.Forms.ComboBox comBox_Destination;
        private System.Windows.Forms.ComboBox comBox_Source;
        private System.Windows.Forms.DataGridView dgd_FlightInfoAdmin;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_SearchFlight;
        private System.Windows.Forms.Button btn_EditAdmin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_AdminPanelHelp;
    }
}