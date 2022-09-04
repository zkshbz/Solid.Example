namespace NonSolid.BaseClasses;

public class NotificationBase
{
    public string messsage { get; set; }
    
    public void Notify()
    {
        Console.WriteLine(messsage);
    }
}