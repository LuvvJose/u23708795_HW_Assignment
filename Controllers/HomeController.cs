using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using u23708795_HW_Assignment.Models;
using u24894045_HW01.Models;

namespace u23708795_HW_Assignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult MainPage()
        {
            ViewBag.Message = "Welcome to the main page of the application.";
            return View();
        }

        public ActionResult Services()
        {
            var services = ServicesList.Service;
            return View(services);
        }

        public ActionResult NormalBooking()
        {
            ViewBag.drivers = DriverList.Drivers;
            ViewBag.Vehicles = VehiclesList.Vehicles;
            ViewBag.reasons = ReasonsList.Reasons;
            ViewBag.ServiceID = 1;

            return View();
        }

        public ActionResult BookingConfirmation(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Booking ID is missing.");
            }

            var bookings = Bookings.GetBookings() as IEnumerable<Bookings>;

            if (bookings == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, "Bookings data is invalid.");
            }

            var booking = bookings.FirstOrDefault(b => b.BookingID == id.Value);
            if (booking == null)
            {
                return HttpNotFound("Booking not found.");
            }

            var driver = DriverList.Drivers.FirstOrDefault(d => d.DriverID == booking.DriverID);
            var vehicle = VehiclesList.Vehicles.FirstOrDefault(v => v.VehicleID == booking.VehicleID);

            var viewModel = new BookingConfirmation
            {
                Booking = booking,
                Driver = driver,
                Vehicle = vehicle
            };

            return View(viewModel);
        }

        public ActionResult Manage()
        {
            ViewBag.Services = new List<string> { "Service1", "Service2" };
            return View();
        }

        public ActionResult CreateBooking(Bookings booking)
        {
            if (booking == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Booking data is missing.");
            }

            if (!ModelState.IsValid)
            {
                // Repopulate dropdowns in case of validation errors
                ViewBag.ServiceID = booking.ServiceID;
                ViewBag.Vehicles = VehiclesList.Vehicles.Where(v => v.ServiceID == booking.ServiceID).ToList();
                ViewBag.Drivers = DriverList.Drivers.Where(d => d.ServiceID == booking.ServiceID).ToList();
                ViewBag.Reasons = ReasonsList.Reasons;

                return View("Book", booking);
            }

            // Assign booking details
            booking.BookingID = Guid.NewGuid();
            booking.isSOS = false;
            BookingsList.Bookings.Add(booking);

            // Get associated driver and vehicle
            var driver = DriverList.Drivers.FirstOrDefault(d => d.DriverID == booking.DriverID);
            if (driver == null)
            {
                driver = new Drivers // Fixed type name to match the provided type signature
                {
                    FirstName = "(Unavailable)",
                    LastName = "",
                    PhoneNumber = "",
                    ImagePath = "~/Content/Images/Drivers/default.png"
                };
            }

            var vehicle = VehiclesList.Vehicles.FirstOrDefault(v => v.VehicleID == booking.VehicleID);
            if (vehicle == null)
            {
                vehicle = new Vehicles
                {
                    Type = "Unknown Vehicle",
                    RegistrationNumber = "N/A",
                    ImagePath = "~/Content/Images/Vehicles/default.png"
                };
            }

            var viewModel = new BookingConfirmation
            {
                Booking = booking,
                Driver = driver,
                Vehicle = vehicle
            };

            return View("BookingConfirmed", viewModel);
        }
    }
}
