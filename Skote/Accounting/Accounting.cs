using Microsoft.AspNetCore.Mvc;

namespace Skote.Accounting
{
    public class Accounting : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult OdenenFaturalar()
        {
            return View();
        }
        public IActionResult OdenmeyenFaturalar()
        {
            return View();
        }
        public IActionResult IptalFaturalar()
        {
            return View();
        }
        public IActionResult ResmiFaturalar()
        {
            return View();
        }
        public IActionResult ResmiOlmayanFaturalar()
        {
            return View();
        }
    }
}
