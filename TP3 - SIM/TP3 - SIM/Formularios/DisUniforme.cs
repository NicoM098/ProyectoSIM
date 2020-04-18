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
            btn_graficar.Enabled = false;
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
                btn_graficar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe completar los parametros requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
