using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class MyClassController : Controller
  {

    [HttpGet("/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/result")]
    public ActionResult Result(string sentence, string word)
    {
      MyClass newClass = new MyClass();

      newClass.RepeatCounter(sentence, word);

      return View(newClass);
    }
  }
}
