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
            var model = new Assignments
            {
                Drivers = new List<Drivers>(),
                Vehicles = new List<Vehicles>()
            };
            return View(model);
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
            ViewBag.Services = ServicesList.Service; 
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
                ViewBag.ServiceID = booking.ServiceID;
                ViewBag.Vehicles = VehiclesList.Vehicles.Where(v => v.ServiceID == booking.ServiceID).ToList();
                ViewBag.Drivers = DriverList.Drivers.Where(d => d.ServiceID == booking.ServiceID).ToList();
                ViewBag.Reasons = ReasonsList.Reasons;

                return View("Book", booking);
            }

            booking.BookingID = Guid.NewGuid();
            booking.isSOS = false;
            BookingsList.Bookings.Add(booking);

            var driver = DriverList.Drivers.FirstOrDefault(d => d.DriverID == booking.DriverID);
            if (driver == null)
            {
                driver = new Drivers
                {
                    FirstName = "---",
                    LastName = "---",
                    PhoneNumber = "---",
                    ImagePath = "~/Content/Images/Drivers/Driver1.jpeg"
                };
            }

            var vehicle = VehiclesList.Vehicles.FirstOrDefault(v => v.VehicleID == booking.VehicleID);
            if (vehicle == null)
            {
                vehicle = new Vehicles
                {
                    Type = "---",
                    RegistrationNumber = "---",
                    ImagePath = "~/Content/Images/Services/AA.jpeg"
                };
            }

            var viewModel = new BookingConfirmation
            {
                Booking = booking,
                Driver = driver,
                Vehicle = vehicle
            };

            return View("BookingConfirmation", viewModel);
        }

        public ActionResult SOSBooking()
        {
            var random = new Random();

            var availableDrivers = DriverList.Drivers;
            var availableVehicles = VehiclesList.Vehicles;
            var availableReasons = ReasonsList.Reasons;

            if (!availableDrivers.Any() || !availableVehicles.Any())
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, "No drivers or vehicles available for SOS booking.");
            }

            var driver = availableDrivers[random.Next(availableDrivers.Count)];
            var vehicle = availableVehicles[random.Next(availableVehicles.Count)];
            var reasonId = availableReasons.FirstOrDefault()?.ReasonID ?? 1;

            var booking = new Bookings
            {
                BookingID = Guid.NewGuid(),
                isSOS = true,
                BookingDate = DateTime.Now,
                PickupTime = DateTime.Now,
                PhoneNumber = "0000000000",
                FullName = "SOS Booking",
                DriverID = driver.DriverID,
                VehicleID = vehicle.VehicleID,
                ReasonID = reasonId,
                PickupAddress = "Current Location",
                ServiceID = 1
            };

            BookingsList.Bookings.Add(booking);

            var viewModel = new BookingConfirmation
            {
                Booking = booking,
                Driver = driver,
                Vehicle = vehicle
            };

            return View("BookingConfirmation", viewModel);
        }


        public ActionResult RideHistory()
        {
            var bookings = BookingsList.Bookings.Select(b => new BookingConfirmation
            {
                Booking = b,
                Driver = DriverList.Drivers.FirstOrDefault(d => d.DriverID == b.DriverID) ?? new Drivers
                {
                    FirstName = "N/A",
                    LastName = "",
                    PhoneNumber = "",
                    ImagePath = "~/Content/Images/Drivers/Driver1.png"
                },
                Vehicle = VehiclesList.Vehicles.FirstOrDefault(v => v.VehicleID == b.VehicleID) ?? new Vehicles
                {
                    Type = "Unknown",
                    RegistrationNumber = "N/A",
                    ImagePath = "~/Content/Images/Services/AA.png"
                }
            }).ToList();

            return View(bookings);
        }

    }
}
