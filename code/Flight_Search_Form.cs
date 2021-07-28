using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    public partial class Flight_Search_Form : Form
    {
        AirlineDbEntities db;
        public Flight_Search_Form()
        {
            InitializeComponent();
            db = new AirlineDbEntities();
            BindDestination();
            BindSource();
        }
// ----- link datagrid to database ------------
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
//------------------- search flight in database ----------------
// in this function user can search through the database to find desired flight
// all the fileds are checked to be valid
        private void btn_SearchFlight_Click(object sender, EventArgs e)
        {
            dgd_FlightInfo.DataSource = null;  // clear datagrid
             
            if (cmbBox_Source.Text == "" || cmbBox_Destination.Text == "")   // check data entry
                MessageBox.Show("Please choose your source and destination", "Alert...!");
            else if (cmbBox_Source.Text != cmbBox_Destination.Text)
            {
                string shortDate = cdr_FlightDate.Value.ToShortDateString();
                if (rbtn_OneWay.Checked)  //check roundtrip flights
                {

                    if (cmbBox_FlightClass.Text != "") // check flight class to is selected or not
                    { // serach in database to finde source nad destination 
                        dgd_FlightInfo.DataSource = db.Flight_Details.Where(a =>            
                                                                            a.Source.Equals(cmbBox_Source.Text)
                                                                         && a.Destination.Equals(cmbBox_Destination.Text)
                                                                         && a.Departure_Date == cdr_FlightDate.Value.Date
                                                                         && a.Flight_Class.Equals(cmbBox_FlightClass.Text)

                                                                             ).ToList();
                    }
                    else
                    {
                        dgd_FlightInfo.DataSource = db.Flight_Details.Where(a =>
                                                                            a.Source.Equals(cmbBox_Source.Text)
                                                                         && a.Destination.Equals(cmbBox_Destination.Text)
                                                                         && a.Departure_Date == cdr_FlightDate.Value.Date
                                                                           ).ToList();
                    }


                }

                if (rbtn_RoundTrip.Checked) // check roundtrip to is selected or not
                {
                    var cnt_1 = db.Flight_Details.Where(b => b.Source.Equals(cmbBox_Destination.Text) // check first rout
                                                     && b.Destination.Equals(cmbBox_Source.Text)
                                                     && b.Departure_Date == cdr_FlightReturnDate.Value.Date).Count();

                    var cnt_2 = db.Flight_Details.Where(b => b.Source.Equals(cmbBox_Source.Text)  // check return rout
                                                               && b.Destination.Equals(cmbBox_Destination.Text)
                                                               && b.Departure_Date == cdr_FlightDate.Value.Date).Count();
                    if (cmbBox_FlightClass.Text != "")
                    {
                        if (cnt_1 > 0 && cnt_2 > 0) // check first and second rout are existed
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
                    }
                    else
                    {

                        if (cnt_1 > 0 && cnt_2 > 0) // check first and second rout are existed
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
            
        }


        private void Flight_Search_Form_Load(object sender, EventArgs e)
        {
 
            rbtn_OneWay.Checked = true;
        }

        private void rbtn_RoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ReturnDate.Visible = true;
            cdr_FlightReturnDate.Visible = true;
       }

        private void rbtn_OneWay_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ReturnDate.Visible = false;
            cdr_FlightReturnDate.Visible = false;
        }
      

     
    }
}
