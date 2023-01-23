using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using _02_Clases.Helpers;
using System.Security.Cryptography;

namespace _01_Web_Fundamentos
{
    public partial class Form21Files : Form
    {
        public Form21Files()
        {
            InitializeComponent();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            //OBJETO PARA ABRIR FILES
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string contenido = await HelperFiles.ReadFileAsync(path);
                this.textBox.Text = contenido;
                //DIBUJAMOS LOS DATOS EN UN LISTBOX
                this.SetStringNombres(contenido);

            }
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                string contenido = this.GetStringNombres();
                await HelperFiles.WriteFileAsync(path, contenido);
                MessageBox.Show("Datos guardados");
            }
        }

        //METODO PARA RECUPERAR TODOS LOS NOMBRES    
        //DE LA LISTA EN FORMATO SEPARADOS POR COMAS
        public string GetStringNombres()
        {
            string datos = "";
            foreach (string nombre in this.listNombres.Items)
            {
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;
        }

        //METODO PARA ESCRIBIR LOS NOMBRES QUE    
        //TENGAMOS EN UN STRING EN EL LISTBOX
        public void SetStringNombres(string data)
        {
            //ANTONIA,ADRIAN,LUCIA
            string[] nombres = data.Split(',');
            this.listNombres.Items.Clear();
            foreach (string name in nombres)
            {
                this.listNombres.Items.Add(name);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = this.inputNombre.Text;
            this.listNombres.Items.Add(nombre);
            this.inputNombre.SelectAll();
            this.inputNombre.Focus();
        }


    }
}
