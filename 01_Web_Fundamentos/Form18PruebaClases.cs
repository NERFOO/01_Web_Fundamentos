using _02_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Web_Fundamentos
{
    public partial class Form18PruebaClases : Form
    {
        public Form18PruebaClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Jaime";
            persona.Apellidos = "Calderón Acero";
            persona.Edad = 21;
            persona.Nacionalidad = Paises.España;
            persona.Genero = TipoGenero.Masculino;
            
            this.listBox.Items.Add("Nombre: " + persona.Nombre + ", Apellidos: " + persona.Apellidos + ", Edad: " + persona.Edad);
            this.listBox.Items.Add("Nacionalidad: " + persona.Nacionalidad + ", Genero: " + persona.Genero);

            this.listBox.Items.Add("el nombre completo es: " + persona.GetNombreCompleto());


            persona.MetodoParametrosOpcionales(12);
            //ESTO ES PARA ATRIBUTOS OPCIONALES QUE YA OBV TIENEN VALOR PREDEFINIDO
            persona.MetodoParametrosOpcionales(12, numero2: 9999);

            //PARA VER LAS SOBRECARGAS/POLIMORFISMO
            persona.GetNombreCompleto();


            persona.Domicilio = new Direccion("Calle franco", "Madrid", 28560);
            this.listBox.Items.Add("Nombre: " + persona.Nombre);
            this.listBox.Items.Add("Domicilio: " + persona.Domicilio.Calle);
            this.listBox.Items.Add("Domicilio Vacaciones: " + persona.DomicilioVacaciones.Calle);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "Jaime";
            empleado.Apellidos = "Calderon Acero";
            //AHORA EL EMPLEADO ES UN LISTO
            this.listBox.Items.Add(empleado.GetNombreCompleto() + ", Salario: " + empleado.GetSalarioMinimo());
            this.listBox.Items.Add(empleado.GetNombreCompleto() + ", Vacaciones: " + empleado.GetDiasVacaciones());

            Director director = new Director();
            director.Nombre = "lola";
            director.Apellidos = "Flores";

            this.listBox.Items.Add(director.GetNombreCompleto() + ", Salario: " + director.GetSalarioMinimo());
            this.listBox.Items.Add(director.GetNombreCompleto() + ", Vacaciones: " + director.GetDiasVacaciones());

            this.listBox.Items.Add(director);

        }
    }
}
