using Microsoft.AspNetCore.Mvc;
using World.Models;
using System.Collections.Generic;


namespace World.Controllers
{
    public class CityController : Controller
    {

      [HttpGet("/search")]
      public ActionResult Search()
      {

        return View();
      }

      [HttpPost("/result2")]
      public ActionResult Result2(string name)
      {
        List<City> myCity = City.GetAll(name);

        return View(myCity);
      }

    }
}
