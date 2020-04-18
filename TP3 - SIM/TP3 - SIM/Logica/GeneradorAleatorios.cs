using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3___SIM.Logica
{
    class GeneradorAleatorios
    {
        private double min;
        private double max;
        private List<double> numeros;
        private object oGeneradorAleatorios;
        public static Random rnd = new Random();

        //METODOS GET Y SET

        public double Min
        {
            get { return min; }
            set { min = value; }
        }
        public double Max
        {
            get { return max; }
            set { max = value; }
        }
        public List<double> Numeros
        {
            get { return numeros; }
            set { numeros = value; }
        }

        //CONSTRUCTOR
        public GeneradorAleatorios()
        {
            Numeros = new List<double>();
        }


        public List<double> calcularAleatorioExponencial(int x, int A, int B, int RND, int cant)
        {
            double x1 = x;
            Numeros.Clear();



            return Numeros;
        }

        public List<double> calcularAleatorioUniforme(int A, int B, int cant)
        {
            double x1;
            Numeros.Clear();
            int RND = cant;

            for (int i = 0; i < cant; i++)
            {
                x1 = A + RND * (B - A);
            }


            return Numeros;
        }

        public List<double> calcularAleatorioNormal(int x, int a, int c, int m, int cant)
        {
            double x1 = x;
            Numeros.Clear();

            return Numeros;
        }

        public double generadorCS()
        {
            Random rnd = new Random();

            double aleatorio = (rnd.Next(10000));
            double aux = (double)aleatorio / 10000;

            return aux;
        }

        public List<double> generadorUniforme(double a, double b, int cantidad)
        {
            numeros.Clear();

            for (int i = 1; i <= cantidad; i++)
            {
                double x = 0;

                x = Math.Truncate((a + (b - a) * rnd.NextDouble())*10000) / 10000;

                numeros.Add(x);
            }

            return numeros;
        }
    }
}
