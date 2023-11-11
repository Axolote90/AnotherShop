﻿using AnotherShop3.Clases_Objetos;
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
    
    public partial class frmSugerencia : Form
    {
        private Form formularioPrincipal;
        public frmSugerencia(Form formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private void btnEnviarSugerencia_Click(object sender, EventArgs e)
        {
            Panel panelPrincipal = (formularioPrincipal as frmMain)?.PanelP;

            if (panelPrincipal != null)
            {
                // Crear una instancia del formulario de inicio y mostrarlo en el panel principal
                frmInicio frmCreacionCuenta = new frmInicio(formularioPrincipal);
                FormHelper.AbrirFormEnPanel(panelPrincipal, frmCreacionCuenta);
            }
        }

        private void FotoSugerencia_Click(object sender, EventArgs e)
        {

        }
    }
}
