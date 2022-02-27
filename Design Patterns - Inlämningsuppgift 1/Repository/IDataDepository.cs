namespace Design_Patterns_Assignment
{
    public interface IDataRepository
    {
        string Load(string text);
        void Save(string text);
    }
}