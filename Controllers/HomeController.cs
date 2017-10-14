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

        [HttpPost("/contacts/new"), ActionName("ContactInfo")]
        public ActionResult NewContact()
        {
          string contactName = Request.Form["new-contact-name"];
          string contactPhone = Request.Form["new-contact-phone"];
          string contactAddress = Request.Form["new-contact-address"];
          Contact newContact = new Contact(contactName, contactPhone, contactAddress);
          return View(Contact.GetAll());
        }
        // [HttpGet("/contacts")]


        [HttpGet("/contacts/{id}")]
        public ActionResult ContactInfo(int id)
        {
          Contact selectedContact = Contact.Find(id);
          List<Contact> contacts = selectedContact.GetContacts();
          return View(selectedContact);
        }

    }
}
