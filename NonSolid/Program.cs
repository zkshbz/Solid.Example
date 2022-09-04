// See https://aka.ms/new-console-template for more information

using NonSolid;

Console.WriteLine("notification start");

var notificationType = 2;

NotificationSender.Notify(notificationType);



Console.WriteLine("notification end");
Console.ReadLine();

