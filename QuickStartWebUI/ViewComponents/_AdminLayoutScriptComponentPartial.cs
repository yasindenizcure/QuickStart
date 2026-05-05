using Microsoft.AspNetCore.Mvc;

namespace QuickStartWebUI.ViewComponents
{
    public class _AdminLayoutScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
