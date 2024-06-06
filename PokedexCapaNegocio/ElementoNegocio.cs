using PokedexAccesoDatos;
using PokedexCapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexCapaNegocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listarElementos() 
        {
            List<Elemento> listaElementos = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery("SELECT id, descripcion FROM elementos");
                datos.EjecutarLector();

                while(datos.Reader.Read()) 
                {
                    Elemento elemento = new Elemento();

                    elemento.Id = (int) datos.Reader["id"];
                    elemento.Descripcion = (string) datos.Reader["descripcion"];

                    listaElementos.Add(elemento);
                }
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

            return listaElementos;
        }
    }
}
