using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4___SIM
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int cantidadVuelos;
            int Desde;
            int Hasta;
            int gananciaPasajero;
            int costoReprog;
            int estrategia;

            cantidadVuelos = int.Parse(txtNroVuelos.Text);
            Desde = int.Parse(txtDesde.Text);
            Hasta = int.Parse(txtHasta.Text);
            gananciaPasajero = int.Parse(txtGanancia.Text);
            costoReprog = int.Parse(txtCosto.Text);
            estrategia = int.Parse(cmbEstrategia.SelectedItem.ToString());
        }


        private void cmbEstrategia_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_probabilidades.Rows.Clear();
            int estrategia;
            estrategia = int.Parse(cmbEstrategia.SelectedItem.ToString());

            for (int i = 28; i <= estrategia; i++)
            {
                dgv_probabilidades.Rows.Add(i, 0);
            }
        }
    }
}
