using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3___SIM.Logica;

namespace TP3___SIM.Formularios
{
    public partial class DisUniforme : Form
    {
        private readonly GeneradorAleatorios oGeneradorAleatorios;
        public DisUniforme()
        {
            InitializeComponent();
            oGeneradorAleatorios = new GeneradorAleatorios();
        }

        private void DisUniforme_Load(object sender, EventArgs e)
        {
            cbo_cantIntervalos.Enabled = false;
            btnGraficar.Enabled = false;
            lblChi.Text = "";
        }

        private bool ValidarCampos()
        {
            if (txtCantidad.Text == "")
            {
                return false;
            }
            return true;
        }


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            dgvNumerosAleatorios.Rows.Clear();
            int cantidad;
            int limInf = 0;
            int limSup = 0;

            if (ValidarCampos())
            {
                limInf = int.Parse(txtLimInf.Text);
                limSup = int.Parse(txtLimSup.Text);
                cantidad = int.Parse(txtCantidad.Text);

                List<double> numeros = new List<double>();


                //ESTA ES LA LLAMADA AL METODO DE GENERAR ALEATORIOS
                //HAY QUE SOLUCIONAR EL GENERAR NUMEROS ALEATORIOS, HACER UNA LISTA E ITERAR SOBRE ELLA PARA HACER LAS OPERACIONES
                //Hay otras soluciones con problemas

                int contador = 0;
                numeros = oGeneradorAleatorios.generadorUniforme(limInf, limSup, cantidad);

                foreach (double n in numeros)
                {
                    contador += 1;
                    dgvNumerosAleatorios.Rows.Add(contador, n);
                }

                cbo_cantIntervalos.Enabled = true;
                btnGraficar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe completar los parametros requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_graficar_Click(object sender, EventArgs e)
        {
            dgwJiCuadrado.Rows.Clear();

            int numIntervalos = 0;
            double acumEstadisticoPrueba = 0;
            Intervalo[] intervalos;


            if (cbo_cantIntervalos.SelectedIndex != -1)
            {
                numIntervalos = Convert.ToInt32(cbo_cantIntervalos.SelectedItem);
                //GestorIntervalo oGestorIntervalo = new GestorIntervalo(oGeneradorAleatorios.Numeros,oGeneradorAleatorios.Min,oGeneradorAleatorios.Max);

                //Crep un gestor de intervalos, pasandole como parametro la lista de numeros aleatorios que es un atributo del generador de aleatorios que usamos 
                GestorIntervalo oGestorIntervalo = new GestorIntervalo(oGeneradorAleatorios.Numeros);

                intervalos = oGestorIntervalo.armarIntervalos(numIntervalos);

                //Generacion grafico
                List<int> listaEnteros = new List<int>();
                histogramaGenerado.Series.Clear();
                histogramaGenerado.Series.Add("Frecuecias Observadas");
                histogramaGenerado.Series.Add("Frecuencias Esperadas");

                for (int i = 0; i < numIntervalos; i++)
                {
                    listaEnteros.Add(intervalos[i].FrecuenciaObservada);
                    histogramaGenerado.Series[0].Points.AddXY(i, intervalos[i].FrecuenciaObservada);
                    histogramaGenerado.Series[0].Points[i].AxisLabel = "[" + intervalos[i].Desde + " - " + intervalos[i].Hasta + "]";
                    histogramaGenerado.Series[0].IsValueShownAsLabel = true;
                    histogramaGenerado.Series[1].Points.AddXY(i, intervalos[i].FrecuenciaEsperada);
                    histogramaGenerado.Series[1].Points[i].AxisLabel = "[" + intervalos[i].Desde + " - " + intervalos[i].Hasta + "]";
                    histogramaGenerado.Series[1].IsValueShownAsLabel = true;

                    EstadisticoPrueba jiCuadrado = new EstadisticoPrueba();
                    double c = Math.Round((jiCuadrado.calEstadisticoPrueba(intervalos[i].FrecuenciaEsperada, intervalos[i].FrecuenciaObservada)), 2);
                    acumEstadisticoPrueba += c;
                    dgwJiCuadrado.Rows.Add("[" + intervalos[i].Desde + " - " + intervalos[i].Hasta + "]", intervalos[i].FrecuenciaObservada, intervalos[i].FrecuenciaEsperada, c, Math.Round(acumEstadisticoPrueba, 2));
                }

                lblChi.Text = acumEstadisticoPrueba.ToString();

                int gradosLibertad = numIntervalos - 1;

                histogramaGenerado.ChartAreas[0].AxisY.Maximum = listaEnteros.Max();

                btnGraficar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la cantidad de Intervalos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
