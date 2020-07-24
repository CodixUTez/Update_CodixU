using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;
using codixU.Models;
using codixU.Models.Entities;


namespace codixU.Manager
{
    public class CustomPrincipal :IPrincipal
    {
        public CustomPrincipal(IIdentity identity)
        {
            _identity = identity;
        }

        private IIdentity _identity;

        public IIdentity Identity
        {
            get
            {
                return _identity;
            }
        }

        private Users _user;

        public Users User
        {
            get
            {
                if (_user == null)
                {
                    using (var db = new AuthorizeContext())
                    {
                        _user = db.Users.Single(a => a.Email == Identity.Name);
                    }
                }

                return _user;
            }
        }

        public bool IsInRole(string role) //Rol kontrolü burada gerçekleştiriliyor.
        {
            using (var db = new AuthorizeContext())
            {
                if (!String.IsNullOrEmpty(role))
                {
                    var userRole = db.Users.Include("Roles").Single(u => u.Email == Identity.Name);

                    foreach (var item in role.Split(','))
                    {
                        if (userRole.Roles.Any(r => r.RoleName.Equals(item)))
                            return true;
                    }
                }
                else
                {
                    return true;
                }

                return false;
            }
        }
    }
}