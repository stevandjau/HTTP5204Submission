using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index()
        {
            Student s01 = new Student()
            {
                name = "Steve",
                studentNo = "n01151903",
                program = "Web Development"
            };
            return View(s01);
        }
    }
}