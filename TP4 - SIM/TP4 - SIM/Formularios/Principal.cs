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
        private TP4___SIM.Logica.Generador oGenerador = new Logica.Generador();

        List<double> probAcumulada = new List<double>();

        public Principal()
        {
            InitializeComponent();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int cantidadVuelos;
            int Desde;
            int Hasta;
            double gananciaPasajero;
            double costoReprog;
            int estrategia;
            

            double aux = 0;
            

            cantidadVuelos = int.Parse(txtNroVuelos.Text);
            Desde = int.Parse(txtDesde.Text);
            Hasta = int.Parse(txtHasta.Text);
            gananciaPasajero = int.Parse(txtGanancia.Text);
            costoReprog = int.Parse(txtCosto.Text);
            estrategia = int.Parse(cmbEstrategia.SelectedItem.ToString());


            //Calculo de prob acumuladas guardando en la lista probAcumulada
            for (int i = 0; i < dgv_probabilidades.Rows.Count; i++)
            {
                aux = Convert.ToDouble(dgv_probabilidades.Rows[i].Cells[2].Value);

                probAcumulada.Add(aux);
            }

            double GananciaAcumulada = 0;

            for (int i = 0; i < cantidadVuelos; i++)
            {
                int NroVuelo = i + 1;

                double RNDAsistencia = Math.Truncate(oGenerador.generadorUniforme() * 10000) / 10000;

                int Asistencias = compareRandom(RNDAsistencia, probAcumulada);

                int Inasistencias;
                int CantPasajeros;
                int PasajerosReprogramados;

                if (Asistencias > 30)
                {
                    Inasistencias = 0;
                    CantPasajeros = 30;
                    PasajerosReprogramados = Asistencias - 30;
                }
                else
                {
                    Inasistencias = 30 - Asistencias;
                    CantPasajeros = Asistencias;
                    PasajerosReprogramados = 0;
                }

                double GananciaVuelo = Math.Round((CantPasajeros * gananciaPasajero), 2);

                double CostoReprog = Math.Round((PasajerosReprogramados * costoReprog), 2);

                double GananciaNeta = GananciaVuelo - CostoReprog;

                GananciaAcumulada += GananciaNeta;

                if (NroVuelo >= Desde && NroVuelo <= Hasta)
                {
                    dgvMonteCarlo.Rows.Add(NroVuelo, RNDAsistencia, Asistencias, Inasistencias, CantPasajeros, PasajerosReprogramados, GananciaVuelo, CostoReprog, GananciaNeta, GananciaAcumulada);
                }
            }

            double GananciaPromedio = Math.Round((GananciaAcumulada / (double)cantidadVuelos), 2);

            txtGananciaProm.Text = GananciaPromedio.ToString();
        }


        private int compareRandom(double random, List<double> probAcumulada)
        {
            int j = 28;

            for (int i = 0; i < probAcumulada.Count(); i++)
            {
                if (random < probAcumulada.ElementAt(i))
                {
                    return j;
                }

                j++;
            }
            return j;
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

        private void dgv_probabilidades_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double aux = 0;

            for (int i = 0; i < dgv_probabilidades.Rows.Count; i++)
            {
                aux += Convert.ToDouble(dgv_probabilidades.Rows[i].Cells[1].Value.ToString());

                if (aux > 1)
                {
                    MessageBox.Show("La suma de las probabilidades no debe ser mayor a 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    dgv_probabilidades.Rows[i].Cells[2].Value = aux;
                }
            }
        }

        private void dgv_probabilidades_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dgv_probabilidades.Rows[e.RowIndex].ErrorText = "";
            double newDouble;

            if (dgv_probabilidades.Rows[e.RowIndex].IsNewRow) { return; }
            if (!double.TryParse(e.FormattedValue.ToString(),
                out newDouble) || newDouble < 0)
            {
                dgv_probabilidades.Rows[e.RowIndex].ErrorText = "El valor ingresado debe ser un double mayor a 0";

                e.Cancel = true;
            }
        }
    }
}
