using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class MyClassTest
  {
    [TestMethod]
    public void IsInputNotEmpty_CheckIfInputNotEmpty_True()
    {
      MyClass newClass = new MyClass();
      Assert.AreEqual(true, newClass.IsInputNotEmpty("I am not empty and strin"));
    }

    [TestMethod]
    public void RepeatCounter_CheckIfMatchNotFound_True()
    {
      MyClass newClass = new MyClass();
      Assert.AreEqual(0, newClass.RepeatCounter("I like sushi", "shoe"));
    }

    [TestMethod]
    public void RepeatCounter_CheckIfSingleMatchFound_True()
    {
      MyClass newClass = new MyClass();
      Assert.AreEqual(1, newClass.RepeatCounter("Today was a nice day.", "was"));
    }

    [TestMethod]
    public void RepeatCounter_CheckIfMultipleMatchesFound_True()
    {
      MyClass newClass = new MyClass();
      Assert.AreEqual(2, newClass.RepeatCounter("I love my cat so much, and my cat loves me back.", "cat"));
    }

    [TestMethod]
    public void RepeatCounter_CheckIfMultipleMatchesFoundAndCaseIgnored_True()
    {
      MyClass newClass = new MyClass();
      Assert.AreEqual(2, newClass.RepeatCounter("Swimming whale is like swimming submarine ", "swimming"));
    }

    [TestMethod]
    public void RepeatCounter_CheckIfMultipleMatchesFoundCaseAndPunctuationalMarksIgnored_True()
    {
      MyClass newClass = new MyClass();
      Assert.AreEqual(3, newClass.RepeatCounter("Some flowers smell like ,some? grosserie in .some! store.", "Some"));
    }

    [TestMethod]
    public void GetCounter_CheckIfResulInt_True()
    {
      MyClass newClass = new MyClass();
      newClass.RepeatCounter("Result is equalse to one + one + one + one + one.", "one");
      Assert.AreEqual(5, newClass.GetCounter());
    }
  }
}
