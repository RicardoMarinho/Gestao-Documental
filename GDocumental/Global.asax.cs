using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace GDocumental
{
    public class Global : System.Web.HttpApplication
    {
        //Ligar BD
        public static string conexao = "";

        protected void Application_Start(object sender, EventArgs e)
        {
            //Ligar BD
            System.Configuration.AppSettingsReader boot = new System.Configuration.AppSettingsReader();
            conexao = (string)(boot.GetValue("ligacao", typeof(string)));
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

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