using System.Net.Mail;

namespace Solid.Extensions;

public static class MailMessageExtensions
{
    public static void SetBody(this MailMessage mailMessage, string message)
    {
        mailMessage.Body = message;
    }
}