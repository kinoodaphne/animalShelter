using System;
using System.Collections.Generic;

namespace Shelter
{
    public class Animals
    {
        public Animals()
        {

        }

        public Animals(int id, string name, DateTime dateOfBirth, bool isChecked, bool kidFriendly, DateTime since)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            IsChecked = isChecked;
            KidFriendly = kidFriendly;
            Since = since;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsChecked { get; set; }
        public bool KidFriendly { get; set; }
        public DateTime Since { get; set; }
        public List<Animals> AnimalList{get; set;}
    }
}
