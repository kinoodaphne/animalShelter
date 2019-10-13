using System.Globalization;
using System;

namespace Shelter.shared
{
    public class Manager : Employees
    {
        public Manager() : base() {

        }

        public Manager(int id, string firstName, string lastName, DateTime dateOfBirth, DateTime employeedSince, DateTime managerSince) : base(id, firstName, lastName, dateOfBirth, employeedSince) {
            ManagerSince = managerSince;
        }

        public DateTime ManagerSince { get; set; }
    }
}