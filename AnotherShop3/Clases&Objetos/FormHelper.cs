using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace AnotherShop3.Clases_Objetos
{
    internal class FormHelper
    {
        private static Stack<Form> formHistory = new Stack<Form>();

        public static void AbrirFormEnPanel(Panel panel, Form formHija)
        {
            if (panel.Controls.Count > 0)
            {
                formHistory.Push((Form)panel.Controls[0]);
                panel.Controls.RemoveAt(0);
            }
            formHija.TopLevel = false;
            formHija.Dock = DockStyle.Fill;
            panel.Controls.Add(formHija);
            panel.Tag = formHija;
            formHija.Show();
        }

        public static void RegresarAFormAnterior(Panel panel)
        {
            if (formHistory.Count > 0)
            {
                Form formAnterior = formHistory.Pop();
                panel.Controls.Clear();
                panel.Controls.Add(formAnterior);
                panel.Tag = formAnterior;
                formAnterior.Show();
            }
        }

        public static void RegresarAFormAnterior(Form formularioPrincipal)
        {
            if (formHistory.Count > 0)
            {
                Form formAnterior = formHistory.Pop();
                Panel panelPrincipal = formularioPrincipal.Controls.OfType<Panel>().FirstOrDefault();
                if (panelPrincipal != null)
                {
                    panelPrincipal.Controls.Clear();
                    panelPrincipal.Controls.Add(formAnterior);
                    panelPrincipal.Tag = formAnterior;
                    formAnterior.Show();
                }
            }
        }
    }
}
