using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;
namespace JSShopping.Helper
{
    public class EmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string templatePath, Dictionary<string, string> placeholders)
        {
            string body = File.ReadAllText(templatePath);

            // Replace placeholders (e.g., {{UserName}}, {{ShopLink}})
            foreach (var placeholder in placeholders)
            {
                body = body.Replace("{{" + placeholder.Key + "}}", placeholder.Value);
            }

            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("MSDEVBUILD Shop", _config["EmailSettings:SenderEmail"]));
            email.To.Add(new MailboxAddress("", toEmail));
            email.Subject = subject;

            var bodyBuilder = new BodyBuilder { HtmlBody = body };
            email.Body = bodyBuilder.ToMessageBody();

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_config["EmailSettings:SMTPServer"], int.Parse(_config["EmailSettings:SMTPPort"]), SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_config["EmailSettings:SenderEmail"], _config["EmailSettings:SenderPassword"]);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }


        public async Task EmailAsync(string toEmail, string subject, string content)
        {
           

           

            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("JSQUARE Shop", "nithya4050siva@gmail.com"));
            email.To.Add(new MailboxAddress("", toEmail));
            email.Subject = subject;
            var bodyBuilder = new BodyBuilder { TextBody=content };
            email.Body = bodyBuilder.ToMessageBody();

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync("nithya4050siva@gmail.com", "umwb djfw oifi gmor");
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}
