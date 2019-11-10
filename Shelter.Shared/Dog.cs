using System;

namespace Shelter.Shared
{
    public class Dog : Animal
    {
        public Dog() : base() {

        }

        public Dog(int id, string name, string race, DateTime dateOfBirth, bool isChecked, bool kidFriendly, DateTime since, bool barker) : base(id, name, race, dateOfBirth, isChecked, kidFriendly, since) {
            Barker = barker;
        }
        public bool Barker { get; set; }
    }
}