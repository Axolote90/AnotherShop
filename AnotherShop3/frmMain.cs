using System;
using System.Windows.Forms;
using AnotherShop3.Clases_Objetos; // Importa clases y objetos de AnotherShop3
using System.Runtime.InteropServices; // Importa funciones de la DLL user32
using System.Drawing;

//@Joshua si la gente del congo tuviera tus oportunidades estaría graduado de las mejores universidades
namespace AnotherShop3
{
    public partial class frmMain : Form
    {
        public Panel PanelP;
        

        public frmMain()
        {
            InitializeComponent();
            PanelP = PanelPrincipal;
            
            

            var formularioHijo1 = new frmAccesoDeCuenta(this);
            var formularioHijo2 = new frmCreacionDeCuenta(this);
            var formularioHijo3 = new frmCuentas(this);

            FormHelper.AbrirFormEnPanel(PanelP, formularioHijo1);

            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MoverVentana()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximizer_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void btnMinimizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana();
        }

        private int animationDuration = 500; // Duración de la animación en milisegundos
        private int animationSteps = 40;     // Número de pasos de animación

        private int currentStep = 0;

 
        private void MinimizarTimer_Tick(object sender, EventArgs e)
        {
            if (currentStep < animationSteps)
            {
                double progress = (double)currentStep / animationSteps;

                // Calcula el tamaño y la posición de la ventana en función del progreso
                //int newWidth = (int)(this.Width - (this.Width * progress));
                int newHeight = (int)(this.Height - (this.Height * progress));

                this.Size = new Size(this.Width, newHeight);

                currentStep++;
            }
            else
            {
                // La animación ha finalizado, minimiza la ventana
                this.WindowState = FormWindowState.Minimized;
                MinimizarTimer.Stop();
                currentStep = 0;
            }
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}