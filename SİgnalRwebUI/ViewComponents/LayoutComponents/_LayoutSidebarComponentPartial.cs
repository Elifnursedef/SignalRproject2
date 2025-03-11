using Microsoft.AspNetCore.Mvc;

namespace SİgnalRwebUI.ViewComponents.LayoutComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        
    }
}
