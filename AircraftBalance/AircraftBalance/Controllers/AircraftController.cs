using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AircraftBalance.Controllers
{
    public class AircraftController : Controller
    {
        // GET: Aircraft
        public ActionResult Index()
        {
            return View();
        }
    }
}