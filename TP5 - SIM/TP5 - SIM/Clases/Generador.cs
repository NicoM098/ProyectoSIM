using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5___SIM.Clases
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
                random = 0.01;
            }
            if (random == 1)
            {
                random = 0.99;
            }
            return random;
        }

        public double generadorUniforme(double A, double B, double random)
        {
            double x = A + random * (B - A);

            return x;
        }
    }
}
