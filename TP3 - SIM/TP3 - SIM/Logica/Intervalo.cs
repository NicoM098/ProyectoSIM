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
        private double frecuenciaEsperada;
        private int frecuenciaObservada;
        private double marcaClase;
        private double probConMc;
        private double probAcum;

        public Intervalo(double desde, double hasta, double fe, int fo)
        {
            this.Desde = desde;
            this.Hasta = hasta;
            this.FrecuenciaEsperada = fe;
            this.FrecuenciaObservada = fo;
            this.MarcaClase = (Desde + Hasta) / (double) 2;            
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

        public double FrecuenciaEsperada
        {
            get { return frecuenciaEsperada; }
            set { frecuenciaEsperada = value; }
        }

        public double ProbConMc { get => probConMc; set => probConMc = value; }
        public double ProbAcum { get => probAcum; set => probAcum = value; }
        public double MarcaClase { get => marcaClase; set => marcaClase = value; }

        /*ublic int FrecuenciaObservada { get => frecuenciaObservada; set => frecuenciaObservada = value; }*/

        public void aumentarFO()
        {
            FrecuenciaObservada++;
        }
    }
}
