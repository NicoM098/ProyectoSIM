using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5___SIM.Clases
{
    class Cliente
    {
        private int id;
        private string estado;

        public Cliente()
        {
        }

        public Cliente(int id, string estado)
        {
            this.id = id;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
