using Microsoft.AspNetCore.Mvc;

namespace SignalRwebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
