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
    public partial class Ejer01FechaNacimiento : Form
    {
        public Ejer01FechaNacimiento()
        {
            InitializeComponent();
        }

        private void calcularDia_Click(object sender, EventArgs e)
        {
            int day = int.Parse(this.day.Text);
            int month = int.Parse(this.month.Text);
            int year = int.Parse(this.year.Text);

            if (month == 1)
            {
                month = 13;
                year -= 1;
            } else if (int.Parse(this.month.Text) == 2)
            {
                month = 14;
                year -= 1;
            }

            // 1. Multiplicar el Mes más 1 por 3 y dividirlo entre 5
            int op1 = ((int.Parse(this.month.Text) + 1) * 3) / 5;

            // 2. Dividir el año entre 4
            int op2 = year / 4;

            // 3. Dividir el año entre 100
            int op3 = year / 100;

            // 4. Dividir el año entre 400
            int op4 = year / 400;

            // 5. Sumar el dia, el doble del mes, el año, el resultado de la operación 1, el resultado de la operación 2,
            //menos el resultado de la operación 3 más la operación 4 más 2
            int op5 = day + (month * 2) + year + op1 + op2 - op3 + op4 + 2;

            // 6. Dividir el resultado anterior entre 7
            int op6 = op5 / 7;

            // 7. Restar el número del paso 5 con el número del paso 6 por 7
            int op7 = op5 - (op6 * 7);




            this.txtResultado.Text = op7.ToString();
        }
    }
}
