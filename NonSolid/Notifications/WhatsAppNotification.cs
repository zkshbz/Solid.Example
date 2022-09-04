using NonSolid.Abstract;
using NonSolid.BaseClasses;

namespace NonSolid.Notifications;

public class WhatsAppNotification : NotificationBase, INotification
{
    public WhatsAppNotification(string _message)
    {
        messsage = _message;
    }


    public void WhatsAppApiCreate()
    {
        Console.WriteLine("whats app api created");
    }
}