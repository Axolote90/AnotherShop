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
    public partial class frmDesarrollador : Form
    {
        public frmDesarrollador()
        {
            InitializeComponent();
        }

        private void btnLimpiarDataBase_Click(object sender, EventArgs e)
        {
            UsersLogica.Instancia.EliminarTodosLosDatos();
            mostrar_Datos();

        }

        private void btnActualizarDataBase_Click(object sender, EventArgs e)
        {
            mostrar_Datos();
        }

        public void mostrar_Datos()
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource = UsersLogica.Instancia.Listar();
        }
    }
}
