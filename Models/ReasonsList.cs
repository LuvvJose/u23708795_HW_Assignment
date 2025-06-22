using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace u23708795_HW_Assignment.Models
{
    public class ReasonsList
    {
        public static List<Reasons> Reasons = new List<Reasons>
        {
          new Reasons { ReasonID = 1, Description = "SOS Emergency" },
          new Reasons { ReasonID = 2, Description = "Critical Illness Transport" },
          new Reasons { ReasonID = 3, Description = "Medical Supplies Delivery" },
          new Reasons { ReasonID = 4, Description = "Accident" }
        };

    }
}