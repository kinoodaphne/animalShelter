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
        }
    }
}
