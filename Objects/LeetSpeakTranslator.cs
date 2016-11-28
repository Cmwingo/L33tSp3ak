using System;
using System.Collections.Generic;

namespace LeetSpeak.Objects
{
  public class LeetSpeakTranslator
  {
    public string Translate(string input)
    {
      string preTranslation = input.Replace('e', '3').Replace('E', '3').Replace('o', '0').Replace('O', '0').Replace('I', '1');
      string [] inputWords = preTranslation.Split(' ');
      List<string> outputWords = new List<string> {};
      foreach (var word in inputWords)
      {
        if(word.StartsWith("s") || word.StartsWith("S"))
        {
          outputWords.Add(word);
        }
        else
        {
          outputWords.Add(word.Replace('s', 'z').Replace('S', 'Z'));
        }
      }
      string translation = String.Join(" ", outputWords);
      return translation;
    }
  }
}
