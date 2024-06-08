using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PokedexCapaNegocio
{
    public class EmailService
    {
        private MailMessage _email;
        private SmtpClient _servidor;

        public EmailService() 
        {
            _servidor = new SmtpClient();
            _servidor.Host = "sandbox.smtp.mailtrap.io";
            _servidor.Port = 2525;
            _servidor.EnableSsl = true;
            _servidor.UseDefaultCredentials = false;
            _servidor.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["UserName"].ToString(), ConfigurationManager.AppSettings["Pass"].ToString());
        }

        public void ArmarCorreo(string emailDestino, string asunto, string cuerpo) 
        {
            _email = new MailMessage();
            _email.From = new MailAddress("pokedex_web@gmail.com");
            _email.To.Add(emailDestino);
            _email.Subject = asunto;
            _email.Body = cuerpo;
        }

        public void ArmarCorreoBienvenida(string emailDestino) 
        {
            _email = new MailMessage();
            _email.From = new MailAddress("pokedex_web@gmail.com");
            _email.To.Add(emailDestino);
            _email.Subject = "Bienvenido a la Pokedex Web, Trainee";
            _email.IsBodyHtml = true;
            _email.Body = @"<h2> Bienvenido, Trainee.</h2><br>
                            <p>Gracias por unirte a esta aventura</p>";
        }

        public void EnviarMail() 
        {
            try
            {
                _servidor.Send(_email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
