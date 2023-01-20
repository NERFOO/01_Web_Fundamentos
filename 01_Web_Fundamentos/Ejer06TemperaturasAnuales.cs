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
    public partial class Ejer06TemperaturasAnuales : Form
    {
        List<Anio> years;
        List<Mes> meses;

        public Ejer06TemperaturasAnuales()
        {
            InitializeComponent();
            this.years = new List<Anio>();
            this.meses = new List<Mes>();
        }

        private void btnGenerarYears_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse("01/01/2018");
            for (int i = 0; i < 5 ; i++)
            {
                //LOS AÑOS DEBEN DE IR EN MINUSCULA A LA HORA DE LLAMAR AL METODO EN SUS PARAMETROS
                string anioActual = fecha.ToString("yyyy");
                fecha = fecha.AddYears(1);
                this.dropDown.Items.Add(anioActual);
            }
        }

        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Anio anio = new Anio();

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

                if(anio.TemperaturaMaximaYear < mes.TemperaturaMaxima)
                {
                    anio.TemperaturaMaximaYear = mes.TemperaturaMaxima;
                }
                if(anio.TemperaturaMinimaYear > mes.TemperaturaMinima)
                {
                    anio.TemperaturaMinimaYear = mes.TemperaturaMinima;
                }
            }
            this.inputMaxYear.Text = anio.TemperaturaMaximaYear.ToString();
            this.inputMinYear.Text = anio.TemperaturaMinimaYear.ToString();
            this.inputMediaYear.Text = anio.GetTemperaturaMediaYear().ToString();
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
