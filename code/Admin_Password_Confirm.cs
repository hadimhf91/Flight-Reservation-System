using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Reservation_System
{
    public partial class Admin_Password_Confirm : Form
    {
        public Admin_Password_Confirm()
        {
            InitializeComponent();
        }
// --------------- save new admin passwrod -----------
// in this function the new password and user name will check to be not repetitive and valide, 
// then they would be saved
        private void btn_AdminNewPassSave_Click(object sender, EventArgs e)
        {
            if (!(txtBox_AdminCurrentPass.Text == GlobalVar.admin_password)) // check current password
                MessageBox.Show("Your current password is not correct!", "Alert !");
           else if(txtBox_AdminNewPass.Text != txtBox_AdminConfirmPass.Text)   // check new password confirmation
                MessageBox.Show("Your new passwords are not match!", "Alert !");
            else
            {
                if (txtBox_AdminConfirmPass.Text != string.Empty || txtBox_AdminNewPass.Text != string.Empty)
                {
                    AirlineDbEntities db = new AirlineDbEntities(); // make an object
                    var admin = db.Administrators.First(f =>
                    f.Username == GlobalVar.admin_user_name && f.Password == GlobalVar.admin_password);
                    admin.Password = txtBox_AdminNewPass.Text;
                    db.SaveChanges(); // save new user and pass
                    MessageBox.Show("Your password is changed!", "Success !");
                }
                else { MessageBox.Show("Please fill all the blanks", "Warning!"); }
            }

        }
    }
}
