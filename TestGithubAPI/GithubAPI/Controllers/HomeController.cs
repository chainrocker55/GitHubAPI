using GithubAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Net;
using System.IO;
using System;
using System.Text;
using Newtonsoft.Json;

namespace GithubAPI.Controllers
{
    public class HomeController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact me";

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
        [HttpGet]
        public JsonResult GetRepoSitory(string user)
        {
            Console.WriteLine(user);
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.github.com/users/chainrocker55/repos");
                request.ContentType = "application/json";
                request.Accept = "application/vnd.github.symmetra-preview+json";
                request.Method = WebRequestMethods.Http.Get;
                request.UserAgent = "Foo";
                request.Method = "GET";
                WebResponse response = request.GetResponse(); //Error Here
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string result = reader.ReadToEnd();

                var jsonResult = JsonConvert.DeserializeObject(result);
                JsonResult obj = new JsonResult(jsonResult);

                response.Close();
                dataStream.Close();
                return obj;
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
          
        }
    }
}
