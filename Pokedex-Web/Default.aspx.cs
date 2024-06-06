using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PokedexCapaNegocio;

namespace Pokedex_Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                PokemonNegocio negocio = new PokemonNegocio();

                RepeaterCards.DataSource = negocio.ListarConSP();
                RepeaterCards.DataBind();
            }
        }
    }
}