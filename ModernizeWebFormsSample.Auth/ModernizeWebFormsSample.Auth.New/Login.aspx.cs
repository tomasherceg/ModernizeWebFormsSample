using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;

namespace ModernizeWebFormsSample.Auth.New
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_OnClick(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(UserName.Text, Password.Text))
            {
                // get user info
                var user = Membership.GetUser(UserName.Text);

                // build a list of claims
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, user.ProviderUserKey.ToString()));
                if (Roles.Enabled)
                {
                    foreach (var role in Roles.GetRolesForUser(user.UserName))
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }
                }

                // create the identity
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationType);

                Context.GetOwinContext().Authentication.SignIn(new AuthenticationProperties()
                {
                    IsPersistent = RememberMe.Checked
                }, 
                identity);

                Response.Redirect("~/");
            }
            else
            {
                FailureText.Text = "The credentials are not valid!";
            }
        }

    }
}