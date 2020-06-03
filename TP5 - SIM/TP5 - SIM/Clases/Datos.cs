using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5___SIM.Clases
{
    public class Datos
    {
        private double tiempo;
        private int iteraciones;
        private int desde;
        private double hasta;

        private List<double> distProbDestino = new List<double>();

        private double llegClienteA;
        private double llegClienteB;

        private double tiempoVentaA;
        private double tiempoVentaB;

        private double tiempoRepA;
        private double tiempoRepB;

        private double tiempoRelojero;

        public Datos()
        {
        }

        //GETTERS Y SETTERS
        public double Tiempo { get => tiempo; set => tiempo = value; }
        public int Iteraciones { get => iteraciones; set => iteraciones = value; }
        public int Desde { get => desde; set => desde = value; }
        public double Hasta { get => hasta; set => hasta = value; }

        public List<double> DistProbDestino { get => distProbDestino; set => distProbDestino = value; }

        public double LlegClienteA { get => llegClienteA; set => llegClienteA = value; }
        public double LlegClienteB { get => llegClienteB; set => llegClienteB = value; }

        public double TiempoVentaA { get => tiempoVentaA; set => tiempoVentaA = value; }
        public double TiempoVentaB { get => tiempoVentaB; set => tiempoVentaB = value; }

        public double TiempoRepA { get => tiempoRepA; set => tiempoRepA = value; }
        public double TiempoRepB { get => tiempoRepB; set => tiempoRepB = value; }

        public double TiempoRelojero { get => tiempoRelojero; set => tiempoRelojero = value; }

        public void CargarDatos(double tiempo, int iteraciones, int desde, double hasta, List<double> distProbDest, double llegClienteA, double llegClienteB, double tiempoVentaA, double tiempoVentaB, double tiempoRepA, double tiempoRepB, double tiempoRelojero)
        {
            this.distProbDestino.Clear();

            this.tiempo = tiempo;
            this.iteraciones = iteraciones;
            this.desde = desde;
            this.hasta = hasta;
            this.distProbDestino = distProbDest;
            this.llegClienteA = llegClienteA;
            this.llegClienteB = llegClienteB;
            this.tiempoVentaA = tiempoVentaA;
            this.tiempoVentaB = tiempoVentaB;
            this.tiempoRepA = tiempoRepA;
            this.tiempoRepB = tiempoRepB;
            this.tiempoRelojero = tiempoRelojero;
        }
    }
}
