using System;
using System.Collections.Generic;
using System.Security.Claims;
using cv.business.Concrete;
using cv.data.Concrete.EntityFramework;
using cv.entity.Concrete;
using cv.webui.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace cv.webui.Controllers
{
    public class LoginController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminRepository());
        public IActionResult Index(string returnUrl = null)
        {
            return View(new AdminModel
            {
                ReturnUrl = returnUrl
            });
        }
        [HttpPost]
        public IActionResult Index(AdminModel adminModel)
        {
            if (ModelState.IsValid)
            {
                if (AuthenticateUser(adminModel))
                {
                    return Redirect(adminModel.ReturnUrl ?? "/");
                }


            }
            return View(adminModel);
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        private bool AuthenticateUser(AdminModel model)
        {
            var user = adminManager.GetByUserName(model.UserName);

            if (user == null || model.Password != user.Password)
            {
                return false;
            }

            var claims = new List<Claim>{
                new Claim(ClaimTypes.Name,user.UserName)
            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            return true;
        }

    }
}