using System.Net;
using System.Net.Mail;
using NonSolid.Abstract;
using NonSolid.BaseClasses;

namespace NonSolid.Notifications;

public class MailNotification : NotificationBase, INotification
{
    //new keyword LSP violate
    //creating client, creating message, setting body message SRP violate 
    public new void Notify()
    {
        var client = new SmtpClient("smtp-mail.outlook.com", 587);
        client.UseDefaultCredentials = false;
        client.Credentials = new NetworkCredential("mailAddress", "mailPassword");

        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.EnableSsl = true;

        var from = new MailAddress("zekidev@outlook.com","test-mail");
        var to = new MailAddress("zekisahbaz@outlook.com");
        var message = new MailMessage(from,to);
        message.Body = "this is a test mail";

        client.Send(message);
    }

    //unnecessary coding ISP violate
    public void WhatsAppApiCreate()
    {
        throw new NotImplementedException();
    }
}