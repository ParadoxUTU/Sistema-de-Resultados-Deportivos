using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace SistemaResultadosDeportivos.Logica
{
    public class Correos
    {
        public void enviarCorreo(string correo, string contrasena)
        {
            bool exito = false;
            /*while (!exito)
            {*/
                try
                {
                    using (MailMessage mailMessage = new MailMessage())
                    {
                        mailMessage.To.Add(correo);
                        mailMessage.Subject = "Cambiar contraseña";
                        mailMessage.Body = "Nueva contraseña: " + contrasena;
                        mailMessage.IsBodyHtml = false;
                        mailMessage.From = new MailAddress("noreply@gmail.com", "cambiar contraseña");
                        using (SmtpClient cliente = new SmtpClient())
                        {
                            cliente.UseDefaultCredentials = false;
                            cliente.Credentials = new NetworkCredential("paradoxsoftwaresoporte@gmail.com", "ipfdshybzchdjnhg");
                            cliente.Port = 587;
                            cliente.EnableSsl = true;
                            cliente.Host = "smtp.gmail.com";
                            cliente.Send(mailMessage);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            //}
        }
    }
}
