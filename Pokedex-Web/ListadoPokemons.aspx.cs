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
    public partial class ListadoPokemons : System.Web.UI.Page
    {
        public bool FiltroAvanzado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();

            Session.Add("listaPokemons", negocio.ListarConSP());

            GridViewPokemons.DataSource = Session["listaPokemons"];
            GridViewPokemons.DataBind();
        }

        protected void GridViewPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = GridViewPokemons.SelectedDataKey.Value.ToString();
            Response.Redirect($"FormularioPokemon.aspx?id={id}");
        }

        protected void GridViewPokemons_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewPokemons.PageIndex = e.NewPageIndex;
            GridViewPokemons.DataBind();
        }

        protected void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada = (List<Pokemon>)Session["listaPokemons"];

            listaFiltrada = listaFiltrada.FindAll(x => x.Nombre.ToUpper().Contains(FiltroTextBox.Text.ToUpper()));

            GridViewPokemons.DataSource = listaFiltrada;
            GridViewPokemons.DataBind();
        }

        protected void FiltroAvanzadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FiltroAvanzado = FiltroAvanzadoCheckBox.Checked;
            FiltroTextBox.Enabled = !FiltroAvanzado;
        }

        protected void CampoDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CriterioDropDownList.Items.Clear();

            if (CampoDropDownList.SelectedItem.ToString() == "Seleccione una opción...") 
            {
                return;
            }

            if (CampoDropDownList.SelectedItem.ToString() == "Número")
            {
                CriterioDropDownList.Items.Add("Igual a");
                CriterioDropDownList.Items.Add("Mayor a");
                CriterioDropDownList.Items.Add("Menor a");
            }
            else
            {
                CriterioDropDownList.Items.Add("Contiene");
                CriterioDropDownList.Items.Add("Comienza con");
                CriterioDropDownList.Items.Add("Termina con");
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            
            try
            {
                GridViewPokemons.DataSource = negocio.Filtrar(CampoDropDownList.SelectedValue,
                                                              CriterioDropDownList.SelectedValue,
                                                              FiltroAvanzadoTextBox.Text,
                                                              EstadoDropDownList.SelectedValue);
                GridViewPokemons.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("Error.aspx");
            }
        }
    }
}