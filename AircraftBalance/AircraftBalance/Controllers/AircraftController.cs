using AircraftBalance.BusinessLogic;
using AircraftBalance.Data;
using AircraftBalance.Models;
using AircraftBalance.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AircraftBalance.Controllers
{
    public class AircraftController : Controller
    {

        private readonly AircraftService _svc = new AircraftService();
        private readonly Calculation _calc = new Calculation();

        // GET: Aircraft
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculate()
        {
            var vm = new AircraftViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Calculate(Aircraft aircraft, Payload payload)
        {
            var plane = _svc.GetAircraftByID(aircraft.AircraftId);

            _calc.CalculateZeroFuelCG(payload, aircraft);
            

        }
    }
}