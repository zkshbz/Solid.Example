using NonSolid.Abstract;
using NonSolid.BaseClasses;

namespace NonSolid.Notifications;

public class SmsNotification : NotificationBase, INotification
{
    public SmsNotification(string _message)
    {
        messsage = _message;
    }


    public void WhatsAppApiCreate()
    {
        throw new NotImplementedException();
    }
}