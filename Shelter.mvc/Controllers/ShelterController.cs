namespace Shelter.mvc.Controllers
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shelter.MVC.Models;
using Shelter.Shared;
using System.Linq;

namespace Shelter.MVC.Controllers
{
  public class ShelterController : Controller
  {
    private readonly ILogger<ShelterController> _logger;

    public ShelterController(ILogger<ShelterController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View(AnimalDatabase.Animals);
    }

    public IActionResult Detail(int id)
    {
      var targetAnimal = ShelterDatabase.Animals.Animals.FirstOrDefault(x => x.Id == id);
      if (targetAnimal == default(Animals))
      {
        return NotFound();
      }
      return View(targetAnimal);
    }

    public IActionResult Delete(int id)
    {
      var targetBeer = BeerDatabase.Brewery.Beers.FirstOrDefault(x => x.Id == id);
      if (targetBeer == default(Beer))
      {
        return NotFound();
      }
      return View(targetBeer);
    }

    [HttpPost]
    public IActionResult DoDelete(int id)
    {
      var targetBeer = BeerDatabase.Brewery.Beers.FirstOrDefault(x => x.Id == id);
      if (targetBeer == default(Beer))
      {
        return NotFound();
      }
      BeerDatabase.Brewery.Beers.Remove(targetBeer);
      return RedirectToAction(nameof(Index));

    }
  }
}