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
        public void Actualizar(Trainee user)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery(@"UPDATE users SET 
                                    imagen_perfil = @url_imagen,
                                    nombre = @nombre,
                                    apellido = @apellido
                                    -- fecha_nacimiento = @fecha_nacimiento
                                    WHERE id = @id");
                datos.AgregarParametro("url_imagen", user.ImagenPerfil);
                datos.AgregarParametro("nombre", user.Nombre);
                datos.AgregarParametro("apellido", user.Apellido);
                //datos.AgregarParametro("fecha_nacimiento", user.FechaNacimiento);
                datos.AgregarParametro("id", user.Id);

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

        public bool Login(Trainee trainee) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery("SELECT id, email, pass, [admin], imagen_perfil, nombre, apellido FROM users WHERE email = @email AND pass = @pass");
                datos.AgregarParametro("email", trainee.Email);
                datos.AgregarParametro("pass", trainee.Pass);

                datos.EjecutarLector();

                if (datos.Reader.Read()) 
                {
                    trainee.Id = (int)datos.Reader["id"];
                    trainee.Admin = (bool) datos.Reader["admin"];
                    trainee.ImagenPerfil = datos.Reader.IsDBNull(4) ? null : (string) datos.Reader["imagen_perfil"];
                    trainee.Nombre = datos.Reader.IsDBNull(5) ? null : (string) datos.Reader["nombre"];
                    trainee.Apellido = datos.Reader.IsDBNull(6) ? null : (string) datos.Reader["apellido"];

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
