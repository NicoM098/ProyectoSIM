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
            if (txt_cantidad.Text == "")
            {
                return false;
            }
            return true;
        }


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            dgvNumerosAleatorios.Rows.Clear();
            int cantidad;
            int a = 0;
            int b = 0;

            if (ValidarCampos())
            {
                a = int.Parse(txt_LimInf.Text);
                b = int.Parse(txt_LimSup.Text);
                cantidad = int.Parse(txt_cantidad.Text);
                List<double> numeros = new List<double>();

                List<double> lista = oGeneradorAleatorios.generadorCS(cantidad);


                //ESTA ES LA LLAMADA AL METODO DE GENERAR ALEATORIOS
                //HAY QUE SOLUCIONAR EL GENERAR NUMEROS ALEATORIOS, HACER UNA LISTA E ITERAR SOBRE ELLA PARA HACER LAS OPERACIONES

                int contador = 0;
                numeros = oGeneradorAleatorios.calcularAleatorioUniforme(a, b, cantidad);
                foreach (double n in numeros)
                {
                    contador += 1;
                    dgvNumerosAleatorios.Rows.Add(contador, n);
                }
                {
                    //ACA HAY QUE RELLENAR EL DGV CON LOS DATOS DE LA DISTRIBUCION

                    /*i++;
                    dgv_aleatoriosCS.Rows.Add(i, aleatorio.ToString());*/
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
            dgvNumerosAleatorios.Refresh();
            dgvNumerosAleatorios.Rows.Clear();
            txt_cantidad.Text = "0";
            dgwJiCuadrado.Rows.Clear();

            lblChi.Text = "";

            cbo_cantIntervalos.SelectedIndex = -1;

            cbo_cantIntervalos.Enabled = false;
            btn_graficar.Enabled = false;
            lblChi.Text = "";

            btn_graficar.Enabled = false;
        }
    }
}
