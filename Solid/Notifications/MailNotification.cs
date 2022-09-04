using System.Net;
using System.Net.Mail;
using Solid.Abstract;
using Solid.BaseClasses;
using Solid.Extensions;
using Solid.NotificationHelper;

namespace Solid.Notifications;

public class MailNotification : MailNotificationBaseClass, INotification
{
    public MailNotification(string bodyMessage)
    {
        BodyMessage = bodyMessage;
    }
    public void Notify()
    {
        var client = MailHelper.CreateClint();
        var message = MailHelper.CreateMessage();
        message.SetBody(BodyMessage);

        client.Send(message);
    }
}