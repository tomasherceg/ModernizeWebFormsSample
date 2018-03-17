using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ModernizeWebFormsSample.Auth.Old
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_OnClick(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(EmailTextBox.Text, PasswordTextBox.Text))
            {
                FormsAuthentication.SetAuthCookie(EmailTextBox.Text, RememberMeCheckBox.Checked);
                Response.Redirect("~/");
            }
            else
            {
                Alert.Visible = true;
            }
        }
    }
}