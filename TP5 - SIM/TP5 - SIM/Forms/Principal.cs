using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP5___SIM.Clases;

namespace TP5___SIM
{
    public partial class Principal : Form
    {
        Datos oDatos = new Datos();

        public Principal()
        {
            InitializeComponent();
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            Parametros parametros = new Parametros(oDatos);
            parametros.Show();
        }

        private string compareRandom(double random, List<double> probAcumulada)
        {
            for (int i = 0; i < probAcumulada.Count(); i++)
            {
                if (random < probAcumulada.ElementAt(i))
                {
                    if (i == 0)
                    {
                        return "Comprar";
                    }
                    else if (i == 1)
                    {
                        return "Entregar Reloj";
                    }
                    else if (i == 2)
                    {
                        return "Retirar Reloj";
                    }
                }
            }
            return "";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Generador oGenerador = new Generador();

            double tiempo = oDatos.Tiempo;

            int iteraciones = oDatos.Iteraciones;

            int desde = oDatos.Desde;
            double hasta = oDatos.Hasta;

            double llegClienteA = oDatos.LlegClienteA;
            double llegClienteB = oDatos.LlegClienteB;

            double tiempoVentaA = oDatos.TiempoVentaA;
            double tiempoVentaB = oDatos.TiempoVentaB;

            double tiempoRepA = oDatos.TiempoRepA;
            double tiempoRepB = oDatos.TiempoRepB;

            double tiempoRepIni = oDatos.TiempoRelojero;

            double tiempoEntrega = 3;
            double tiempoRetiro = 3;

            double tiempoAyudanteIni = 5 * tiempoEntrega;
            double tiempoRelojeroIni = tiempoRepIni - tiempoAyudanteIni;

            int cantClientes = 0;

            List<double> probAcumulada = new List<double>(oDatos.DistProbDestino);

            //FILA DE INICIALIZACION

            Dictionary<string, string> filaAnterior = new Dictionary<string, string>();

            string Evento = "Inicialización";
            filaAnterior.Add("Evento", Evento);

            string Reloj = "0";
            filaAnterior.Add("Reloj", Reloj);

            string RND1 = Math.Round(oGenerador.generadorUniforme(),2).ToString();
            filaAnterior.Add("RND1", RND1.ToString());

            string TiempoEntreLlegCliente = oGenerador.generadorUniforme(llegClienteA, llegClienteB, double.Parse(RND1)).ToString();
            filaAnterior.Add("TiempoEntreLlegCliente", TiempoEntreLlegCliente.ToString());

            string ProximaLlegCliente = (double.Parse(TiempoEntreLlegCliente) + double.Parse(Reloj)).ToString();
            filaAnterior.Add("ProximaLlegCliente", ProximaLlegCliente.ToString());

            string RND2 = "";
            filaAnterior.Add("RND2", RND2);

            string Destino = "";
            filaAnterior.Add("Destino", Destino);

            string RND3 = "";
            filaAnterior.Add("RND3", RND3);

            string TiempoAtencionVenta = "";
            filaAnterior.Add("TiempoAtencionVenta", TiempoAtencionVenta);

            string FinCompra = "";
            filaAnterior.Add("FinCompra", FinCompra);

            string TiempoAtencionEntrega = "";
            filaAnterior.Add("TiempoAtencionEntrega", TiempoAtencionEntrega);

            string FinEntrega = "";
            filaAnterior.Add("FinEntrega", FinEntrega);

            string RND4 = "";
            filaAnterior.Add("RND4", RND4);

            string TiempoReparacion = "";
            filaAnterior.Add("TiempoReparacion", TiempoReparacion);

            string FinReparacion = "";
            filaAnterior.Add("FinReparacion", FinReparacion);

            string TiempoAtencionRetiro = "";
            filaAnterior.Add("TiempoAtencionRetiro", TiempoAtencionRetiro);

            string FinRetiro = "";
            filaAnterior.Add("FinRetiro", FinRetiro);

            string EstadoAyudante = "Libre";
            filaAnterior.Add("EstadoAyudante", EstadoAyudante);

            int ColaAyudante = 0;
            filaAnterior.Add("ColaAyudante", ColaAyudante.ToString());

            string EstadoRelojero = "Libre";
            filaAnterior.Add("EstadoRelojero", EstadoRelojero);

            int ColaRelojero = 0;
            filaAnterior.Add("ColaRelojero", ColaRelojero.ToString());

            int CantRelojesRetirar = 5;
            filaAnterior.Add("CantRelojesRetirar", CantRelojesRetirar.ToString());

            string InicioOcupacionAyudante = "";
            filaAnterior.Add("InicioOcupacionAyudante", InicioOcupacionAyudante);

            string InicioOcupacionRelojero = "";
            filaAnterior.Add("InicioOcupacionRelojero", InicioOcupacionRelojero);

            double TiempoOcupacionAyudante = tiempoAyudanteIni;
            filaAnterior.Add("TiempoOcupacionAyudante", TiempoOcupacionAyudante.ToString());

            double TiempoOcupacionRelojero = tiempoRepIni;
            filaAnterior.Add("TiempoOcupacionRelojero", TiempoOcupacionRelojero.ToString());

            dgvColas.Rows.Add(Evento, Reloj, RND1, TiempoEntreLlegCliente, ProximaLlegCliente, RND2, Destino, RND3, TiempoAtencionVenta, FinCompra, TiempoAtencionEntrega, FinEntrega, RND4, TiempoReparacion, FinReparacion, TiempoAtencionRetiro, FinRetiro, EstadoAyudante, ColaAyudante, EstadoRelojero, ColaRelojero, CantRelojesRetirar, InicioOcupacionAyudante, InicioOcupacionRelojero, TiempoOcupacionAyudante, TiempoOcupacionRelojero);

            for (int i = 1; i <= 1 /*|| double.Parse(Reloj) <= tiempo*/; i++)
            {
                //**********CALCULO DE EVENTO************
                Dictionary<string, Double> aComparar = new Dictionary<string, Double>();

                string[] eventos = new string[5];
                eventos[0] = "llegada_cliente";
                eventos[1] = "fin_compra";
                eventos[2] = "fin_entrega_reloj";
                eventos[3] = "fin_reparacion_reloj";
                eventos[4] = "fin_retiro_reloj";

                string[] columnas = new string[5];
                columnas[0] = "ProximaLlegCliente";
                columnas[1] = "FinCompra";
                columnas[2] = "FinEntrega";
                columnas[3] = "FinReparacion";
                columnas[4] = "FinRetiro";

                for (int j = 0; j < columnas.Count(); j++)
                {
                    if (filaAnterior[columnas[j]] != "")
                    {
                        string key = columnas[j];
                        Double value = Convert.ToDouble(filaAnterior[columnas[j]]);
                        aComparar.Add(key, value);
                    }
                }

                var min = aComparar.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;

                int indice = Array.IndexOf(columnas, min);

                //Asignacion de Evento....
                Evento = eventos[indice];

                //Pregunta si evento es del tipo "llegada_cliente"
                if (Evento.Equals(eventos[0]))
                {
                    cantClientes += 1;

                    Reloj = filaAnterior["ProximaLlegCliente"];

                    //Calculo de proxima llegada del cliente
                    RND1 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();

                    TiempoEntreLlegCliente = oGenerador.generadorUniforme(llegClienteA, llegClienteB, double.Parse(RND1)).ToString();

                    ProximaLlegCliente = (double.Parse(TiempoEntreLlegCliente) + double.Parse(Reloj)).ToString();

                    //Calculo del destino del cliente
                    RND2 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();

                    Destino = compareRandom(double.Parse(RND2), probAcumulada);

                    //Si el Ayudante esta "Libre"
                    if (filaAnterior["EstadoAyudante"].Equals("Libre"))
                    {
                        //Si el destino es "Comprar"
                        if (Destino.Equals("Comprar"))
                        {
                            RND3 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();

                            TiempoAtencionVenta = oGenerador.generadorUniforme(tiempoVentaA, tiempoVentaB, double.Parse(RND3)).ToString();

                            FinCompra = (double.Parse(Reloj) + double.Parse(TiempoAtencionVenta)).ToString();

                            EstadoAyudante = "Ocupado";

                            ColaAyudante = 0;

                            InicioOcupacionAyudante = Reloj;

                            TiempoAtencionEntrega = "";
                            FinEntrega = filaAnterior["FinEntrega"];
                            RND4 = "";
                            TiempoReparacion = "";
                            FinReparacion = filaAnterior["FinReparacion"];
                            TiempoAtencionRetiro = "";
                            FinRetiro = filaAnterior["FinRetiro"];
                            EstadoRelojero = filaAnterior["EstadoRelojero"];
                            ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
                            CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
                            InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
                            TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
                            TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                        }

                        //Si el destino es "Entregar Reloj"
                        if (Destino.Equals("Entregar Reloj"))
                        {
                            TiempoAtencionEntrega = tiempoEntrega.ToString();

                            FinEntrega = (double.Parse(Reloj) + double.Parse(TiempoAtencionEntrega)).ToString();

                            EstadoAyudante = "Ocupado";

                            ColaAyudante = 0;

                            InicioOcupacionAyudante = Reloj;

                            RND3 = "";
                            TiempoAtencionVenta = "";
                            FinCompra = filaAnterior["FinCompra"];
                            RND4 = "";
                            TiempoReparacion = "";
                            FinReparacion = filaAnterior["FinReparacion"];
                            TiempoAtencionRetiro = "";
                            FinRetiro = filaAnterior["FinRetiro"];
                            EstadoRelojero = filaAnterior["EstadoRelojero"];
                            ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
                            CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
                            InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
                            TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
                            TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                        }

                        //Si el destino es "Retirar reloj"
                        if (Destino.Equals("Retirar Reloj"))
                        {
                            TiempoAtencionRetiro = tiempoRetiro.ToString();

                            FinRetiro = (double.Parse(Reloj) + double.Parse(TiempoAtencionRetiro)).ToString();

                            EstadoAyudante = "Ocupado";

                            ColaAyudante = 0;

                            InicioOcupacionAyudante = Reloj;

                            RND3 = "";
                            TiempoAtencionVenta = "";
                            FinCompra = filaAnterior["FinCompra"];
                            TiempoAtencionEntrega = "";
                            FinEntrega = filaAnterior["FinEntrega"];
                            RND4 = "";
                            TiempoReparacion = "";
                            FinReparacion = filaAnterior["FinReparacion"];
                            EstadoRelojero = filaAnterior["EstadoRelojero"];
                            ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
                            CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
                            InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
                            TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
                            TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                        }

                    }

                    

                    
                }

                dgvColas.Rows.Add(Evento, Reloj, RND1, TiempoEntreLlegCliente, ProximaLlegCliente, RND2, Destino, RND3, TiempoAtencionVenta, FinCompra, TiempoAtencionEntrega, FinEntrega, RND4, TiempoReparacion, FinReparacion, TiempoAtencionRetiro, FinRetiro, EstadoAyudante, ColaAyudante, EstadoRelojero, ColaRelojero, CantRelojesRetirar, InicioOcupacionAyudante, InicioOcupacionRelojero, TiempoOcupacionAyudante, TiempoOcupacionRelojero);


                DataGridViewColumn columna = new DataGridViewColumn();

                dgvColas.Columns.Add("cliente " + cantClientes.ToString(), "Estado Cliente " + cantClientes.ToString());

            }
        }
    }
}
