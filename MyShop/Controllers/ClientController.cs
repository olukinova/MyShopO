using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
