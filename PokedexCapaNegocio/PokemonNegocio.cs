using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokedexAccesoDatos;
using PokedexCapaDominio;

namespace PokedexCapaNegocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> ListarConSP() 
        {
            List<Pokemon> listaPokemons = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearStoredProcedure("spListar");
                datos.EjecutarLector();

                while (datos.Reader.Read()) 
                {
                    Pokemon pokemon = new Pokemon();

                    // Datos Básicos
                    pokemon.Id = (int) datos.Reader["id"];
                    pokemon.Nombre = (string) datos.Reader["nombre"];
                    pokemon.Descripcion = (string) datos.Reader["Descripcion Pokemon"];

                    // Datos de Elemento
                    pokemon.Tipo = new Elemento();
                    pokemon.Tipo.Id = (int) datos.Reader["id_tipo"];
                    pokemon.Tipo.Descripcion = (string) datos.Reader["descripcion"];
                    pokemon.UrlImagen = (string) datos.Reader["url_imagen"];

                    if (!Convert.IsDBNull(datos.Reader["id_evol"]))
                    {
                        pokemon.Evolucion = new Pokemon();
                        pokemon.Evolucion.Id = (int) datos.Reader["id_evol"];
                        pokemon.Evolucion.Nombre = (string)datos.Reader["nombre_evol"];
                    }

                    listaPokemons.Add(pokemon);
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

            return listaPokemons;
        }

        public void Agregar(Pokemon pokemon) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearStoredProcedure("spAltaPokemon");

                datos.AgregarParametro("nombre", pokemon.Nombre);
                datos.AgregarParametro("id_tipo", pokemon.Tipo.Id);
                datos.AgregarParametro("id_evolucion", pokemon.Evolucion.Id);
                datos.AgregarParametro("descripcion", pokemon.Descripcion);
                datos.AgregarParametro("url_imagen", pokemon.UrlImagen);
                datos.AgregarParametro("id_debilidad", pokemon.TipoDebilidad.Id);

                datos.EjecutarAccion();
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
