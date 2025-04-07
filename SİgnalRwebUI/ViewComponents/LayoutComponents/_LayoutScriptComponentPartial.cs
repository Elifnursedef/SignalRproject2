using Microsoft.AspNetCore.Mvc;

namespace SignalRwebUI.ViewComponents.LayoutComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
