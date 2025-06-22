using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using u23708795_HW_Assignment.Models;

namespace u23708795_HW_Assignment.Models
{
    public static class ServicesList
    {
        public static List<Services> Service = new List<Services>
       {
           new Services
           {
               ServiceID = 1,
               Name = "Advanced Life Support",
               Description = "ALS ambulance is staffed by a Paramedic and is used to transport patients who require a high level of care.",
               ImagePath = "~/Content/Images/Services/ADL.jpg",
               Drivers = new List<Drivers>(),
               Vehicles = new List<Vehicles>()
           },
           new Services
           {
               ServiceID = 2,
               Name = "Basic Life Support",
               Description = "BLS ambulance provides transport to patients who are in a non-life threatening condition.",
               ImagePath = "~/Content/Images/Services/BLS.jpeg",
               Drivers = new List<Drivers>(),
               Vehicles = new List<Vehicles>()
           },
           new Services
           {
               ServiceID = 3,
               Name = "Patient Support",
               Description = "The most basic type of transport for patients requiring ambulatory support to and from the hospital.",
               ImagePath = "~/Content/Images/Services/PT.jpeg",
               Drivers = new List<Drivers>(),
               Vehicles = new List<Vehicles>()
           },
           new Services
           {
               ServiceID = 4,
               Name = "Medical Utility Vehicle",
               Description = "A state-of-the-art small or large van designed to facilitate the movement and transport of patients.",
               ImagePath = "~/Content/Images/Services/MDU.jpeg",
               Drivers = new List<Drivers>(),
               Vehicles = new List<Vehicles>()
           },
           new Services
           {
               ServiceID = 5,
               Name = "Event Medical Ambulance",
               Description = "Ambulances stationed at events such as concerts, sports games, and festivals to provide medical assistance.",
               ImagePath = "~/Content/Images/Services/EMA.jpeg",
               Drivers = new List<Drivers>(),
               Vehicles = new List<Vehicles>()
           },
           new Services
           {
               ServiceID = 6,
               Name = "Air Ambulance",
               Description = "Air ambulances help in transferring patients across long distances in both emergency and non-emergency situations.",
               ImagePath = "~/Content/Images/Services/AA.jpeg",
               Drivers = new List<Drivers>(),
               Vehicles = new List<Vehicles>()
           }
       };

        public static List<Bookings> Bookings = new List<Bookings>();

        public static List<Reasons> Reasons = new List<Reasons>
       {
           new Reasons { ReasonID = 1, Description = "SOS Emergency" },
           new Reasons { ReasonID = 2, Description = "Critical Illness Transport" },
           new Reasons { ReasonID = 3, Description = "Medical Supplies Delivery" },
           new Reasons { ReasonID = 4, Description = "Accident" }
       };
    }
}
