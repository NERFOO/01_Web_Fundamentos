using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//USING MANUALES
using System.Xml.Serialization;
using System.IO;
using _02_Clases.Models;
using _02_Clases.Helpers;

namespace _01_Web_Fundamentos
{
    public partial class Form24ColeccionXMLMascotas : Form
    {

        XmlSerializer serializer;
        List<Mascota> coleccionMascotas;
        string path;

        public Form24ColeccionXMLMascotas()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(List<Mascota>));
            this.coleccionMascotas = new List<Mascota>();
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtEdad.Text);

            //CONVERT FILE TO BYTE[]
            //mascota.Imagen = Image.FromFile(@"C:\Users\User\Desktop\Certificados y documentos de interes\logo NERFO\logoFondoNegro.png");
            //byte[] imageBytes = File.ReadAllBytes(@"C:\Users\User\Desktop\Certificados y documentos de interes\logo NERFO\logoFondoNegro.png");
            //mascota.Imagen = imageBytes;
            //PARA PINTAR NECESITAMOS LA CLASE IMAGE: IMAGE.FROMSTREAM(STREAM)
            //this.image.Image = mascota.Imagen.ToString();
            //string cadena = Encoding.UTF8.GetString(mascota.Imagen);
            //this.image.Image = cadena;

            //MemoryStream ms = new MemoryStream();
            //this.image.Image = System.Drawing.Image.FromStream(imageBytes);

            // CONVERT FILE TO BYTE []
            mascota.Imagen = HelperFiles.ConvertFileToByteArray(this.path);

            // PARA PINTAR NECESITAMOS LA CLASE IMAGE: Image.FromStream(stream);
            Stream stream = new MemoryStream(mascota.Imagen);
            this.image.Image = Image.FromStream(stream);

            this.coleccionMascotas.Add(mascota);
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
            this.DibujarMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach(Mascota mascota in this.coleccionMascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }


        private void btnLeer_Click(object sender, EventArgs e)
        {
            using(StreamReader reader = new StreamReader("coleccionmascotas.xml"))
            {
                this.coleccionMascotas = (List<Mascota>)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.DibujarMascotas();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            using(StreamWriter writer = new StreamWriter("coleccionmascotas.xml"))
            {
                this.serializer.Serialize(writer, this.coleccionMascotas);
                await writer.FlushAsync();
                writer.Close();
            }
            this.lstMascotas.Items.Clear();
            this.coleccionMascotas.Clear();
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstMascotas.SelectedIndex;
            if(indice != -1)
            {
                Mascota mascota = this.coleccionMascotas[indice];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Years.ToString();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.path = ofd.FileName;
            }
        }
    }
}
