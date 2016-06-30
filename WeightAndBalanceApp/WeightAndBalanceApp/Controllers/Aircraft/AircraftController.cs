using System.Web.Mvc;
using WeightAndBalanceApp.Models;

namespace WeightAndBalanceApp.Controllers.Aircraft
{
    public class AircraftController : Controller
    {
        // GET: Aircraft
        [HttpGet]
        public ActionResult Index()
        {
            var vm = new AircraftViewModel();
            return View(vm);
        }
    }
}