using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexAccesoDatos
{
    public class AccesoDatos
    {
        private SqlCommand comando;
        private SqlDataReader reader;

        public SqlDataReader Reader { get { return reader; } }
        public SqlConnection Conexion { get; }

        public AccesoDatos() 
        {
            Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["pokedex_db"].ConnectionString);
            comando = new SqlCommand();
            comando.Connection = Conexion;
        }
    }
}
