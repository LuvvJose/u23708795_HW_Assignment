using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u23708795_HW_Assignment.Models
{
	public class Bookings
	{
        private static object bookings;

        public static object GetBookings()
        {
            return bookings;
        }

        internal static void SetBookings(object value)
        {
            bookings = value;
        }

        [Key]
        public Guid BookingID { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [Display(Name = "Full Name")]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Pickup Time is required")]
        [DataType(DataType.Time)]
        [Display(Name = "Pickup Time")]
        public DateTime PickupTime { get; set; }

        [Required(ErrorMessage = "Pickup Address is required")]
        [Display(Name = "Pickup Address")]
        [StringLength(300)]
        public string PickupAddress { get; set; }

        [Display(Name = "Is SOS")]
        public bool isSOS { get; set; }

        [Required(ErrorMessage = "Booking Date is required")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }

        [Required(ErrorMessage = "Driver selection is required")]
        [Display(Name = "Driver")]
        public int DriverID { get; set; }

        [Required(ErrorMessage = "Vehicle selection is required")]
        [Display(Name = "Vehicle")]
        public int VehicleID { get; set; }

        [Required(ErrorMessage = "Service ID is required")]
        [Display(Name = "Service")]
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Please select a reason")]
        [Display(Name = "Reason")]
        public int ReasonID { get; set; }
    }

}
