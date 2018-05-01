using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebWithPatterns.CompositeCommands;
using WebWithPatterns.Models;

namespace WebWithPatterns.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Data()
        {
            RefWrapper<IList<President>> widgets = new RefWrapper<IList<President>>
            {
                Value = new List<President>()
            };
            return View(GetModel(new WidgetGetter(widgets)));
        }

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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
