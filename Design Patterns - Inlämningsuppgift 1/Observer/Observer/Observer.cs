using System;

namespace Design_Patterns_Assignment
{
    class Observer
    {
        internal static void Run()
        {
            Console.WriteLine("Observer");

            IEmail email = new EmailMessage();
            IEmailWatcher emailWatcher = new EmailWatcher();
            email.registerObserver(emailWatcher);
            bool observerIsRunning = true;

            Console.WriteLine("Tryck Q för att skicka ut ett mail");
            Console.WriteLine("Tryck W för att påbörja/avsluta prenumeration");
            Console.WriteLine("Tryck E för att avsluta programmet");

            while (observerIsRunning)
            {
                var userInput = Console.ReadKey(true).Key;
                switch (userInput)
                {
                    case ConsoleKey.Q:
                        email.notifyObservers();
                        break;
                    case ConsoleKey.W:
                        if (email.Observers.Contains(emailWatcher))
                        {
                            email.unregisterObserver(emailWatcher);
                            Console.WriteLine("Avprenumererad");
                        }
                        else
                        {
                            email.registerObserver(emailWatcher);
                            Console.WriteLine("Prenumenerad");
                        }
                        break;
                    case ConsoleKey.E:
                        observerIsRunning = false;
                        break;
                }
            }
        }
    }
}