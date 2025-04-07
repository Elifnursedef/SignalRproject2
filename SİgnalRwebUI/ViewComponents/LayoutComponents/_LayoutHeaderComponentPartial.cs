using Microsoft.AspNetCore.Mvc;

namespace SignalRwebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
