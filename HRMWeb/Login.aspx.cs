﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Text;

namespace HRMWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Membership.ValidateUser(Login1.UserName, Login1.Password) == true)
                {
                    Session["user"] = Login1.UserName;
                    Response.Redirect("Default.aspx");
                }
            }
            catch(Exception es)
            {
                Login1.FailureText = "Error in connection ";
            }
        }
    }
}
