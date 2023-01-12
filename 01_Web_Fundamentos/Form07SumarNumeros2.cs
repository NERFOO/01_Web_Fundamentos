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
    public partial class Form07SumarNumeros2 : Form
    {
        public Form07SumarNumeros2()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            string txtNumeros = this.inputNum.Text;

            for(int i = 0; i < txtNumeros.Length; i++)
            {
                char caracter = txtNumeros[i];
                int numero = int.Parse(caracter.ToString());
                suma += numero;
            }

            this.resultado.Text = "El resultado de la suma es: " + suma;


        }
    }
}
