using System.Globalization;
using System;

namespace Shelter.shared
{
    public class Caretaker : Employees
    {
        public Caretaker() : base() {

        }

        public Caretaker(int id, string firstName, string lastName, DateTime dateOfBirth, DateTime employeedSince, bool hasMultipleAnimals) : base(id, firstName, lastName, dateOfBirth, employeedSince) {
            HasMultipleAnimals = hasMultipleAnimals;
        }

        public bool HasMultipleAnimals { get; set; }
    }
}