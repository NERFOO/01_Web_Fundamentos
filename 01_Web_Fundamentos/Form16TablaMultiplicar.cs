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
    public partial class Form16TablaMultiplicar : Form
    {

        List<TextBox> inputs;
        int contador;

        public Form16TablaMultiplicar()
        {
            InitializeComponent();
            this.inputs = new List<TextBox>();

            foreach(TextBox input in this.groupBox1.Controls)
            {
                if(input is TextBox)
                {
                    this.inputs.Add((TextBox)input);
                }
            }

            this.inputs.Reverse();

            for(int i = 0; i < inputs.Count; i++)
            {
                this.inputs[i].Text = i.ToString();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (TextBox input in inputs)
            {
                input.Text = this.inputNum.Text;
            }

            int numero = int.Parse(this.inputNum.Text);
            for(int i = 0; i < this.inputs.Count; i++)
            {
                int operacion = numero * (i + 1);
                this.inputs[i].Text = operacion.ToString();
            }
        }
    }
}
