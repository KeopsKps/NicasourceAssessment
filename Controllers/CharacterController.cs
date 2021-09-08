using System;
using Microsoft.AspNetCore.Mvc;
using NicasourceAssessment.Models;
using Newtonsoft.Json.Linq;

namespace NicasourceAssessment.Controllers
{
    public class CharacterController : Controller
    {   
        public Search SearchObject;
        public IActionResult Index()
        {
            return View();
        }

        [Route("Character/{CharacterID?}")]
        [Route("Character/Index/{CharacterID?}")]
        public IActionResult Index(int CharacterID)
        {
            string URL = "https://superheroapi.com/api/4368073683252121/" + CharacterID;
            SearchObject = new Search(URL);
            if (SearchObject.FormattedResponse["response"].ToString().Equals("success"))
            {
                Character SearchedCharacter = new Character();
                SearchedCharacter.Id = SearchObject.FormattedResponse["id"].ToString();
                SearchedCharacter.Name = SearchObject.FormattedResponse["name"].ToString();
                SearchedCharacter.FullName = SearchObject.FormattedResponse["biography"]["full-name"].ToString();
                SearchedCharacter.FirstAppearance = SearchObject.FormattedResponse["biography"]["first-appearance"].ToString();
                SearchedCharacter.ImageURL = SearchObject.FormattedResponse["image"]["url"].ToString();
                return View(SearchedCharacter);
            }
            else
                return View("Error");
        }
    }
}