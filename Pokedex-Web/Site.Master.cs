using PokedexCapaDominio;
using PokedexCapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace Pokedex_Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (LoginHelper.PaginaActualNecesitaLogin(Page))
            {
                if (!Seguridad.SessionActiva(Session["trainee"]))
                {
                    Response.Redirect("Login.aspx");
                }
            }

            if (Seguridad.SessionActiva(Session["trainee"]))
            {
                ImagenPerfilActual.ImageUrl = ((Trainee)Session["trainee"]).ImagenPerfil != null ?  "~/Images/" + ((Trainee)Session["trainee"]).ImagenPerfil : "https://www.pngmart.com/files/21/Account-Avatar-Profile-PNG-Clipart.png" ;
            }
        }

        protected void CerrarSesionButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("LoginTrainee.aspx");
        }
    }
}