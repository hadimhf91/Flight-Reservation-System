//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flight_Reservation_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight_Details
    {
        public int Id { get; set; }
        public string Flight_ID { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public Nullable<System.DateTime> Departure_Date { get; set; }
        public Nullable<System.TimeSpan> Departure_Time { get; set; }
        public string Flight_Class { get; set; }
        public Nullable<int> Capacity { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Remained_Seat { get; set; }
    }
}
