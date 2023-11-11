using AnotherShop3.Clases_Objetos;
using System;
using System.Windows.Forms;

using AnotherShop3.DataBase;
using AnotherShop3.DataBase.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using AnotherShop3.DataBase.Logica;

namespace AnotherShop3
{
    public partial class frmCreacionDeCuenta : Form
    {
        private Form formularioPrincipal;
        public frmCreacionDeCuenta(Form formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
            mtxtTel.Mask = "";
            mtxtTel.Text = "Telefono";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Nombre = txtUserName.Text;
            string Correo = txtMail.Text;
            string Telefono = mtxtTel.Text;
            string Contraseña = txtPassword.Text;
            string Tienda = "false";

            if (txtUserName.Text == "Nombre" || txtMail.Text == "Correo" || txtPassword.Text == "Contraseña" || mtxtTel.Text == "")
            {
                MessageBox.Show("Rellene todos Los datos");
            }
            else
            {
                if (UsersLogica.Instancia.ExisteNombreUsuario(txtUserName.Text) == true)
                {
                    MessageBox.Show("El nombre de usuario ya esta ocupado");
                }
                else
                {
                    if (IsValidEmail(txtMail.Text))
                    {
                        Users Usuario = new Users()
                        {
                            UserName = Nombre,
                            Password = Contraseña,
                            Mail = Correo,
                            Phone = Telefono,
                            Tienda = Tienda
                        };

                        bool respuesta = UsersLogica.Instancia.Guardar(Usuario);

                        // Obtener el panel principal del formulario principal
                        Panel panelPrincipal = (formularioPrincipal as frmMain)?.PanelP;

                        if (panelPrincipal != null)
                        {

                            frmAccesoDeCuenta frmInicio = new frmAccesoDeCuenta(formularioPrincipal);
                            FormHelper.AbrirFormEnPanel(panelPrincipal, frmInicio);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una dirección de correo válida (Gmail, Hotmail u Outlook).");
                    }
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            // Utilizamos una expresión regular para verificar si la dirección de correo contiene los dominios deseados
            string pattern = @"@(gmail\.com|hotmail\.com|outlook\.com)$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }

        private void lkbIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        // Los siguientes eventos manejan el texto cuando el mouse se mueve sobre y fuera de los campos de entrada.
        private void Name_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Nombre") { txtUserName.Text = ""; } else { }
        }

        private void Name_MouseLeaave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text)) { txtUserName.Text = "Nombre"; } else { }
        }

        private void Mail_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtMail.Text == "Correo") { txtMail.Text = ""; } else { }
        }

        private void Mail_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMail.Text)) { txtMail.Text = "Correo"; } else { }
        }

        private void Tel_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtTel.Text == "Telefono") { txtTel.Text = ""; } else { }
        }

        private void Tel_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTel.Text)) { txtTel.Text = "Telefono"; } else { }
        }

        private void Password_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Contraseña") { txtPassword.Text = ""; } else { }
        }

        private void Passwor_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text)) { txtPassword.Text = "Contraseña"; } else { }
        }

        private void mtxtTel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mtxtTel.Text == "Telefono")
            {
                mtxtTel.Text = "";
                mtxtTel.Mask = "+000-000-0000";
            }
        }

        private void mtxtTel_MouseLeave(object sender, EventArgs e)
        {
            if (mtxtTel.Text == "+   -   -")
            {
                mtxtTel.Mask = "";
                mtxtTel.Text = "Telefono";
            }
        }
    }
}
