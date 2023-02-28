using Microsoft.AspNetCore.Mvc;

namespace Skote.Orders
{
    public class Order : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult AktifSiparisler()
        {
            return View();
        }
        public IActionResult IslemdekiSiparisler()
        {
            return View();
        }
        public IActionResult AskıyaAlınanSiparisler()
        {
            return View();
        }
        public IActionResult IptalEdilenSiparisler()
        {
            return View();
        }
    }
}
