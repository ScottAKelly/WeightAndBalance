using System;
using System.Web.Mvc;
using WeightAndBalanceApp.Models;
using WeightAndBalanceApp.Services;

namespace WeightAndBalanceApp.Controllers.Aircraft
{
    public class AircraftController : Controller
    {
        private readonly Lazy<AircraftService> _svc;

        // GET: Aircraft
        [HttpGet]
        public ActionResult Index()
        {
            var vm = new AircraftViewModel();
            return View(vm);
        }
    }
}