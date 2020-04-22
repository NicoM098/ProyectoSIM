﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Intervalo[] armarIntervalos(int cant)
        {
            intervalos = new Intervalo[cant];
            double paso = Math.Round(((double)1 / cant), 2);
            double desde = 0;
            double hasta = desde + paso;
            int frecEsperada = (numeros.Count() / cant);

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
    }
}