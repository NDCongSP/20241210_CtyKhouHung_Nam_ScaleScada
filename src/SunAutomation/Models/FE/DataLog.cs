using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunAutomation
{
    [Table("DataLog")]
    public class DataLog
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(100)]
        public string Code { get; set; }
        public double Weight { get; set; }
        public double TotalWeight { get; set; }
        public int Count { get; set; }  
    }
}
