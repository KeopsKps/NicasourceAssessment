using System;
using Microsoft.AspNetCore.Mvc;
using NicasourceAssessment.Models;
using Newtonsoft.Json.Linq;

namespace NicasourceAssessment.Controllers
{
    public class CharacterController : Controller
    {
        
        public Search SearchObject;

        //[HttpPost]
        // public void Index(string CharacterID)
        // {
        //     string URL = "https://superheroapi.com/api/4368073683252121/" + CharacterID;
        //     this.SearchObject = new Search(URL);
        //     Console.WriteLine(SearchObject.FormattedResponse["response"]);
        //     Index();
        // }

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
                return View(SearchObject.FormattedResponse);
            else
                return View("Error");
            
        }
    }
}