using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using DOCs_RSVP_Form.Models;

namespace DOCs_RSVP_Form.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index() => View();

        [HttpGet]
        public ActionResult RSVPNow() => View();

        [HttpPost]
        public ActionResult RSVPNow(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                Repository.AddReservation(reservation);
                return View("Congratulations",
                    Repository.Reservations
                    .Last());
            }
            else { return View(); }
        }

        [HttpGet]
        public ViewResult Attendees()
        {
            return View(Repository.Reservations);
        }
    }
}