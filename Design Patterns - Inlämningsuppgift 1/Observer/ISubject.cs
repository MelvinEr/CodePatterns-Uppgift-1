using System.Collections.Generic;

namespace Design_Patterns_Assignment
{
    public interface ISubject
    {
        List<IObserver> Observers { get; set; }
        void registerObserver(IObserver observer);
        void unregisterObserver(IObserver observer);
        void notifyObservers();
    }
}