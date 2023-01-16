using System;
using System.Collections;
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
    public partial class Form13ArrayList : Form
    {
        public Form13ArrayList()
        {
            InitializeComponent();

            //VAMOS A TENER UNA COLECCION NO TIPADA
            ArrayList colection = new ArrayList();
            colection.Add(this.button1);
            colection.Add(this.button2);
            colection.Add(this.button3);

            //AÑADIMOS LA CAJA A NUESTRA COLECCION
            colection.Add(this.textBox1);

            //SE ACCEDE DIRECTAMENTE A SUS PROPIEDADES/METODOS
            List<Button> buttons = new List<Button>();
            buttons.Add(this.button1);
            buttons.Add(this.button2);
            buttons.Add(this.button3);
            buttons[0].BackColor = Color.Lavender;

            //CONTROL DE ERRORES DE COMPILACION
            //buttons.Add(this.textBox1);


            //SI INTENTAMOS ACCEDER A LAS PRIPIEDADES NO LAS VEREMOS
            ((Button)colection[0]).Text = "Soy un boton";
            
            //LOS BUCLES FOREACH PUEDEN REALIZAR EL CASTING DE FORMA AUTOMATICA
            foreach(Control control in colection)
            {
                control.BackColor = Color.Coral;

                //TAMBIEN PODEMOS MANEJAR LOS OBJETOS POR SU CLASE CON PROPIEDADES ESPECIFICAS DEL OBJETO, PARA ELLO, DBEMOS PREGUNTAR 
                //Y HACER CASTING
                //QUIERO PEGAR EL CONTENIDO DEL PORTAPAPELES : PASTE()
                if(control is TextBox)
                {
                    ((TextBox)control).Paste();
                }
            }
        }
    }
}
