using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using website.Models;

namespace website.Controllers
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

            List<ProgrammingLanguage> languages = new List<ProgrammingLanguage>(){
                new ProgrammingLanguage("C#", new DateTime(2014, 10, 25)),
                new ProgrammingLanguage("VB.NET", new DateTime(2014, 10, 25)),
                new ProgrammingLanguage("VBA", new DateTime(2013, 07, 25)),
                new ProgrammingLanguage("Ruby", new DateTime(2016, 12, 21)),
            };

            return View(languages);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
