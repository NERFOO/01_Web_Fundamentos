namespace _01_Web_Fundamentos
{
    partial class Ejer02ColeccionNumeros
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputSuma = new System.Windows.Forms.TextBox();
            this.inputImpares = new System.Windows.Forms.TextBox();
            this.inputPares = new System.Windows.Forms.TextBox();
            this.numRandoms = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeros";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(231, 40);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(111, 44);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(359, 40);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(163, 45);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Impares";
            // 
            // inputSuma
            // 
            this.inputSuma.Location = new System.Drawing.Point(342, 115);
            this.inputSuma.Name = "inputSuma";
            this.inputSuma.Size = new System.Drawing.Size(100, 32);
            this.inputSuma.TabIndex = 7;
            // 
            // inputImpares
            // 
            this.inputImpares.Location = new System.Drawing.Point(342, 196);
            this.inputImpares.Name = "inputImpares";
            this.inputImpares.Size = new System.Drawing.Size(100, 32);
            this.inputImpares.TabIndex = 8;
            // 
            // inputPares
            // 
            this.inputPares.Location = new System.Drawing.Point(342, 154);
            this.inputPares.Name = "inputPares";
            this.inputPares.Size = new System.Drawing.Size(100, 32);
            this.inputPares.TabIndex = 9;
            // 
            // numRandoms
            // 
            this.numRandoms.FormattingEnabled = true;
            this.numRandoms.ItemHeight = 25;
            this.numRandoms.Location = new System.Drawing.Point(50, 68);
            this.numRandoms.Name = "numRandoms";
            this.numRandoms.Size = new System.Drawing.Size(151, 254);
            this.numRandoms.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sumar seleccionados";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // Ejer02ColeccionNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numRandoms);
            this.Controls.Add(this.inputPares);
            this.Controls.Add(this.inputImpares);
            this.Controls.Add(this.inputSuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ejer02ColeccionNumeros";
            this.Text = "Ejer02ColeccionNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnGenerar;
        private Button btnMostrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox inputSuma;
        private TextBox inputImpares;
        private TextBox inputPares;
        private ListBox numRandoms;
        private Button button1;
        private Label label5;
    }
}