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
            ruta = "C:\\Hola.csv";
        }

        //Lee todo el archivo, lo almacena en el vector y lo recorre

        //public void readData(DataGridView dgv, int desde, int hasta)
        //{
        //    string[] lines = System.IO.File.ReadAllLines(ruta);
        //    dgv.Rows.Clear();
        //    if (lines.Length > 0)
        //    {
        //        int i = 0;

        //        for (i = 1; i < lines.Length - 1; i++)
        //        {
        //            string[] dataWords = lines[i].Split(',');
        //            MessageBox.Show(dataWords[0].ToString());
        //            if (int.Parse(dataWords[0]) >= desde && int.Parse(dataWords[0]) <= hasta)
        //            {
        //                dgv.Rows.Add(dataWords);
        //            }


        //        }
        //    }
        //}


        // Va leyendo el archivo linea por linea
        public void readData(DataGridView dgv, int desde, int hasta, int cantVuelos)
        {
            //string[] lines = System.IO.File.ReadAllLines(ruta);
            StreamReader sr = new StreamReader(ruta);
            string currentRow = sr.ReadLine(); //La primera linea son los titulos de las columnas

            while (currentRow != null && currentRow != "")
            {
                currentRow = sr.ReadLine();
                string[] cells = currentRow.Split(';');

                if (cells[0] != "")
                {
                    if ((int.Parse(cells[0]) >= desde && int.Parse(cells[0]) <= hasta) || int.Parse(cells[0]) == cantVuelos)
                    {
                        dgv.Rows.Add(cells);
                    }
                }
            }
        }


        //Guarda los datos y abre el cuadro para elegir el lugar donde guardarlo
        //public void saveData(DataGridView dgv)
        //{

        //    if (dgv.Rows.Count == 0)
        //    {
        //        return;
        //    }
        //    //String builder representa una cadena de caracteres mutable a diferencia de string
        //    StringBuilder sb = new StringBuilder();

        //    // Guarda todos los nombres de las columnas en un string y separados por coma
        //    string columnsHeader = "";
        //    for (int i = 0; i < dgv.Columns.Count; i++)
        //    {
        //        columnsHeader += dgv.Columns[i].Name + ";";
        //    }

        //    sb.Append(columnsHeader + Environment.NewLine);

        //    // Recorre cada una de las filas del datagrid
        //   
        //    for (int i = 0; i < dgv.Rows.Count; i++)
        //    {
        //        DataGridViewRow dgvRow = dgv.Rows[i];
        //        for (int c = 0; c < dgvRow.Cells.Count; c++)
        //        {
        //            // La coma es el delimitador

        //            sb.Append(dgvRow.Cells[c].Value + ";");
        //        }
        //        sb.Append(Environment.NewLine);
        //    }
        //    // Load up the save file dialog with the default option as saving as a .csv file.
        //    SaveFileDialog sfd = new SaveFileDialog();
        //    sfd.Filter = "CSV files (*.csv)|*.csv";
        //    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        // If they've selected a save location...
        //        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false))
        //        {
        //            // Write the stringbuilder text to the the file.
        //            sw.WriteLine(sb.ToString());
        //            ruta = Path.GetFullPath(sfd.FileName);
        //        }
        //        MessageBox.Show("CSV file saved.");
        //    }





        //Guarda el archivo en la ruta que esta especificada como atributo de la clase

        public void saveData(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                return;
            }
            //String builder representa una cadena de caracteres mutable a diferencia de string
            StringBuilder sb = new StringBuilder();

            // Guarda todos los nombres de las columnas en un string y separados por coma
            string columnsHeader = "";
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                columnsHeader += dgv.Columns[i].Name + ";";
            }

            sb.Append(columnsHeader + Environment.NewLine);

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow dgvRow = dgv.Rows[i];
                for (int c = 0; c < dgvRow.Cells.Count; c++)
                {
                    // La coma es el delimitador

                    sb.Append(dgvRow.Cells[c].Value + ";");
                }
                sb.Append(Environment.NewLine);
            }

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(ruta, false))
            {
                // Escribe lo que tiene el stringBuilder en el archivo
                sw.WriteLine(sb.ToString());
            }
        }

    }
}

