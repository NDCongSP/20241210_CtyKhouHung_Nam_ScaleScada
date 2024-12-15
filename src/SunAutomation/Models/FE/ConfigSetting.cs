using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunAutomation
{
    [Table("ConfigSettings")]
    public class ConfigSetting
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Serialize json from settingsMode.
        /// </summary>
        public string ConfingModel { get; set; }
    }
}
