using Microsoft.AspNetCore.Mvc;

namespace SignalRwebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
