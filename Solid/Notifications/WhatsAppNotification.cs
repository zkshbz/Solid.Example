using Solid.Abstract;
using Solid.BaseClasses;

namespace Solid.Notifications;

public class WhatsAppNotification : OtherNotificationTypeBaseClass, INotification
{
    public WhatsAppNotification(string _message)
    {
        message = _message;
    }
}