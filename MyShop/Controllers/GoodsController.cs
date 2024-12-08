using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers
{
    public class GoodsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
