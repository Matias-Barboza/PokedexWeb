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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PokemonNegocio negocio = new PokemonNegocio();

                Session.Add("listaPokemons", negocio.ListarConSP());

                GridViewPokemons.DataSource = Session["listaPokemons"];
                GridViewPokemons.DataBind();
            }
        }

        protected void GridViewPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = GridViewPokemons.SelectedDataKey.Value.ToString();
            Response.Redirect($"FormularioPokemon.aspx?id={id}");
        }

        protected void GridViewPokemons_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewPokemons.PageIndex = e.NewPageIndex;
            GridViewPokemons.DataSource = Session["listaPokemons"];
            GridViewPokemons.DataBind();
        }
    }
}