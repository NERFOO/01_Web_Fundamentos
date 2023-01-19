using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal{ get; set; }

        //CONSTRUCTOR VACIO
        public Direccion()
        {
            Debug.WriteLine("Constructor direccion UN parametros");
        }

        public Direccion(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;

            Debug.WriteLine("Constructor direccion DOS parametros");
        }

        public Direccion(string calle, string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;

            Debug.WriteLine("Constructor direccion TRES parametros");
        }
    }
}
