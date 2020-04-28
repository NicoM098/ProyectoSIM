using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3___SIM.Logica
{
    class GestorIntervalo
    {
        private List<double> numeros;
        private Intervalo[] intervalos;

        public GestorIntervalo(List<double> aleatorios)
        {
            numeros = aleatorios;
        }


        public Intervalo[] armarUniforme(int cant, int limiteS, int limiteI)
        {
            intervalos = new Intervalo[cant];
            double paso = Math.Round(((double) (limiteS-limiteI) / (double) cant), 2);
            double desde = limiteI;
            double hasta = desde + paso;
            double frecEsperada = Math.Round((numeros.Count() / (double)cant), 2);

            List<double> aux = numeros;

            for (int i = 0; i < cant; i++)
            {
                //Asignamos los valores a cada objeto intervalo de la lista intervalos
                intervalos[i] = new Intervalo(desde, hasta, frecEsperada, 0);

                for (int j = 0; j < aux.Count(); j++)
                {
                    //Compara cada valor de aux con el valor del hasta del intervalo que recien creamos, si es menor
                    //quiere decir que el valor entra en el intervalo, entonces hay que aumentar la frecuenciaObservada
                    //de ese intervalo
                    //Remuevo el valor porque ya lo procese y no puede entrar en otro intervalo, 
                    //de esta forma se reducen las comparaciones
                    //Entonces tener en cuenta que aux.Cont(), que es el limite del ciclo, va a ir cambiando

                    //Esto sirve porque en el vector de intervalos, los Hasta estan "ordenados"
                    if (aux.ElementAt(j) <= intervalos[i].Hasta)
                    {
                        intervalos[i].aumentarFO(); //Metodo de la clase Intervalo que hace aumentar el valor de Frecuencia Observada en una unidad
                        aux.RemoveAt(j);
                        //Esto es para evitar que se saltee de comparar un numero
                        j--;
                    }
                }
                desde = hasta;
                hasta += paso;
            }
            return intervalos;
        }


        public Intervalo[] armarExponencial(int cant, double limiteS, double limiteI, double lambda)
        {
            intervalos = new Intervalo[cant];
            double paso = (double)(limiteS) / (double)cant;
            double desde = 0;
            double hasta = desde + paso;

            double acumulador = 0;

            List<double> aux = numeros;

            for (int i = 0; i < cant; i++)
            {
                double frecEsperada = Math.Truncate(feExponencial(desde, hasta, lambda, cant) * 10000) / 10000;

                acumulador += ((1 - Math.Exp(-lambda * hasta)) - (1 - Math.Exp(-lambda * desde)));

                intervalos[i] = new Intervalo(desde, hasta, frecEsperada, 0);

                for (int j = 0; j < aux.Count(); j++)
                {
                    if (aux.ElementAt(j) <= intervalos[i].Hasta)
                    {
                        intervalos[i].aumentarFO();
                        aux.RemoveAt(j);
                        j--;
                    }
                }
                desde = hasta;
                hasta += paso;
            }

            return intervalos;
        }


        public Intervalo[] armarNormal(int cant, double limiteS, double limiteI, double media, double desvEstandar)
        {
            intervalos = new Intervalo[cant];
            double paso = (double)(limiteS - limiteI) / (double)cant;
            double desde = limiteI;
            double hasta = desde + paso;

            List<double> aux = numeros;

            for (int i = 0; i < cant; i++)
            {
                double frecEsperada = Math.Truncate(feNormal(desde, hasta, media, desvEstandar) * 10000) / 10000;           
                intervalos[i] = new Intervalo(desde, hasta, frecEsperada, 0);

                for (int j = 0; j < aux.Count(); j++)
                {
                    if (aux.ElementAt(j) <= intervalos[i].Hasta)
                    {
                        intervalos[i].aumentarFO();
                        aux.RemoveAt(j);
                        j--;
                    }
                }
                desde = hasta;
                hasta += paso;
            }
            return intervalos;
        }


        public double feExponencial(double desde, double hasta, double lambda, double N)
        {
            return ((1 - Math.Exp(-lambda * hasta)) - (1 - Math.Exp(-lambda * desde))) * N;
        }


        public double feNormal(double desde, double hasta, double media, double desvEstandar)
        {
            double mc = Math.Round((desde + hasta) / (double)2,6); //Redondeo a 6 decimales para que no me de periodico
            double fe = (Math.Exp(-0.5 * (Math.Pow(((mc - media) / desvEstandar), 2)))/(desvEstandar*Math.Sqrt(2*Math.PI)))*(hasta-desde);
            return fe;
        }
    }
}
