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

            //CREAR EVENTO DEL CLICK DEL BOTON GENERAR MESES
            this.btnMeses.Click += BtnMeses_Click;

            //CREAR EVENTO DEL CLICK DEL BOTON MOSTRAR
            this.btnMostrar.Click += BtnMostrar_Click;

        }

        private void BtnMostrar_Click(object? sender, EventArgs e)
        {
            this.inputMax.Text = this.temperaturas.Max().ToString();
            this.inputMax.ForeColor = System.Drawing.Color.Blue;
            this.inputMax.TextAlign = HorizontalAlignment.Center;

            this.inputMin.Text = this.temperaturas.Min().ToString();
            this.inputMin.ForeColor = System.Drawing.Color.Red;
            this.inputMin.TextAlign = HorizontalAlignment.Center;

            this.inputMedia.Text = Math.Truncate(this.temperaturas.Average()).ToString();
            this.inputMedia.ForeColor = System.Drawing.Color.Blue;
            this.inputMedia.TextAlign = HorizontalAlignment.Center;


            //int maxima = 0;
            //int minima = 0;
            //int media = 0;
            //int suma = 0;
            //foreach (int temp in this.temperaturas)
            //{
            //    maxima = Math.Max(maxima, temp);
            //    minima = Math.Min(minima, temp);
            //    suma += temp;
            //}
            //media = suma / this.temperaturas.Count;
            //this.txtTemperaturaMaxima.Text = maxima.ToString();
            //this.txtTemperaturaMinima.Text = minima.ToString();
            //this.txtTemperaturaMedia.Text = media.ToString();



        }

        private void BtnMeses_Click(object? sender, EventArgs e)
        {
            //MESES DEL AÑO EN UNA LISTA
            this.meses = new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            //TEMPERATURAS ALEATORIAS
            this.temperaturas = new List<int>();
            Random aleat = new Random();

            //RESETEA LOS RANDOMS
            this.temperaturas.Clear();

            //RESETEA LA LISTA
            this.listBox.Items.Clear();

            //AÑADE LOS MESES A LA LISTA
            for (int i = 0; i < meses.Count; i++)
            {
                this.temperaturas.Add(aleat.Next(-15, 40));
                this.listBox.Items.Add(meses[i] + ": " + temperaturas[i]);
            }


            //this.temperaturas.Clear();
            //this.lstMeses.Items.Clear();
            //Random random = new Random();
            //DateTime fecha = DateTime.Parse("01/01/2023");
            //for (int i = 1; i <= 12; i++)
            //{
            //    int temp = random.Next(-20, 40);
            //    this.temperaturas.Add(temp);
            //    string nombreMes = fecha.ToString("MMMM");
            //    fecha = fecha.AddMonths(1);
            //    this.lstMeses.Items.Add(nombreMes + ": " + temp);
            //}

        }
    }
}
