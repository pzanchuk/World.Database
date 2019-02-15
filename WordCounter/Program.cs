using System;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      MyClass newClass = new MyClass();

      Console.WriteLine("========================================");
      Console.WriteLine("======== Welcome to WordCounter ========");
      Console.WriteLine("========================================");

      Console.Write("Please enter a sentence: ");
      string userInputSentense = Console.ReadLine();

      if(newClass.IsInputNotEmpty(userInputSentense) == true){

        Console.Write("Please enter a word you would like to count: ");
        string userInputWord = Console.ReadLine();
        newClass.RepeatCounter(userInputSentense, userInputWord);
        Console.WriteLine("Word [" + userInputWord + "] has been seen here " + newClass.GetCounter() + " time/s.");
        Console.Write("Try one more sentence and word? [Y/N]: ");
        string yesOrNo = Console.ReadLine();
        if(yesOrNo.ToUpper() == "Y")
        {
          Main();
        }
      }else
      {
        Console.WriteLine("Your sentence is empty, please try again");
        Main();
      }
    }
  }
}
