using System;
using System.Windows.Forms;

namespace AnotherShop3
{
    public partial class frmIniciador : Form
    {
        private int Time = 14;

        public frmIniciador()
        {
            InitializeComponent();

            ProgressBar.Start();
        }

        private void ProgressBar_Tick(object sender, EventArgs e)
        {
            Time -= 1;

            if (Time <= 0)
            {
                ProgressBar.Stop();
                this.Close();
            }

            switch (Time)
            {
                case 13:
                    lbCarga.Text = "Abriendo Aplicacion";
                    break;
                case 12:
                    lbCarga.Text = "Llamando Proveedores";
                    break;
                case 6:
                    lbCarga.Text = "Rechazando Demandas";
                    break;
                case 9:
                    lbCarga.Text = "Evadiendo impuestos";
                    break;
            }

            if (Time == 1)
            {
                var formulario = new frmMain();
                formulario.Owner = this;
                formulario.Show();
            }

            pbCarga.PerformStep();
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}