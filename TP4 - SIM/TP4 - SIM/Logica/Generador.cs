using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4___SIM.Logica
{
    class Generador
    {
        private Random rnd;

        public Generador()
        {
            rnd = new Random();
        }

        public double generadorUniforme()
        {
            double random = rnd.NextDouble();

            if (random == 0)
            {
                random = 0.0001;
            }
            return random;
        }
    }
}
