using Microsoft.AspNetCore.Mvc;

namespace SİgnalRwebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
