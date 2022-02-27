using System.Collections.Generic;

namespace Design_Patterns_Assignment
{
    internal class EmailMessage : IEmail
    {
        public List<IObserver> Observers { get; set; }

        public EmailMessage()
        {
            Observers = new();
        }

        public void registerObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void unregisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update("this is the email");
            }
        }
    }
}