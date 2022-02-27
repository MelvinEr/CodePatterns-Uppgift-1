namespace Design_Patterns_Assignment
{
    public interface IEmail : ISubject
    {
        new void notifyObservers();
    }
}