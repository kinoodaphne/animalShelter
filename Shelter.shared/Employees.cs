using System;
namespace Shelter.shared
{
    public class Employees
    {
        public Employees() {

        }

        public Employees(int id, string firstName, string lastName, DateTime dateOfBirth, DateTime employeedSince) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            EmployeedSince = employeedSince;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime EmployeedSince { get; set; }

    }
}