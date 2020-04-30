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
    public partial class DisNormal : Form
    {
        double media;
        double desviacion;

        private readonly GeneradorAleatorios oGeneradorAleatorios;

        public DisNormal()
        {
            InitializeComponent();

            oGeneradorAleatorios = new GeneradorAleatorios();
            cbo_cantIntervalos.Enabled = false;
            btnGraficar.Enabled = false;
            lblChi.Text = "";
        }      


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            dgvNumerosAleatorios.Rows.Clear();
            int cantidad;
            media = 0;
            desviacion = 0;

            if (ValidarCampos())
            {
                cantidad = int.Parse(txtCantidad.Text);
                media = double.Parse(txtMedia.Text);
                desviacion = double.Parse(txtDesviacion.Text);

                List<double> lista = oGeneradorAleatorios.generadorNormal(cantidad, media, desviacion);
               
                int i = 0;
                foreach (double aleatorio in lista)
                {
                    i++;
                    dgvNumerosAleatorios.Rows.Add(i, aleatorio.ToString());
                }
                cbo_cantIntervalos.Enabled = true;
                btnGraficar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe completar los parametros requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                double limInf = oGeneradorAleatorios.Min;
                double limSup = oGeneradorAleatorios.Max;
                int cantidad = int.Parse(txtCantidad.Text);

                intervalos = oGestorIntervalo.armarNormal(numIntervalos, limSup, limInf, media, desviacion, cantidad);

                //Generacion grafico
                List<int> listaEnteros = new List<int>();
                histogramaGenerado.Series.Clear();
                histogramaGenerado.Series.Add("Frecuecias Observadas");
                histogramaGenerado.Series.Add("Frecuencias Esperadas");

                for (int i = 0; i < numIntervalos; i++)
                {
                    listaEnteros.Add(intervalos[i].FrecuenciaObservada);
                    histogramaGenerado.Series[0].Points.AddXY(i, intervalos[i].FrecuenciaObservada);
                    histogramaGenerado.Series[0].Points[i].AxisLabel = "[" + Math.Round(intervalos[i].Desde,4) + " - " + Math.Round(intervalos[i].Hasta,4) + "]";
                    histogramaGenerado.Series[0].IsValueShownAsLabel = true;
                    histogramaGenerado.Series[1].Points.AddXY(i, intervalos[i].FrecuenciaEsperada);
                    histogramaGenerado.Series[1].Points[i].AxisLabel = "[" + Math.Round(intervalos[i].Desde, 4) + " - " + Math.Round(intervalos[i].Hasta, 4) + "]";
                    histogramaGenerado.Series[1].IsValueShownAsLabel = true;

                    EstadisticoPrueba jiCuadrado = new EstadisticoPrueba();
                    double c = Math.Round((jiCuadrado.calEstadisticoPrueba(intervalos[i].FrecuenciaEsperada, intervalos[i].FrecuenciaObservada)), 2);
                    acumEstadisticoPrueba += c;
                    dgwJiCuadrado.Rows.Add("[" + Math.Round(intervalos[i].Desde, 4) + " - " + Math.Round(intervalos[i].Hasta, 4) + "]", intervalos[i].FrecuenciaObservada, intervalos[i].FrecuenciaEsperada, c, Math.Round(acumEstadisticoPrueba, 2));
                }

                lblChi.Text = acumEstadisticoPrueba.ToString();

                int gradosLibertad = numIntervalos - 1;
                lblGrados.Text = gradosLibertad.ToString();
                histogramaGenerado.ChartAreas[0].AxisY.Maximum = listaEnteros.Max() + 50;

                btnGraficar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la cantidad de Intervalos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //Limpiar

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            //Limpiar textbox
            txtCantidad.Text = "";
            txtMedia.Text = "";
            txtDesviacion.Text = "";

            //Limpiar dgv
            dgvNumerosAleatorios.Refresh();
            dgvNumerosAleatorios.Rows.Clear();
            dgwJiCuadrado.Refresh();
            dgwJiCuadrado.Rows.Clear();

            //Limpiar chart
            histogramaGenerado.Series.Clear();

            //Resetear combobox
            cbo_cantIntervalos.SelectedIndex = -1;
            cbo_cantIntervalos.Enabled = false;

            //Limpiar labels
            lblChi.Text = "";
            lblGrados.Text = "";


            //Setear botones
            btnGraficar.Enabled = false;
        }

        //Validacion

        private bool ValidarCampos()
        {
            if (txtCantidad.Text == "")
            {
                return false;
            }            
            if (txtMedia.Text == "")
            {
                return false;
            }
            if (txtDesviacion.Text == "")
            {
                return false;
            }
            return true;
        }

        private void txtCantidad_MouseClick(object sender, MouseEventArgs e)
        {
            //This method will prevent the cursor from being positioned in the middle 
            //of a textbox when the user clicks in it.
            MaskedTextBox textBox = sender as MaskedTextBox;

            if (textBox != null)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    int pos = textBox.SelectionStart;

                    if (pos > textBox.Text.Length)
                        pos = textBox.Text.Length;

                    textBox.Select(pos, 0);
                });
            }
        }

        private void txtMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;
        }
    }
}
