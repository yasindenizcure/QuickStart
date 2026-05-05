using Microsoft.AspNetCore.Mvc;

namespace QuickStartWebUI.ViewComponents
{
    public class _DefaultFooterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
