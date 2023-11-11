using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace AnotherShop3
{
    public partial class frmVerificarCorreo : Form
    {
        public frmVerificarCorreo()
        {
            InitializeComponent();
        }

        private void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("AnothesShopHub@gmail.com");
                mensaje.To.Add(destinatario);
                mensaje.Subject = asunto;
                mensaje.Body = cuerpo;

                SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
                clienteSmtp.Port = 587;
                clienteSmtp.Credentials = new NetworkCredential("AnothesShopHub@gmail.com", "AnotherShop2257");
                clienteSmtp.EnableSsl = true;

                clienteSmtp.Send(mensaje);

                MessageBox.Show("Correo enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
