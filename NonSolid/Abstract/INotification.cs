namespace NonSolid.Abstract;

public interface INotification
{
    void Notify();
    //ISP violate
    void WhatsAppApiCreate();
}