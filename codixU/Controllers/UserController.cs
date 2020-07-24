using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using codixU.Models;

namespace codixU.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Register()
        {
            return View();
        }
        //Post: User
        [HttpPost]
        public ActionResult Register(Models.Entities.Users model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AuthorizeContext())
                {
                    var user = db.Users.Create();
                    user.Name = model.Name;
                    user.Surname = model.Surname;
                    user.Email = model.Email;
                    user.Password = model.Password;
                    user.ConfirmPassowrd = model.Password;
                    user.algorithm = model.algorithm = false;
                    user.score = model.score = 0;

                    foreach (var item in db.Roles.Where(r => r.ID > 2 && r.ID < 6))
                    {
                        user.Roles.Add(item);
                    }

                    db.Users.Add(user);
                    db.SaveChanges();
                }

                return RedirectToAction("Login");
            }

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.DataModels.Login model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AuthorizeContext())
                {
                    if (db.Users.Any(u => u.Email == model.Email && u.Password == model.Password))
                    {
                        FormsAuthentication.SetAuthCookie(model.Email, false);
                        return RedirectToAction("StudentHome", "Student");
                    }
                    else
                    {
                        ModelState.AddModelError("ErrorMessage", "Email adresi veya Şifre hatalı!!");
                        
                    }
                }
            }

            return View();
        }

        
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }
    }
}