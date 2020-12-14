using Microsoft.AspNetCore.Mvc;
using words.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/input")]
    public ActionResult AddLibs(string adjective1, )
    {
      Word myWord = new Word();
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
    }
  }
}