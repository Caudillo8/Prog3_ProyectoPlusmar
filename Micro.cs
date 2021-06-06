using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Plusmar
{
    [Serializable]
    class Micro
    {
       private int Capacidad;//static no acá
       private int NumeroMicro;
       private Pasajero _pasajero;
       private string _destino;

       public Micro (int Capacidad, int NumeroMicro, Pasajero _pasajero, string _destino)
        {
            this.Capacidad = Capacidad;
            this.NumeroMicro = NumeroMicro;
            this._destino = _destino;
            this._pasajero = _pasajero;
        }
        public Micro(int Capacidad, int NumeroMicro, string _destino)
        {
            this.Capacidad = Capacidad;
            this.NumeroMicro = NumeroMicro;
            this._destino = _destino;
        }
        public int capacidad
        {
            get
            {
                return Capacidad;
            }
            set
            {
                Capacidad = value;
            }
        }

        public int nroMicro { get { return NumeroMicro; } }
        public Pasajero pasajeroM { get { return _pasajero; } }
        public string destinoM { get { return _destino; } }

        //REPOSITORIO DE: MICROS, DESTINOS, PASAJEROS  NO HACE FALTA, INSTANCIARLOS NORMALMENTE SERIALIZAR, LA 2DA EXE COMENTAR
        //EMPAREJAR MICROS CON PASAJEROS X DESTINO
        //calcular asientos (si hay lugar)
        //AGREGAR-ELIMINAR: PASAJERO, MICRO, DESTINO

        public  bool BuscarMicro (Pasajero pasajero, Micro [] micro)///ver lo del bool en el meth
        {
            //bool match = false;
            foreach(Micro m in micro)
            {
                if ((m.capacidad >= pasajero.cantidadPjes)&&(
                    m._destino == pasajero.destinopasajero))
                {                  
                    m.capacidad  =  (m.capacidad)- (pasajero.cantidadPjes); //OCUPANDO ASIENTOS
                    //match = true;
                    Console.WriteLine("MICRO SELECCIONADO=  ", (m.nroMicro) );//MUESTRO EL MICRO DISPONIBLE
                    return true;
                }
                else
                {
                    Console.WriteLine("NO HAY LUGAR/NO EXISTE EL DESTINO");
                }                 
            }
        }
    }
}
