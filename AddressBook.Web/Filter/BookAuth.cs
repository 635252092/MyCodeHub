using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Web.Filter
{
    public class BookAuth : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["userid"] == null && filterContext.HttpContext.Request.Cookies["userid"]==null)
            {

                filterContext.HttpContext.Response.RedirectToRoute(new { Controller = "Home", Action = "Login", });
            }
            else if (filterContext.HttpContext.Session["userid"] == null  && filterContext.HttpContext.Request.Cookies["userid"] != null)
            {
                filterContext.HttpContext.Session["userid"] = filterContext.HttpContext.Request.Cookies["userid"].Value;
            }
        }
    }
}