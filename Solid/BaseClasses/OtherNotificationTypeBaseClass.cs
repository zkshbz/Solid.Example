namespace Solid.BaseClasses;

public class OtherNotificationTypeBaseClass
{
    public string message { get; set; }

    public void Notify()
    {
        Console.WriteLine(message);
    }
}