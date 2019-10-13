using System;

namespace Shelter
{
    class Cat : Animals
    {
        public Cat() : base()
        {

        }

        public Cat(int id, string name, string race, DateTime dateOfBirth, bool isChecked, bool kidFriendly, DateTime since, bool clawed) : base(id, name, dateOfBirth, isChecked, kidFriendly, since)
        {
            Race = race;
            Clawed = clawed;
        }

        public string Race { get; set; }
        public bool Clawed { get; set; }
    }
}