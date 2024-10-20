
using ECommerce.Application.Abstraction.Service;
using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Net;

namespace ECommerce.Infrastructure.Service
{
    public  class EmailService:IEmailService
    {
        private readonly IConfiguration _config;
        public EmailService(IConfiguration config)
        {
            _config = config;
        }




        public async Task SendMailAsync(string[] tos, string subject, string body, bool bodyHtml = true)
        {
            SmtpClient client = new SmtpClient();
            client.Host = _config["MailSetting:host"];
            client.Port = Convert.ToInt32(_config["MailSetting:port"]);

            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(_config["MailSetting:from"], _config["MailSetting:fromPassword"]);
            client.EnableSsl = true;

            //mail message
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(_config["MailSetting:from"]);
            foreach (var to in tos)
                mailMessage.To.Add(to);

            mailMessage.IsBodyHtml = bodyHtml;
            mailMessage.Body = body;
            mailMessage.Subject = subject;
            await client.SendMailAsync(mailMessage);

        }


        public async Task SendMailAsync(string to, string subject, string body, bool bodyHtml = true)
        {
            SmtpClient client = new SmtpClient();
            client.Host = _config["MailSetting:host"];
            client.Port = Convert.ToInt32(_config["MailSetting:port"]);

            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(_config["MailSetting:from"], _config["MailSetting:fromPassword"]);
            client.EnableSsl = true;

            //mail message
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(_config["MailSetting:from"]);
            mailMessage.To.Add(to);
            mailMessage.IsBodyHtml = bodyHtml;
            mailMessage.Body = body;
            mailMessage.Subject = subject;
            await client.SendMailAsync(mailMessage);

        }




    }
}
