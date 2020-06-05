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

        private string compareRandom(double random, List<double> probAcumulada)
        {
            for (int i = 0; i < probAcumulada.Count(); i++)
            {
                if (random < probAcumulada.ElementAt(i))
                {
                    if (i == 0)
                    {
                        return "Comprar";
                    }
                    else if (i == 1)
                    {
                        return "Entregar Reloj";
                    }
                    else if (i == 2)
                    {
                        return "Retirar Reloj";
                    }
                }
            }
            return "";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            double tiempo = oDatos.Tiempo;
            int iteraciones = oDatos.Iteraciones;

            int desde = oDatos.Desde;
            double hasta = oDatos.Hasta;

            double llegClienteA = oDatos.LlegClienteA;
            double llegClienteB = oDatos.LlegClienteB;

            double tiempoVentaA = oDatos.TiempoVentaA;
            double tiempoVentaB = oDatos.TiempoVentaB;

            double tiempoRepA = oDatos.TiempoRepA;
            double tiempoRepB = oDatos.TiempoRepB;

            double tiempoRepIni = oDatos.TiempoRelojero;

            List<double> probAcumulada = new List<double>(oDatos.DistProbDestino);
        }
    }
}
