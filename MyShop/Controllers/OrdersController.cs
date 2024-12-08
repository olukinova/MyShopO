using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
