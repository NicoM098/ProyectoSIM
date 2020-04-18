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

        public List<double> generadorCS(int cantNum)
        {
            Random rnd = new Random();

            Numeros.Clear();

            for (int i = 0; i < cantNum; i++)
            {
                double aleatorio = (rnd.Next(10000));
                double aux = (double)aleatorio / 10000;
                numeros.Add(aux);

                if (i == 0)
                {
                    min = aux;
                    max = aux;
                }
                if (aux < min)
                {
                    min = aux;
                }
                if (aux > max)
                {
                    max = aux;
                }
            }
            return numeros;
        }

    }
}
