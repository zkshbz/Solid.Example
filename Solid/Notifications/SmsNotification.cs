using Solid.Abstract;
using Solid.BaseClasses;

namespace Solid.Notifications;

public class SmsNotification : OtherNotificationTypeBaseClass, INotification
{
    public SmsNotification(string _message)
    {
        message = _message;
    }
}