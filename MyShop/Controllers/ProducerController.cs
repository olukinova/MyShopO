using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers
{
    public class ProducerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
