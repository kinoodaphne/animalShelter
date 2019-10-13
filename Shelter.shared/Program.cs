using System;

namespace Shelter.shared
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our animal shelter!");

            Cat cat1 = new Cat(1, "Jef", "Tabby", new DateTime(2009, 12, 06), true, true, new DateTime(2019, 10, 13), false);
            Console.WriteLine(cat1.Name);
            Console.WriteLine("Declawed? " + cat1.Declawed);
            Console.WriteLine("---");

            Dog dog1 = new Dog(1, "Sia", "Shitzu", new DateTime(2019, 09, 09), true, true, new DateTime(2019, 10, 13), false);
            Console.WriteLine(dog1.Name);
            Console.WriteLine("Race? " + dog1.Race);
            Console.WriteLine("---");

            Other hamster1 = new Other(1, "Hammy", "This is a hamster", new DateTime(2017, 05, 19), true, true, new DateTime(2019, 10, 13), "Gerbil");
            Console.WriteLine(hamster1.Name);
            Console.WriteLine("Description? " + hamster1.Description);
            Console.WriteLine("---");

            Manager manager1 = new Manager(1, "John", "Mayer", new DateTime(1967, 10, 23), new DateTime(2016, 10, 13), new DateTime(2017, 01, 27));
            Console.WriteLine(manager1.FirstName);
            Console.WriteLine("Manager since? " + manager1.ManagerSince);
            Console.WriteLine("---");

            Caretaker caretaker1 = new Caretaker(1, "Eddie", "Mayne", new DateTime(1967, 10, 23), new DateTime(2016, 10, 13), true);
            Console.WriteLine(caretaker1.FirstName);
            Console.WriteLine("Has multiple animals? " + caretaker1.HasMultipleAnimals);
            Console.WriteLine("---");

            Administrator administrator1 = new Administrator(1, "Charlotte", "Dawne", new DateTime(1967, 10, 23), new DateTime(2016, 10, 13), new DateTime(2017, 01, 27));
            Console.WriteLine(administrator1.FirstName);
            Console.WriteLine("Administrator since? " + administrator1.AdministratorSince);
            Console.WriteLine("---");
        }
    }
}
