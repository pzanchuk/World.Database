using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class MyClassTest
  {
    [TestMethod]
    public void isInputNotEmpty_CheckIfNotEmptyAndLegal_True()
    {
      MyClass newClass = new MyClass();
      Assert.AreEqual(true, newClass.isInputNotEmptyAndLegal("I am not empty and string"));
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
  }
}
