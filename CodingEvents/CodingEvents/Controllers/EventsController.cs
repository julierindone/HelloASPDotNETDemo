using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        private static List<string> Events = new List<string>();            //b/c List is static, we can access it from ALL our methods

        //get: /controller>/
        [HttpGet]
        public IActionResult Index()
        {
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
    public IActionResult NewEvent(string name)       //handling our post request made in Add()
        {
            Events.Add(name);

            return Redirect("/Events");
        }

    }
}
