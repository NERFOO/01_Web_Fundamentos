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
    public partial class Form08ColeccionGrafica : Form
    {
        public Form08ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.inputNewElemento.Text;
            this.listBox.Items.Add(elemento);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //NECESITAMOS RECUPERAR EL OBJETO SELECCIONADO DEL CONTROL LISTBOX
            //string seleccionado = this.listBox.SelectedItem.ToString();
            //this.listBox.Items.Remove(seleccionado);
            int indice = this.listBox.SelectedIndex;
            this.listBox.Items.RemoveAt(indice);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listBox.SelectedIndex != -1)
            {
                this.lblIndice.Text = this.listBox.SelectedIndex.ToString();
                this.lblItem.Text = this.listBox.SelectedItem.ToString();
            }
        }
    }
}
