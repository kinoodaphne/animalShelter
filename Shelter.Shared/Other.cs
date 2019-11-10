using System;

namespace Shelter.Shared
{
    public class Other : Animal
    {
        public Other() : base() {

        }

        public Other(int id, string name, string race, string description, DateTime dateOfBirth, bool isChecked, bool kidFriendly, DateTime since) : base(id, name, race, dateOfBirth, isChecked, kidFriendly, since) {
            Description = description;
        }
        public string Description { get; set; }
    }
}