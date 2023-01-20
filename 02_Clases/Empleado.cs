using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    public class Empleado: Persona
    {

        protected int SalarioMinimo { get; set; }

        public Empleado()
        {
            Debug.WriteLine("Constructor empleado Vacio");
            this.SalarioMinimo = 1500;
        }


        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacacciones() EMPLEADO");
            return 22;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public Empleado(string nombre, string apellidos) : base(nombre, apellidos)
        {
            Debug.WriteLine("Constructor EMPLEADO dos parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
    }
}
