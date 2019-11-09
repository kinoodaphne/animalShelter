using System;
using System.Collections.Generic;
using Shelter.MVC.Models;
using Shelter.Shared;

namespace Shelter.MVC.Models
{
  public class AnimalDatabase
  {
    private static bool _isInitialized = false;
    private static Shelter.Shared.Shelter _shelter = null;

    private static void Initialize()
    {
      if (!_isInitialized)
      {
        var shelter = new Shelter.Shared.Shelter()
        {
          Animals = new List<Animal> {
            new Dog(1, "Sia", "Shitzu", new DateTime(2019, 09, 09), true, true, new DateTime(2019, 10, 13), false),
            new Cat(2, "Jef", "Tabby", new DateTime(2009, 12, 06), true, true, new DateTime(2019, 10, 13), false),
            new Other(3, "Hammy", "Gerbil", "This is a hamster", new DateTime(2017, 05, 19), true, true, new DateTime(2019, 10, 13)),
            }
        };

        _shelter = shelter;
        _isInitialized = true;
      }
    }

    public static Shared.Shelter Shelter
    {
      get
      {
        Initialize();
        return _shelter;
      }
    }
  }
}