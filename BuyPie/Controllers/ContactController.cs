using Microsoft.AspNetCore.Mvc;

namespace BuyPie.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
