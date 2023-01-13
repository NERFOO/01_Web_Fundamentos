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
    public partial class Ejer03TiendaProductos : Form
    {
        public Ejer03TiendaProductos()
        {
            InitializeComponent();
            this.listTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.listTienda.Items.Add(this.inputProducto.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //NUMERO DE ELEMENTOS SELECCIONADOS
            int numSeleccionados = this.listTienda.SelectedIndices.Count;

            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                //RECUPERAMOS EL INDICE DEL PRODUCTO SELECCIONAO
                int numIndex = this.listTienda.SelectedIndices[i];
                this.listTienda.Items.RemoveAt(numIndex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
