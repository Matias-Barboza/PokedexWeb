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
    public partial class LoginTrainee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IngresarButton_Click(object sender, EventArgs e)
        {
            Trainee trainee = new Trainee();
            TraineeNegocio negocio = new TraineeNegocio();

            try
            {
                trainee.Email = EmailTextBox.Text;
                trainee.Pass = PassTextBox.Text;

                if (negocio.Login(trainee)) 
                {
                    Session.Add("trainee", trainee);
                    Response.Redirect("MiPerfil.aspx", false);
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
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}