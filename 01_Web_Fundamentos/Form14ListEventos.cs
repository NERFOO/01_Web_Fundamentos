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
    public partial class Form14ListEventos : Form
    {
        //DECLARAMOS LA COLECCION A NIVEL DE CLASE PARA UTILIZARLA EN OTROS EVENTOS
        List<Button> botones;

        //VAMOS A TENER UNA VARIABLE CONTADOR
        //LAS VARIABLES A NIVEL DE CLASE MANTIENEN SU VALOR MENTRAS ESTEMOS TRABAJANDO CON ESTA CLASE
        int contador;

        public Form14ListEventos()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            contador = 0;

            //VAMOS A RELLENAR LA COLECCION CON TODOS LOS BOTONES DEL DIBUJO
            //this.botones.Add(this.button1);
            //DENTRO DE LA CLASE CONTROL (FORM) TENEMOS UNA COLECCION LLAMADA CONTROLS QUE CONTIENE TODOS
            //LOS CONTROLES DEL FORM, VAMOS A RECORRER TODOS LOS CONTROLES Y AÑADIRLOS A NUESTRA COLECION DE FORMA DINAMICA

            //UNA DE LAS NORMAS ES TENER SIEMPRE NUESTRAS COLECCIONES NO LAS DEL PROGRAMA
            foreach(Control control in this.Controls)
            {
                //DEBEMOS PREGUNTAR POR LOS CONTROLES BUTTON
                if(control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }

            //AQUI MANEJAMOS NUESTRA COLECCION PERSONALIZADA, ASOCIAMOS CADA BOTON DE LA COLECCION A UN METODO EVENTO
            foreach(Button boton in this.botones)
            {
                boton.Click += Boton_Click;
            }

        }

        private void Boton_Click(object? sender, EventArgs e)
        {
            this.contador++;
            this.txtMensaje.Text = "Contador: " + this.contador;

            //NECESITO ACCEDER AL BOTON, CUANDO PULSEMOS SOBRE EL BOTON, CAMBIAMOS SU COLOR...
            Button boton = (Button)sender;
            boton.BackColor = Color.Turquoise;
            boton.Text = this.contador.ToString();

        }
    }
}
