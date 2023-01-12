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
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1.Text);
            int num2 = int.Parse(this.num2.Text);

            int resultado = num1 + num2;

            this.resultadoSuma.Text = "La suma es " + resultado.ToString();
        }
    }
}
