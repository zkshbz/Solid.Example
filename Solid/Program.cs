// See https://aka.ms/new-console-template for more information

using Solid;
using Solid.Notifications;

Console.WriteLine("notification start");

var mailNotification = new MailNotification("mail notification");
NotificationSender.Notify(mailNotification);

Console.WriteLine("notification end");
Console.ReadLine();