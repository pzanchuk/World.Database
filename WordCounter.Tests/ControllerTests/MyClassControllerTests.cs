using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class MyClassControllerTest
    {

      [TestMethod]
      public void New_ReturnsCorrectView_True()
      {
        MyClassController controller = new MyClassController();
        ActionResult newView = controller.New();
        Assert.IsInstanceOfType(newView, typeof(ViewResult));
      }

      [TestMethod]
      public void Result_ReturnsCorrectView_True()
      {
        MyClassController controller = new MyClassController();
        ActionResult resultView = controller.New();
        Assert.IsInstanceOfType(resultView, typeof(ViewResult));
      }

      [TestMethod]
      public void Result_PassesCorrectModelType_objectList()
      {

        MyClassController controller = new MyClassController();
        ViewResult resultView = controller.Result("a", "b") as ViewResult;
        var result = resultView.ViewData.Model;
        Assert.IsInstanceOfType(result, typeof(List<object>));
      }

    }
}
