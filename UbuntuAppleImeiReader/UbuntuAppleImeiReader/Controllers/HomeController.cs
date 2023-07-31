using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UbuntuAppleImeiReader.Models;

namespace UbuntuAppleImeiReader.Controllers
{
    public class HomeController : Controller
    {
        private PhoneInfo phoneInfo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            phoneInfo = new PhoneInfo();
        }

        public IActionResult Index()
        {

            if(!String.IsNullOrEmpty(phoneInfo.imei) && phoneInfo.imei.Contains("35"))

                return View(phoneInfo);

            else
                return View("Error");
        }




      
    }
}