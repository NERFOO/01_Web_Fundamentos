using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using _02_Clases.Models;
using System.IO;

namespace _01_Web_Fundamentos
{
    public partial class Form23ObjetoXMLMascota : Form
    {
        //EL OBJETO PARA SERIALIZAR EN XML
        XmlSerializer serializer;

        public Form23ObjetoXMLMascota()
        {
            InitializeComponent();

            //EN EL MOMENTO DE INSTANCIAR EL OBJETO SERA NECESARIO INDICAR LA CLASE QUE UTILLIZARA EN LA SERIALIZACION
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void btnLeerDato_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            //LEER ES IGUAL SOLO QUE UTILIZA UN OBJETO LLAMADO STREAMREADER 
            using (StreamReader reader = new StreamReader("mascotas.xml"))
            {
                //NECESITAMOS REUPERAR EL OBJETO MASCOTA MEDIANTE EL SERIALZADOR , TIENE UN METODO LLAMADO
                //DESERIALIZE() QUE RECUPERA EL OBJETO SERIALIZADO
                mascota = (Mascota) this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtEdad.Text = mascota.Years.ToString();
        }

        private async void btnGuardarDato_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtEdad.Text);
            //PARA SERIALIZAR SE UTILIZA EL OBJETO DE SYSTEM.IO LLAMADO STREAMWRITER
            //NO IMPORTA LA EXTENSION DEL ARCHIVO, SIEMPRE LO ALMACENA EN XML
            using (StreamWriter writer = new StreamWriter("mascotas.xml"))
            {
                //EL SERIALIZADOR XML TIENE UN METODO LLAMADO SERIALIZE() QUE UTILIZA EL FICHERO PARA GUARDAR EL OBJETO
                this.serializer.Serialize(writer, mascota);

                //COMO HABLAMOS DE FICHEROS Y ESCRITURA DEBEMOS UTILIZAR FLUSH()
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
        }
    }
}
