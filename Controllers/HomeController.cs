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

        [HttpPost("/contacts/new"), ActionName("ContactForm")]
        public ActionResult NewContact()
        {
          string contactName = Request.Form["new-contact-name"];
          string contactPhone = Request.Form["new-contact-phone"];
          string contactAddress = Request.Form["new-contact-address"];
          Contact newContact = new Contact(contactName, contactPhone, contactAddress);
          return View(Contact.GetAll());
        }

        // [HttpPost("/contacts/{id}"), ActionName("ContactInfo")]
        // public ActionResult ContactInfo(int id)
        // {
        //   Contact selectedContact = Contact.Find(id);
        //   return View(selectedPlace);
        // }

    }
}
