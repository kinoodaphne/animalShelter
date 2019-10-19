using System.Collections.Generic;
using Shelter;

namespace Shelter.mcv.Models
{
    public class AnimalDatabase
    {
        private static bool _isInitialized = false;
        private static IEnumerable<AnimalType> _animalTypes = null;
        private static Shelter.Animals _animals = null;

        private static void Initialize() {
            if (!_isInitialized) {
                var dog = new AnimalType { Name = "hond" };
                var cat = new AnimalType { Name = "kat" };
                var other = new AnimalType { Name = "andere" };
                /*var animals = new Shelter.Animals() {
                    animal = new List<Animals> {
                        new animals { Name = "Gouden Carolus Classic", BeerType = darkSpecial, Id = 1 },
                        new animals { Name = "Gouden Carolus Tripel", BeerType = tripel, Id = 2 },
                        new animals { Name = "Gouden Carolus Tripel Versie II", BeerType = tripel, Id = 3 },
                    }
                };*/

                /*_animalTypes = new[] { darkSpecial, tripel, amberspecial };
                _animals = animals;
                _isInitialized = true;*/
            }
        }

        public static Animals Animals {
            get {
                Initialize();
                return _animals;
            }
        }

        public static IEnumerable<AnimalType> AnimalTypes {
            get {
                Initialize();
                return _animalTypes;
            }
        }
    }
}