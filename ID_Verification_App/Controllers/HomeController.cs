using ID_Verification_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ID_Verification_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(RegisterUser ru)
        {

            return View();
        }

        [Authorize]
        public ActionResult Welcome()
        {
            return View();

        }
    }
}