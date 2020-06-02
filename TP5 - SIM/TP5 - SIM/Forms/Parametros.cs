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
    public partial class Parametros : Form
    {
        Datos oDatos = new Datos();

        public Parametros(Datos datos)
        {
            InitializeComponent();
            oDatos = datos;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            double tiempo = double.Parse(txtTiempo.Text);
            int iteraciones = int.Parse(txtIteraciones.Text);

            int desde = int.Parse(txtDesde.Text);
            double hasta = double.Parse(txtHasta.Text);

            double llegClienteA = double.Parse(txtLlegadaA.Text);
            double llegClienteB = double.Parse(txtLlegadaB.Text);

            double tiempoVentaA = double.Parse(txtTiempoVentaA.Text);
            double tiempoVentaB = double.Parse(txtTiempoVentaB.Text);

            double tiempoRepA = double.Parse(txtTiempoRepA.Text);
            double tiempoRepB = double.Parse(txtTiempoRepB.Text);

            double tiempoRepIni = double.Parse(txtInicialRep.Text);

            List<double> probAcumulada = new List<double>();

            double aux = 0;

            for (int i = 0; i < dgvDistDestinoCliente.Rows.Count; i++)
            {
                aux = Convert.ToDouble(dgvDistDestinoCliente.Rows[i].Cells[2].Value);

                probAcumulada.Add(aux);
            }

            oDatos.CargarDatos(tiempo, iteraciones, desde, hasta, probAcumulada, llegClienteA, llegClienteB, tiempoVentaA, tiempoVentaB, tiempoRepA, tiempoRepB, tiempoRepIni);
        }
    }
}
