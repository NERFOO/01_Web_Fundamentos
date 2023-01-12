namespace _01_Web_Fundamentos
{
    partial class Ejer01FechaNacimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.calcularDia = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año";
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(99, 40);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(100, 23);
            this.day.TabIndex = 3;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(99, 84);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(100, 23);
            this.month.TabIndex = 4;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(99, 129);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 23);
            this.year.TabIndex = 5;
            // 
            // calcularDia
            // 
            this.calcularDia.Location = new System.Drawing.Point(251, 69);
            this.calcularDia.Name = "calcularDia";
            this.calcularDia.Size = new System.Drawing.Size(95, 51);
            this.calcularDia.TabIndex = 6;
            this.calcularDia.Text = "Calcular dia";
            this.calcularDia.UseVisualStyleBackColor = true;
            this.calcularDia.Click += new System.EventHandler(this.calcularDia_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(425, 87);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(113, 15);
            this.txtResultado.TabIndex = 7;
            this.txtResultado.Text = "El dia que nacio fue ";
            // 
            // Ejer01FechaNacimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.calcularDia);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejer01FechaNacimiento";
            this.Text = "Ejer01FechaNacimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox day;
        private TextBox month;
        private TextBox year;
        private Button calcularDia;
        private Label txtResultado;
    }
}