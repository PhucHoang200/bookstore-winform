using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using static System.Net.WebRequestMethods;

namespace BUS
{
    public class EmailBUS
    {
        public bool SendOtpEmail(string email, string otp)
        {
            try
            {
                
                // Cấu hình SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, // Cổng của Gmail SMTP
                    //Chú ý xóa mật khẩu trước khi copy gửi lên chat
                    Credentials = new NetworkCredential("sbook7107@gmail.com", "kzid tqky kfyi zcyz"), // Thông tin tài khoản email
                    EnableSsl = true // Sử dụng SSL
                };

                // Cấu hình thư
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("sbook7107@gmail.com"), // Địa chỉ gửi
                    Subject = "Đặt lại mật khẩu của bạn", // Tiêu đề email
                    Body = $"Chào bạn,\n\nMã OTP của bạn là: {otp}\n\nVui lòng không chia sẻ mã này với bất kỳ ai.",
                    IsBodyHtml = false // Đặt là false nếu bạn không sử dụng HTML trong email
                };

                mail.To.Add(email); // Địa chỉ người nhận

                // Gửi email
                smtpClient.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Console.WriteLine("Lỗi gửi email: " + ex.Message);
                return false;
            }
        }

        

    }
}
