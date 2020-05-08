using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP4___SIM.Logica
{
    class Almacenamiento
    {
        private string ruta;
       
        public Almacenamiento()
        {
            //ruta = "C:\\Hola.csv";
            ruta = "C:\\Users\\famil\\Desktop\\Simulacion.csv";
        }

        public void newFile()
        {
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }
        }

        public void saveData(string[] row)
        {
            
            string data = "";
            for (int i = 0; i < row.Length; i++)
            {
                data += row[i] + ";";
            }
            using (System.IO.StreamWriter file =new System.IO.StreamWriter(ruta, true))
            {
                file.WriteLine(data);
            }            
        }
    }
}
       
 

