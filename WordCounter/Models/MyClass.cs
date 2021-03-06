using System;

namespace WordCounter.Models
{
  public class MyClass
  {
    private int counter = 0;

    public int GetCounter()
    {
      if (counter.GetType() == typeof(int) ) {
        return counter;
      }else
      {
        return 0;
      }
    }

    public bool IsInputNotEmpty(string userInput)
    {
      if(String.IsNullOrEmpty(userInput) || userInput.GetType() != typeof(string))
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
        if(element.Trim(',','.','?','!').ToUpper() == userInputWord.ToUpper())
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
