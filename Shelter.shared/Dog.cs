using System;

namespace Shelter
{
    class Dog : Animals
    {
        // This constructor will call BaseClass.BaseClass()
        public Dog() : base()
        {

        }

        public Dog(int id, string name, string race, DateTime dateOfBirth, bool isChecked, bool kidFriendly, DateTime since) : base(id, name, dateOfBirth, isChecked, kidFriendly, since)
        {

        }
    }
}
