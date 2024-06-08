using PokedexAccesoDatos;
using PokedexCapaDominio;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexCapaNegocio
{
    public class UsuarioNegocio
    {
        public bool Loguear(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery("SELECT id, usuario, pass, tipo_user FROM usuarios WHERE usuario = @user AND pass = @pass");
                datos.AgregarParametro("user", usuario.User);
                datos.AgregarParametro("pass", usuario.Pass);

                datos.EjecutarLector();

                if (datos.Reader.Read()) 
                {
                    usuario.Id = (int)datos.Reader["id"];
                    usuario.TipoUsuario = (TipoUsuario) datos.Reader["tipo_user"];

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                datos.CerrarConexion();
                datos = null;
            }
        }
    }
}
