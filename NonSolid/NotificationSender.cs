using NonSolid.BaseClasses;
using NonSolid.Notifications;

namespace NonSolid;

public static class NotificationSender
{
    //if statements OCP violate
    //creating object with new DIP violate
    public static void Notify(int notificationType)
    {
        if (notificationType == 1)
        {
            var mailNotification = new MailNotification();
            mailNotification.Notify();
        }
        else if (notificationType == 2)
        {
            var whatsApp = new WhatsAppNotification("whats app notification");
            
            whatsApp.Notify();
        }
        else
        {
            var smsNotification = new SmsNotification("sms notification");
            smsNotification.Notify();
        }
    }
}