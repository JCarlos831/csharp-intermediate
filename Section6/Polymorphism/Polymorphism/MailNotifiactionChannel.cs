using System;

namespace Polymorphism
{
    public class MailNotifiactionChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}