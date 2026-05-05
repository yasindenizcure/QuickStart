using Microsoft.AspNetCore.Mvc;

namespace QuickStartWebUI.ViewComponents
{
    public class _DefaultHeadComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
