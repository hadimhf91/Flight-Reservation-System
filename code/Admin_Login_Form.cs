using System;
using System.Linq;
using System.Windows.Forms;


namespace Flight_Reservation_System
{
    public partial class Admin_Login_Form : Form
    {
        public Admin_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_AdminExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //----------------- Admin login -----------------
        // in this function input fields are checked and compare with 
        //database to autorize admin or send an approprate message when
        //InputLanguage data is not valid
        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            
             AirlineDbEntities db = new AirlineDbEntities(); // make an object of database
            if (txtBox_AdminName.Text != string.Empty && txtBox_AdminPass.Text != string.Empty) //check admin authentication
            {
                var user = db.Administrators.Where(a => a.Username.Equals(txtBox_AdminName.Text)).SingleOrDefault(); //looking for user name
                if (user != null)
                {
                    if (user.Password.Equals(txtBox_AdminPass.Text)) // check admin password
                    {
                        GlobalVar.admin_user_name = txtBox_AdminName.Text; // save admin user name in global variable
                        GlobalVar.admin_password = txtBox_AdminPass.Text;  // save admin user name in global variable
                        Admin_Panel_Form admin_panel_form = new Admin_Panel_Form();
                        this.Hide();
                        admin_panel_form.ShowDialog(); 
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is not correct","Alert...!");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is not correct","Alert...!");
                }
            }
            else
            {
                MessageBox.Show("Please enter login information","Warning!");
            }
        }

        private void Admin_Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void lbl_AdminLoginHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
