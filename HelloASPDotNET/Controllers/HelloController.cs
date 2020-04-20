﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        [Route("/helloworld")]
        public IActionResult Index()
        {
            string html = "<form method='post' action='helloworld/display'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // POST: /<controller>/display
        [HttpPost]
        [Route("/helloworld/display")]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        // GET: /<controller>/welcome?name=value or GET: /<controller>/welcome/name
        [HttpGet]
        [Route("/helloworld/welcome/{name?}")]
        public IActionResult Welcome(string name = "World")
        {
            return Content(string.Format("<h1>Welcome to my app, {0}!</h1>", name), "text/html");
        }
    }
}
