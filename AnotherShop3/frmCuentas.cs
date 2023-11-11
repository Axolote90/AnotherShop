using AnotherShop3.Clases_Objetos;
using AnotherShop3.DataBase.Logica;
using AnotherShop3.DataBase.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherShop3
{
    public partial class frmCuentas : Form
    {
        private Form formularioPrincipal;
        public int idUsuario;
        public Image FotoPerfil;
        public Image FotoPerfilNueva;
        public frmCuentas(Form formularioPrincipal)
        {
            InitializeComponent();

            this.formularioPrincipal = formularioPrincipal;

            string nombreUsuarioGuardado = Properties.Settings.Default.NombreUsuario;
            
            idUsuario = UsersLogica.Instancia.ObtenerIDPorNombreUsuario(nombreUsuarioGuardado);
            FotoPerfil = UsersLogica.Instancia.ObtenerImagenPorID(idUsuario);

            // Llamar al método ObtenerPorID para obtener el usuario por su ID
            UsersLogica usersLogica = UsersLogica.Instancia;
            Users usuario = usersLogica.ObtenerPorID(idUsuario);

            if (usuario != null)
            {
                // Acceder al nombre de usuario y establecerlo en la etiqueta
                txtNombre.Text = usuario.UserName;
                txtCorreo.Text = usuario.Mail;
                txtContraseña.Text = "*********";
                txtTelefono.Text = usuario.Phone;

                if (FotoPerfil != null)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = FotoPerfil;
                }
                
            }
            else
            {
                // Si no se encontró el usuario, puedes mostrar un mensaje de error o limpiar la etiqueta.
                txtNombre.Text = "Usuario no encontrado";
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Load(openFileDialog1.FileName);

                    // Asignar la imagen seleccionada a FotoPerfilNueva
                    FotoPerfilNueva = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, registrándola en un logger
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void GuardarImagenEnBaseDeDatos()
        {
            try
            {
                // Verificar si se seleccionó una imagen antes de intentar guardarla
                if (FotoPerfilNueva != null)
                {
                    // Guardar la imagen en la base de datos
                    UsersLogica.Instancia.GuardarImagen(idUsuario, FotoPerfilNueva);

                    // Limpiar la variable después de guardarla si es necesario
                    FotoPerfilNueva = null;
                }
                else
                {
                    MessageBox.Show("Seleccione una imagen antes de intentar guardarla.");
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, registrándola en un logger
                MessageBox.Show("Error al guardar la imagen en la base de datos: " + ex.Message);
            }
        }

        private void btnAplicarCambiosCuenta_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Rellena todos los Datos");
            }
            else
            {
                if (txtNombre.Text == "Nombre" || txtCorreo.Text == "Correo" || txtTelefono.Text == "Telefono")
                {

                }
                else
                {
                    Users Usuario = new Users()
                    {
                        UserName = txtNombre.Text,

                        Mail = txtCorreo.Text,
                        Phone = txtTelefono.Text
                    };
                    GuardarImagenEnBaseDeDatos();
                    UsersLogica.Instancia.EditarPorID(idUsuario, Usuario);
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
