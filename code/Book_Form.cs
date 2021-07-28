using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Flight_Reservation_System
{
    public partial class Book_Form : Form
    {

        AirlineDbEntities db;

        public Book_Form()
        {
            InitializeComponent();
            db = new AirlineDbEntities(); // make an object of database
            BindDestination();
            BindSource();
        }

        private void BindDestination()
        {
            var items = db.Flight_Details.Select(a => a.Destination).Distinct().ToList();  // make a link list to connect database
            cmbBox_Destination.DataSource = items;
            cmbBox_Destination.DisplayMember = "Destination";
            //throw new NotImplementedException();
        }

        private void BindSource()
        {
            var items = db.Flight_Details.Select(a => a.Source).Distinct().ToList();
            cmbBox_Source.DataSource = items;
            cmbBox_Source.DisplayMember = "source";
            //throw new NotImplementedException();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ------------ffsidjfjsjfosfoksf-----
        private void btn_SearchFlight_Click(object sender, EventArgs e)
        {
            dgd_FlightInfo.DataSource = null;  // clear datagrid
            btn_Book.Enabled = false;
            if (cmbBox_Source.Text == "" || cmbBox_Destination.Text == "")   // check data entry
                MessageBox.Show("Please choose your source and destination", "Alert...!");
            else if (cmbBox_Source.Text != cmbBox_Destination.Text)
            {
                string shortDate = cdr_FlightDate.Value.ToShortDateString();
                if (rbtn_OneWay.Checked)  //check roundtrip flights
                {
                    
                    if (cmbBox_FlightClass.Text != "")
                    {
                        dgd_FlightInfo.DataSource = db.Flight_Details.Where(a =>
                                                                            a.Source.Equals(cmbBox_Source.Text)
                                                                         && a.Destination.Equals(cmbBox_Destination.Text)
                                                                         && a.Departure_Date == cdr_FlightDate.Value.Date
                                                                         && a.Flight_Class.Equals(cmbBox_FlightClass.Text)

                                                                             ).ToList();
                      
                    }
                    else {
                        dgd_FlightInfo.DataSource = db.Flight_Details.Where(a =>
                                                                            a.Source.Equals(cmbBox_Source.Text)
                                                                         && a.Destination.Equals(cmbBox_Destination.Text)
                                                                         && a.Departure_Date == cdr_FlightDate.Value.Date
                                                                           ).ToList();
                         
                    }

                    
                }

                if (rbtn_RoundTrip.Checked)
                {
                    var cnt_1 = db.Flight_Details.Where(b => b.Source.Equals(cmbBox_Destination.Text)
                                                     && b.Destination.Equals(cmbBox_Source.Text)
                                                     && b.Departure_Date == cdr_FlightReturnDate.Value.Date).Count();

                    var cnt_2 = db.Flight_Details.Where(b => b.Source.Equals(cmbBox_Source.Text)
                                                               && b.Destination.Equals(cmbBox_Destination.Text)
                                                               && b.Departure_Date == cdr_FlightDate.Value.Date).Count();
                    if (cmbBox_FlightClass.Text != "")
                    {
                        if (cnt_1 > 0 && cnt_2 > 0)
                        {
                            dgd_FlightInfo.DataSource = db.Flight_Details.Where(b =>
                                                                        b.Source.Equals(cmbBox_Destination.Text)
                                                                     && b.Destination.Equals(cmbBox_Source.Text)
                                                                     && b.Departure_Date == cdr_FlightReturnDate.Value.Date
                                                                     && b.Flight_Class.Equals(cmbBox_FlightClass.Text)
                                                                  ||
                                                                    (b.Source.Equals(cmbBox_Source.Text)
                                                                   && b.Destination.Equals(cmbBox_Destination.Text)
                                                                   && b.Departure_Date == cdr_FlightDate.Value.Date)
                                                                   && b.Flight_Class.Equals(cmbBox_FlightClass.Text)
                                                                    ).ToList();
                            
                        }
                    } else
                    {
               
                        if (cnt_1 > 0 && cnt_2 > 0) 
                        {
                            dgd_FlightInfo.DataSource = db.Flight_Details.Where(b =>
                                                    b.Source.Equals(cmbBox_Destination.Text)
                                                 && b.Destination.Equals(cmbBox_Source.Text)
                                                 && b.Departure_Date == cdr_FlightReturnDate.Value.Date
                                                  
                                              ||
                                                (b.Source.Equals(cmbBox_Source.Text)
                                               && b.Destination.Equals(cmbBox_Destination.Text)
                                               && b.Departure_Date == cdr_FlightDate.Value.Date)
                                              
                                                ).ToList();
                          
                        }

                    }
                }
                if (dgd_FlightInfo.Rows.Count == 0)
                    MessageBox.Show("There is no flight for your request ", "Information");
            }
            if (dgd_FlightInfo.Rows.Count > 0) { btn_Book.Enabled = true; }
        }



        private void Book_Form_Load(object sender, EventArgs e)
        {

            rbtn_OneWay.Checked = true; // Set premetive value for objects
            btn_Book.Enabled = false;
         
           
            
        }


        private void rbtn_RoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ReturnDate.Visible = true;  // roundtrip checker
            cdr_FlightReturnDate.Visible = true;
        }


        

        private void dgd_FlightInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            var currentrow = dgd_FlightInfo.CurrentRow.Cells["Id"].Value;
            int current_int = Convert.ToInt32(currentrow);
            string current_st = currentrow.ToString();

            if (current_int > 0) //check row counter

            {
                BookedTicket bt = new BookedTicket();
                var Chk = db.Flight_Details.Where(a => a.Id.Equals(current_int)).SingleOrDefault();
                if (Chk.Remained_Seat != 0)
                {
                    var Fid = dgd_FlightInfo.CurrentRow.Cells["Flight_ID"].Value;
                int cnt_booked= db.BookedTickets.Where(a => a.UserName.Equals(GlobalVar.customer_user_name)&& a.Status == "Booked    "&& a.Flight_ID== Fid.ToString()).Count();
                  
                    if (cnt_booked == 0)
                    {
                        bt.Book_ID = Convert.ToInt32(dgd_FlightInfo.CurrentRow.Cells[0].Value);
                        bt.Flight_ID = dgd_FlightInfo.CurrentRow.Cells[1].Value.ToString();
                        bt.UserName = GlobalVar.customer_user_name; // save customer name 
                        bt.Source = dgd_FlightInfo.CurrentRow.Cells[2].Value.ToString();
                        bt.Destination = dgd_FlightInfo.CurrentRow.Cells[3].Value.ToString();
                        bt.Departure_Date = Convert.ToDateTime(dgd_FlightInfo.CurrentRow.Cells[4].Value);
                        bt.Departure_Time = (TimeSpan)(dgd_FlightInfo.CurrentRow.Cells[5].Value);
                        bt.Flight_Class = dgd_FlightInfo.CurrentRow.Cells[6].Value.ToString();
                        bt.Price = Convert.ToInt32(dgd_FlightInfo.CurrentRow.Cells[7].Value);
                        bt.Status = "Booked    ";
                        db.BookedTickets.Add(bt);

                        Chk.Remained_Seat = Chk.Remained_Seat - 1;
                        db.SaveChanges();  // Save changes in database
                        dgd_Booking.DataSource = db.BookedTickets.Where(a => a.UserName.Equals(GlobalVar.customer_user_name)).ToList();
                        dgd_Booking.Columns[0].Visible = false;
                        dgd_Booking.Columns[2].Visible = false;

                        MessageBox.Show("Your Flight is booked", "Information");
                    }
                    else { MessageBox.Show("Your Flight already booked", "Warning");  }
                }
                else { MessageBox.Show("Full"); }


            }


            else { MessageBox.Show("Please select your flight", "Warining!"); }
        }

        //------- print a selected ticket as a pdf file ----------------------
        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (dgd_Booking.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog(); // make an object for save dialog
                sfd.Filter = "PDF (*.pdf)|*.pdf";          // set file format
                sfd.FileName = "Ticket.pdf";              // set file name
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))    // check if is any file with this name
                    {
                        try
                        {
                            File.Delete(sfd.FileName);   // replace the file
                        }
                        catch (IOException ex)    // error handler if disk is full
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }

                    if (!fileError)   // alignment of pdf file
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgd_Booking.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgd_Booking.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            if (dgd_Booking.SelectedRows.Count == 0)  // select row that should be print
                                dgd_Booking.SelectAll();
                            foreach (DataGridViewRow row in dgd_Booking.SelectedRows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value?.ToString() ?? "");
                                }
                            }
                            if (dgd_Booking.SelectedRows.Count == dgd_Booking.RowCount) dgd_Booking.ClearSelection();

                            using (var stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc =
                                    new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);  //set page size
                                PdfWriter.GetInstance(pdfDoc, stream);  // makeing pdf file
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        // ---- check one way or two way flight ticket --------------------
        private void rbtn_OneWay_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ReturnDate.Visible = false;  // roundtrip selection
            cdr_FlightReturnDate.Visible = false;
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }





        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Customer_Register_Form frm = new Customer_Register_Form(true);
            frm.ShowDialog();
        }

        //-------- show all the history of customer activation(reservatiom) --------------

        private void btn_History_Click(object sender, EventArgs e)
        {
            BookedTicket bt = new BookedTicket();
            dgd_Booking.DataSource = db.BookedTickets.Where(a => a.UserName.Equals(GlobalVar.customer_user_name)).ToList();
            
            dgd_Booking.Columns[0].Visible = false;
            dgd_Booking.Columns[2].Visible = false;
        }
                    
        //------- cancel a reservation -----------------
        // In this function customer can cancel a book that he has done before
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            
            if (dgd_Booking.CurrentRow != null)
            {
                var currentrow = dgd_Booking.CurrentRow.Cells["Book_ID"].Value; // check booking ID

                int current_int = Convert.ToInt32(currentrow);

                BookedTicket bt = new BookedTicket(); // make a new object

                var cnl = db.Flight_Details.Where(a => a.Id.Equals(current_int)).SingleOrDefault(); // find the data in data bse
                int Rowno = Convert.ToInt32(dgd_Booking.CurrentRow.Cells["Id"].Value);
                var cancelId = db.BookedTickets.Where(a => a.Id.Equals(Rowno)).SingleOrDefault();
                if (cancelId.Status == "Booked    ") // check the status of selected ticket
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to cancel your booking?", "Warning!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)   // validate that customer want to delete this ticket
                    {
                        cnl.Remained_Seat = cnl.Remained_Seat + 1;
                        dgd_Booking.CurrentRow.Cells["Status"].Value = "Cancelled ";
                        db.SaveChanges();  // Save changes in database
                        MessageBox.Show(" Your reservation is cancelled", "Warrning");
                        dgd_Booking.DataSource = db.BookedTickets.Where(a => a.UserName.Equals(GlobalVar.customer_user_name)).ToList();
                        dgd_Booking.Columns[0].Visible = false;
                        dgd_Booking.Columns[2].Visible = false;
                    }

                }
                else if (cancelId.Status == "Cancelled ")  // check to be sure the ticket has not been cancelled before
                     MessageBox.Show("Your booking has been cancelled before !","warining");
                
                }
                else { MessageBox.Show("Please select your flight"); }
            }
        // ------------ show book window -------------------
        private void lbl_BookHelp_Click(object sender, EventArgs e)
        {
            GlobalVar.help = File.ReadAllText("help\\book_panel_help.txt"); // open text box in current path directory
            Help_Form help_form = new Help_Form();
            help_form.ShowDialog();
        }
    }


    }



