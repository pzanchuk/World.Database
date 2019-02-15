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
  }
}
