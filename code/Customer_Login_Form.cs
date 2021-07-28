using System;
using System.Linq;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    public partial class Customer_Login_Form : Form
    {
        public Customer_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_CustomerExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //----------------- customer login -----------------
        // in this function input fields are checked and compare with 
        //database to autorize customer or send an approprate message when
        //InputLanguage data is not valid
        private void btn_CustomerLogin_Click(object sender, EventArgs e)
        {
           
            AirlineDbEntities db = new AirlineDbEntities();
            Customer new_customer = new Customer();
            new_customer.UserName = txtBox_CustomerName.Text;
            new_customer.Password = txtBox_CustomerPass.Text;
            new_customer.login(new_customer.UserName);
            // Check Customer Authentication
            if (new_customer.UserName != string.Empty && new_customer.Password != string.Empty)
            {
                var user = db.Personal_Info.Where(a => a.UserName.Equals(new_customer.UserName)).SingleOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(new_customer.Password)) // check password
                    {
                        GlobalVar.customer_user_name = txtBox_CustomerName.Text; // save customer name through the forms
                        GlobalVar.customer_id = user.Id;
                        this.Hide();
                        Book_Form booking_form = new Book_Form();
                        booking_form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is not correct", "Alert...!");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is not correct", "Alert...!");
                }
            }
            else
            {
                MessageBox.Show("Please enter login information", "Warning!");
            }


        }

        private void Customer_Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
