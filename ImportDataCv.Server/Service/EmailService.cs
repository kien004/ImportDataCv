using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using ImportDataCv.Server.ModelMails;
using MailKit.Net.Smtp;


namespace ImportDataCv.Server.Service
{
    public class EmailService 
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string recipientEmail, string subject, string message)
        {
            var smtpSettings = _configuration.GetSection("SmtpSettings");

            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(smtpSettings["SenderName"], smtpSettings["SenderEmail"]));
            email.To.Add(new MailboxAddress(recipientEmail, recipientEmail));
            email.Subject = subject;

            var bodyBuilder = new BodyBuilder { HtmlBody = message };
            email.Body = bodyBuilder.ToMessageBody();

            using var smtp = new SmtpClient();
            try
            {
                // Kết nối tới máy chủ SMTP với STARTTLS trên port 587
                await smtp.ConnectAsync(smtpSettings["Server"], 587, SecureSocketOptions.StartTls);

                // Xác thực tài khoản
                await smtp.AuthenticateAsync(smtpSettings["Username"], smtpSettings["Password"]);

                // Gửi email
                await smtp.SendAsync(email);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Email sending failed: {ex.Message}");
            }
            finally
            {
                await smtp.DisconnectAsync(true);
            }
        }
    } 
}
