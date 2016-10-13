using AircraftBalance.BusinessLogic;
using AircraftBalance.Data;
using AircraftBalance.Models;
using AircraftBalance.Services;
using System.Linq;
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
            ViewBag.ZeroFuelCG = _calc.CalculateZeroFuelCG(viewModel, payload);
            ViewBag.TakeOffCG = _calc.CalculateTakeoffCG(viewModel, payload);
            ViewBag.LandingCG = _calc.CalculateLandingCG(viewModel, payload);
            // Now use inputs from viewModel and constants from the object to calculate.  Call calculation methods.
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult GetItems(int? val)
        {
            if (val != null)
            {
                //Values are hard coded for demo. you may replae with values 
                // coming from your db/service based on the passed in value ( val.Value)

                return Json(new { Success = "true", Data = _db.PayloadItems.Where(e => e.AircraftId == val)});
            }
            return Json(new { Success = "false" });
        }
    }
}