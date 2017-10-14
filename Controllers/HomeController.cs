using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AddressBookProject.Models;

namespace AddressBookProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/"), ActionName("ContactList")]
        public ActionResult Index()
        {
            return View(Contact.GetAll());
        }

        [HttpGet("/contacts/new"), ActionName("ContactForm")]
        public ActionResult ContactForm()
        {
          return View();
        }

        [HttpPost("/contacts/new"), ActionName("ContactList")]
        public ActionResult NewContact()
        {
          string contactName = Request.Form["new-contact-name"];
          string contactPhone = Request.Form["new-contact-phone"];
          string contactAddress = Request.Form["new-contact-address"];
          Contact newContact = new Contact(contactName, contactPhone, contactAddress);
          return View(Contact.GetAll());
        }
        // [HttpGet("/contacts")]


        [HttpPost("/contacts/{id}"), ActionName("ContactInfo")]
        public ActionResult ContactInfo(int id)
        {
          Contact selectedContact = Contact.Find(id);
          return View(selectedContact);
        }

    }
}
