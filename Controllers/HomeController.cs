using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AddressBookProject.Models;

namespace AddressBookProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
