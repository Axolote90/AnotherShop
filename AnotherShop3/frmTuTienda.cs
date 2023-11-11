using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnotherShop3.DataBase.Logica;

namespace AnotherShop3
{
    public partial class frmTuTienda : Form
    {
        private Form formularioPrincipal;
        public frmTuTienda(Form formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private void btnCrearTienda_Click(object sender, EventArgs e)
        {
            UsersLogica.Instancia.CrearNuevaTabla();
            UsersLogica.Instancia.InsertarDescripcionEnShop(txtDescripcion.Text);
        }

        private void lkbIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
