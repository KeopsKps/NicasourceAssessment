using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using NicasourceAssessment.Models;

namespace NicasourceAssessment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static readonly HttpClient client = new HttpClient();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.IsSearchResult = false;
            List<CharacterSearch> EmptyObject = new List<CharacterSearch>();
            return View(EmptyObject);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public ActionResult Index(string SearchCriteria)
        {
            string URL = "https://superheroapi.com/api/4368073683252121/search/" + SearchCriteria;
            Search SearchObject = new Search(URL);
            SearchResult searchResult = new SearchResult(true);
            ViewBag.IsSearchResult = false;
            List<CharacterSearch> Character = new List<CharacterSearch>();
            if (SearchObject.FormattedResponse["response"].ToString().Equals("success")) 
            {    
                ViewBag.IsSearchResult = true;
                foreach(JObject CharacterInfo in SearchObject.FormattedResponse["results"])
                {
                    Character.Add(
                        new CharacterSearch(){
                            Response = SearchObject.FormattedResponse["results"].ToString(),
                            ImageURL = CharacterInfo["image"]["url"].ToString(),
                            Name = CharacterInfo["name"].ToString(),
                            Gender = CharacterInfo["appearance"]["gender"].ToString()
                        }
                    );
                }  
            }
            return View(Character);
        }
    }
}
