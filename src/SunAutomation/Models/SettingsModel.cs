using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunAutomation
{
    public class SettingsModel
    {
        /// <summary>
        /// Danh sách các email nhận báo cáo tự động.
        /// nhiều email, thì cách nhau bởi dấu ,.
        /// </summary>
        //public List<EmailAddress> Emails { get; set; }
        public string RecipientEmail { get; set; }
        /// <summary>
        /// Thời gian ghi giá trị kiểm để báo trạng thái connect cho PLC biết.
        /// </summary>
        public int CheckConnectInterval { get; set; }
        //cấu hình cho email.
        public string SenderEmail { get; set; }
        public string SenderPassword { get; set; }
        public string EmailSubject { get; set; }
        public string AttachmentPath { get; set; }
    }

    public class EmailAddress
    {
        public string Email { get; set; }
    }
}
