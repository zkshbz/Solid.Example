using System.Net;
using System.Net.Mail;

namespace Solid.NotificationHelper;

public static class MailHelper
{
    public static SmtpClient CreateClint()
    {
        var client = new SmtpClient("smtp-mail.outlook.com", 587);
        client.UseDefaultCredentials = false;
        client.Credentials = new NetworkCredential("mailAdress", "mailPassword");

        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.EnableSsl = true;

        return client;
    }

    public static MailMessage CreateMessage()
    {
        var from = new MailAddress("zekidev@outlook.com","test-mail");
        var to = new MailAddress("zekisahbaz@outlook.com");
        var message = new MailMessage(from,to);

        return message;
    }
}