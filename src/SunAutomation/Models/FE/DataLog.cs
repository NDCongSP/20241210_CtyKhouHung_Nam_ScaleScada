using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Browsable(false)]
        public Guid Id { get; set; }
        [DisplayName("Ngày Giờ Cân")]
        public DateTime CreatedDate { get; set; }
        [MaxLength(100)]
        [DisplayName("Mã Hàng")]
        public string Code { get; set; }
        [DisplayName("Khối Lượng (kg)")]
        public double Weight { get; set; }
        [DisplayName("Tổng Khối Lượng (kg)")]
        public double TotalWeight { get; set; }
        [DisplayName("Bộ Đếm")]
        public int Count { get; set; }  
    }
}
