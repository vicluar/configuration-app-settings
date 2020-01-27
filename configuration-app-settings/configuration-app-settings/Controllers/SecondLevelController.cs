using configuration_app_settings.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace configuration_app_settings.Controllers
{
    public class SecondLevelController : Controller
    {
        private readonly MySecondLevelConfig _mySecondLevelConfig;

        public SecondLevelController(IOptionsSnapshot<MySecondLevelConfig> mySecondLevelConfig)
        {
            _mySecondLevelConfig = mySecondLevelConfig.Value;
        }

        public IActionResult HelloSecondLevel()
        {
            ViewBag.SecondLevelConfigValue1 = _mySecondLevelConfig.SecondLevelConfigValue1;
            ViewBag.SecondLevelConfigValue2 = _mySecondLevelConfig.SecondLevelConfigValue2;

            return View();
        }
    }
}
