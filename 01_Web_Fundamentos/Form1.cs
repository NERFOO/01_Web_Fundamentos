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

            //CONVERSION AUTOMATICA
            short num = 99;
            int mayor = num;

            //CASTING ENTRE NUMEROS
            int numMayor = 99;
            short numMenor = 888;
            //NECESITAMOS ALMACENAR EN EL NUMERO MENOR EL DATO DEL NUMERO MAYOR
            numMenor = (short) numMayor;

            //CONVERTIR STRING A PRIMITIVO
            string txtNum = "1105";
            int numEntero = int.Parse(txtNum);
            double doble = double.Parse(txtNum);

            //CONVERTIR OBJETOS A STRING
            int valor = 9876;
            string texto = valor.ToString();
            string boton = this.btnPulsar.ToString();

        }

    }
}