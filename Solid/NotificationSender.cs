using Solid.Abstract;
using Solid.Notifications;

namespace Solid;

public static class NotificationSender
{
    public static void Notify(INotification notification)
    {
       notification.Notify();
    }
}