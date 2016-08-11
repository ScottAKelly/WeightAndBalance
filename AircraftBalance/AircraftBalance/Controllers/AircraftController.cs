using AircraftBalance.BusinessLogic;
using AircraftBalance.Data;
using AircraftBalance.Models;
using AircraftBalance.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static AircraftBalance.Data.IdentityModel;

namespace AircraftBalance.Controllers
{
    public class AircraftController : Controller
    {
        private AircraftBalanceDbContext _db = new AircraftBalanceDbContext();
        private Aircraft _plane = new Aircraft();
        private readonly AircraftService _svc = new AircraftService();
        private readonly Calculation _calc = new Calculation();

        // GET: Aircraft
        public ActionResult Index(Aircraft aircraft)
        {
            ViewBag.AircraftMake = new SelectList(_db.Aircraft, "AircraftId", "AircraftMake", aircraft.AircraftId);
            ViewBag.AircraftName = new SelectList(_db.Aircraft, "AircraftId", "AircraftName", aircraft.AircraftId);
            ViewBag.AircraftModel = new SelectList(_db.Aircraft, "AircraftId", "AircraftModel", aircraft.AircraftId);
            return View();
        }

        public ActionResult Calculate()
        {
            var vm = new AircraftViewModel();
            return View(vm);
        }

        //[HttpPost]
        //public ActionResult Calculate(AircraftViewModel vm)
        //{
        //    _plane = _svc.GetAircraftByID(vm.AircraftId);
        //}
    }
}