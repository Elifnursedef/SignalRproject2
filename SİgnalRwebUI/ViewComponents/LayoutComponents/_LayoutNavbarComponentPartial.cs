﻿using Microsoft.AspNetCore.Mvc;

namespace SİgnalRwebUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
