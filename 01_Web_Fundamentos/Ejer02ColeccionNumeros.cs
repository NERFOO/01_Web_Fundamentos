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
    public partial class Ejer02ColeccionNumeros : Form
    {
        public Ejer02ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numRandom = random.Next(1, 10);

            this.numRandoms.Items.Add(numRandom);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = 0, pares = 0, impares = 0;

            foreach (int numeros in this.numRandoms.Items)
            {
                if( numeros % 2 == 0)
                {
                    pares += numeros;
                    this.inputPares.Text = pares.ToString();
                } else
                {
                    impares += numeros;
                    this.inputImpares.Text = impares.ToString();
                }
                suma += numeros;
                this.inputSuma.Text = suma.ToString();
            }
        }
    }
}
