using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3___SIM.Formularios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnDisUniforme_Click(object sender, EventArgs e)
        {
            Formularios.DisUniforme ventana = new Formularios.DisUniforme();
            ventana.Show();
        }

        private void btnDisExponencial_Click(object sender, EventArgs e)
        {
            Formularios.DisExponencial ventana = new Formularios.DisExponencial();
            ventana.Show();
        }

        private void btnDisNormal_Click(object sender, EventArgs e)
        {
            Formularios.DisNormal ventana = new Formularios.DisNormal();
            ventana.Show();
        }
    }
}
