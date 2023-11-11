using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnotherShop3.DataBase.Logica;
using AnotherShop3.DataBase.Modelo;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using AnotherShop3.Clases_Objetos;

//@Joshua si la gente del congo tuviera tus oportunidades estaría graduado de las mejores universidades
namespace AnotherShop3
{
    public partial class frmCambiarContraseña : Form
    {
        private Form formularioPrincipal;

        private int idUsuario;
        public frmCambiarContraseña(Form formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;

            string nombreUsuarioGuardado = Properties.Settings.Default.NombreUsuario;

            idUsuario = UsersLogica.Instancia.ObtenerIDPorNombreUsuario(nombreUsuarioGuardado);
        }

        public int CodigoVerificacion;
        
        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            string Destinatario = txtCorreo.Text;

            // Crea una instancia de la clase Random
            Random rand = new Random();

            // Genera un número aleatorio de 4 cifras
            do
            {
                CodigoVerificacion = rand.Next(10000);
            } while (CodigoVerificacion < 1000);

            SmtpClient smtp = null; // Declarar la variable fuera del bloque using

            try
            {
                if (txtCorreo.Text != "")
                {
                    if (IsValidEmail(Destinatario))
                    {
                        var email = new MimeMessage();

                        email.From.Add(new MailboxAddress("AnotherShop", "AnotherShop@outlook.es"));
                        email.To.Add(new MailboxAddress("Usuario", Destinatario));

                        email.Subject = "Codigo de Verificacion";
                        email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
                        {
                            Text = "Tu código para cambiar contraseña es el siguiente:" + CodigoVerificacion.ToString()
                        };

                        smtp = new SmtpClient(); // Inicializar smtp fuera del bloque using

                        smtp.Connect("smtp.office365.com", 587, false);

                        // Note: only needed if the SMTP server requires authentication
                        smtp.Authenticate("AnotherShop@outlook.es", "Mayoneza-1");

                        smtp.Send(email);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una dirección de correo válida (Gmail, Hotmail u Outlook).");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una dirección de correo válida (Gmail, Hotmail u Outlook).");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de correo electrónico no válido: " + ex.Message);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show("Error al enviar el correo electrónico: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
            finally
            {
                // Liberar recursos aquí, por ejemplo, desconectar el cliente SMTP
                if (smtp != null && smtp.IsConnected)
                {
                    smtp.Disconnect(true);
                }
            }

        }

        private bool IsValidEmail(string email)
        {
            // Utilizamos una expresión regular para verificar si la dirección de correo contiene los dominios deseados
            string pattern = @"@(gmail\.com|hotmail\.com|outlook\.com)$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {          
            if(txtCodigoVerificacion.Text == CodigoVerificacion.ToString())
            {
                if (txtContraseña.Text == "")
                {
                    MessageBox.Show("Rellena todos los Datos");
                }
                else
                {
                    
                    Users Usuario = new Users()
                    {
                        Password = txtContraseña.Text
                    };

                    UsersLogica.Instancia.EditarContraseñaPorID(idUsuario, Usuario);

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Obtener el panel principal del formulario principal
            Panel panelPrincipal = (formularioPrincipal as frmMain)?.PanelP;

            if (panelPrincipal != null)
            {

                // Crear una instancia del formulario de inicio de sesión y mostrarlo en el panel principal
                frmAccesoDeCuenta frmCreacionCuenta = new frmAccesoDeCuenta(formularioPrincipal);
                FormHelper.AbrirFormEnPanel(panelPrincipal, frmCreacionCuenta);
            }
        }
    }
}
