using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/input")]
    public ActionResult Words(string adjective1, string adjective2, string birdType, string houseRoom, string verb1, string verb2, string relativesName, string noun1, string liquid, string verbIng1, string bodyPart, string pluralNoun, string verbIng2, string noun2)
    {
      WordVariable myWord = new WordVariable();
      myWord.Adjective1 = adjective1;
      myWord.Adjective2 = adjective2;
      myWord.BirdType = birdType;
      myWord.HouseRoom = houseRoom;
      myWord.Verb1 = verb1;
      myWord.Verb2 = verb2;
      myWord.RelativesName = relativesName;
      myWord.Noun1 = noun1;
      myWord.Liquid = liquid;
      myWord.VerbIng1 = verbIng1;
      myWord.BodyPart = bodyPart;
      myWord.PluralNoun = pluralNoun;
      myWord.VerbIng2 = verbIng2;
      myWord.Noun2 = noun2;
      return View(myWord);
    }


  }
}