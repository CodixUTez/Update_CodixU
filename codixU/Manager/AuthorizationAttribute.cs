using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;

namespace codixU.Manager
{
    public class AuthorizationAttribute : AuthorizeAttribute
    {
        public string Permission { get; set; }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException("httpContext");
            }

            IPrincipal user = httpContext.User;
            if (!user.Identity.IsAuthenticated)
            {
                return false;
            }

            if (!String.IsNullOrEmpty(Permission))
                if (Permission.Count() > 0)
                {
                    if (!user.IsInRole(Permission))
                    {
                        return false;
                    }
                }

            return true;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new
                            {
                                controller = "User",
                                action = "Login"
                            })
                        );
        }
    }
}