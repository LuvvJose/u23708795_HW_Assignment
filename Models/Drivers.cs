using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u23708795_HW_Assignment.Models
{
	public class Drivers
	{
    [Key]
    public int DriverID { get; set; }

    [Required(ErrorMessage = "First name is required")]
    [StringLength(50)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required")]
    [StringLength(50)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Display(Name = "Profile Image Path")]
    [StringLength(255)]
    public string ImagePath { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [Phone(ErrorMessage = "Invalid phone number format")]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Service ID is required")]
    [Display(Name = "Service")]
    public int ServiceID { get; set; }

    // Optional: Full name convenience property (not mapped to DB)
    [Display(Name = "Full Name")]
    public string FullName => $"{FirstName} {LastName}";
	}
}