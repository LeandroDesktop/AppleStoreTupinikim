using Microsoft.AspNetCore.Mvc;

namespace AppStoreTupinikim.Controllers
{
    public class Produto : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
