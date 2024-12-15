using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunAutomation
{
    public static class GlobalVariable
    {
        public static ConfigSetting MyConfig { get; set; } = new ConfigSetting();
        public static SettingsModel SettingConfig { get; set; } = new SettingsModel();
        public static Email EmailCenter { get; set; } = new Email();
    }
}
