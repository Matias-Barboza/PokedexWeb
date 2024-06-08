using PokedexAccesoDatos;
using PokedexCapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexCapaNegocio
{
    public class TraineeNegocio
    {
        public int InsertarNuevo(Trainee trainee) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearStoredProcedure("spInsertarNuevoTrainee");
                datos.AgregarParametro("email", trainee.Email);
                datos.AgregarParametro("pass", trainee.Pass);

                return datos.EjecutarAccionScalar();
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

        public bool Login(Trainee trainee) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery("SELECT id, email, pass, [admin] FROM users WHERE email = @email AND pass = @pass");
                datos.AgregarParametro("email", trainee.Email);
                datos.AgregarParametro("pass", trainee.Pass);

                datos.EjecutarLector();

                if (datos.Reader.Read()) 
                {
                    trainee.Id = (int)datos.Reader["id"];
                    trainee.Admin = (bool) datos.Reader["admin"];

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
