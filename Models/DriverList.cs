using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static u23708795_HW_Assignment.Models.VehiclesList;

namespace u23708795_HW_Assignment.Models
{
    public class DriverList
    {
        public static List<Drivers> Drivers = new List<Drivers>
        {
             new Drivers { DriverID = 1, FirstName = "Jose", LastName = "Edu", ImagePath = "~/Content/Images/Drivers/Driver1.jpg", PhoneNumber = "0785554440", ServiceID = 1 },
            new Drivers { DriverID = 2, FirstName = "Jeff", LastName = "Lost", ImagePath = "~/Content/Images/Drivers/Driver2.jpeg", PhoneNumber = "0785554441", ServiceID = 1 },
            new Drivers { DriverID = 3, FirstName = "Ben", LastName = "Dover", ImagePath = "~/Content/Images/Drivers/Driver3.jpeg", PhoneNumber = "0785554442", ServiceID = 2 },
            new Drivers { DriverID = 4, FirstName = "Ian", LastName = "Watts", ImagePath = "~/Content/Images/Drivers/Driver4.jpeg", PhoneNumber = "0785554443", ServiceID = 2 },
            new Drivers { DriverID = 5, FirstName = "Pile", LastName = "Driver", ImagePath = "~/Content/Images/Drivers/Driver5.jpeg", PhoneNumber = "0785554444", ServiceID = 3 },
            new Drivers { DriverID = 6, FirstName = "Suplex", LastName = "City", ImagePath = "~/Content/Images/Drivers/Driver6.jpeg", PhoneNumber = "0785554445", ServiceID = 3 },
            new Drivers { DriverID = 7, FirstName = "Tingus", LastName = "Pingus", ImagePath = "~/Content/Images/Drivers/Driver7.jpeg", PhoneNumber = "0785554446", ServiceID = 4 },
            new Drivers { DriverID = 8, FirstName = "Lebron", LastName = "James", ImagePath = "~/Content/Images/Drivers/Driver8.jpeg", PhoneNumber = "0785554447", ServiceID = 4 },
            new Drivers { DriverID = 9, FirstName = "Alfredo", LastName = "Solsona", ImagePath = "~/Content/Images/Drivers/Driver9.jpeg", PhoneNumber = "0785554448", ServiceID = 5 },
            new Drivers { DriverID = 10, FirstName = "Selma", LastName = "Bacha", ImagePath = "~/Content/Images/Drivers/Driver10.jpeg", PhoneNumber = "0785554449", ServiceID = 5 },
            new Drivers { DriverID = 11, FirstName = "Diego", LastName = "Maradona", ImagePath = "~/Content/Images/Drivers/Driver11.jpeg", PhoneNumber = "0785554450", ServiceID = 6 },
            new Drivers { DriverID = 12, FirstName = "Criss", LastName = "Lost", ImagePath = "~/Content/Images/Drivers/Driver12.jpeg", PhoneNumber = "0785554451", ServiceID = 6 }
        };
    }
}