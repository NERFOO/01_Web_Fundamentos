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
            this.InsertarProducto();
        }
        void InsertarProducto()
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
            //NUMERO DE ELEMENTOS SELECCIONADOS
            int numSeleccionados = this.listTienda.SelectedIndices.Count;

            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                //RECUPERAMOS EL INDICE DEL PRODUCTO SELECCIONAO
                int numIndex = this.listTienda.SelectedIndices[i];
                numIndex.ToString(this.inputProducto.Text);
            }
        }

        private void inputProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.listTienda.Items.Add(this.inputProducto.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.listTienda.Items.Clear();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //NUMERO DE ELEMENTOS SELECCIONADOS
            int numSeleccionados = this.listTienda.SelectedIndices.Count;

            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                //RECUPERAMOS EL INDICE DEL PRODUCTO SELECCIONAO
                int numIndex = this.listTienda.SelectedIndices[i];
                this.listAlmacen.Items.Add(this.listTienda.SelectedItem);
                this.listTienda.Items.RemoveAt(numIndex);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach(string item in this.listTienda.Items)
            {
                this.listAlmacen.Items.Add((string)item);
            }
            this.listTienda.Items.Clear();
        }

        private void listAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listAlmacen.SelectedIndex == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
            }
            
            if(this.listAlmacen.SelectedIndex == this.listAlmacen.Items.Count - 1)
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            this.listAlmacen.SelectedIndex--;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            this.listAlmacen.SelectedIndex++;
        }
    }
}
