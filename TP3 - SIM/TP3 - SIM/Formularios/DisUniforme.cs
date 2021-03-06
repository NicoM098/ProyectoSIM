﻿using System;
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
        //Todo: calcular grados de libertad y ver histograma
        private int limSup = 0;
        private int limInf = 0;
        private int cantidad = 0;

        private readonly GeneradorAleatorios oGeneradorAleatorios;
        public DisUniforme()
        {
            InitializeComponent();

            cbo_cantIntervalos.Enabled = false;
            btnGraficar.Enabled = false;
            lblChi.Text = "";
            oGeneradorAleatorios = new GeneradorAleatorios();
        }

        private bool ValidarCampos()
        {
            if (txtCantidad.Text == "" || txtLimSup.Text == "" || txtLimInf.Text == "")
            {
                MessageBox.Show("Debe completar los parametros requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (int.Parse(txtLimSup.Text) <= int.Parse(txtLimInf.Text))
                {
                    txtLimInf.Text = "";
                    txtLimSup.Text = "";
                    txtLimInf.Focus();

                    MessageBox.Show("Ingrese limites validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            dgvNumerosAleatorios.Rows.Clear();

            cantidad = 0;
            limInf = 0;
            limSup = 0;

            if (ValidarCampos())
            {
                limInf = Math.Min(int.Parse(txtLimInf.Text), int.Parse(txtLimSup.Text));
                limSup = Math.Max(int.Parse(txtLimInf.Text), int.Parse(txtLimSup.Text));
                cantidad = int.Parse(txtCantidad.Text);

                List<double> numeros = new List<double>();

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
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            //Limpiar textbox
            txtCantidad.Text = "";
            txtLimInf.Text = "";
            txtLimSup.Text = "";

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

                intervalos = oGestorIntervalo.armarUniforme(numIntervalos, limSup, limInf);

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
                histogramaGenerado.ChartAreas[0].AxisY.Maximum = listaEnteros.Max()+5;

                btnGraficar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la cantidad de Intervalos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtLimInf_MouseClick(object sender, MouseEventArgs e)
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

        private void txtLimSup_MouseClick(object sender, MouseEventArgs e)
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
