using Design_Patterns_Assignment;

using System;

namespace Design_Patterns_Assignment
{
    internal class Repository
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Repository Pattern

            IDataRepository repository = new DataRepository();
            Console.WriteLine("Repository");
            var data = repository.Load("Dataset A");
            var customer = repository.Load("From Table Customer Where Name==Steve"); // this is a search
            var animal = repository.Load("From Table Animal Where Owner==Steve"); // this is a search
            repository.Save(data);
            repository.Save(customer);
            repository.Save(animal);
        }
    }
}