using PokedexCapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_Web
{
    public partial class MenuLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error", "Ups! Al parecer no estás logueado.");
                Response.Redirect("Error.aspx");
            }
        }

        protected void MenuAdminButton_Click(object sender, EventArgs e)
        {
            if (LoginHelper.UsuarioEsAdmin((Usuario)Session["usuario"])) 
            {
                Response.Redirect("MenuAdmin.aspx");
            }
        }

        protected void FormularioMailButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioMail.aspx");
        }
    }
}