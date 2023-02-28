using Microsoft.AspNetCore.Mvc;

namespace Skote.Customer
{
    public class Customer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
