using Microsoft.AspNetCore.Mvc;

namespace SignalRwebUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
