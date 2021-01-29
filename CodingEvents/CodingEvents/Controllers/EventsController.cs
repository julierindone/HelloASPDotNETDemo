using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        private static Dictionary<string, string> Events = new Dictionary<string, string>();
        public IActionResult Index()
        {            
/*            Events.Add("Code With Pride");
            Events.Add("Apple WWDC");
            Events.Add("Strange Loop");*/
            ViewBag.events = Events;

            return View();
        }

        // get: /Events/Add
        [HttpGet]
        public IActionResult Add()     //we are adding the form that we make in View.
        {
            return View();
        }

        //Post: /Events/Add
        [HttpPost]
        [Route("/Events/Add/")]
        public IActionResult NewEvent(string name, string description)       //handling our post request made in Add()
        {
            Events.Add(name, description);

            return Redirect("/Events");
        }

    }
}


