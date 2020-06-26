using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP6___SIM.Clases;
using TP6___SIM.Forms;

namespace TP6___SIM
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
        string Complejidad;
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
        int ClientesSinReloj;
        int nroOrdenCliente;
        double acumTiempoAyu;
        double acumTiempoRel;

        Datos oDatos = new Datos();

        Dictionary<string, string> filaAnterior = new Dictionary<string, string>();

        Generador oGenerador = new Generador();

        Hashtable Clientes = new Hashtable();

        List<Cliente> colaAyudante = new List<Cliente>();

        List<Cliente> colaAux = new List<Cliente>();

        //TODO: Acordarse de limpiar las listas para una proxima simulacion.............

        public Principal()
        {
            InitializeComponent();

            btnIniciar.Enabled = false;
            btnEuler.Enabled = false;
            btnVolver.Enabled = false;

            dgvEuler.Visible = false;
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = true;
            btnEuler.Enabled = true;

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


        private string compareRandom(double random)
        {
            if (random < 0.5f)
            {
                return "50";
            }
            else
            {
                return "80";
            }
        }


        private string calculoTiempoReparacion(int contInt, double a, double h, int R, int C)
        {
            double t = 0f;
            double D = 0f;
            double derivada;
            double Dsiguiente = 0f;
            double tsiguiente = 0f;

            dgvEuler.Rows.Add("", "a = " + a.ToString(), "h = " + h.ToString(), "R = " + R.ToString(), "C = " + C.ToString(), "");
            dgvEuler.Rows.Add(contInt, "", "", "", tsiguiente.ToString(), Dsiguiente.ToString());

            while (D <= C + 1000)
            {
                t = tsiguiente;
                D = Dsiguiente;

                derivada = (0.4f / (double) C) + t + a * R;

                tsiguiente = Math.Round(t + h, 2);
                Dsiguiente = D + h * derivada;

                dgvEuler.Rows.Add(contInt, t, D, derivada, tsiguiente, Dsiguiente);

                if (D >= C)
                {
                    dgvEuler.Rows.Add("Fin", "-", "-", "-", "-", "-");
                    dgvEuler.Rows.Add();
                    dgvEuler.Rows.Add();
                    return t.ToString();
                }
            }

            return "0";
        }



        private void destinoComprar(double tiempoVentaA, double tiempoVentaB)
        {
            RND3 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();

            TiempoAtencionVenta = oGenerador.generadorUniforme(tiempoVentaA, tiempoVentaB, double.Parse(RND3)).ToString();

            FinCompra = (double.Parse(Reloj) + double.Parse(TiempoAtencionVenta)).ToString();
        }



        private void destinoEntregar(double tiempoEntrega)
        {
            TiempoAtencionEntrega = tiempoEntrega.ToString();

            FinEntrega = (double.Parse(Reloj) + double.Parse(TiempoAtencionEntrega)).ToString();
        }



        private void destinoRetirar(double tiempoRetiro)
        {
            TiempoAtencionRetiro = tiempoRetiro.ToString();

            FinRetiro = (double.Parse(Reloj) + double.Parse(TiempoAtencionRetiro)).ToString();
        }



        private void llegadaCliente(double llegClienteA, double llegClienteB, List<double> probAcumulada, double tiempoVentaA, double tiempoVentaB, double tiempoRetiro, double tiempoEntrega)
        {
            ContadorClientes += 1;

            Cliente cli = new Cliente();

            nroOrdenCliente += 1;

            cli.Id = nroOrdenCliente;

            cli.Estado = "";

            Reloj = filaAnterior["ProximaLlegCliente"];

            //Calculo de proxima llegada del cliente
            RND1 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();

            TiempoEntreLlegCliente = oGenerador.generadorUniforme(llegClienteA, llegClienteB, double.Parse(RND1)).ToString();

            ProximaLlegCliente = (double.Parse(TiempoEntreLlegCliente) + double.Parse(Reloj)).ToString();

            //Calculo del destino del cliente
            RND2 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();

            if (RND2 == 1.ToString())
            {
                RND2 = 0.98.ToString();
            }

            Destino = compareRandom(double.Parse(RND2), probAcumulada);


            //Si el Ayudante esta "Libre"
            if (filaAnterior["EstadoAyudante"].Equals("Libre"))
            {
                //Si el destino es "Comprar"
                if (Destino.Equals("Comprar"))
                {
                    destinoComprar(tiempoVentaA, tiempoVentaB);

                    //Columnas que se mantienen
                    FinEntrega = filaAnterior["FinEntrega"];
                    FinReparacion = filaAnterior["FinReparacion"];
                    FinRetiro = filaAnterior["FinRetiro"];

                    //ESTADO CLIENTE
                    cli.Estado = "AC";
                }


                //Si el destino es "Entregar Reloj"
                if (Destino.Equals("Entregar Reloj"))
                {
                    destinoEntregar(tiempoEntrega);

                    //Columnas que se mantienen
                    FinCompra = filaAnterior["FinCompra"];
                    FinReparacion = filaAnterior["FinReparacion"];
                    FinRetiro = filaAnterior["FinRetiro"];

                    //ESTADO CLIENTE
                    cli.Estado = "AER";
                }

                EstadoAyudante = "Ocupado";

                InicioOcupacionAyudante = Reloj;

                //Si el destino es "Retirar reloj"
                if (Destino.Equals("Retirar Reloj"))
                {
                    if (CantRelojesRetirar > 0)
                    {
                        destinoRetirar(tiempoRetiro);

                        //Columnas que se mantienen
                        FinCompra = filaAnterior["FinCompra"];
                        FinEntrega = filaAnterior["FinEntrega"];
                        FinReparacion = filaAnterior["FinReparacion"];

                        //ESTADO CLIENTE
                        cli.Estado = "ARR";
                    }
                    else
                    {
                        ClientesSinReloj += 1;

                        EstadoAyudante = "Libre";

                        InicioOcupacionAyudante = filaAnterior["InicioOcupacionAyudante"];

                        FinCompra = filaAnterior["FinCompra"];
                        FinEntrega = filaAnterior["FinEntrega"];
                        FinReparacion = filaAnterior["FinReparacion"];
                        FinRetiro = filaAnterior["FinRetiro"];
                    }
                }

                if (!(Destino.Equals("Retirar Reloj") && CantRelojesRetirar == 0))
                {
                    //Se agrega a la lista auxiliar
                    colaAux.Add(cli);
                }

                ColaAyudante = 0;
            }

            if (filaAnterior["EstadoAyudante"].Equals("Ocupado"))
            {
                if (Destino.Equals("Comprar"))
                {
                    cli.Estado = "EAC";
                }
                else if (Destino.Equals("Entregar Reloj"))
                {
                    cli.Estado = "EAE";
                }
                else if (Destino.Equals("Retirar Reloj") && CantRelojesRetirar > 0)
                {
                    cli.Estado = "ERR";
                }

                if (!(cli.Estado.Equals("")))
                {
                    colaAyudante.Add(cli);

                    ColaAyudante += 1;
                }

                //Operacion del resto de las columnas
                FinCompra = filaAnterior["FinCompra"];
                FinEntrega = filaAnterior["FinEntrega"];
                FinReparacion = filaAnterior["FinReparacion"];
                FinRetiro = filaAnterior["FinRetiro"];
                EstadoAyudante = filaAnterior["EstadoAyudante"];
                //**********************************
            }

            //Se agrega el cliente a la Hashtable
            Clientes.Add(nroOrdenCliente, cli);

            if (nroOrdenCliente <= 50)
            {
                //Se agrega una columna con el cliente nuevo
                dgvColas.Columns.Add("cliente" + nroOrdenCliente.ToString(), "Estado Cliente " + nroOrdenCliente.ToString());
            }


            //Se mantienen indistintamente estas columnas....
            EstadoRelojero = filaAnterior["EstadoRelojero"];
            ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
            CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
            InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
            TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
            TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
        }



        private void finCompra(double tiempoVentaA, double tiempoVentaB, double tiempoEntrega, double tiempoRetiro)
        {
            if (colaAux.ElementAt(0).Estado == "AC")
            {
                int idAux = colaAux.ElementAt(0).Id;

                Cliente temp = (Cliente)Clientes[idAux];

                temp.Estado = "";

                colaAux.RemoveAt(0);

                Clientes[idAux] = temp;
            }


            Reloj = filaAnterior["FinCompra"];

            if (ColaAyudante > 0)
            {
                ColaAyudante -= 1;

                EstadoAyudante = filaAnterior["EstadoAyudante"];
                InicioOcupacionAyudante = filaAnterior["InicioOcupacionAyudante"];
                TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);

                Cliente cliTemp = colaAyudante.ElementAt(0);

                //VER SI ANDA
                if (cliTemp.Estado.Equals("EAC"))
                {
                    destinoComprar(tiempoVentaA, tiempoVentaB);

                    cliTemp.Estado = "AC";

                    //Columnas que se mantienen
                    FinEntrega = filaAnterior["FinEntrega"];
                    FinReparacion = filaAnterior["FinReparacion"];
                    FinRetiro = filaAnterior["FinRetiro"];
                }
                else if (cliTemp.Estado.Equals("EAE"))
                {
                    destinoEntregar(tiempoEntrega);

                    cliTemp.Estado = "AER";

                    //Columnas que se mantienen
                    FinReparacion = filaAnterior["FinReparacion"];
                    FinRetiro = filaAnterior["FinRetiro"];
                }
                else if (cliTemp.Estado.Equals("ERR"))
                {
                    destinoRetirar(tiempoRetiro);

                    cliTemp.Estado = "ARR";

                    //Columnas que se mantienen
                    FinEntrega = filaAnterior["FinEntrega"];
                    FinReparacion = filaAnterior["FinReparacion"];
                }

                //Se agrega a la hashtable
                Clientes[cliTemp.Id] = cliTemp;

                colaAux.Add(cliTemp);

                colaAyudante.RemoveAt(0);
            }
            else
            {
                FinEntrega = filaAnterior["FinEntrega"];
                FinReparacion = filaAnterior["FinReparacion"];
                FinRetiro = filaAnterior["FinRetiro"];

                EstadoAyudante = "Libre";

                if (filaAnterior["EstadoAyudante"].Equals("Ocupado"))
                {
                    InicioOcupacionAyudante = "";

                    TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]) + double.Parse(Reloj) - double.Parse(filaAnterior["InicioOcupacionAyudante"]);
                }
                else
                {
                    InicioOcupacionAyudante = "";

                    TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
                }
            }


            //Columnas que se mantienen indistintamente....
            ProximaLlegCliente = filaAnterior["ProximaLlegCliente"];
            EstadoRelojero = filaAnterior["EstadoRelojero"];
            ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
            CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
            InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
            TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
        }



        private void finEntregaReloj(int contInt, double h, double a, double tiempoVentaA, double tiempoVentaB, double tiempoEntrega, double tiempoRetiro)
        {
            if (colaAux.ElementAt(0).Estado == "AER")
            {
                int idAux = colaAux.ElementAt(0).Id;

                Cliente temp = (Cliente)Clientes[idAux];

                temp.Estado = "";

                colaAux.RemoveAt(0);

                Clientes[idAux] = temp;
            }

            Reloj = filaAnterior["FinEntrega"];

            if (filaAnterior["ColaAyudante"] == "0")
            {
                EstadoAyudante = "Libre";

                if (filaAnterior["EstadoAyudante"].Equals("Ocupado"))
                {
                    InicioOcupacionAyudante = "";

                    TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]) + double.Parse(Reloj) - double.Parse(filaAnterior["InicioOcupacionAyudante"]);
                }
                else
                {
                    InicioOcupacionAyudante = "";

                    TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
                }

                //Operacion del resto de las columnas
                FinCompra = filaAnterior["FinCompra"];
                FinRetiro = filaAnterior["FinRetiro"];
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

                    //Columnas que se mantienen....
                    FinRetiro = filaAnterior["FinRetiro"];
                }
                else if (cliTemp.Estado.Equals("EAE"))
                {
                    destinoEntregar(tiempoEntrega);

                    cliTemp.Estado = "AER";

                    //Columnas que se mantienen....
                    FinCompra = filaAnterior["FinCompra"];
                    FinRetiro = filaAnterior["FinRetiro"];
                }
                else if (cliTemp.Estado.Equals("ERR"))
                {
                    destinoRetirar(tiempoRetiro);

                    cliTemp.Estado = "ARR";

                    //Columnas que se mantienen...
                    FinCompra = filaAnterior["FinCompra"];
                }

                Clientes[cliTemp.Id] = cliTemp;

                colaAux.Add(cliTemp);

                colaAyudante.RemoveAt(0);

                //Columnas que se mantiene...
                TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
                EstadoAyudante = filaAnterior["EstadoAyudante"];
                InicioOcupacionAyudante = filaAnterior["InicioOcupacionAyudante"];
            }


            if (filaAnterior["EstadoRelojero"].Equals("Libre"))
            {
                RND4 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();

                Complejidad = compareRandom(double.Parse(RND4));

                TiempoReparacion = calculoTiempoReparacion(contInt, a, h, ColaRelojero, int.Parse(Complejidad));

                FinReparacion = (double.Parse(Reloj) + double.Parse(TiempoReparacion)).ToString();

                EstadoRelojero = "Ocupado";

                InicioOcupacionRelojero = Reloj;

                //Operacion del resto de las columnas
                ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
                CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
                TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                //**********************************
            }
            else
            {
                ColaRelojero += 1;

                FinReparacion = filaAnterior["FinReparacion"];

                EstadoRelojero = filaAnterior["EstadoRelojero"];

                InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];

                //Operacion del resto de las columnas
                CantRelojesRetirar = int.Parse(filaAnterior["CantRelojesRetirar"]);
                TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                //**********************************
            }

            //Columna que se mantiene indistintamente...
            ProximaLlegCliente = filaAnterior["ProximaLlegCliente"];
        }



        private void finReparacionReloj(int contInt, double h, double a)
        {
            Reloj = filaAnterior["FinReparacion"];

            CantRelojesRetirar += 1;

            if (int.Parse(filaAnterior["ColaRelojero"]) > 0)
            {
                ColaRelojero -= 1;

                RND4 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();

                Complejidad = compareRandom(double.Parse(RND4));

                TiempoReparacion = calculoTiempoReparacion(contInt, a, h, ColaRelojero, int.Parse(Complejidad));

                FinReparacion = (double.Parse(Reloj) + double.Parse(TiempoReparacion)).ToString();

                EstadoRelojero = filaAnterior["EstadoRelojero"];

                TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
            }
            else
            {
                EstadoRelojero = "Libre";

                if (filaAnterior["EstadoRelojero"].Equals("Ocupado"))
                {
                    InicioOcupacionRelojero = "";
                    TiempoOcupacionRelojero = double.Parse(Reloj) + double.Parse(filaAnterior["TiempoOcupacionRelojero"]) - double.Parse(filaAnterior["InicioOcupacionRelojero"]);
                }
                else
                {
                    InicioOcupacionRelojero = "";
                    TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
                }
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
            if (colaAux.ElementAt(0).Estado == "ARR")
            {
                int idAux = colaAux.ElementAt(0).Id;

                Cliente temp = (Cliente)Clientes[idAux];

                temp.Estado = "";

                colaAux.RemoveAt(0);

                Clientes[idAux] = temp;
            }

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

                    //Columnas que se mantienen
                    FinEntrega = filaAnterior["FinEntrega"];
                    FinReparacion = filaAnterior["FinReparacion"];
                }
                else if (cliTemp.Estado.Equals("EAE"))
                {
                    destinoEntregar(tiempoEntrega);

                    cliTemp.Estado = "AER";

                    //Columnas que se mantienen
                    FinCompra = filaAnterior["FinCompra"];
                    FinReparacion = filaAnterior["FinReparacion"];
                }
                else if (cliTemp.Estado.Equals("ERR"))
                {
                    destinoRetirar(tiempoRetiro);

                    cliTemp.Estado = "ARR";

                    //Columnas que se mantienen
                    FinEntrega = filaAnterior["FinEntrega"];
                    FinCompra = filaAnterior["FinCompra"];
                    FinReparacion = filaAnterior["FinReparacion"];
                }

                Clientes[cliTemp.Id] = cliTemp;

                colaAux.Add(cliTemp);

                colaAyudante.RemoveAt(0);

                EstadoAyudante = filaAnterior["EstadoAyudante"];
                ColaAyudante -= 1;
                InicioOcupacionAyudante = filaAnterior["InicioOcupacionAyudante"];
                TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
            }
            else
            {
                EstadoAyudante = "Libre";

                if (filaAnterior["EstadoAyudante"].Equals("Ocupado"))
                {
                    InicioOcupacionAyudante = "";
                    TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]) + double.Parse(Reloj) - double.Parse(filaAnterior["InicioOcupacionAyudante"]);

                }
                else
                {
                    InicioOcupacionAyudante = "";
                    TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]);
                }
            }

            //Operacion del resto de las columnas
            ProximaLlegCliente = filaAnterior["ProximaLlegCliente"];
            EstadoRelojero = filaAnterior["EstadoRelojero"];
            ColaRelojero = int.Parse(filaAnterior["ColaRelojero"]);
            InicioOcupacionRelojero = filaAnterior["InicioOcupacionRelojero"];
            TiempoOcupacionRelojero = double.Parse(filaAnterior["TiempoOcupacionRelojero"]);
            FinReparacion = filaAnterior["FinReparacion"];
            //**********************************
        }




        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Generador oGenerador = new Generador();

            double tiempo = oDatos.Tiempo;

            int iteraciones = oDatos.Iteraciones;

            int desde = oDatos.Desde;
            double hasta = oDatos.Hasta+1;

            double llegClienteA = oDatos.LlegClienteA;
            double llegClienteB = oDatos.LlegClienteB;

            double tiempoVentaA = oDatos.TiempoVentaA;
            double tiempoVentaB = oDatos.TiempoVentaB;

            double h = oDatos.H;
            double a = oDatos.A;

            double tiempoRepIni = oDatos.TiempoRelojero;

            double tiempoEntrega = 3;
            double tiempoRetiro = 3;

            double tiempoAyudanteIni = 5 * tiempoEntrega;
            double tiempoRelojeroIni = tiempoRepIni - tiempoAyudanteIni;

            int contadorIteraciones = 0;
            int contIt = 0;

            List<double> probAcumulada = new List<double>(oDatos.DistProbDestino);

            //FILA DE INICIALIZACION

            Evento = "Inicialización";
            filaAnterior.Add("Evento", Evento);

            Reloj = "0";
            filaAnterior.Add("Reloj", Reloj);

            RND1 = Math.Round(oGenerador.generadorUniforme(), 2).ToString();
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

            Complejidad = "";
            filaAnterior.Add("Complejidad", Complejidad);

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

            TiempoOcupacionRelojero = tiempoRelojeroIni;
            filaAnterior.Add("TiempoOcupacionRelojero", TiempoOcupacionRelojero.ToString());

            ContadorClientes = 0;
            filaAnterior.Add("ContadorClientes", ContadorClientes.ToString());

            ClientesSinReloj = 0;
            filaAnterior.Add("ClientesSinReloj", ClientesSinReloj.ToString());

            acumTiempoAyu = 0;
            acumTiempoRel = 0;

            dgvColas.Rows.Add(contIt,
                Evento,
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
                Complejidad,
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
                ContadorClientes,
                ClientesSinReloj);


            for (int i = 1; i <= iteraciones && double.Parse(Reloj) <= tiempo; i++)
            {
                contIt++;

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
                Complejidad = "";
                TiempoReparacion = "";
                FinReparacion = "";
                TiempoAtencionRetiro = "";
                FinRetiro = "";
                EstadoAyudante = "";
                EstadoRelojero = "";


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
                    finEntregaReloj(contIt, h, a, tiempoVentaA, tiempoVentaB, tiempoEntrega, tiempoRetiro);
                }

                //Si el evento es "fin_reparacion_reloj"
                if (Evento.Equals(eventos[3]))
                {
                    finReparacionReloj(contIt, h, a);
                }

                //Si el evento es "fin_retiro_reloj"
                if (Evento.Equals(eventos[4]))
                {
                    finRetiroReloj(tiempoVentaA, tiempoVentaB, tiempoEntrega, tiempoRetiro);
                }

                if (double.Parse(Reloj) >= desde)
                {
                    contadorIteraciones++;

                    if (contadorIteraciones <= hasta || i >= iteraciones || double.Parse(Reloj) >= tiempo)
                    {
                        dgvColas.Rows.Add(contIt,
                        Evento,
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
                        Complejidad,
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
                        ContadorClientes,
                        ClientesSinReloj);
                    }
                }

                //if (i >= iteraciones || double.Parse(Reloj) >= tiempo)
                //{
                //    if (EstadoAyudante.Equals("Ocupado"))
                //    {
                //        TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]) + double.Parse(Reloj) - double.Parse(InicioOcupacionAyudante);
                //    }

                //    if (EstadoRelojero.Equals("Ocupado"))
                //    {
                //        TiempoOcupacionRelojero = double.Parse(Reloj) + double.Parse(filaAnterior["TiempoOcupacionRelojero"]) - double.Parse(InicioOcupacionRelojero);
                //    }
                //}


                int cantFilas = dgvColas.Rows.Count - 1;

                if (nroOrdenCliente <= 50)
                {
                    foreach (DictionaryEntry item in Clientes)
                    {
                        Cliente aux = (Cliente)item.Value;

                        dgvColas.Rows[dgvColas.Rows.Count - 1].Cells["cliente" + aux.Id.ToString()].Value = aux.Estado;
                    }
                }


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

            if (EstadoAyudante.Equals("Ocupado"))
            {
                TiempoOcupacionAyudante = double.Parse(filaAnterior["TiempoOcupacionAyudante"]) + double.Parse(Reloj) - double.Parse(InicioOcupacionAyudante);
            }

            if (EstadoRelojero.Equals("Ocupado"))
            {
                TiempoOcupacionRelojero = double.Parse(Reloj) + double.Parse(filaAnterior["TiempoOcupacionRelojero"]) - double.Parse(InicioOcupacionRelojero);
            }


            //Asignacion de los valores de Tiempo Ocupacion correspondientes en la ultima fila....
            dgvColas.Rows[dgvColas.Rows.Count - 1].Cells["ayudante2"].Value = TiempoOcupacionAyudante;
            dgvColas.Rows[dgvColas.Rows.Count - 1].Cells["relojero2"].Value = TiempoOcupacionRelojero;


            double porcOcupacionAyudante = ((TiempoOcupacionAyudante - tiempoAyudanteIni) * 100f) / double.Parse(Reloj);

            double porcOcupacionRelojero = ((TiempoOcupacionRelojero - tiempoRelojeroIni) * 100f) / double.Parse(Reloj);



            lblTOPA.Text = (Math.Round(porcOcupacionAyudante, 2)).ToString() + "%";
            lblTOPR.Text = (Math.Round(porcOcupacionRelojero, 2)).ToString() + "%";


            btnIniciar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvColas.Rows.Clear();

            dgvEuler.Rows.Clear();


            foreach (DictionaryEntry item in Clientes)
            {
                Cliente aux = (Cliente)item.Value;

                if (aux.Id <= 50)
                {
                    dgvColas.Columns.Remove("cliente" + aux.Id.ToString());
                }
            }

            oDatos = new Datos();

            filaAnterior = new Dictionary<string, string>();

            oGenerador = new Generador();

            Clientes = new Hashtable();

            colaAyudante = new List<Cliente>();

            colaAux = new List<Cliente>();

            btnIniciar.Enabled = true;

            nroOrdenCliente = 0;

            lblTOPA.Text = "";
            lblTOPR.Text = "";
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            dgvEuler.Visible = true;
            btnEuler.Enabled = false;
            btnVolver.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            dgvEuler.Visible = false;
            btnVolver.Enabled = false;
            btnEuler.Enabled = true;
        }
    }
}
