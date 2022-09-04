namespace NonSolid.BaseClasses;

public class NotificationBase
{
    public string messsage { get; set; }
    
    //LSP violate
    public void Notify()
    {
        Console.WriteLine(messsage);
    }
}