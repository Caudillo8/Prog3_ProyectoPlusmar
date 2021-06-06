using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Plusmar
{
    [Serializable]
    class Pasajero
    {
        //ATRIBUTOS, MET ACCESO, CONSTRUCTORES
        private string Nombre;
        private string Dni;
        private int cantPasajes;
        private string _destino;

        public Pasajero(string Nombre, string Dni, int cantPasajes, string _destino)
        {
            this.Nombre = Nombre;
            this.Dni = Dni;
            this.cantPasajes = cantPasajes;
            this._destino = _destino;
        }
        public string nombre { get; set; }
        public string dni { get; set; }
        public int cantidadPjes { get; set; }
        public string destinopasajero { get; set; }

        public void AgregarPasajero(Pasajero p)
        {
            List<Pasajero> listaPasajeros = new List<Pasajero>();
            listaPasajeros.Add(p);     
        }


    }
}
