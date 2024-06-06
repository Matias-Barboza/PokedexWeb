using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PokedexCapaDominio;
using PokedexCapaNegocio;

namespace Pokedex_Web
{
    public partial class FormularioPokemon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdTextBox.Enabled = false;

            try
            {

                // Configuración inicial
                if (!IsPostBack)
                {
                    ElementoNegocio negocio = new ElementoNegocio();
                    List<Elemento> listaElementos = negocio.listarElementos();

                    TipoDropDownList.DataSource = listaElementos;
                    TipoDropDownList.DataValueField = "Id";
                    TipoDropDownList.DataTextField = "Descripcion";
                    TipoDropDownList.DataBind();

                    DebilidadDropDownList.DataSource = listaElementos;
                    DebilidadDropDownList.DataValueField = "Id";
                    DebilidadDropDownList.DataTextField = "Descripcion";
                    DebilidadDropDownList.DataBind();
                }

                // Configuración si viene para modificación
                if (Request.QueryString["id"] != null && !IsPostBack)
                {
                    PokemonNegocio negocio = new PokemonNegocio();

                    Pokemon pokemonSeleccionado = negocio.ObtenerPorId(Convert.ToInt32(Request.QueryString["id"]));

                    IdTextBox.Text = pokemonSeleccionado.Id.ToString();
                    NombreTextBox.Text = pokemonSeleccionado.Nombre.ToString();
                    NumeroTextBox.Text = pokemonSeleccionado.Numero.ToString();
                    TipoDropDownList.SelectedValue = pokemonSeleccionado.Tipo.Id.ToString();
                    DebilidadDropDownList.SelectedValue = pokemonSeleccionado.TipoDebilidad.Id.ToString();
                    DescripcionTextBox.Text = pokemonSeleccionado.Descripcion;
                    UrlImagenTextBox.Text = pokemonSeleccionado.UrlImagen;

                    UrlImagenTextBox_TextChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw ex;
            }
        }

        protected void UrlImagenTextBox_TextChanged(object sender, EventArgs e)
        {
            ImagePokemon.ImageUrl = UrlImagenTextBox.Text;
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pokemon nuevoPokemon = new Pokemon();
                PokemonNegocio negocio = new PokemonNegocio();

                nuevoPokemon.Nombre = NombreTextBox.Text;
                nuevoPokemon.Numero = int.Parse(NumeroTextBox.Text);
                nuevoPokemon.Tipo = new Elemento();
                nuevoPokemon.Tipo.Id = int.Parse(TipoDropDownList.SelectedValue);
                nuevoPokemon.TipoDebilidad = new Elemento();
                nuevoPokemon.TipoDebilidad.Id = int.Parse(DebilidadDropDownList.SelectedValue);
                nuevoPokemon.Descripcion = DescripcionTextBox.Text;
                nuevoPokemon.UrlImagen = UrlImagenTextBox.Text;
                nuevoPokemon.Evolucion = new Pokemon();

                if (Request.QueryString["id"] != null)
                {
                    nuevoPokemon.Id = int.Parse(IdTextBox.Text);
                    negocio.Modificar(nuevoPokemon);
                }
                else
                {
                    negocio.Agregar(nuevoPokemon);
                }

                Response.Redirect("ListadoPokemons.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("errorAgregar", ex);
                throw ex;
            }
        }
    }
}