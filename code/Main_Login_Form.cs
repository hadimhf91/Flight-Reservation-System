using System;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    
    public partial class Main_Login_Form : Form
    {
        public Main_Login_Form()
        {
            InitializeComponent();
        }


        //----------- load customer search form --------------
        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Customer_Login_Form customer_login_form = new Customer_Login_Form();
            customer_login_form.ShowDialog();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            Admin_Login_Form admin_login_form = new Admin_Login_Form();
            admin_login_form.ShowDialog();
        }
        //----------- load guest search fligh form --------------
        private void btn_Guest_Click(object sender, EventArgs e)
        {
            Flight_Search_Form guest_flight_search = new Flight_Search_Form();
            guest_flight_search.ShowDialog();
        }

        private void Main_Login_Form_Load(object sender, EventArgs e)
        {

        }
        //----------- load signup form --------------
        private void btn_Signup_Click(object sender, EventArgs e)
        {
            Customer_Register_Form customer_register_form = new Customer_Register_Form();
            customer_register_form.ShowDialog();
        }
    }
}
