using PokedexCapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Pokedex_Web
{
    public class LoginHelper
    {
        public static bool ExisteUsuarioLogueado(HttpSessionState session) 
        {
            return session["usuario"] != null;
        }

        public static bool UsuarioEsAdmin(Usuario usuario) 
        {
            return usuario.TipoUsuario == TipoUsuario.ADMIN;
        }
    }
}