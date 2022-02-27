using System;

namespace Design_Patterns_Assignment
{
    public class FacebookMessager : IMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a facebookmessage");
        }
    }
}