using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.IO;

namespace u23708795_HW_Assignment.Models
{
    public class VehiclesList
    {
        public static List<Vehicles> Vehicles = new List<Vehicles>
        {
           new Vehicles { VehicleID = 1, Type = "Advanced Life Support", RegistrationNumber = "GP 001-ALS", ImagePath = "~/Content/Images/Vehicles/ALS.jpeg", ServiceID = 1 },
            new Vehicles { VehicleID = 2, Type = "Basic Life Support", RegistrationNumber = "KZN 001-BLS", ImagePath = "~/Content/Images/Vehicles/BLS.jpeg", ServiceID = 2 },
            new Vehicles { VehicleID = 3, Type = "Patient Transport", RegistrationNumber = "WC 001-PT", ImagePath = "~/Content/Images/Vehicles/Patient.jpeg", ServiceID = 3 },
            new Vehicles { VehicleID = 4, Type = "Medical Utility Vehicle", RegistrationNumber = "EC 001-MUV", ImagePath = "~/Content/Images/Vehicles/Medical.jpeg", ServiceID = 4 },
            new Vehicles { VehicleID = 5, Type = "Event Medical Ambulance", RegistrationNumber = "NW 001-EMA", ImagePath = "~/Content/Images/Vehicles/Event.jpeg", ServiceID = 5 },
            new Vehicles { VehicleID = 6, Type = "Air Ambulance", RegistrationNumber = "ZA-AIR-001", ImagePath = "~/Content/Images/Vehicles/Air.jpeg", ServiceID = 6 },
            new Vehicles { VehicleID = 7, Type = "Advanced Life Support", RegistrationNumber = "GP 002-ALS", ImagePath = "~/Content/Images/Vehicles/ALS.jpeg", ServiceID = 1 },
            new Vehicles { VehicleID = 8, Type = "Basic Life Support", RegistrationNumber = "FS 002-BLS", ImagePath = "~/Content/Images/Vehicles/BLS.jpeg", ServiceID = 2 },
            new Vehicles { VehicleID = 9, Type = "Patient Transport", RegistrationNumber = "LIM 002-PT", ImagePath = "~/Content/Images/Vehicles/Patient.jpeg", ServiceID = 3 },
            new Vehicles { VehicleID = 10, Type = "Medical Utility Vehicle", RegistrationNumber = "MP 002-MUV", ImagePath = "~/Content/Images/Vehicles/Medical.jpeg", ServiceID = 4 },
            new Vehicles { VehicleID = 11, Type = "Event Medical Ambulance", RegistrationNumber = "NC 002-EMA", ImagePath = "~/Content/Images/Vehicles/Event.jpeg", ServiceID = 5 },
            new Vehicles { VehicleID = 12, Type = "Air Ambulance", RegistrationNumber = "ZA-AIR-002", ImagePath = "~/Content/Images/Vehicles/Air.jpeg", ServiceID = 6 }
        };
    }
}