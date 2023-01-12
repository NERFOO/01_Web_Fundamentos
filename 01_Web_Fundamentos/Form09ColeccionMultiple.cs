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
    public partial class Form09ColeccionMultiple : Form
    {
        public Form09ColeccionMultiple()
        {
            InitializeComponent();
            this.listBox.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.inputNewElemento.Text;
            this.listBox.Items.Add(elemento);
            this.inputNewElemento.Focus();
            this.inputNewElemento.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //NO PODEMOS ELIMINAR ELEMENTOS UTILIZANDO UN BUCLE DE REFERENCIA
            //DEBEMOS RECORRER TODOS LOS ELEMENTOS SELECCIONADOS
            //NOS INTERESA EL INDICE DE CADA ELEMENTO
            //NUMERO DE ELEMENTOS SELECCIONADOS
            int numSeleccionado = this.listBox.SelectedIndices.Count;
            //RECORREMOS TODOS LOS INDICES SELECCIONADOS
            for (int i = numSeleccionado - 1; i >= 0 ; i--)
            {
                //RECUPERAMOS EL INDICE SELECCIONADO
                int indice = this.listBox.SelectedIndices[i];
                //POR ULTIMO, ELIMINAMOS EL ELEMENTO POR SU INDICE
                this.listBox.Items.RemoveAt(indice);
            }
        }

        private void btnSeleccionado_Click(object sender, EventArgs e)
        {
            //COMO SOLAMENTE VAMOS A DIBUJAR PODEMOS UTILIZAR BUCLES DE REFERENCIA
            string indices = "";
            foreach (int indice in this.listBox.SelectedIndices)
            {
                indices += indice + ", ";
            }
            this.lblIndice.Text = indices.Trim(',');

            string items = "";
            foreach (string elem in this.listBox.SelectedItems)
            {
                items += elem + ", ";
            }
            this.lblItem.Text = items;
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
        }
    }
}
