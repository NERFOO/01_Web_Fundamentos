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
    public partial class Ejer05TemperaturasClases : Form
    {
        public Ejer05TemperaturasClases()
        {
            InitializeComponent();
            this.btnMeses.Click += BtnMeses_Click;
        }

        private void BtnMeses_Click(object? sender, EventArgs e)
        {
            this.listBox.Items.Clear();
            this.listBox.Items.Add();Temperaturas.GetMeses()
        }
    }
}
