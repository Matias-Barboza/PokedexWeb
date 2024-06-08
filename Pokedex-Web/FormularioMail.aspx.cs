using PokedexCapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_Web
{
    public partial class FormularioMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null) 
            {
                Session.Add("error", "Ups! Al parecer no estás logueado.");
                Response.Redirect("Error.aspx");
            }
        }

        protected void EnviarMailButton_Click(object sender, EventArgs e)
        {
            EmailService emailService = new EmailService();

            try
            {
                emailService.ArmarCorreo(DestinatarioTextBox.Text, AsuntoTextBox.Text, MensajeTextBox.Text);
                emailService.EnviarMail();
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("Error.aspx");
            }
        }
    }
}