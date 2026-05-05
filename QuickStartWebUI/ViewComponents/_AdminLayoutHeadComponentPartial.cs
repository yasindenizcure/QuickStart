using Microsoft.AspNetCore.Mvc;

namespace QuickStartWebUI.ViewComponents
{
    public class _AdminLayoutHeadComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}