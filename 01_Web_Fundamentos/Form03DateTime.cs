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
    public partial class Form03DateTime : Form
    {
        public Form03DateTime()
        {
            InitializeComponent();

            this.inputFechaActual.Text = DateTime.Now.ToString();
        }

        private void checkBoxCambiarFecha_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.inputFechaActual.Text);
            if(this.checkBoxCambiarFecha.Checked == true)
            {
                this.inputFechaActual.Text = fecha.ToShortDateString();
            } else
            {
                this.inputFechaActual.Text = fecha.ToLongDateString();
            }
        }

        private void btnIncremento_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.incremento.Text);
            DateTime fecha = DateTime.Parse(this.inputFechaActual.Text);

            if(this.rdbDays.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            } else if (this.rdbMonths.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            } else
            {
                fecha = fecha.AddYears(incremento);
            }

            this.nuevaFecha.Text = fecha.ToString();
        }
    }
}
