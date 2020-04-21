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
        private readonly GeneradorAleatorios oGeneradorAleatorios;

        public DisNormal()
        {
            InitializeComponent();
            oGeneradorAleatorios = new GeneradorAleatorios();

        }

        private void DisNormal_Load(object sender, EventArgs e)
        {
            cbo_cantIntervalos.Enabled = false;
            btn_graficar.Enabled = false;
            lblChi.Text = "";
        }

        private bool ValidarCampos()
        {
            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("Debe completar los parametros requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if ((int.Parse(txt_cantidad.Text) % 2) != 0)
                {
                    MessageBox.Show("Debe ingresar una cantidad par", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            dgv_aleatoriosCS.Rows.Clear();
            int cantidad;

            if (ValidarCampos())
            {
                cantidad = int.Parse(txt_cantidad.Text);
                List<double> lista = oGeneradorAleatorios.generadorNormal(cantidad);

                int i = 0;
                foreach (double aleatorio in lista)
                {
                    i++;
                    dgv_aleatoriosCS.Rows.Add(i, aleatorio.ToString());
                }
                cbo_cantIntervalos.Enabled = true;
                btn_graficar.Enabled = true;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            dgv_aleatoriosCS.Refresh();
            dgv_aleatoriosCS.Rows.Clear();
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
