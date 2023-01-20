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
        List<Mes> meses;

        public Ejer05TemperaturasClases()
        {
            InitializeComponent();
            this.meses = new List<Mes>();
        }

        private void btnMeses_Click_1(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
            this.meses.Clear();
            Random random = new Random();
            DateTime tiempo = DateTime.Parse("01/01/2023");
            for (int i = 1; i <= 12; i++)
            {
                Mes mes = new Mes();
                string nombremes = tiempo.ToString("MMMM").ToUpper();
                mes.NombreMes = nombremes;
                mes.TemperaturaMaxima = random.Next(10, 50);
                mes.TemperaturaMinima = random.Next(-10, 9);
                this.meses.Add(mes);
                this.listBox.Items.Add(nombremes);
                tiempo = tiempo.AddMonths(1);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox.SelectedIndex != -1)
            {
                int indice = this.listBox.SelectedIndex;
                Mes mes = this.meses[indice];
                this.inputMax.Text = mes.TemperaturaMaxima.ToString();
                this.inputMin.Text = mes.TemperaturaMinima.ToString();
                this.inputMedia.Text = mes.GetTemperaturaMedia().ToString();
            }
        }
    }

}
