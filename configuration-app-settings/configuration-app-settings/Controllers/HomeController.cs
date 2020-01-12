using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using configuration_app_settings.Models;
using configuration_app_settings.Configurations;
using Microsoft.Extensions.Options;

namespace configuration_app_settings.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppSettings _appSettings;

        public HomeController(ILogger<HomeController> logger, IOptionsSnapshot<AppSettings> appSettings)
        {
            _logger = logger;
            _appSettings = appSettings.Value;
        }

        public IActionResult Index()
        {
            ViewBag.HeadConfigValue1 = _appSettings.MyHeadConfiguration.HeadConfigValue1;
            ViewBag.HeadConfigValue2 = _appSettings.MyHeadConfiguration.HeadConfigValue2;
            
            ViewBag.SecondLevelConfigValue1 = _appSettings.MyHeadConfiguration
                .MySecondLevelConfig.SecondLevelConfigValue1;
            ViewBag.SecondLevelConfigValue2 = _appSettings.MyHeadConfiguration
                .MySecondLevelConfig.SecondLevelConfigValue2;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
