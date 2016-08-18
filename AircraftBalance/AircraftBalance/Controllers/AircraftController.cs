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
        private readonly AircraftBalanceDbContext _db;
        private readonly Aircraft _plane;
        private readonly AircraftService _svc;
        private readonly Calculation _calc;

        public AircraftController()
        {
            _db = new AircraftBalanceDbContext();
            _plane = new Aircraft();
            _svc = new AircraftService();
            _calc = new Calculation();
        }

        // GET: Aircraft
        public ActionResult Index()
        {
            var viewModel = new AircraftViewModel
            {
                Aircraft = _db.Aircraft.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(AircraftViewModel viewModel)
        {
            var plane = _db.Aircraft.SingleOrDefault(e => e.AircraftId == viewModel.Plane);
            var payload = _calc.CreateFromItems(viewModel.PayloadItems);
            // Now use inputs from viewModel and constants from the object to calculate.  Call calculation methods.
            return View(viewModel);
        }

        public ActionResult Calculate(Aircraft plane)
        {
            plane = _plane;
            return View();
        }

        //[HttpPost]
        //public ActionResult Calculate(AircraftViewModel vm)
        //{
        //    _plane = _svc.GetAircraftByID(vm.AircraftId);
        //}

        public ActionResult ChooseAircraft()
        {
            return View("Index");
        }

    }
}