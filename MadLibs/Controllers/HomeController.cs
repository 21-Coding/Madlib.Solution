using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Tale() { 
      MadLibsVariable myMadLibsVariable = new MadLibsVariable(); 
      myMadLibsVariable.Name = "Lina";
      myMadLibsVariable.Noun = "horse";
      myMadLibsVariable.Adjective = "very";
      myMadLibsVariable.Verb = "run";
      return View(myMadLibsVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string name, string noun, string adjective, string verb ) 
    { 
      MadLibsVariable myMadLibsVariable = new MadLibsVariable(); 
      myMadLibsVariable.Name = name;
      myMadLibsVariable.Noun = noun;
      myMadLibsVariable.Adjective = adjective;
      myMadLibsVariable.Verb = verb;
      return View(myMadLibsVariable);
    }
  }
}
