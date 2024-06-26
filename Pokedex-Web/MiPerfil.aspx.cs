﻿using PokedexCapaDominio;
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

            if (!IsPostBack)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            Trainee user = (Trainee)Session["trainee"];

            EmailTextBox.Text = user.Email;
            NombreTextBox.Text = user.Nombre;
            ApellidoTextBox.Text = user.Apellido;
            ImagenPerfilNuevo.ImageUrl = user.ImagenPerfil != null ? "~/Images/" + user.ImagenPerfil : "https://www.came-educativa.com.ar/upsoazej/2022/03/placeholder-4.png";

            if (!(user.FechaNacimiento.Year < 1753))
            {
                FechaNacimientoTextBox.Text = user.FechaNacimiento.ToString("yyyy-MM-dd");
            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {

            // Esto es importante ya que sin esto las validaciones igual funcionan,
            // pero ejecutarian codigo innecesario en caso de no estar presente
            Page.Validate();

            if (!Page.IsValid)
            {
                return;
            }

            try
            {


                Trainee user = (Trainee)Session["trainee"];
                TraineeNegocio negocio = new TraineeNegocio();

                if (ImagenTxt.PostedFile.FileName != "")
                {
                    string ruta = Server.MapPath("./Images/");
                    ImagenTxt.PostedFile.SaveAs(ruta + "perfil-" + user.Id + ".jpg");
                    user.ImagenPerfil = "perfil-" + user.Id + ".jpg";
                }

                if (FechaNacimientoTextBox.Text != "")
                {
                    user.FechaNacimiento = DateTime.Parse(FechaNacimientoTextBox.Text);
                }

                user.Nombre = NombreTextBox.Text;
                user.Apellido = ApellidoTextBox.Text;

                negocio.Actualizar(user);

                Image img = (Image)Master.FindControl("ImagenPerfilActual");
                img.ImageUrl = "~/Images/" + user.ImagenPerfil;
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}