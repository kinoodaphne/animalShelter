using System;

namespace Shelter.Shared
{
    public class Dog : Animal
    {
        public Dog() : base() {

        }

        public Dog(int id, string name, string race, DateTime dateOfBirth, bool isChecked, bool kidFriendly, DateTime since, bool barker) : base(id, name, dateOfBirth, isChecked, kidFriendly, since) {
            Race = race;
            Barker = barker;
        }

        public string Race { get; set; }
        public bool Barker { get; set; }
    }
}