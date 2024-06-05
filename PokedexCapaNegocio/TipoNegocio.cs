using PokedexAccesoDatos;
using PokedexCapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexCapaNegocio
{
    public class TipoNegocio
    {
        public List<Tipo> listarTipos() 
        {
            List<Tipo> listaTipos = new List<Tipo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery("SELECT id, descripcion FROM tipos");
                datos.EjecutarLector();

                while(datos.Reader.Read()) 
                {
                    Tipo tipo = new Tipo();

                    tipo.Id = (int) datos.Reader["id"];
                    tipo.Descripcion = (string) datos.Reader["descripcion"];

                    listaTipos.Add(tipo);
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

            return listaTipos;
        }
    }
}
