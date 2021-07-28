using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Flight_Reservation_System
{
     class Flight
    {

        public string FlightId;
        public string Source;
        public string Destination;
        public DateTime FlightDate;
        public DateTime FlightTime;
        public string FlightClass;
        public Int32 Capacity;
        public Int32 Price;
        public bool RoundTrip;
        public DateTime FlightReturnDate; 

        static Flight() { }
        
    }

    class User
    {
        public void Search_flight() { }

    }

     class Guest : User
     {
       public void register() { }
     }

     class Customer : User
     {

        public string FirstName;
        public string LastName;
        public string UserName;
        public string Password;
        public DateTime Birthdate;
        public string Email;


        public void login(string a) {  }
        public void book() { }
        public void cancel() { }
        public void print() { }
     }

     class Admin : User
     {

        public string UserName;
        public string Password;
        public string Email;


        public void admin_login() { }
        public void add_flight() { }
        public void add_admin() { }
        public void report() { }
        }
    }

