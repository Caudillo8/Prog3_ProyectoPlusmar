using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Plusmar
{
    [Serializable]
    static class Sistema       
    {
        static public Micro[] listaMicro;
        static public Pasajero listaPasajero ;

        static public bool TomarRSV( Pasajero _mipasajero, Micro _mimicro)//...no todas los accesos devuelven un valor
        {
            if (_mimicro.BuscarMicro (_mipasajero,listaMicro))

               listaPasajero.AgregarPasajero(_mipasajero);
        }

        static public void Imprimir(Micro []lista_micros)
        {
            foreach( Micro micro in lista_micros)
            {
                Console.WriteLine(micro.nroMicro.ToString(), "    ", micro.destinoM
                                  ,"    ", micro.capacidad);
            }
            Console.WriteLine("------------------------------------------------");
        }
        static public void Imprimir(Pasajero[] lista_pasajeros)
        {
            foreach (Pasajero pasajero in lista_pasajeros)
            {
                Console.WriteLine(pasajero.dni, "    ", pasajero.destinopasajero
                                  , "    ", pasajero.cantidadPjes);
            }
            Console.WriteLine("------------------------------------------------");
        }


        //ESCRITURA
        /*  Stream flujo = File.Create("PLUSMAR1.bin");
          serializer. Serialize(flujo, Sistema);
          flujo.Close();*/
    }
}
