using System;

namespace WordCounter
{
  public class MyClass
  {
    private int counter = 0;

    public int GetCounter()
    {
      return counter;
    }

    public bool IsInputNotEmpty(string userInput)
    {
      if(String.IsNullOrEmpty(userInput))
      {
        return false ;
      }
      else
      {
        return true;
      }
    }

    public int RepeatCounter(string userInputSentense, string userInputWord)
    {
      string[] sentenceToArray = new string[]{" "};
      sentenceToArray = userInputSentense.Split(' ');
      foreach(string element in sentenceToArray)
      {
        if(element.Trim(',','.','?','!','(').ToUpper() == userInputWord.ToUpper())
        {
          counter++;
        }
      }
      if(counter == 0){
         return 0;
      }
      return counter;
    }

  }
}
