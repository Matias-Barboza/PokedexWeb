using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace Pokedex_Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // Esta porcion de codigo lo que hace es centralizar el codigo jquery
            // Es una de las formas para los validadores, es mas moderna que la del WebConfig y de mayor "optimización"
            // Se usa el codigo JS a través de CDN
            
            //string JQueryVer = "1.11.3";
            //ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            //{
            //    Path = "~/js/jquery-" + JQueryVer + ".min.js",
            //    DebugPath = "~/js/jquery-" + JQueryVer + ".js",
            //    CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".min.js",
            //    CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".js",
            //    CdnSupportsSecureConnection = true,
            //    LoadSuccessExpression = "window.jQuery"
            //});
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
            Exception exc = Server.GetLastError();

            Session.Add("error", exc);
            Server.Transfer("Error.aspx");
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}