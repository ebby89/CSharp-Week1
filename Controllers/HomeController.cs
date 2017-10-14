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
            return View(Contact.GetAll());
        }

        [HttpGet("/contacts/form")]
        public ActionResult ContactForm()
        {
          return View();
        }

        [HttpPost("/contacts/new")]
        public ActionResult ContactInfo()
        {
          string contactName = Request.Form["new-contact-name"];
          string contactPhone = Request.Form["new-contact-phone"];
          string contactAddress = Request.Form["new-contact-address"];
          Contact newContact = new Contact(contactName, contactPhone, contactAddress);
          return Redirect("/");
        }

        [HttpGet("/contacts/{id}")]
        public ActionResult ContactInfo(int id)
        {
          Contact selectedContact = Contact.Find(id);
          return View(selectedContact);
        }

        [HttpPost("/contacts/list/clear")]
        public ActionResult ContactListClear()
        {
          Contact.ClearAll();
          return View();
        }

    }
}
