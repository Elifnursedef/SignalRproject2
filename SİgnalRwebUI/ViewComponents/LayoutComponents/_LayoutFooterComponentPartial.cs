using Microsoft.AspNetCore.Mvc;

namespace SİgnalRwebUI.ViewComponents.LayoutComponents
{
    public class _LayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
