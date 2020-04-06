using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClientt
{//Login şartını yazdık
    public class UserAuthentication : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.Session["User"]==null)
            {
                HttpContext.Current.Session["Error"] = "Bu sayfaya gimek için önce Giriş yapın!";
                filterContext.Result = new RedirectResult("/Login/Login");
            }
        }
    }
}