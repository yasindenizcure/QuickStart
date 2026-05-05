using Microsoft.AspNetCore.Mvc;

namespace QuickStartWebUI.ViewComponents
{
    public class _DefaultMessageComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}