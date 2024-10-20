

namespace ECommerce.Application.Abstraction.Service
{
    public interface IEmailService
    {
        Task SendMailAsync(string[] tos, string subject, string body, bool bodyHtml = true);
        Task SendMailAsync(string to, string subject, string body, bool bodyHtml = true);
    }
}
