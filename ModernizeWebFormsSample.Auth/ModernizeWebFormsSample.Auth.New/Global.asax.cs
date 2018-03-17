using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ModernizeWebFormsSample.Auth.New
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // create default user
            var defaultUser = Membership.GetUserNameByEmail("test@user.local");
            if (defaultUser == null)
            {
                MembershipCreateStatus status;
                Membership.CreateUser("test@user.local", "Pa$$w0rd", "test@user.local", "question", "answer", true, out status);
                if (status != MembershipCreateStatus.Success)
                {
                    throw new Exception($"Couldn't create a default user! {status}");
                }
            }
        }
    }
}