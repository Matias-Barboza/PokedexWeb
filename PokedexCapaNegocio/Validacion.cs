using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace PokedexCapaNegocio
{
    public static class Validacion
    {
        public static bool ControlTieneTextoVacio(object control) 
        {

            // Pattern matching 
            if (control is TextBox cajaTexto) 
            {
                return string.IsNullOrEmpty(cajaTexto.Text);
            }

            return false;
        }
    }
}
