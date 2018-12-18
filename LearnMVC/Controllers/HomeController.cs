using LearnMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greering = hour < 12 ? "Good morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            GuestResponse temp = new GuestResponse
            {
                Email = "bsrn",
                Name = "fdbrs",
                Phone = "3435465534",
                WillAttend = true
            };
            return View("Thanks", temp);
        }
    }
}