using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q3_Interface
{
    internal class EmailNotificationService : INotificationService
    {
        public string Message { get; set; }
        public string Recipient { get; set; }

        public void SendNotification(string Message, string Recipient)
        {
            Console.WriteLine($"Sending email to {Recipient}.");
            Console.WriteLine($"Message: {Message}");
        }
    }
}
