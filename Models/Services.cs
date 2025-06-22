using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23708795_HW_Assignment.Models
{
    public class Services
    {
        public int ServiceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Drivers> Drivers { get; set; }
        public List<Vehicles> Vehicles { get; set; }
        public string ImagePath { get; set; }
    }

}