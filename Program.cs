using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Plusmar
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //----------------------------------------------------INSTANCIO MI LISTA DE MICROS
            Micro[] micros = new Micro[3];
            micros[0] = new Micro(10, 1, "Córdoba");
            micros[1] = new Micro(15, 5, "La Pampa");
            micros[2] = new Micro(20, 11, "Mendoza");

            //DESERIALIZAR AQUÍ----LECTURA-----------------------   
            if (File.Exists("PLUSMAR1.bin"))
            {
                Stream flujo2 = File.OpenRead("PLUSMAR1.bin");
                BinaryFormatter deserealizer = new BinaryFormatter() ;
                Sistema  = deserealizer.Deserialize(flujo2);//es tipo y se usa como var
                flujo2.Close();
            }
            Application.Run(new FormLogin());
        }
    }
}
