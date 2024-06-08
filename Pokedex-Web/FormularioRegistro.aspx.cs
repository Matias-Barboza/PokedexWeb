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
    public partial class FormularioRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegistrarseButton_Click(object sender, EventArgs e)
        {
            try
            {
                Trainee user = new Trainee();
                TraineeNegocio negocio = new TraineeNegocio();
                EmailService emailService = new EmailService();

                user.Email = EmailTextBox.Text;
                user.Pass = PassTextBox.Text;

                int idNuevo = negocio.InsertarNuevo(user);

                emailService.ArmarCorreoBienvenida(user.Email);
                emailService.EnviarMail();

                Response.Redirect("Default.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}