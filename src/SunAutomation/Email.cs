using System;
using System.Net.Mail;
using System.Diagnostics;
using System.Net;

namespace SunAutomation
{
    public class Email
    {
        // 1. Thông tin tài khoản Gmail của bạn
        public string SenderEmail = "your_email@gmail.com";
        public string SenderPassword = "your_password"; // Hoặc mật khẩu ứng dụng

        // 2. Thông tin email người nhận
        public string RecipientEmail = "recipient_email@example.com";
        public string Subject = "DỮ LIỆU CÂN";
        public string Body = "Báo cáo";
        // Đường dẫn file attachment.
        public string AttachmentPath { get; set; }

        /// <summary>
        /// Gui email.
        /// </summary>
        public bool SendEmail()
        {
            try
            {
                // 3. Cấu hình nội dung email
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(SenderEmail); // Người gửi
                mail.To.Add(RecipientEmail);             // Người nhận
                mail.Subject = Subject; // Tiêu đề
                mail.Body = Body; // Nội dung
                mail.IsBodyHtml = false; // Nếu muốn gửi HTML, đổi thành true
                // 4. Thêm file đính kèm
                   
                Attachment attachment = new Attachment(AttachmentPath);
                mail.Attachments.Add(attachment);

                // 5. Cấu hình SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(SenderEmail, SenderPassword);
                smtp.EnableSsl = true; // Gmail yêu cầu SSL

                // 6. Gửi email
                smtp.Send(mail);

                Console.WriteLine("Email sent successfully!");
                mail.Dispose();
                smtp.Dispose();
                return true;

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in sendEmail:" + ex.Message);
                return false;
            }
        }
    }
}
