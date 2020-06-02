using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP5___SIM.Clases;

namespace TP5___SIM
{
    public partial class Principal : Form
    {
        public double tiempo;
        public int iteraciones;

        Datos oDatos = new Datos();

        public Principal()
        {
            InitializeComponent();
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            Parametros parametros = new Parametros(oDatos);
            parametros.Show();
        }

        public void CargarDatos(double tiempo, int iteraciones)
        {
            this.tiempo = tiempo;
            this.iteraciones = iteraciones;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            double time = oDatos.Tiempo;
            int it = oDatos.Iteraciones;


        }
    }
}
