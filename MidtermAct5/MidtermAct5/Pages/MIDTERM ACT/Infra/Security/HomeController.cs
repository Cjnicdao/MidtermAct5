using Microsoft.AspNetCore.Mvc;

namespace MidtermAct5.Pages.MIDTERM_ACT.Infra.Security
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
