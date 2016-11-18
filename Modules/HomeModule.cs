using Nancy;
using System;
using System.Collections.Generic;
using Hangman.Objects;

namespace Hangman
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]= _ =>{
        return View["index.cshtml"];
      };
      Post["/hangman"] = _ =>{
        
      }
    }
  }
}
