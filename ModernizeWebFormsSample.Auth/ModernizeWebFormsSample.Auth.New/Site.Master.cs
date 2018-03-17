using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ModernizeWebFormsSample.Auth.New
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            MenuSignInLink.Visible = !Context.User.Identity.IsAuthenticated;
            MenuMyProfileLink.Visible = Context.User.Identity.IsAuthenticated;
            MenuSignOutLink.Visible = Context.User.Identity.IsAuthenticated;
        }

        protected void LogoutButton_OnClick(object sender, EventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut();
            Response.Redirect("~/");
        }
    }
}