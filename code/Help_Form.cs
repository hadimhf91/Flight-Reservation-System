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
  

    public partial class Help_Form : Form
    {
        public Help_Form()
        {
              
        InitializeComponent();
        }

        private void Help_Form_Load(object sender, EventArgs e)
        {
            txtBox_Help.Text =  GlobalVar.help;
           
        }
    }
}
