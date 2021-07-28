namespace Flight_Reservation_System
{
    partial class Flight_Search_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight_Search_Form));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cdr_FlightDate = new System.Windows.Forms.DateTimePicker();
            this.btn_SearchFlight = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.cmbBox_FlightClass = new System.Windows.Forms.ComboBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.dgd_FlightInfo = new System.Windows.Forms.DataGridView();
            this.cmbBox_Source = new System.Windows.Forms.ComboBox();
            this.cmbBox_Destination = new System.Windows.Forms.ComboBox();
            this.rbtn_OneWay = new System.Windows.Forms.RadioButton();
            this.rbtn_RoundTrip = new System.Windows.Forms.RadioButton();
            this.grpBox_Search = new System.Windows.Forms.GroupBox();
            this.lbl_ReturnDate = new System.Windows.Forms.Label();
            this.cdr_FlightReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_FlightSearchHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_FlightInfo)).BeginInit();
            this.grpBox_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(634, 291);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(119, 37);
            this.btn_Exit.TabIndex = 28;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // cdr_FlightDate
            // 
            this.cdr_FlightDate.AllowDrop = true;
            this.cdr_FlightDate.CalendarFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdr_FlightDate.Location = new System.Drawing.Point(573, 9);
            this.cdr_FlightDate.Name = "cdr_FlightDate";
            this.cdr_FlightDate.Size = new System.Drawing.Size(151, 26);
            this.cdr_FlightDate.TabIndex = 27;
            // 
            // btn_SearchFlight
            // 
            this.btn_SearchFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchFlight.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchFlight.Image")));
            this.btn_SearchFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchFlight.Location = new System.Drawing.Point(238, 291);
            this.btn_SearchFlight.Name = "btn_SearchFlight";
            this.btn_SearchFlight.Size = new System.Drawing.Size(117, 39);
            this.btn_SearchFlight.TabIndex = 26;
            this.btn_SearchFlight.Text = "Search";
            this.btn_SearchFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SearchFlight.UseVisualStyleBackColor = true;
            this.btn_SearchFlight.Click += new System.EventHandler(this.btn_SearchFlight_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(442, 291);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(112, 39);
            this.btn_Clear.TabIndex = 25;
            this.btn_Clear.Text = "&Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // cmbBox_FlightClass
            // 
            this.cmbBox_FlightClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_FlightClass.FormattingEnabled = true;
            this.cmbBox_FlightClass.Items.AddRange(new object[] {
            "ECONOMY",
            "BUSINESS",
            "VIP"});
            this.cmbBox_FlightClass.Location = new System.Drawing.Point(273, 6);
            this.cmbBox_FlightClass.MaxDropDownItems = 3;
            this.cmbBox_FlightClass.Name = "cmbBox_FlightClass";
            this.cmbBox_FlightClass.Size = new System.Drawing.Size(165, 28);
            this.cmbBox_FlightClass.TabIndex = 20;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Date.Image")));
            this.lbl_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Date.Location = new System.Drawing.Point(485, 5);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(82, 42);
            this.lbl_Date.TabIndex = 24;
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(12, 84);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(30, 20);
            this.lbl_to.TabIndex = 23;
            this.lbl_to.Text = "TO";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(8, 9);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(46, 20);
            this.lbl_From.TabIndex = 21;
            this.lbl_From.Text = "From";
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Class.Location = new System.Drawing.Point(219, 9);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(48, 20);
            this.lbl_Class.TabIndex = 29;
            this.lbl_Class.Text = "Class";
            // 
            // dgd_FlightInfo
            // 
            this.dgd_FlightInfo.AllowUserToAddRows = false;
            this.dgd_FlightInfo.AllowUserToDeleteRows = false;
            this.dgd_FlightInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgd_FlightInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgd_FlightInfo.Location = new System.Drawing.Point(12, 122);
            this.dgd_FlightInfo.Name = "dgd_FlightInfo";
            this.dgd_FlightInfo.ReadOnly = true;
            this.dgd_FlightInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgd_FlightInfo.Size = new System.Drawing.Size(741, 149);
            this.dgd_FlightInfo.TabIndex = 32;
            // 
            // cmbBox_Source
            // 
            this.cmbBox_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_Source.FormattingEnabled = true;
            this.cmbBox_Source.Location = new System.Drawing.Point(60, 5);
            this.cmbBox_Source.Name = "cmbBox_Source";
            this.cmbBox_Source.Size = new System.Drawing.Size(121, 28);
            this.cmbBox_Source.TabIndex = 33;
            // 
            // cmbBox_Destination
            // 
            this.cmbBox_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_Destination.FormattingEnabled = true;
            this.cmbBox_Destination.Location = new System.Drawing.Point(60, 76);
            this.cmbBox_Destination.Name = "cmbBox_Destination";
            this.cmbBox_Destination.Size = new System.Drawing.Size(121, 28);
            this.cmbBox_Destination.TabIndex = 34;
            // 
            // rbtn_OneWay
            // 
            this.rbtn_OneWay.AutoSize = true;
            this.rbtn_OneWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_OneWay.Location = new System.Drawing.Point(15, 24);
            this.rbtn_OneWay.Name = "rbtn_OneWay";
            this.rbtn_OneWay.Size = new System.Drawing.Size(86, 24);
            this.rbtn_OneWay.TabIndex = 36;
            this.rbtn_OneWay.TabStop = true;
            this.rbtn_OneWay.Text = "one-way";
            this.rbtn_OneWay.UseVisualStyleBackColor = true;
            this.rbtn_OneWay.CheckedChanged += new System.EventHandler(this.rbtn_OneWay_CheckedChanged);
            // 
            // rbtn_RoundTrip
            // 
            this.rbtn_RoundTrip.AutoSize = true;
            this.rbtn_RoundTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_RoundTrip.Location = new System.Drawing.Point(121, 25);
            this.rbtn_RoundTrip.Name = "rbtn_RoundTrip";
            this.rbtn_RoundTrip.Size = new System.Drawing.Size(94, 24);
            this.rbtn_RoundTrip.TabIndex = 37;
            this.rbtn_RoundTrip.TabStop = true;
            this.rbtn_RoundTrip.Text = "round trip";
            this.rbtn_RoundTrip.UseVisualStyleBackColor = true;
            this.rbtn_RoundTrip.CheckedChanged += new System.EventHandler(this.rbtn_RoundTrip_CheckedChanged);
            // 
            // grpBox_Search
            // 
            this.grpBox_Search.Controls.Add(this.lbl_ReturnDate);
            this.grpBox_Search.Controls.Add(this.rbtn_RoundTrip);
            this.grpBox_Search.Controls.Add(this.cdr_FlightReturnDate);
            this.grpBox_Search.Controls.Add(this.rbtn_OneWay);
            this.grpBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Search.Location = new System.Drawing.Point(223, 40);
            this.grpBox_Search.Name = "grpBox_Search";
            this.grpBox_Search.Size = new System.Drawing.Size(530, 64);
            this.grpBox_Search.TabIndex = 38;
            this.grpBox_Search.TabStop = false;
            this.grpBox_Search.Text = "Travel Selection";
            // 
            // lbl_ReturnDate
            // 
            this.lbl_ReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReturnDate.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ReturnDate.Image")));
            this.lbl_ReturnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ReturnDate.Location = new System.Drawing.Point(262, 15);
            this.lbl_ReturnDate.Name = "lbl_ReturnDate";
            this.lbl_ReturnDate.Size = new System.Drawing.Size(49, 42);
            this.lbl_ReturnDate.TabIndex = 39;
            this.lbl_ReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdr_FlightReturnDate
            // 
            this.cdr_FlightReturnDate.AllowDrop = true;
            this.cdr_FlightReturnDate.CalendarFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdr_FlightReturnDate.Location = new System.Drawing.Point(350, 23);
            this.cdr_FlightReturnDate.Name = "cdr_FlightReturnDate";
            this.cdr_FlightReturnDate.Size = new System.Drawing.Size(151, 26);
            this.cdr_FlightReturnDate.TabIndex = 40;
            this.cdr_FlightReturnDate.Visible = false;
            // 
            // lbl_FlightSearchHelp
            // 
            this.lbl_FlightSearchHelp.AutoSize = true;
            this.lbl_FlightSearchHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FlightSearchHelp.Image = ((System.Drawing.Image)(resources.GetObject("lbl_FlightSearchHelp.Image")));
            this.lbl_FlightSearchHelp.Location = new System.Drawing.Point(738, 0);
            this.lbl_FlightSearchHelp.Name = "lbl_FlightSearchHelp";
            this.lbl_FlightSearchHelp.Size = new System.Drawing.Size(35, 31);
            this.lbl_FlightSearchHelp.TabIndex = 39;
            this.lbl_FlightSearchHelp.Text = "   ";
            // 
            // Flight_Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 346);
            this.Controls.Add(this.lbl_FlightSearchHelp);
            this.Controls.Add(this.grpBox_Search);
            this.Controls.Add(this.cmbBox_Destination);
            this.Controls.Add(this.cmbBox_Source);
            this.Controls.Add(this.dgd_FlightInfo);
            this.Controls.Add(this.lbl_Class);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.cdr_FlightDate);
            this.Controls.Add(this.btn_SearchFlight);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.cmbBox_FlightClass);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_From);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Flight_Search_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight_Search_Form";
            this.Load += new System.EventHandler(this.Flight_Search_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgd_FlightInfo)).EndInit();
            this.grpBox_Search.ResumeLayout(false);
            this.grpBox_Search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DateTimePicker cdr_FlightDate;
        private System.Windows.Forms.Button btn_SearchFlight;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cmbBox_FlightClass;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.DataGridView dgd_FlightInfo;
        private System.Windows.Forms.ComboBox cmbBox_Source;
        private System.Windows.Forms.ComboBox cmbBox_Destination;
        private System.Windows.Forms.RadioButton rbtn_OneWay;
        private System.Windows.Forms.RadioButton rbtn_RoundTrip;
        private System.Windows.Forms.GroupBox grpBox_Search;
        private System.Windows.Forms.DateTimePicker cdr_FlightReturnDate;
        private System.Windows.Forms.Label lbl_ReturnDate;
        private System.Windows.Forms.Label lbl_FlightSearchHelp;
    }
}