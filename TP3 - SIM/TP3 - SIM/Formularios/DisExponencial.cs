using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

using TP3___SIM.Logica;

namespace TP3___SIM.Formularios
{

    public partial class DisExponencial : Form
    {
        private double lambda;

        private readonly GeneradorAleatorios oGeneradorAleatorios;


        public DisExponencial()
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

            if (ValidarCampos())
            {
                cantidad = int.Parse(txtCantidad.Text);
                lambda = 0;

                if (txtMedia.Text != "")
                {
                    //REVISAR
                    //lambda = double.Parse(txtMedia.Text) / (double) cantidad;

                    lambda = (double) 1 / double.Parse(txtMedia.Text);
                }
                else
                {
                    if (txtLambda.Text != "")
                    {
                        lambda = double.Parse(txtLambda.Text);
                    }
                }

                List<double> lista = oGeneradorAleatorios.generadorExponencial(cantidad,lambda);

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


        private void btnGraficar_Click(object sender, EventArgs e)
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
                int N = int.Parse(txtCantidad.Text);

                intervalos = oGestorIntervalo.armarExponencial(numIntervalos, limSup, limInf, lambda, N);

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
                lblGrados.Text = gradosLibertad.ToString();

                histogramaGenerado.ChartAreas[0].AxisY.Maximum = listaEnteros.Max() + 10;

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
            txtLambda.Text = "";
            txtMedia.Text = "";

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


        //Validaciones

        private bool ValidarCampos()
        {
            if (txtCantidad.Text == "")
            { 
                return false;
            }
            if (txtLambda.ReadOnly == false && txtLambda.Text == "")
            {
                return false;
            }
            else
            {
                if (txtMedia.ReadOnly == false && txtMedia.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {  
            modoLectura(txtLambda, txtMedia); 
        }

        private void txtMedia_Click(object sender, EventArgs e)
        {
            modoLectura(txtLambda, txtMedia);
        }

        private void txtLambda_Click(object sender, EventArgs e)
        {
           
            modoLectura(txtMedia, txtLambda);
        }

        private void txtLambda_TextChanged(object sender, EventArgs e)
        {
            modoLectura(txtMedia, txtLambda);
        }


        private void modoLectura(MaskedTextBox t1,MaskedTextBox t2)
        {
            if (t1.Text == "")
            {
                t1.ReadOnly = true;
                t2.ReadOnly = false;
            }
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
    }
}
