namespace _01_Web_Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //PROPIEDAD DE TIPO PRIMITIVO
            this.txtNombre.Width = 150;
            this.btnPulsar.Text = "Boton pulsado!!";

            //PROPIEDAD DE TIPO OBJETO
            this.txtNombre.Location = new Point(70, 100);

            //PROPIEDAD DE TIPO ENUMERADAS
            //UNA ENUMERACION SON UNA SERIE DE VALORES QUE SE REPRESENTAN DE FORMA GRAFICA Y AYUDAN AL PROGRAMADOR
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.BackColor = Color.Aquamarine;
        }

    }
}