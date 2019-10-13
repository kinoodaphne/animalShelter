using System;

namespace Shelter
{
    class Other : Animals
    {
        public Other() : base()
        {

        }

        public Other(int id, string name, string description, DateTime dateOfBirth, bool isChecked, bool kidFriendly, DateTime since, string kind) : base(id, name, dateOfBirth, isChecked, kidFriendly, since)
        {
            Description = description;
            Kind = kind;
        }

        public string Description { get; set; }
        public string Kind { get; set; }
    }
}
