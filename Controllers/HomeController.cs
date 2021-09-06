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
using NicasourceAssessment.Models;
using Newtonsoft.Json.Linq;

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
            return View();
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
        public async void Index(string SearchCriteria)
        {
            JObject JsonSearchResult;
            var URL = "https://superheroapi.com/api/4368073683252121/search/" + SearchCriteria;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var streamTask = await client.GetStringAsync(URL);
            //var repositories = JsonSerializer.Deserialize<List<Search>>(streamTask);
            var msg = streamTask.ToString();
            JsonSearchResult = JObject.Parse(msg);
            var something = JsonSearchResult["response"];
            Console.WriteLine(something);
        }
    }
}
