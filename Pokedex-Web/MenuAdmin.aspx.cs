using PokedexCapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_Web
{
    public partial class MenuAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error", "Ups! Al parecer no estás logueado.");
                Response.Redirect("Error.aspx");
                return;
            }

            if (!LoginHelper.UsuarioEsAdmin((Usuario)Session["usuario"]))
            {
                Session.Add("error", "No tienes los permisos necesarios para visitar esta página.");
                Response.Redirect("Error.aspx");
                return;
            }
        }
    }
}