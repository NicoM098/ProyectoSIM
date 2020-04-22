using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3___SIM.Logica
{
    class Intervalo
    {
        private double desde;
        private double hasta;
        private int frecuenciaEsperada;
        private int frecuenciaObservada;
        private double marcaClase;
        private double probAcumulada;
        private double probConMC;

        public Intervalo(double desde, double hasta, int fe, int fo)
        {
            this.Desde = desde;
            this.Hasta = hasta;
            this.FrecuenciaEsperada = fe;
            this.FrecuenciaObservada = fo;
        }

        public double Desde
        {
            get { return desde; }
            set { desde = value; }
        }

        public double Hasta
        {
            get { return hasta; }
            set { hasta = value; }
        }

        public int FrecuenciaObservada
        {
            get { return frecuenciaObservada; }
            set { frecuenciaObservada = value; }
        }

        /*
        public double Desde { get => desde; set => desde = value; }
        public double Hasta { get => hasta; set => hasta = value; }*/

        public int FrecuenciaEsperada
        {
            get { return frecuenciaEsperada; }
            set { frecuenciaEsperada = value; }
        }

        /*ublic int FrecuenciaObservada { get => frecuenciaObservada; set => frecuenciaObservada = value; }*/

        public void aumentarFO()
        {
            FrecuenciaObservada++;
        }
    }
}
