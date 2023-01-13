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
    public partial class Form12Metodos : Form
    {
        public Form12Metodos()
        {
            InitializeComponent();
        }

        private void btnDoble_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.inputNumero.Text);
            this.GetDoble(num);

            //DIBUJAMOS EN RESULTADO
            this.resultado.Text= num.ToString();
        }

        void GetDoble(int numero)
        {
            //CAMBIAMOS EL VALOR DEL PARAMETRO WRAPPER RECIBIDO
            numero = numero * 2;
        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.inputNumero.Text);

            //TANTO EN EL METODO COMO EN LA LLAMADA DEBEMOS UTILIZAR REF
            this.GetDobleReferencia(ref num);
            this.resultado.Text = num.ToString();
        }

        void GetDobleReferencia( ref  int numero)
        {
            //CAMBIAMOS EL VALOR DE LA VARIABLE DE REFERENCIA
            numero = numero * 2;
        }
        int GetDobleNumero(int numero)
        {
            //CAMBIAMOS EL VALOR DE LA VARIABLE DE REFERENCIA
            int doble = numero * 2;
            return doble;
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnReferencia);
            this.CambiarColor(this.btnDoble);
        }

        void CambiarColor(Button boton)
        {
            //CAMBIAMOS ALGO DEL OBJETO
            boton.BackColor= Color.Aquamarine;
        }

        private void lblMause_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMause.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void inputNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //LA TECLA PULSADA --> e.KeyChar
            //DESACTIVA LAS ACCIONES POSTERIORES AL EVENTO --> e.Handled = true;
            //DEBEMOS INDICAR QUE SI ES LA TECLA DE BORRAR ESTE HABILITADO EL EVENTO
            //char teclaBorrar = (char)8;
            //EXISTE UNA ENUMERACION QUE NOS DEVUELVE EL CODIGO DE CADA TECLA
            char teclaBorrar = (char) Keys.Back;

            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void inputLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;

            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
