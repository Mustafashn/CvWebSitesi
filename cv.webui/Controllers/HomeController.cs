using System;
using cv.business.Concrete;
using cv.data.Concrete.EntityFramework;
using cv.entity.Concrete;
using cv.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace cv.webui.Controllers
{
    public class HomeController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            var contact = new Contact()
            {
                ContactName = model.Name,
                ContactMail = model.Mail,
                ContactMessage = model.Message,
                ContactSubject = model.Subject,
                ContactDate = DateTime.Now,
            };
            if (!ModelState.IsValid)
            {
                return View(model);

            }
            contactManager.Add(contact);

            return Redirect("/");
        }

    }
}