using System;
using System.Windows.Forms;



namespace Flight_Reservation_System
{
    public static class GlobalVar
    { public static string customer_user_name;
      public static string admin_user_name;
      public static string admin_password;
      public static int customer_id;
      public static string help;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Login_Form());
        }
    }
}
