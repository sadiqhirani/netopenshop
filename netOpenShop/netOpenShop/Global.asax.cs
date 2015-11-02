using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace netOpenShop
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var currentPath = HttpContext.Current.Request.Url.AbsolutePath.ToLower();
            var paths = currentPath.Split('/');
            //var absolutePath =
            //db get categories
            //on found categories
            //search for product slug
            //on found for product get absolute path
            //assign absolute path
            HttpContext.Current.RewritePath("absolutePath",true);
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}