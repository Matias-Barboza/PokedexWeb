using PokedexCapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;

namespace Pokedex_Web
{
    public static class LoginHelper
    {
        public static bool ExisteUsuarioLogueado(HttpSessionState session) 
        {
            return session["usuario"] != null || session["trainee"] != null;
        }

        public static bool UsuarioEsAdmin(Usuario usuario) 
        {
            return usuario.TipoUsuario == TipoUsuario.ADMIN;
        }

        public static bool PaginaActualNecesitaLogin(Page pagina)
        {
            return pagina is MiPerfil || pagina is MisFavoritos || pagina is ListadoPokemons;
        }
    }
}