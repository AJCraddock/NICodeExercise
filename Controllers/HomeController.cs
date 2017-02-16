using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using NICodeExercise.Models;
//using System.Runtime.Serialization;
using System.Xml.Serialization;
//using System.Text;
using NICodeExercise.ViewModels;

namespace NICodeExercise.Controllers
{
    public class HomeController : Controller
    {
        private static HttpClient Client = new HttpClient();

        public IActionResult Index(){
            SearchVM result = new SearchVM();
            return View("SearchHome", result);
        }
        public IActionResult Search(string address, string citystatezip)
        {
            SearchVM result = new SearchVM();
            if(!string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(citystatezip)){
                result = DoSearch(address, citystatezip).Result;
                result.SearchPerformed = true;
            }

            return View("SearchHome", result);
        }

        private async Task<SearchVM> DoSearch(string address, string citystatezip){
            SearchVM svm = new SearchVM();
            string uri = String.Format(@"http://www.zillow.com/webservice/GetSearchResults.htm?zws-id=X1-ZWz1dyb53fdhjf_6jziz&address={0}&citystatezip={1}", address,citystatezip);
            var response = await Client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
            // Parse the response body. Blocking!
                XmlSerializer serializer = new XmlSerializer(typeof(searchresults));
                var strmR = await response.Content.ReadAsStreamAsync();
                svm.SearchResults = (searchresults) serializer.Deserialize(strmR);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase); 
                svm.Message = response.ReasonPhrase;
            }    

            return svm;
         }
        
        public IActionResult About()
        {
            ViewData["Message"] = "This is my .Net Core MVC application.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
