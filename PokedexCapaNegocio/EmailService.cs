using System;
using System.Collections.Generic;
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
            _servidor.Host = "smtp.gmail.com";
            _servidor.Port = 587;
            _servidor.EnableSsl = true;
            _servidor.UseDefaultCredentials = false;
            _servidor.Credentials = new NetworkCredential("programationiii@gmail.com", "programacion3");
        }

        public void ArmarCorreo(string emailDestino, string asunto, string cuerpo) 
        {
            _email = new MailMessage();
            _email.From = new MailAddress("programationiii@gmail.com");
            _email.To.Add(emailDestino);
            _email.Subject = asunto;
            _email.IsBodyHtml = true;
            _email.Body = $"<h1>Prueba mail<h1><br> Prueba desde la pokedex. El mensaje es: {cuerpo}";
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
