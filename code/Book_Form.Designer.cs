namespace Flight_Reservation_System
{
    partial class Book_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Form));
            this.cdr_FlightReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Book = new System.Windows.Forms.Button();
            this.grpBox_Search = new System.Windows.Forms.GroupBox();
            this.lbl_ReturnDate = new System.Windows.Forms.Label();
            this.rbtn_RoundTrip = new System.Windows.Forms.RadioButton();
            this.rbtn_OneWay = new System.Windows.Forms.RadioButton();
            this.cmbBox_Destination = new System.Windows.Forms.ComboBox();
            this.cmbBox_Source = new System.Windows.Forms.ComboBox();
            this.dgd_FlightInfo = new System.Windows.Forms.DataGridView();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cdr_FlightDate = new System.Windows.Forms.DateTimePicker();
            this.btn_SearchFlight = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cmbBox_FlightClass = new System.Windows.Forms.ComboBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            this.dgd_Booking = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_History = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.lbl_BookHelp = new System.Windows.Forms.Label();
            this.grpBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_FlightInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_Booking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cdr_FlightReturnDate
            // 
            this.cdr_FlightReturnDate.AllowDrop = true;
            this.cdr_FlightReturnDate.CalendarFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdr_FlightReturnDate.Location = new System.Drawing.Point(561, 70);
            this.cdr_FlightReturnDate.Name = "cdr_FlightReturnDate";
            this.cdr_FlightReturnDate.Size = new System.Drawing.Size(151, 26);
            this.cdr_FlightReturnDate.TabIndex = 58;
            this.cdr_FlightReturnDate.Visible = false;
            // 
            // btn_Book
            // 
            this.btn_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.Image = ((System.Drawing.Image)(resources.GetObject("btn_Book.Image")));
            this.btn_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Book.Location = new System.Drawing.Point(9, 126);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(110, 42);
            this.btn_Book.TabIndex = 57;
            this.btn_Book.Text = "Book";
            this.btn_Book.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // grpBox_Search
            // 
            this.grpBox_Search.Controls.Add(this.lbl_ReturnDate);
            this.grpBox_Search.Controls.Add(this.rbtn_RoundTrip);
            this.grpBox_Search.Controls.Add(this.rbtn_OneWay);
            this.grpBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Search.Location = new System.Drawing.Point(199, 51);
            this.grpBox_Search.Name = "grpBox_Search";
            this.grpBox_Search.Size = new System.Drawing.Size(548, 64);
            this.grpBox_Search.TabIndex = 56;
            this.grpBox_Search.TabStop = false;
            this.grpBox_Search.Text = "Travel Selection";
            // 
            // lbl_ReturnDate
            // 
            this.lbl_ReturnDate.AutoSize = true;
            this.lbl_ReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReturnDate.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ReturnDate.Image")));
            this.lbl_ReturnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ReturnDate.Location = new System.Drawing.Point(274, 22);
            this.lbl_ReturnDate.Name = "lbl_ReturnDate";
            this.lbl_ReturnDate.Size = new System.Drawing.Size(55, 33);
            this.lbl_ReturnDate.TabIndex = 60;
            this.lbl_ReturnDate.Text = "     ";
            this.lbl_ReturnDate.Visible = false;
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
            // cmbBox_Destination
            // 
            this.cmbBox_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_Destination.FormattingEnabled = true;
            this.cmbBox_Destination.Location = new System.Drawing.Point(48, 68);
            this.cmbBox_Destination.Name = "cmbBox_Destination";
            this.cmbBox_Destination.Size = new System.Drawing.Size(121, 28);
            this.cmbBox_Destination.TabIndex = 55;
            // 
            // cmbBox_Source
            // 
            this.cmbBox_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_Source.FormattingEnabled = true;
            this.cmbBox_Source.Location = new System.Drawing.Point(48, 17);
            this.cmbBox_Source.Name = "cmbBox_Source";
            this.cmbBox_Source.Size = new System.Drawing.Size(121, 28);
            this.cmbBox_Source.TabIndex = 54;
            // 
            // dgd_FlightInfo
            // 
            this.dgd_FlightInfo.AllowUserToAddRows = false;
            this.dgd_FlightInfo.AllowUserToDeleteRows = false;
            this.dgd_FlightInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgd_FlightInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgd_FlightInfo.Location = new System.Drawing.Point(125, 19);
            this.dgd_FlightInfo.Name = "dgd_FlightInfo";
            this.dgd_FlightInfo.ReadOnly = true;
            this.dgd_FlightInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgd_FlightInfo.Size = new System.Drawing.Size(629, 149);
            this.dgd_FlightInfo.TabIndex = 53;
            this.dgd_FlightInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgd_FlightInfo_CellContentClick);
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Class.Location = new System.Drawing.Point(195, 18);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(48, 20);
            this.lbl_Class.TabIndex = 52;
            this.lbl_Class.Text = "Class";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Exit.Location = new System.Drawing.Point(635, 549);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(119, 42);
            this.btn_Exit.TabIndex = 51;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // cdr_FlightDate
            // 
            this.cdr_FlightDate.AllowDrop = true;
            this.cdr_FlightDate.CalendarFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr_FlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cdr_FlightDate.Location = new System.Drawing.Point(561, 19);
            this.cdr_FlightDate.Name = "cdr_FlightDate";
            this.cdr_FlightDate.Size = new System.Drawing.Size(151, 26);
            this.cdr_FlightDate.TabIndex = 50;
            // 
            // btn_SearchFlight
            // 
            this.btn_SearchFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchFlight.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchFlight.Image")));
            this.btn_SearchFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchFlight.Location = new System.Drawing.Point(9, 19);
            this.btn_SearchFlight.Name = "btn_SearchFlight";
            this.btn_SearchFlight.Size = new System.Drawing.Size(110, 43);
            this.btn_SearchFlight.TabIndex = 49;
            this.btn_SearchFlight.Text = "Search";
            this.btn_SearchFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SearchFlight.UseVisualStyleBackColor = true;
            this.btn_SearchFlight.Click += new System.EventHandler(this.btn_SearchFlight_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.Location = new System.Drawing.Point(7, 108);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 44);
            this.btn_Cancel.TabIndex = 48;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cmbBox_FlightClass
            // 
            this.cmbBox_FlightClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_FlightClass.FormattingEnabled = true;
            this.cmbBox_FlightClass.Items.AddRange(new object[] {
            "ECONOMY",
            "BUSINESS",
            "VIP"});
            this.cmbBox_FlightClass.Location = new System.Drawing.Point(249, 17);
            this.cmbBox_FlightClass.MaxDropDownItems = 3;
            this.cmbBox_FlightClass.Name = "cmbBox_FlightClass";
            this.cmbBox_FlightClass.Size = new System.Drawing.Size(165, 28);
            this.cmbBox_FlightClass.TabIndex = 44;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Date.Image")));
            this.lbl_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Date.Location = new System.Drawing.Point(473, 18);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(55, 33);
            this.lbl_Date.TabIndex = 47;
            this.lbl_Date.Text = "     ";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(6, 76);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(30, 20);
            this.lbl_to.TabIndex = 46;
            this.lbl_to.Text = "TO";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(2, 17);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(46, 20);
            this.lbl_From.TabIndex = 45;
            this.lbl_From.Text = "From";
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.Location = new System.Drawing.Point(18, 547);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(115, 42);
            this.btn_Print.TabIndex = 62;
            this.btn_Print.Text = "Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // dgd_Booking
            // 
            this.dgd_Booking.AllowUserToAddRows = false;
            this.dgd_Booking.AllowUserToDeleteRows = false;
            this.dgd_Booking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgd_Booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgd_Booking.Location = new System.Drawing.Point(125, 19);
            this.dgd_Booking.Name = "dgd_Booking";
            this.dgd_Booking.ReadOnly = true;
            this.dgd_Booking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgd_Booking.Size = new System.Drawing.Size(629, 144);
            this.dgd_Booking.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgd_FlightInfo);
            this.groupBox1.Controls.Add(this.btn_Book);
            this.groupBox1.Controls.Add(this.btn_SearchFlight);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 197);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_History);
            this.groupBox2.Controls.Add(this.dgd_Booking);
            this.groupBox2.Controls.Add(this.btn_Cancel);
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 187);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            // 
            // btn_History
            // 
            this.btn_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.Image = ((System.Drawing.Image)(resources.GetObject("btn_History.Image")));
            this.btn_History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_History.Location = new System.Drawing.Point(9, 28);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(110, 42);
            this.btn_History.TabIndex = 64;
            this.btn_History.Text = "History";
            this.btn_History.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_From);
            this.groupBox3.Controls.Add(this.lbl_to);
            this.groupBox3.Controls.Add(this.lbl_Date);
            this.groupBox3.Controls.Add(this.lbl_Class);
            this.groupBox3.Controls.Add(this.cdr_FlightDate);
            this.groupBox3.Controls.Add(this.cmbBox_FlightClass);
            this.groupBox3.Controls.Add(this.cdr_FlightReturnDate);
            this.groupBox3.Controls.Add(this.cmbBox_Source);
            this.groupBox3.Controls.Add(this.grpBox_Search);
            this.groupBox3.Controls.Add(this.cmbBox_Destination);
            this.groupBox3.Location = new System.Drawing.Point(11, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 126);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            // 
            // btn_Profile
            // 
            this.btn_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_Profile.Image")));
            this.btn_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.Location = new System.Drawing.Point(183, 547);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(112, 42);
            this.btn_Profile.TabIndex = 67;
            this.btn_Profile.Text = "Profile";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Profile.UseVisualStyleBackColor = true;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // lbl_BookHelp
            // 
            this.lbl_BookHelp.AutoSize = true;
            this.lbl_BookHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookHelp.Image = ((System.Drawing.Image)(resources.GetObject("lbl_BookHelp.Image")));
            this.lbl_BookHelp.Location = new System.Drawing.Point(762, 0);
            this.lbl_BookHelp.Name = "lbl_BookHelp";
            this.lbl_BookHelp.Size = new System.Drawing.Size(35, 31);
            this.lbl_BookHelp.TabIndex = 68;
            this.lbl_BookHelp.Text = "   ";
            this.lbl_BookHelp.Click += new System.EventHandler(this.lbl_BookHelp_Click);
            // 
            // Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.lbl_BookHelp);
            this.Controls.Add(this.btn_Profile);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Book_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Form";
            this.Load += new System.EventHandler(this.Book_Form_Load);
            this.grpBox_Search.ResumeLayout(false);
            this.grpBox_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_FlightInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_Booking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker cdr_FlightReturnDate;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.GroupBox grpBox_Search;
        private System.Windows.Forms.RadioButton rbtn_RoundTrip;
        private System.Windows.Forms.RadioButton rbtn_OneWay;
        private System.Windows.Forms.ComboBox cmbBox_Destination;
        private System.Windows.Forms.ComboBox cmbBox_Source;
        private System.Windows.Forms.DataGridView dgd_FlightInfo;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DateTimePicker cdr_FlightDate;
        private System.Windows.Forms.Button btn_SearchFlight;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cmbBox_FlightClass;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.DataGridView dgd_Booking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_ReturnDate;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Label lbl_BookHelp;
    }
}