using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace configuration_app_settings.Configurations
{
    public class MyHeadConfiguration
    {
        public string HeadConfigValue1 { get; set; }
        public bool HeadConfigValue2 { get; set; }
        public MySecondLevelConfig MySecondLevelConfig { get; set; }
    }
}
