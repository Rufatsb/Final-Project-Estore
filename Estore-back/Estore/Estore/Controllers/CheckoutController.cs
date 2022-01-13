using Microsoft.AspNetCore.Mvc;

namespace Estore.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
