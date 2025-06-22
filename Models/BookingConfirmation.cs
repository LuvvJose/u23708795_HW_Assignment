using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23708795_HW_Assignment.Models
{
    public class BookingConfirmation
    {
        public Bookings Booking { get; set; }
        public Drivers Driver { get; set; }
        public Vehicles Vehicle { get; set; }
    }
}