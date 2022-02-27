namespace Design_Patterns_Assignment
{
    class DataRepository : IDataRepository
    {
        public string Load(string text)
        {
            return SimulatedDatabase.Load(text);
        }

        public void Save(string text)
        {
            SimulatedDatabase.Save(text);
        }
    }
}