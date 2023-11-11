using AnotherShop3.Clases_Objetos;
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
    public partial class frmInicio : Form
    {
        private Form formularioPrincipal;
        public Panel panelC;
        public frmInicio(Form formularioPrincipal)
        {
            panelC = PanelContenedor;
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private void btnTusTiendas_Click(object sender, EventArgs e)
        {
                // Crear una instancia del formulario de inicio de sesión y mostrarlo en el panel principal
                frmTuTienda frmTuTienda = new frmTuTienda(formularioPrincipal);
                FormHelper.AbrirFormEnPanel(PanelContenedor, frmTuTienda);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
                // Crear una instancia del formulario de inicio de sesión y mostrarlo en el panel principal
                frmCuentas frmCuentas = new frmCuentas(formularioPrincipal);
                FormHelper.AbrirFormEnPanel(PanelContenedor, frmCuentas);

            
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
                // Crear una instancia del formulario de inicio de sesión y mostrarlo en el panel principal
                frmAjustes frmAjustes = new frmAjustes(formularioPrincipal);
                FormHelper.AbrirFormEnPanel(PanelContenedor, frmAjustes);
        }

        private void btnTiendas_Click(object sender, EventArgs e)
        {
                frmTiendas frmTiendas = new frmTiendas(formularioPrincipal);
                FormHelper.AbrirFormEnPanel(PanelContenedor, frmTiendas);
            
        }
    }
}
