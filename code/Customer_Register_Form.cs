using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Flight_Reservation_System
{
    public partial class Customer_Register_Form : Form
    {
        AirlineDbEntities dq;
        private bool _isEdit = false;
        private Personal_Info _personal;

        public Customer_Register_Form(bool isEdit = false)
        {
            InitializeComponent();
            dq = new AirlineDbEntities(); // Make an object of database
            if (isEdit)
            {
                _isEdit = isEdit;
                _personal = dq.Personal_Info.First(f => f.Id == GlobalVar.customer_id);
                txtBox_CustomerFirstName.Text = _personal.FirstName; // save object to control
                txtBox_CustomerLastName.Text = _personal.LastName;// save object to control
                txtBox_CustomerEmail.Text = _personal.Email;// save object to control
                txtBox_CustomerUserName.Text = _personal.UserName;// save object to control
                cdr_CustomerBirthday.Value = (DateTime)_personal.BirthDate;
                chkBox_Terms.Visible = false;
                btn_Clear.Enabled = false;
                btn_CustomerSave.Enabled = true;
                lbl_CustomerOldPassword.Visible = true;
                txtBox_CustomerOldPassword.Visible = true;
                txtBox_CustomerUserName.Visible = false;
                label1.Visible = false;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            // Clear all fields
            txtBox_CustomerFirstName.Text = "";
            txtBox_CustomerLastName.Text = "";
            txtBox_CustomerEmail.Text = "";
            txtBox_CustomerUserName.Text = "";
            txtBox_CustomerPassword.Text = "";
            txtBox_CustomerPasswordConfirm.Text = "";
            cdr_CustomerBirthday.Value = DateTime.Now;

        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------- save personal information of customer ---------------
        // in this function all fields are checked to be valid nad then save to database
        private void btn_CustomerSave_Click(object sender, EventArgs e)
        {

            if (Validate_Customer_Info())  // check if input data is valid
            {
                if (!_isEdit) // check it's edit version or new one
                {
                    // save customer personal info 
                    int test = dq.Personal_Info.Where(a => a.UserName.Equals(txtBox_CustomerUserName.Text)).Count();
                    if (test == 0)
                    {
                        Personal_Info pi = new Personal_Info();
                        pi.FirstName = txtBox_CustomerFirstName.Text; // save parameter in objects
                        pi.LastName = txtBox_CustomerLastName.Text; // save parameter in objects
                        pi.Email = txtBox_CustomerEmail.Text; // save parameter in objects
                        pi.UserName = txtBox_CustomerUserName.Text;
                        if (txtBox_CustomerPassword.Text != string.Empty)
                        { pi.Password = txtBox_CustomerPassword.Text; }
                        pi.BirthDate = Convert.ToDateTime(cdr_CustomerBirthday.Text);
                        dq.Personal_Info.Add(pi);
                        dq.SaveChanges();
                        MessageBox.Show("Personal Information Saved");
                    }
                    else { MessageBox.Show("You cannot choose the username \n please try again"); }
                }
                else
                {
                   
                        Personal_Info pi = dq.Personal_Info.First(f => f.Id == _personal.Id);
                    pi.FirstName = txtBox_CustomerFirstName.Text; // save parameters in objects
                    pi.LastName = txtBox_CustomerLastName.Text; // save parameters in objects
                    pi.Email = txtBox_CustomerEmail.Text; // save parameters in objects
                    pi.UserName = txtBox_CustomerUserName.Text;
                    if (txtBox_CustomerOldPassword.Text != string.Empty && txtBox_CustomerPassword.Text != string.Empty)
                        pi.Password = txtBox_CustomerPassword.Text;
                    pi.BirthDate = Convert.ToDateTime(cdr_CustomerBirthday.Text);
                    dq.SaveChanges();
                    GlobalVar.customer_user_name = pi.UserName;
                    MessageBox.Show("Personal Information Saved");
                 
                }

                

            }

        }

        bool Validate_Customer_Info()// check input data is valid or not
        {
            if (_isEdit)
            {
                if (txtBox_CustomerFirstName.Text == string.Empty || txtBox_CustomerLastName.Text == string.Empty ||
                    txtBox_CustomerUserName.Text == string.Empty || txtBox_CustomerEmail.Text == string.Empty)

                {
                    MessageBox.Show("please fill all the blanks", "Warning..!");
                    return false;
                }
                else if (txtBox_CustomerOldPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter your old password", "Warning..!");
                    return false;
                }

                else if (txtBox_CustomerOldPassword.Text != string.Empty &&
                                !txtBox_CustomerOldPassword.Text.Equals(_personal.Password))
                {
                    MessageBox.Show("old password is not correct", "Warning..!");
                    return false;
                }
                else if (txtBox_CustomerOldPassword.Text != string.Empty && (txtBox_CustomerPassword.Text != txtBox_CustomerPasswordConfirm.Text))
                {
                    MessageBox.Show("Password Confirm is not correct", "Warning..!");
                    return false;
                }
                else
                    return true;

            }

            if (txtBox_CustomerFirstName.Text == string.Empty || txtBox_CustomerLastName.Text == string.Empty ||
                txtBox_CustomerUserName.Text == string.Empty || txtBox_CustomerEmail.Text == string.Empty)

            {
                MessageBox.Show("please fill all the blanks", "Warning..!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Customer_Register_Form_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_CustomerFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBox_Terms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Terms.Checked == true)  //Accept terms of condition to save personal info
                btn_CustomerSave.Enabled = true;
            else
                btn_CustomerSave.Enabled = false;
        }

        private void txtBox_CustomerFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))// just accept alphabet
            {
                e.Handled = true;
            }
        }

        private void txtBox_CustomerLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar)) // just accept alphabet
            {
                e.Handled = true;
            }
        }

        private void lbl_CustomerRegisterHelp_Click(object sender, EventArgs e)
        {
            GlobalVar.help = File.ReadAllText("help\\customer_panel_help.txt");
            Help_Form help_form = new Help_Form();
            help_form.ShowDialog();
        }
    }
}
