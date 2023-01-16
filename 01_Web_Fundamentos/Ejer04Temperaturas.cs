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
    public partial class Ejer04Temperaturas : Form
    {

        List<string> meses;
        List<int> temperaturas;

        public Ejer04Temperaturas()
        {
            InitializeComponent();
            
            this.meses = new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", };
            
            this.temperaturas = new List<int>();
            Random aleat = new Random();

            for(int i = 0; i < meses.Count; i++)
            {
                this.temperaturas.Add(aleat.Next(-15, 40));
                this.listBox.Items.Add(meses[i]);
            }
        }

    }
}
