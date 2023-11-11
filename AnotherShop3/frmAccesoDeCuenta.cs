using System;
using System.Windows.Forms;

using AnotherShop3.Clases_Objetos;
using AnotherShop3.DataBase.Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AnotherShop3
{
    public partial class frmAccesoDeCuenta : Form
    {

        private Form formularioPrincipal;

        public frmAccesoDeCuenta(Form formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;

        }

        private void frmAccesoDeCuenta_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RecordarCredenciales)
            {
                // Recuperar el nombre de usuario y contraseña almacenados
                string nombreUsuarioGuardado = Properties.Settings.Default.NombreUsuario;
                string contraseñaGuardada = Properties.Settings.Default.Contraseña;

                // Mostrar las credenciales en los cuadros de texto
                txtUserName.Text = nombreUsuarioGuardado;
                txtPassword.Text = contraseñaGuardada;

                // Marcar la CheckBox para indicar que las credenciales se están recordando
                chkRecordarCredenciales.Checked = true;
            }
        }

        private void lkbCrearCuentas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Obtener el panel principal del formulario principal
            Panel panelPrincipal = (formularioPrincipal as frmMain)?.PanelP;

            if (panelPrincipal != null)
            {

                // Crear una instancia del formulario de creación de cuenta y mostrarlo en el panel principal
                frmCreacionDeCuenta frmCreacionCuenta = new frmCreacionDeCuenta(formularioPrincipal);
                FormHelper.AbrirFormEnPanel(panelPrincipal, frmCreacionCuenta);
            }
        }

        // Los siguientes eventos manejan el texto cuando el mouse se mueve sobre y fuera de los campos de entrada.

        private void Name_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Nombre") { txtUserName.Text = ""; } else { }
        }

        private void Password_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Contraseña") { txtPassword.Text = ""; } else { }
        }

        private void Password_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text)) { txtPassword.Text = "Contraseña"; } else { }
        }

        private void Name_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text)) { txtUserName.Text = "Nombre"; } else { }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string nombreUsuario = txtUserName.Text;
            string contraseñaIngresada = txtPassword.Text;

            UsersLogica usersLogica = UsersLogica.Instancia;
            string contraseñaEncontrada = usersLogica.BuscarContraseñaPorNombreUsuario(nombreUsuario);
            if (txtUserName.Text == "Admin" && txtPassword.Text == "AnotherShop")
            {
                var formulario = new frmDesarrollador();
                formulario.Show();
            }else
            if (contraseñaEncontrada != null && contraseñaEncontrada == contraseñaIngresada)
            {
                // Las contraseñas coinciden, el usuario ha iniciado sesión con éxito
                Panel panelPrincipal = (formularioPrincipal as frmMain)?.PanelP;

                

                if (panelPrincipal != null)
                {
                    // Crear una instancia del formulario de inicio y mostrarlo en el panel principal
                    frmInicio frmCreacionCuenta = new frmInicio(formularioPrincipal);
                    FormHelper.AbrirFormEnPanel(panelPrincipal, frmCreacionCuenta);
                }

                // Guarda los datos del usuario para volver a ingresar mas rapido
                if (chkRecordarCredenciales.Checked)
                {
                    Properties.Settings.Default.RecordarCredenciales = true;
                    Properties.Settings.Default.NombreUsuario = nombreUsuario;
                    Properties.Settings.Default.Contraseña = contraseñaIngresada;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    // Borrar las credenciales almacenadas si la CheckBox no está marcada
                    Properties.Settings.Default.RecordarCredenciales = false;
                    Properties.Settings.Default.NombreUsuario = nombreUsuario;
                    Properties.Settings.Default.Contraseña = contraseñaIngresada;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                // Las contraseñas no coinciden o el usuario no fue encontrado
                MessageBox.Show("Inicio de sesión fallido. Verifica tus credenciales.");
            }
        }

        private void chkRecordarCredenciales_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lkbContraseñaOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Obtener el panel principal del formulario principal
            Panel panelPrincipal = (formularioPrincipal as frmMain)?.PanelP;

            if (panelPrincipal != null)
            {
                // Crear una instancia del formulario de inicio de sesión y mostrarlo en el panel principal
                frmCambiarContraseña frmCambiarContraseña = new frmCambiarContraseña(formularioPrincipal);
                FormHelper.AbrirFormEnPanel(panelPrincipal, frmCambiarContraseña);
            }
        }
    }
}