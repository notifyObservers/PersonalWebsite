using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;
using System.Web;
using System.IO;
using System.Data;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        // The default page to display
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
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Course()
        {
            return View();
        }
       /* public IActionResult WWOnly(string studentID)
        {
            if (studentID != "20721570")
            {
            }
            return View();
        } */

        public IActionResult Resume()
        {
            string path = "C:/Users/Linda Li/DEV/Github/PersonalWebsite/MyWebsite/MyWebsite/Controllers/Resumewinter2020.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return new FileStreamResult(stream, "application/pdf");
            //return File("C:/Users/Linda Li/DEV/Github/PersonalWebsite/MyWebsite/MyWebsite/Controllers/Resumewinter2020.pdf", "Application/pdf");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
