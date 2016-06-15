using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeightAndBalance.Models;
using WeightAndBalance.Services;

namespace WeightAndBalance.Controllers
{
    public class AircraftController : Controller
    {
        private AircraftService _svc = new AircraftService();

        // GET: Aircraft
        public ActionResult Index()
        {
            var vm = new AircraftViewModel();
            return View(vm);
        }

    }
}