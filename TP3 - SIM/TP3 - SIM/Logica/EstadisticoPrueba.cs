using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3___SIM.Logica
{
    class EstadisticoPrueba
    {
        double estadistico;

        public double calEstadisticoPrueba(double frecEsperada, int frecObservada)
        {
            double estPru = Math.Pow((frecEsperada - frecObservada), 2) / frecEsperada;
            return estPru;
        }

        public double Estadistico
        {
            get { return Estadistico; }
            set { Estadistico = value; }
        }
    }
}
