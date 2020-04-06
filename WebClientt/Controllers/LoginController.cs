using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientt.Models;
using WebClientt.ServiceProduct;

namespace WebClientt.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        WebClientt.ServiceProduct.ServiceProductClient servis = new ServiceProduct.ServiceProductClient();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel m)
        {
            UserDTO userdto = servis.Login(m.Email, m.Password);
            if (userdto != null)
            {
                
                Session["User"] = userdto.UserId;
                Session["Username"] = userdto.UserName;
                Session["Role"] = userdto.Role;
                Session["mesaj"] = "Hoşgeldin "+userdto.UserName.ToUpper();                
                Session["Supplier"] = userdto.SupplierId;
                if (userdto.Role== "Admin")
                {
                    return RedirectToAction("Products", "Products");
                }
                else
                {
                    return RedirectToAction("Index", "User");
                }
            }
            else
            {
                Session["Error"] = "UserName veya Password Yanlış";
                Session["Supplier"] = 0;
                Session["Role"] = " ";
            }
  
            return View();
        }
        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login","Login");
        }


    }
}
