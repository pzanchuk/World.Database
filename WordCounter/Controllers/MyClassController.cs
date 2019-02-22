using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class MyClassController : Controller
  {

    [HttpGet("/newgame")]
    public ActionResult New()
    {
      return View();
    }


  }
}
