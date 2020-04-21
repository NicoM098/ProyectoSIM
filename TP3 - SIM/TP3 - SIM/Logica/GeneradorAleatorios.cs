using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.ComponentModel;

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


        //Generador Exponencial Negativa
        public List<double> generadorExponencial(int cantidad)
        {
            Numeros.Clear();
            List<double> numerosAleatorios = new List<double>();

            //ACA habría que calcular el lambda, si queremos pasar por parametro la media..
            //
            double acumulador = 0;

            for (int i = 0; i < cantidad; i++)
            {
                
                double x = rnd.NextDouble();
                numerosAleatorios.Add(x);

                acumulador += x;
            }

            double media = acumulador / cantidad;
            double lambda = 1 / media;

            for (int i = 0; i < cantidad; i++)
            {

                double x = 0;

                x = Math.Log(1 - numerosAleatorios.ElementAt(i)) / (-lambda);
                Numeros.Add(x);
            }
            return Numeros;
        }

        public List<double> generadorNormal(int cant)
        {
            numeros.Clear();
           
            double aux = 1;

            List<double> numerosUniformes = new List<double>(generadorUniforme(0, 1, cant));

            numeros.Clear();

            double media = numerosUniformes.Average();

            for (int i = 0; i < cant; i++)
            {
                aux += Math.Pow(numerosUniformes.ElementAt(i) - media, 2);
            }

            double varianza = ((double)1 / (double)(cant - 1)) * aux;
            double desvEstandar = Math.Sqrt(varianza);

            for (int i = 0; i < cant; i+=2)
            {
                double rnd1 = numerosUniformes.ElementAt(i);
                double rnd2 = numerosUniformes.ElementAt(i+1);

                double N1 = Math.Truncate((((Math.Sqrt(-2 * Math.Log(rnd1))) * Math.Cos(2 * Math.PI * rnd2)) * desvEstandar + media)*10000) / 10000;
                double N2 = Math.Truncate((((Math.Sqrt(-2 * Math.Log(rnd1))) * Math.Sin(2 * Math.PI * rnd2)) * desvEstandar + media)*10000) / 10000;

                numeros.Add(N1);
                numeros.Add(N2);
            }
            return numeros;
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
