using Microsoft.AspNetCore.Mvc;

namespace MarketCRUDProduct.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
