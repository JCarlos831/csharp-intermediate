using System;
using System.Net.Mail;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotifiactionChannel());
            encoder.RegisterNotificationChannel(new SmsNotifiactionChannel());
            encoder.Encode(new Video());
        }
    }
}