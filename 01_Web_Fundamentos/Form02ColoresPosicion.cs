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
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.posicionX.Text);
            int y = int.Parse(this.posicionY.Text);

            this.btnPosicion.Location = new Point(x, y);
        }

        private void btnColorFondo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(this.opcionColor.Text);

            MessageBox.Show("El color ha cambiado a " + this.opcionColor.Text);
        }

    }
}
