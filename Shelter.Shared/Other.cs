using System;

namespace Shelter.Shared
{
    public class Other : Animal
    {
        public Other() : base() {

        }

        public Other(int id, string name, string kind, string description, DateTime dateOfBirth, bool isChecked, bool kidFriendly, DateTime since) : base(id, name, dateOfBirth, isChecked, kidFriendly, since) {
            Kind = kind;
            Description = description;
        }

        public string Kind { get; set; }
        public string Description { get; set; }
    }
}