using AnotherShop3.Clases_Objetos;
using AnotherShop3.DataBase.Logica;
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
    public partial class frmAjustes : Form
    {
        private Form formularioPrincipal;

        
        public frmAjustes(Form formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }
        
        // Boton de modo oscuro
        private void btnModo_Click(object sender, EventArgs e)
        {
            CambiarModoVisual();
        }

        private void CambiarModoVisual()
        {
            if (this.BackColor == SystemColors.Control)
            {
                // Cambiar a modo oscuro
                this.BackColor = Color.FromArgb(30, 30, 30);
                // Ajustar otros elementos visuales para el modo oscuro
                panel1.BackColor = Color.FromArgb(40, 40, 40);
                panel2.BackColor = Color.FromArgb(80, 80, 80);
                panel2.ForeColor = Color.Black;
            }
            else
            {
                // Cambiar a modo claro
                this.BackColor = SystemColors.Control; // Puedes ajustar este color según tus preferencias
                // Restaurar otros elementos visuales al modo claro
                panel1.BackColor = SystemColors.Control;
                panel2.BackColor = SystemColors.Control;
            }
        }


        private void btnReportarBug_Click(object sender, EventArgs e)
        {
            Panel panelPrincipal = (formularioPrincipal as frmMain)?.PanelP;

            if (panelPrincipal != null)
            {

                // Crear una instancia del formulario de inicio de sesión y mostrarlo en el panel principal
                frmReportBug frmReportBug = new frmReportBug(formularioPrincipal);
                FormHelper.AbrirFormEnPanel(panelPrincipal, frmReportBug);
            }
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            string nombreUsuarioGuardado = Properties.Settings.Default.NombreUsuario;

            int idUsuario = UsersLogica.Instancia.ObtenerIDPorNombreUsuario(nombreUsuarioGuardado);

            UsersLogica.Instancia.EliminarPorID(idUsuario);

            // Obtener el panel principal del formulario principal
            Panel panelPrincipal = (formularioPrincipal as frmMain)?.PanelP;

            if (panelPrincipal != null)
            {

                // Crear una instancia del formulario de inicio de sesión y mostrarlo en el panel principal
                frmAccesoDeCuenta frmCreacionCuenta = new frmAccesoDeCuenta(formularioPrincipal);
                FormHelper.AbrirFormEnPanel(panelPrincipal, frmCreacionCuenta);
            }
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {

        }

        private void btnSugerencia_Click(object sender, EventArgs e)
        {
            Panel panelPrincipal = (formularioPrincipal as frmMain)?.PanelP;

            if (panelPrincipal != null)
            {

                // Crear una instancia del formulario de inicio de sesión y mostrarlo en el panel principal
                frmSugerencia frmSugerencia = new frmSugerencia(formularioPrincipal);
                FormHelper.AbrirFormEnPanel(panelPrincipal, frmSugerencia);
            }
        }

        
    }
}
