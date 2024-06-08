using PokedexCapaDominio;
using PokedexCapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_Web
{
    public partial class MiPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Seguridad.SessionActiva(Session["trainee"])) 
            {
                Session.Add("error", "Ups! Al parecer no estas logueado.");
                Response.Redirect("Error.aspx");
            }
        }
    }
}