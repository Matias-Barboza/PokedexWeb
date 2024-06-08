using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CerrarSesionButton_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");

            if (Request.Url.AbsolutePath == "/MenuLogin.aspx" || Session["usuario"] == null) 
            {
                Session.Add("error", "Ups! Debes estar logueado para estar aquí.");
                Response.Redirect("Error.aspx");
            }
        }
    }
}