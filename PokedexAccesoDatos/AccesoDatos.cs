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

        public void SetearQuery(string consulta) 
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void SetearStoredProcedure(string procedimientoAlmacenado) 
        {
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = procedimientoAlmacenado;
        }

        public void AgregarParametro(string nombre, object valor) 
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void EjecutarLector() 
        {
            try
            {
                Conexion.Open();
                reader = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EjecutarAccion() 
        {
            try
            {
                Conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CerrarConexion() 
        {
            if(Conexion != null) 
            {
                Conexion.Close();
            }
        }
    }
}
