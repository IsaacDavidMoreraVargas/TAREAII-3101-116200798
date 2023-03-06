using Microsoft.AspNetCore.Mvc;

namespace WebApplication_TareaII_MVC.Controllers.Actions
{
    public class ActionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
