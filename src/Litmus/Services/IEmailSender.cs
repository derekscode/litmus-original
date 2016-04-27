using System.Threading.Tasks;

namespace Litmus.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
