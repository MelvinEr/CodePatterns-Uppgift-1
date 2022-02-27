using System;

namespace Design_Patterns_Assignment
{
    public class SMSMessager : IMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a sms");
        }
    }
}