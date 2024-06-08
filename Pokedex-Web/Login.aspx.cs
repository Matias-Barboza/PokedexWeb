using PokedexCapaDominio;
using PokedexCapaNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       
        }

        protected void IngresarButton_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();

            try
            {
                usuario.User = UsuarioTextBox.Text;
                usuario.Pass = PassTextBox.Text;

                if (negocio.Loguear(usuario)) 
                {
                    Session.Add("usuario", usuario);

                    Response.Redirect("MenuLogin.aspx", false);
                }
                else 
                {
                    Session.Add("error", "Usuario o Contraseña incorrecta.");

                    Response.Redirect("Error.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("Error.aspx");
            }
        }
    }
}