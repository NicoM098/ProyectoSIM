using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4___SIM.Logica;
using System.IO;

namespace TP4___SIM
{
    public partial class Principal : Form
    {
        private Generador oGenerador = new Generador();
        private Almacenamiento oAlmacenamiento = new Almacenamiento();
        List<double> probAcumulada = new List<double>();

        int Desde;
        int Hasta;
        int cantidadVuelos;
        double GananciaAcumulada = 0;

        
        public Principal()
        {
            InitializeComponent();

            cmbVersion.SelectedIndex = 0;
        }


        //Validaciones de todos los datos
        private bool ValidarCampos()
        {
            if (txtNroVuelos.Text == "" || txtCosto.Text == "" || txtGanancia.Text == "" || cmbEstrategia.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar los parametros requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (validarDesdeHata() == false || validarProbabilidades() == false)
                {
                    return false;
                }
            }
            return true;
        }


        //Validacion del desde y el hasta
        public bool validarDesdeHata()
        {
            if (txtDesde.Text == "" && txtHasta.Text == "")
            {
                Desde = 1;
                Hasta = int.Parse(txtNroVuelos.Text);

                txtDesde.Text = Desde.ToString();
                txtHasta.Text = Hasta.ToString();
            }
            else if (txtDesde.Text == "" || txtHasta.Text == "")
            {
                txtDesde.Text = "";
                txtHasta.Text = "";
                txtDesde.Focus();

                MessageBox.Show("Ingrese parametros correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (int.Parse(txtHasta.Text) <= int.Parse(txtDesde.Text))
            {
                txtDesde.Text = "";
                txtHasta.Text = "";
                txtDesde.Focus();

                MessageBox.Show("Ingrese valores 'Desde' y 'Hasta' validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        //Iniciar Simulacion

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                dgvMonteCarlo.Rows.Clear();

                int estrategia;

                double gananciaPasajero;
                double costoReprog;
                double aux = 0;

                GananciaAcumulada = 0;

                cantidadVuelos = int.Parse(txtNroVuelos.Text);
                Desde = int.Parse(txtDesde.Text);
                Hasta = int.Parse(txtHasta.Text);
                gananciaPasajero = double.Parse(txtGanancia.Text);
                costoReprog = double.Parse(txtCosto.Text);
                estrategia = int.Parse(cmbEstrategia.SelectedItem.ToString());

                lblTituloEstrategia.Text = "Estrategia de Sobreventa de " + estrategia.ToString() + " Reservas posibles";

                //Calculo de prob acumuladas guardando en la lista probAcumulada
                for (int i = 0; i < dgv_probabilidades.Rows.Count; i++)
                {
                    aux = Convert.ToDouble(dgv_probabilidades.Rows[i].Cells[2].Value);

                    probAcumulada.Add(aux);
                }

                string[] array = new string[dgvMonteCarlo.Columns.Count];

                if (cmbVersion.SelectedIndex == 1)
                {
                    //Carga de datos en el excel
                    for (int i = 0; i < dgvMonteCarlo.Columns.Count; i++)
                    {
                        array[i] = dgvMonteCarlo.Columns[i].HeaderText;
                    }

                    oAlmacenamiento.newFile();
                    oAlmacenamiento.saveData(array);
                }
                

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

                    if ((NroVuelo >= Desde && NroVuelo <= Hasta) || NroVuelo == cantidadVuelos)
                    {
                        dgvMonteCarlo.Rows.Add(NroVuelo, RNDAsistencia, Asistencias, Inasistencias, CantPasajeros, PasajerosReprogramados, GananciaVuelo, CostoReprog, GananciaNeta, GananciaAcumulada);
                    }

                    array = new string[] { NroVuelo.ToString(), RNDAsistencia.ToString(), Asistencias.ToString(), Inasistencias.ToString(), CantPasajeros.ToString(), PasajerosReprogramados.ToString(), GananciaVuelo.ToString(), CostoReprog.ToString(), GananciaNeta.ToString(), GananciaAcumulada.ToString() };

                    if (cmbVersion.SelectedIndex == 1)
                    {
                        oAlmacenamiento.saveData(array);
                    }
                }

                double GananciaPromedio = Math.Round((GananciaAcumulada / (double)cantidadVuelos), 2);

                cargarDatosEstrategias(estrategia, gananciaPasajero, costoReprog, GananciaPromedio);

                btnIniciar.Enabled = false;
            }
        }

        private bool validarProbabilidades()
        {
            double aux;
            for (int i = 0; i < dgv_probabilidades.Rows.Count; i++)
            {
                aux = double.Parse(dgv_probabilidades.Rows[i].Cells[1].Value.ToString());

                if (aux == 0)
                {
                    MessageBox.Show("No puede ingresar probabilidades iguales a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }
            }
            return true;
        }


        private void cargarDatosEstrategias(int nroReservas, double gananciaPasajero, double costoReprog, double gananciaProm)
        {
            lblMaxReservas.Text = nroReservas.ToString();
            lblGananciaPasajero.Text = "$" + gananciaPasajero.ToString();
            lblCostoReprog.Text = "$" + costoReprog.ToString();
            lblGananciaProm.Text = "$" + gananciaProm.ToString();
            groupBoxEstrategia.Text = "Estrategia de " + nroReservas + " Reservas";

            if (gananciaProm > 2800)
            {
                lblEstrategiaOptima.Text = "Estrategia " + nroReservas.ToString();
                lblEstrategiaOptima.Visible = true;
            }
            else if (gananciaProm == 2800)
            {
                lblTextoConclusion.Text = "En pos de maximizar la utilidad, cualquiera de las dos estrategias es óptima";
                lblEstrategiaOptima.Visible = false;
            }
            else
            {
                lblEstrategiaOptima.Text = "Estrategia Original";
                lblEstrategiaOptima.Visible = true;
            }  
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

            if (cmbEstrategia.SelectedItem != null)
            {
                estrategia = int.Parse(cmbEstrategia.SelectedItem.ToString());

                for (int i = 28; i <= estrategia; i++)
                {
                    dgv_probabilidades.Rows.Add(i, 0);
                }
            }
            
        }

        private void dgv_probabilidades_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double aux = 0;

            for (int i = 0; i < dgv_probabilidades.Rows.Count; i++)
            {
                aux += double.Parse(dgv_probabilidades.Rows[i].Cells[1].Value.ToString());

                if (aux > 1)
                {
                    MessageBox.Show("La suma de las probabilidades no debe ser mayor a 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                    break;
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

            if (!double.TryParse(e.FormattedValue.ToString(), out newDouble) || newDouble < 0)
            {
                e.Cancel = true;
                MessageBox.Show("El valor ingresado debe ser un double mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgv_probabilidades.Rows[e.RowIndex].ErrorText = "El valor ingresado debe ser un double mayor a 0";
            }
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvMonteCarlo.Rows.Clear();

            StreamReader sr = new StreamReader(oAlmacenamiento.Ruta);
            string currentRow = sr.ReadLine(); //La primera linea son los titulos de las columnas

            if(validarDesdeHata())
            {
                Desde = int.Parse(txtDesde.Text);
                Hasta = int.Parse(txtHasta.Text);

                while (!sr.EndOfStream)
                {
                    currentRow = sr.ReadLine();
                    string[] cells = currentRow.Split(';');

                    if ((int.Parse(cells[0]) >= Desde && int.Parse(cells[0]) <= Hasta) || int.Parse(cells[0]) == cantidadVuelos)
                    {
                        dgvMonteCarlo.Rows.Add(cells);
                    }
                }
            }         
        }
        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroVuelos.Text = "";
            txtCosto.Text = "";
            txtGanancia.Text = "";
            cmbEstrategia.SelectedIndex = -1;
            txtDesde.Text = "";
            txtHasta.Text = "";

            dgvMonteCarlo.Rows.Clear();
            dgv_probabilidades.Rows.Clear();

            lblMaxReservas.Text = "";
            lblGananciaPasajero.Text = "";
            lblCostoReprog.Text = "";
            lblGananciaProm.Text = "";
            lblEstrategiaOptima.Text = "Estrategia N";
            lblTituloEstrategia.Text = "Estrategia de Sobreventa de N Reservas";
            groupBoxEstrategia.Text = "Estrategia de N Reservas";

            btnIniciar.Enabled = true;
        }

        private void validarEntero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void validarDouble(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGanancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDouble(sender, e);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDouble(sender, e);
        }

        private void txtNroVuelos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntero(sender, e);
        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntero(sender, e);
        }

        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarEntero(sender, e);
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.SelectedIndex == 0)
            {
                lblDesde.Parent = panelParametros2;
                txtDesde.Parent = panelParametros2;
                lblHasta.Parent = panelParametros2;
                txtHasta.Parent = panelParametros2;

                lblDesde.Location = new Point(484, 141);
                txtDesde.Location = new Point(551, 138);
                lblHasta.Location = new Point(667, 141);
                txtHasta.Location = new Point(729, 138);

                btnMostrar.Visible = false;
            }

            if (cmbVersion.SelectedIndex == 1)
            {
                lblDesde.Parent = panelResultado2;
                txtDesde.Parent = panelResultado2;
                lblHasta.Parent = panelResultado2;
                txtHasta.Parent = panelResultado2;

                lblDesde.Location = new Point(895, 24);
                txtDesde.Location = new Point(962, 21);
                lblHasta.Location = new Point(1078, 24);
                txtHasta.Location = new Point(1140, 21);

                btnMostrar.Visible = true;
            }
        }
    }
}
