using System;

namespace Design_Patterns_Assignment
{
    public class EmailMessager : IMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as an email");
        }
    }
}