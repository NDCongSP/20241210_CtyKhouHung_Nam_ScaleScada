using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    [Table("ConfigSettings")]
    public class ConfigSettings
    {
        [Key]
        public Guid Id { get; set; }
        public string ConfigModel { get; set; }
    }
}
