using System;

namespace Design_Patterns_Assignment
{
    internal class Strategy
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the strategy Pattern
            Console.WriteLine("Strategy");
            MessageHandler mh = new MessageHandler();
            var message = "This is the message";

            IMessage email = new EmailMessager();
            mh.MessageType = email;
            mh.SendMessage(message);

            IMessage facebook = new FacebookMessager();
            mh.MessageType = facebook;
            mh.SendMessage(message);

            IMessage sms = new SMSMessager();
            mh.MessageType = sms;
            mh.SendMessage(message);

            // What i want to happen to happen is
            //
            // Change type of message to send to sms etc.
            // send message            
        }
    }
}