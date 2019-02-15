using System;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("==================Welcome to WordCounter==================");
      Console.Write("Please enter a sentence: ");
      string userInputSentense = Console.ReadLine();
      Console.Write("Please enter a word you would like to count: ");
      string userInputWord = Console.ReadLine();

      MyClass newClass = new MyClass();
      newClass.RepeatCounter(userInputSentense, userInputWord);
      
    }
  }
}
