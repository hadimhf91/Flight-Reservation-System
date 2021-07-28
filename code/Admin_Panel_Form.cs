using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    public partial class Admin_Panel_Form : Form
    {
        AirlineDbEntities db;
       
        public Admin_Panel_Form()
        {
            InitializeComponent();
            db = new AirlineDbEntities();

            BindDestination();
            BindSource();
        }
        // link datagrid to databse
        private void BindDestination()
        {
            var items = db.Flight_Details.Select(a => a.Destination).Distinct().ToList();  // make a link list to connect database
            comBox_Destination.DataSource = items;
            comBox_Destination.DisplayMember = "Destination";
            //throw new NotImplementedException();
        }

        private void BindSource()
        {
            var items = db.Flight_Details.Select(a => a.Source).Distinct().ToList();
            comBox_Source.DataSource = items;
            comBox_Source.DisplayMember = "source";
            //throw new NotImplementedException();
        }



        private void Admin_Panel_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDbDataSet.Flight_Details' table. You can move, or remove it, as needed.
            cdr_FlightDateTime.Format = DateTimePickerFormat.Custom;
            cdr_FlightDateTime.CustomFormat = "dd/MM/yyyy hh : mm : ss";
            cmbBox_FlightClass.SelectedIndex = 0;
        }

        private void txtBox_Source_TextChanged(object sender, EventArgs e)
        {

        }
        //--------- add new flight information to database
        // In this function all input fields are checked to be valid
        // and then will be added to database if they are ok
        private void btn_AddFlightInfo_Click(object sender, EventArgs e)
        {
            if (Validate_Flight_Info())  // check data validation
            {
                int test = db.Flight_Details.Where(a => a.Flight_ID.Equals(txtBox_FlightId.Text)).Count(); // check repetitive flight id 
                if (test == 0)
                {
                    // get all values from text boxes
                    Flight_Details fd = new Flight_Details();
                    fd.Flight_ID = txtBox_FlightId.Text;
                    fd.Source = comBox_Source.Text;
                    fd.Destination = comBox_Destination.Text;
                    // fd.Departure_DateTime = Convert.ToDateTime(cdr_FlightDateTime.Text);
                    fd.Departure_Date = cdr_FlightDateTime.Value.Date;
                    fd.Departure_Time = cdr_FlightDateTime.Value.TimeOfDay;
                    fd.Price = Convert.ToInt32(txtBox_FlightPrice.Text);
                    fd.Flight_Class = cmbBox_FlightClass.Text;
                    fd.Capacity = Convert.ToInt32(txtBox_Capacity.Text);
                    fd.Remained_Seat = Convert.ToInt32(txtBox_Capacity.Text);
                    db.Flight_Details.Add(fd);
                    db.SaveChanges();

                    MessageBox.Show("Flight added", "Updating Database");
                }
                else { MessageBox.Show("Change you flight Id"); }
            }

        }
        // ------------- Add new admin to system -------------
        // in this function input fields are check to be valid for being user and pass
        // and then add this data to database if they are ok
        private void btn_AddAdmin_Click(object sender, EventArgs e)
        {
            if (textBox_UserN.Text != string.Empty && textBox_Pass.Text != string.Empty)
            {
                Administrator fd = new Administrator(); //make new object
                bool flag = db.Administrators.Where(x => x.Username == textBox_UserN.Text).Any(); // check is there same user name or not
                if (flag)
                    MessageBox.Show("This user name is already registered", "Alert");
                else
                {
                    fd.Username = textBox_UserN.Text;  // get new values
                    fd.Password = textBox_Pass.Text;
                    db.Administrators.Add(fd);
                    db.SaveChanges();
                    MessageBox.Show("New Admin is added successfully..!", "Admin panel Message");

                }
            }
            else
                MessageBox.Show("Please fill all the blanks", "Admin panel Message");

        }

        bool Validate_Flight_Info()  // check input data to be valid
        {
            if (txtBox_FlightId.Text == string.Empty   || cdr_FlightDateTime.Text == string.Empty || // check all fileds be filled out
                comBox_Source.Text == string.Empty|| comBox_Destination.Text == string.Empty ||
                txtBox_FlightPrice.Text == string.Empty || cmbBox_FlightClass.Text == string.Empty ||
                txtBox_Capacity.Text == string.Empty)
            {
                MessageBox.Show("please fill all the blanks", "Warning..!");
                return false;
            }
            
              else
                return true;
         }

        //------------ this function will check the capacity field ------------------
        private void txtBox_Capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBox_FlightPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       


        private void btn_Save_Click(object sender, EventArgs e)
        {
            db.SaveChanges(); // Save new flight information into database
            MessageBox.Show("Flight Edited", "Updating Database");
        }

     

        private void btn_SearchFlight_Click(object sender, EventArgs e)
        {
            Flight admin_searched_flight = new Flight();
            admin_searched_flight.Source = comBox_Source.Text;
            admin_searched_flight.Destination = comBox_Destination.Text;

            if (admin_searched_flight.Source == "" || admin_searched_flight.Destination== "")
                MessageBox.Show("Please choose your source and destination", "Alert...!");
            else if (admin_searched_flight.Source != admin_searched_flight.Destination)
            {
                //string shortDate = cdr_FlightDate.Value.ToShortDateString();

                dgd_FlightInfoAdmin.DataSource = db.Flight_Details.Where(a => a.Source.Equals(admin_searched_flight.Source)
                && a.Destination.Equals(admin_searched_flight.Destination)).ToList();

            }
        }

        private void btn_EditAdmin_Click(object sender, EventArgs e)
        {
            Admin_Password_Confirm admin_password_confirm = new Admin_Password_Confirm();
            admin_password_confirm.ShowDialog();
        }

        private void lbl_AdminPanelHelp_Click(object sender, EventArgs e)
        {
            GlobalVar.help = File.ReadAllText("help\\admin_panel_help.txt");
            Help_Form help_form = new Help_Form();
            help_form.ShowDialog();
            
        }
    }

    
}


