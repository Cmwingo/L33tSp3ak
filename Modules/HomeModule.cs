using Nancy;
using System;
using System.Collections.Generic;
using LeetSpeak.Objects;

namespace LeetSpeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/translate"] = _ => {
        LeetSpeakTranslator translator = new LeetSpeakTranslator();
        string result = translator.Translate(Request.Query["input"]);
        return View["index.cshtml", result];
      };
    }
  }
}
