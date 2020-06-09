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
using System.Collections;

namespace TP5___SIM
{
    public partial class Principal : Form
    {
        string Evento;
        string Reloj;
        string RND1;
        string TiempoEntreLlegCliente;
        string ProximaLlegCliente;
        string RND2;
        string Destino;
        string RND3;
        string TiempoAtencionVenta;
        string FinCompra;
        string TiempoAtencionEntrega;
        string FinEntrega;
        string RND4;
        string TiempoReparacion;
        string FinReparacion;
        string TiempoAtencionRetiro;
        string FinRetiro;
        string EstadoAyudante;
        int ColaAyudante;
        string EstadoRelojero;
        int ColaRelojero;
        int CantRelojesRetirar;
        string InicioOcupacionAyudante;
        string InicioOcupacionRelojero;
        double TiempoOcupacionAyudante;
        double TiempoOcupacionRelojero;
        int ContadorClientes;
        int nroOrdenCliente;

        Datos oDatos = new Datos();

        Dictionary<string, string> filaAnterior = new Dictionary<string, string>();

        Generador oGenerador = new Generador();

        Hashtable Clientes = new Hashtable();

        List<Cliente> colaAyudante = new List<Cliente>();

        //TODO: Acordarse de limpiar las listas para una proxima simulacion.............

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


        private void destinoComprar(double tiempoVentaA, double tiempoVentaB)
        {
            RND3 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();

            TiempoAtencionVenta = oGenerador.generadorUniforme(tiempoVentaA, tiempoVentaB, double.Parse(RND3)).ToString();

            FinCompra = (double.Parse(Reloj) + double.Parse(TiempoAtencionVenta)).ToString();

            //Operacion del resto de las columnas
            FinEntrega = filaAnterior["FinEntrega"];
            FinReparacion = filaAnterior["FinReparacion"];
            FinRetiro = filaAnterior["FinRetiro"];
            EstadoRelojero = filaAnterior["EstadoRelojero"];
            ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
            CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
            InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
            TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
            TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
            //**********************************
        }


        private void destinoEntregar(double tiempoEntrega)
        {
            TiempoAtencionEntrega = tiempoEntrega.ToString();

            FinEntrega = (double.Parse(Reloj) + double.Parse(TiempoAtencionEntrega)).ToString();

            //Operacion del resto de las columnas
            FinCompra = filaAnterior["FinCompra"];
            FinReparacion = filaAnterior["FinReparacion"];
            FinRetiro = filaAnterior["FinRetiro"];
            EstadoRelojero = filaAnterior["EstadoRelojero"];
            ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
            CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
            InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
            TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
            TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
            //**********************************
        }


        private void destinoRetirar(double tiempoRetiro)
        {
            TiempoAtencionRetiro = tiempoRetiro.ToString();

            FinRetiro = (double.Parse(Reloj) + double.Parse(TiempoAtencionRetiro)).ToString();

            //Operacion del resto de las columnas
            FinCompra = filaAnterior["FinCompra"];
            FinEntrega = filaAnterior["FinEntrega"];
            FinReparacion = filaAnterior["FinReparacion"];
            EstadoRelojero = filaAnterior["EstadoRelojero"];
            ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
            CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
            InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
            TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
            TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
            //**********************************
        }


        private void llegadaCliente(double llegClienteA, double llegClienteB, List<double> probAcumulada, double tiempoVentaA, double tiempoVentaB, double tiempoRetiro, double tiempoEntrega)
        {
            Cliente cli = new Cliente();

            nroOrdenCliente += 1;

            cli.Id = nroOrdenCliente;

            ContadorClientes += 1;

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
                    destinoComprar(tiempoVentaA, tiempoVentaB);

                    //ESTADO CLIENTE
                    cli.Estado = "AC";
                }


                //Si el destino es "Entregar Reloj"
                if (Destino.Equals("Entregar Reloj"))
                {
                    destinoEntregar(tiempoEntrega);

                    //ESTADO CLIENTE
                    cli.Estado = "AER";
                }


                //Si el destino es "Retirar reloj"
                if (Destino.Equals("Retirar Reloj"))
                {
                    destinoRetirar(tiempoRetiro);

                    //ESTADO CLIENTE
                    cli.Estado = "ARR";
                }

                EstadoAyudante = "Ocupado";

                ColaAyudante = 0;

                InicioOcupacionAyudante = Reloj;
            }

            if (filaAnterior["EstadoAyudante"].Equals("Ocupado"))
            {
                ColaAyudante += 1;

                if (Destino.Equals("Comprar"))
                {
                    cli.Estado = "EAC";
                }
                else if (Destino.Equals("Entregar Reloj"))
                {
                    cli.Estado = "EAE";
                }
                else if (Destino.Equals("Retirar Reloj"))
                {
                    cli.Estado = "ERR";
                }

                colaAyudante.Add(cli);

                //Operacion del resto de las columnas
                FinCompra = filaAnterior["FinCompra"];
                FinEntrega = filaAnterior["FinEntrega"];
                FinReparacion = filaAnterior["FinReparacion"];
                FinRetiro = filaAnterior["FinRetiro"];
                EstadoAyudante = filaAnterior["EstadoAyudante"];
                EstadoRelojero = filaAnterior["EstadoRelojero"];
                ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
                CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
                InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
                TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
                TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                //**********************************
            }

            //Se agrega el cliente a la Hashtable
            Clientes.Add(nroOrdenCliente, cli);

            //Se agrega una columna con el cliente nuevo
            dgvColas.Columns.Add("cliente" + nroOrdenCliente.ToString(), "Estado Cliente " + nroOrdenCliente.ToString());
        }



        private void finCompra(double tiempoVentaA, double tiempoVentaB, double tiempoEntrega, double tiempoRetiro)
        {
            Reloj = filaAnterior["FinCompra"];

            if (ColaAyudante > 0)
            {
                ColaAyudante -= 1;
                EstadoAyudante = filaAnterior["EstadoAyudante"];

                Cliente cliTemp = colaAyudante.ElementAt(0);

                //VER SI ANDA
                if (cliTemp.Estado.Equals("EAC"))
                {
                    destinoComprar(tiempoVentaA, tiempoVentaB);

                    cliTemp.Estado = "AC";
                }
                else if (cliTemp.Estado.Equals("EAE"))
                {
                    destinoEntregar(tiempoEntrega);

                    cliTemp.Estado = "AER";
                }
                else if (cliTemp.Estado.Equals("ERR"))
                {
                    destinoRetirar(tiempoRetiro);

                    cliTemp.Estado = "ARR";
                }

                Clientes[cliTemp.Id] = cliTemp;

                colaAyudante.RemoveAt(0);
            }
            else
            {
                EstadoAyudante = "Libre";

                InicioOcupacionAyudante = "";

                TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]) + double.Parse(Reloj) - double.Parse(filaAnterior["InicioOcupacionAyudante"]);

                //Operacion del resto de las columnas
                ProximaLlegCliente = filaAnterior["ProximaLlegCliente"];
                FinEntrega = filaAnterior["FinEntrega"];
                FinReparacion = filaAnterior["FinReparacion"];
                FinRetiro = filaAnterior["FinRetiro"];
                EstadoRelojero = filaAnterior["EstadoRelojero"];
                ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
                CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
                InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
                TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                //**********************************
            }
        }



        private void finEntregaReloj(double tiempoRepA, double tiempoRepB, double tiempoVentaA, double tiempoVentaB, double tiempoEntrega, double tiempoRetiro)
        {
            Reloj = filaAnterior["FinEntrega"];

            if (filaAnterior["ColaAyudante"] == "0")
            {
                EstadoAyudante = "Libre";
                InicioOcupacionAyudante = "";
                TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]) + double.Parse(Reloj) - double.Parse(filaAnterior["InicioOcupacionAyudante"]);

                //Operacion del resto de las columnas
                ProximaLlegCliente = filaAnterior["ProximaLlegCliente"];
                FinEntrega = filaAnterior["FinEntrega"];
                FinReparacion = filaAnterior["FinReparacion"];
                FinRetiro = filaAnterior["FinRetiro"];
                EstadoRelojero = filaAnterior["EstadoRelojero"];
                ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
                CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
                InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
                TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                //**********************************
            }
            else
            {
                EstadoAyudante = "Ocupado";
                ColaAyudante -= 1;

                Cliente cliTemp = colaAyudante.ElementAt(0);

                //VER SI ANDA
                if (cliTemp.Estado.Equals("EAC"))
                {
                    destinoComprar(tiempoVentaA, tiempoVentaB);

                    cliTemp.Estado = "AC";
                }
                else if (cliTemp.Estado.Equals("EAE"))
                {
                    destinoEntregar(tiempoEntrega);

                    cliTemp.Estado = "AER";
                }
                else if (cliTemp.Estado.Equals("ERR"))
                {
                    destinoRetirar(tiempoRetiro);

                    cliTemp.Estado = "ARR";
                }

                Clientes[cliTemp.Id] = cliTemp;

                colaAyudante.RemoveAt(0);

                TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
            }


            if (filaAnterior["EstadoRelojero"].Equals("Libre"))
            {
                RND4 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();

                TiempoReparacion = oGenerador.generadorUniforme(tiempoRepA, tiempoRepB, double.Parse(RND4)).ToString();

                FinReparacion = (double.Parse(Reloj) + double.Parse(TiempoReparacion)).ToString();

                EstadoRelojero = "Ocupado";

                InicioOcupacionRelojero = Reloj;

                //Operacion del resto de las columnas
                ProximaLlegCliente = filaAnterior["ProximaLlegCliente"];
                FinCompra = filaAnterior["FinCompra"];
                FinRetiro = filaAnterior["FinRetiro"];
                ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
                CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
                TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                //**********************************
            }

            if (filaAnterior["EstadoRelojero"].Equals("Ocupado"))
            {
                ColaRelojero += 1;

                //Operacion del resto de las columnas
                ProximaLlegCliente = filaAnterior["ProximaLlegCliente"];
                FinCompra = filaAnterior["FinCompra"];
                FinReparacion = filaAnterior["FinReparacion"];
                FinRetiro = filaAnterior["FinRetiro"];
                EstadoRelojero = filaAnterior["EstadoRelojero"];
                CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
                InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
                TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                //**********************************
            }
        }



        private void finReparacionReloj(double tiempoRepA, double tiempoRepB)
        {
            Reloj = filaAnterior["FinReparacion"];

            CantRelojesRetirar += 1;

            if (int.Parse(filaAnterior["ColaRelojero"]) > 0)
            {
                RND4 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();

                TiempoReparacion = oGenerador.generadorUniforme(tiempoRepA, tiempoRepB, double.Parse(RND4)).ToString();

                FinReparacion = (double.Parse(Reloj) + double.Parse(TiempoReparacion)).ToString();

                ColaRelojero -= 1;
                EstadoRelojero = filaAnterior["EstadoRelojero"];

                TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
            }
            else
            {
                EstadoRelojero = "Libre";
                InicioOcupacionRelojero = Reloj;
                TiempoOcupacionRelojero = double.Parse(Reloj) + double.Parse(filaAnterior["TiempoOcupacionRelojero"]) - double.Parse(filaAnterior["InicioOcupacionRelojero"]);
            }

            //Operacion del resto de las columnas
            ProximaLlegCliente = filaAnterior["ProximaLlegCliente"];
            FinCompra = filaAnterior["FinCompra"];
            FinEntrega = filaAnterior["FinEntrega"];
            FinRetiro = filaAnterior["FinRetiro"];
            EstadoAyudante = filaAnterior["EstadoAyudante"];
            ColaAyudante = int.Parse(filaAnterior["ColaAyudante"]);
            InicioOcupacionAyudante = filaAnterior["InicioOcupacionAyudante"];
            TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
            //**********************************
        }



        private void finRetiroReloj(double tiempoVentaA, double tiempoVentaB, double tiempoEntrega, double tiempoRetiro)
        {
            Reloj = filaAnterior["FinRetiro"];

            CantRelojesRetirar -= 1;

            if (int.Parse(filaAnterior["ColaAyudante"]) > 0)
            {
                Cliente cliTemp = colaAyudante.ElementAt(0);

                //VER SI ANDA
                if (cliTemp.Estado.Equals("EAC"))
                {
                    destinoComprar(tiempoVentaA, tiempoVentaB);

                    cliTemp.Estado = "AC";
                }
                else if (cliTemp.Estado.Equals("EAE"))
                {
                    destinoEntregar(tiempoEntrega);

                    cliTemp.Estado = "AER";
                }
                else if (cliTemp.Estado.Equals("ERR"))
                {
                    destinoRetirar(tiempoRetiro);

                    cliTemp.Estado = "ARR";
                }

                Clientes[cliTemp.Id] = cliTemp;

                colaAyudante.RemoveAt(0);

                EstadoAyudante = filaAnterior["EstadoAyudante"];
                ColaAyudante -= 1;
                InicioOcupacionAyudante = filaAnterior["InicioOcupacionAyudante"];
                TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
            }
            else
            {
                EstadoAyudante = "Libre";

                InicioOcupacionAyudante = "";
                TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]) + double.Parse(Reloj) - double.Parse(filaAnterior["InicioOcupacionAyudante"]);

                //Operacion del resto de las columnas
                ProximaLlegCliente = filaAnterior["ProximaLlegCliente"];
                FinCompra = filaAnterior["FinCompra"];
                FinEntrega = filaAnterior["FinEntrega"];
                FinReparacion = filaAnterior["FinReparacion"];
                EstadoRelojero = filaAnterior["EstadoRelojero"];
                ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
                InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
                TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                //**********************************
            }
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

            List<double> probAcumulada = new List<double>(oDatos.DistProbDestino);

            //FILA DE INICIALIZACION

            Evento = "Inicialización";
            filaAnterior.Add("Evento", Evento);

            Reloj = "0";
            filaAnterior.Add("Reloj", Reloj);

            RND1 = Math.Round(oGenerador.generadorUniforme(),2).ToString();
            filaAnterior.Add("RND1", RND1.ToString());

            TiempoEntreLlegCliente = oGenerador.generadorUniforme(llegClienteA, llegClienteB, double.Parse(RND1)).ToString();
            filaAnterior.Add("TiempoEntreLlegCliente", TiempoEntreLlegCliente.ToString());

             ProximaLlegCliente = (double.Parse(TiempoEntreLlegCliente) + double.Parse(Reloj)).ToString();
            filaAnterior.Add("ProximaLlegCliente", ProximaLlegCliente.ToString());

             RND2 = "";
            filaAnterior.Add("RND2", RND2);

             Destino = "";
            filaAnterior.Add("Destino", Destino);
           
             RND3 = "";
            filaAnterior.Add("RND3", RND3);

             TiempoAtencionVenta = "";
            filaAnterior.Add("TiempoAtencionVenta", TiempoAtencionVenta);

             FinCompra = "";
            filaAnterior.Add("FinCompra", FinCompra);

             TiempoAtencionEntrega = "";
            filaAnterior.Add("TiempoAtencionEntrega", TiempoAtencionEntrega);

             FinEntrega = "";
            filaAnterior.Add("FinEntrega", FinEntrega);

             RND4 = "";
            filaAnterior.Add("RND4", RND4);

             TiempoReparacion = "";
            filaAnterior.Add("TiempoReparacion", TiempoReparacion);

             FinReparacion = "";
            filaAnterior.Add("FinReparacion", FinReparacion);

             TiempoAtencionRetiro = "";
            filaAnterior.Add("TiempoAtencionRetiro", TiempoAtencionRetiro);

             FinRetiro = "";
            filaAnterior.Add("FinRetiro", FinRetiro);

             EstadoAyudante = "Libre";
            filaAnterior.Add("EstadoAyudante", EstadoAyudante);
             ColaAyudante = 0;
            filaAnterior.Add("ColaAyudante", ColaAyudante.ToString());

             EstadoRelojero = "Libre";
            filaAnterior.Add("EstadoRelojero", EstadoRelojero);

             ColaRelojero = 0;
            filaAnterior.Add("ColaRelojero", ColaRelojero.ToString());

             CantRelojesRetirar = 5;
            filaAnterior.Add("CantRelojesRetirar", CantRelojesRetirar.ToString());

            InicioOcupacionAyudante = "";
            filaAnterior.Add("InicioOcupacionAyudante", InicioOcupacionAyudante);

            InicioOcupacionRelojero = "";
            filaAnterior.Add("InicioOcupacionRelojero", InicioOcupacionRelojero);

            TiempoOcupacionAyudante = tiempoAyudanteIni;
            filaAnterior.Add("TiempoOcupacionAyudante", TiempoOcupacionAyudante.ToString());

            TiempoOcupacionRelojero = tiempoRepIni;
            filaAnterior.Add("TiempoOcupacionRelojero", TiempoOcupacionRelojero.ToString());

            ContadorClientes = 0;
            filaAnterior.Add("ContadorClientes", ContadorClientes.ToString());

            dgvColas.Rows.Add(Evento,
                Reloj,
                RND1,
                TiempoEntreLlegCliente,
                ProximaLlegCliente,
                RND2,
                Destino,
                RND3,
                TiempoAtencionVenta,
                FinCompra,
                TiempoAtencionEntrega,
                FinEntrega,
                RND4,
                TiempoReparacion,
                FinReparacion,
                TiempoAtencionRetiro,
                FinRetiro,
                EstadoAyudante,
                ColaAyudante,
                EstadoRelojero,
                ColaRelojero,
                CantRelojesRetirar,
                InicioOcupacionAyudante,
                InicioOcupacionRelojero,
                TiempoOcupacionAyudante,
                TiempoOcupacionRelojero,
                ContadorClientes);


            for (int i = 1; i <= 30 /*|| double.Parse(Reloj) <= tiempo*/; i++)
            {
                //LIMPIEZA DE VARIABLES
                Evento = "";
                Reloj = "";
                RND1 = "";
                TiempoEntreLlegCliente = "";
                ProximaLlegCliente = "";
                RND2 = "";
                Destino = "";
                RND3 = "";
                TiempoAtencionVenta = "";
                FinCompra = "";
                TiempoAtencionEntrega = "";
                FinEntrega = "";
                RND4 = "";
                TiempoReparacion = "";
                FinReparacion = "";
                TiempoAtencionRetiro = "";
                FinRetiro = "";
                EstadoAyudante = "";
                EstadoRelojero = "";
                InicioOcupacionAyudante = "";
                InicioOcupacionRelojero = "";
                TiempoOcupacionAyudante = 0;
                TiempoOcupacionRelojero = 0;

                
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
                    llegadaCliente(llegClienteA, llegClienteB, probAcumulada, tiempoVentaA, tiempoVentaB, tiempoRetiro, tiempoEntrega);
                }

                //Si el evento es "fin_compra"
                if (Evento.Equals(eventos[1]))
                {
                    finCompra(tiempoVentaA, tiempoVentaB, tiempoEntrega, tiempoRetiro);
                }

                //Si el evento es "fin_entrega_reloj"
                if (Evento.Equals(eventos[2]))
                {
                    finEntregaReloj(tiempoRepA, tiempoRepB, tiempoVentaA, tiempoVentaB, tiempoEntrega, tiempoRetiro);
                }

                //Si el evento es "fin_reparacion_reloj"
                if (Evento.Equals(eventos[3]))
                {
                    finReparacionReloj(tiempoRepA, tiempoRepB);
                }

                //Si el evento es "fin_retiro_reloj"
                if (Evento.Equals(eventos[4]))
                {
                    finRetiroReloj(tiempoVentaA, tiempoVentaB, tiempoEntrega, tiempoRetiro);
                }


                dgvColas.Rows.Add(Evento, Reloj, RND1, TiempoEntreLlegCliente, ProximaLlegCliente, RND2, Destino, RND3, TiempoAtencionVenta, FinCompra, TiempoAtencionEntrega, FinEntrega, RND4, TiempoReparacion, FinReparacion, TiempoAtencionRetiro, FinRetiro, EstadoAyudante, ColaAyudante, EstadoRelojero, ColaRelojero, CantRelojesRetirar, InicioOcupacionAyudante, InicioOcupacionRelojero, TiempoOcupacionAyudante, TiempoOcupacionRelojero, ContadorClientes);

                Cliente temp = (Cliente)Clientes[nroOrdenCliente];
                
                dgvColas.Rows[dgvColas.Rows.Count - 1].Cells["cliente" + nroOrdenCliente.ToString()].Value = temp.Estado;


                //ACTUALIZACION DE DICCIONARIO
                filaAnterior["Evento"] = Evento;
                filaAnterior["Reloj"] = Reloj;
                filaAnterior["RND1"] = RND1;
                filaAnterior["TiempoEntreLlegCliente"] = TiempoEntreLlegCliente;
                filaAnterior["ProximaLlegCliente"] = ProximaLlegCliente;
                filaAnterior["RND2"] = RND2;
                filaAnterior["Destino"] = Destino;
                filaAnterior["RND3"] = RND3;
                filaAnterior["TiempoAtencionVenta"] = TiempoAtencionVenta;
                filaAnterior["FinCompra"] = FinCompra;
                filaAnterior["TiempoAtencionEntrega"] = TiempoAtencionEntrega;
                filaAnterior["FinEntrega"] = FinEntrega;
                filaAnterior["RND4"] = RND4;
                filaAnterior["TiempoReparacion"] = TiempoReparacion;
                filaAnterior["FinReparacion"] = FinReparacion;
                filaAnterior["TiempoAtencionRetiro"] = TiempoAtencionRetiro;
                filaAnterior["FinRetiro"] = FinRetiro;
                filaAnterior["EstadoAyudante"] = EstadoAyudante;
                filaAnterior["ColaAyudante"] = ColaAyudante.ToString();
                filaAnterior["EstadoRelojero"] = EstadoRelojero;
                filaAnterior["ColaRelojero"] = ColaRelojero.ToString();
                filaAnterior["CantRelojesRetirar"] = CantRelojesRetirar.ToString();
                filaAnterior["InicioOcupacionAyudante"] = InicioOcupacionAyudante;
                filaAnterior["InicioOcupacionRelojero"] = InicioOcupacionRelojero;
                filaAnterior["TiempoOcupacionAyudante"] = TiempoOcupacionAyudante.ToString();
                filaAnterior["TiempoOcupacionRelojero"] = TiempoOcupacionRelojero.ToString();
            }
        }
    }
}
