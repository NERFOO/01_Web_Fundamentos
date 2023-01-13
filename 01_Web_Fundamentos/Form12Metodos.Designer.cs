namespace _01_Web_Fundamentos
{
    partial class Form12Metodos
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
            this.inputNumero = new System.Windows.Forms.TextBox();
            this.btnDoble = new System.Windows.Forms.Button();
            this.btnReferencia = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.btnObjetoReferencia = new System.Windows.Forms.Button();
            this.inputNumeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputLetras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMause = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // inputNumero
            // 
            this.inputNumero.Location = new System.Drawing.Point(145, 75);
            this.inputNumero.Margin = new System.Windows.Forms.Padding(5);
            this.inputNumero.Name = "inputNumero";
            this.inputNumero.Size = new System.Drawing.Size(155, 32);
            this.inputNumero.TabIndex = 1;
            // 
            // btnDoble
            // 
            this.btnDoble.Location = new System.Drawing.Point(55, 142);
            this.btnDoble.Margin = new System.Windows.Forms.Padding(5);
            this.btnDoble.Name = "btnDoble";
            this.btnDoble.Size = new System.Drawing.Size(247, 55);
            this.btnDoble.TabIndex = 2;
            this.btnDoble.Text = "Doble valor";
            this.btnDoble.UseVisualStyleBackColor = true;
            this.btnDoble.Click += new System.EventHandler(this.btnDoble_Click);
            // 
            // btnReferencia
            // 
            this.btnReferencia.Location = new System.Drawing.Point(55, 207);
            this.btnReferencia.Margin = new System.Windows.Forms.Padding(5);
            this.btnReferencia.Name = "btnReferencia";
            this.btnReferencia.Size = new System.Drawing.Size(247, 52);
            this.btnReferencia.TabIndex = 3;
            this.btnReferencia.Text = "Doble referencia";
            this.btnReferencia.UseVisualStyleBackColor = true;
            this.btnReferencia.Click += new System.EventHandler(this.btnReferencia_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(55, 337);
            this.resultado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(94, 25);
            this.resultado.TabIndex = 4;
            this.resultado.Text = "Resultado";
            // 
            // btnObjetoReferencia
            // 
            this.btnObjetoReferencia.Location = new System.Drawing.Point(55, 268);
            this.btnObjetoReferencia.Margin = new System.Windows.Forms.Padding(5);
            this.btnObjetoReferencia.Name = "btnObjetoReferencia";
            this.btnObjetoReferencia.Size = new System.Drawing.Size(247, 47);
            this.btnObjetoReferencia.TabIndex = 5;
            this.btnObjetoReferencia.Text = "Objeto referencia";
            this.btnObjetoReferencia.UseVisualStyleBackColor = true;
            this.btnObjetoReferencia.Click += new System.EventHandler(this.btnObjetoReferencia_Click);
            // 
            // inputNumeros
            // 
            this.inputNumeros.Location = new System.Drawing.Point(545, 75);
            this.inputNumeros.Margin = new System.Windows.Forms.Padding(5);
            this.inputNumeros.Name = "inputNumeros";
            this.inputNumeros.Size = new System.Drawing.Size(155, 32);
            this.inputNumeros.TabIndex = 7;
            this.inputNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumeros_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Solo numeros";
            // 
            // inputLetras
            // 
            this.inputLetras.Location = new System.Drawing.Point(545, 148);
            this.inputLetras.Margin = new System.Windows.Forms.Padding(5);
            this.inputLetras.Name = "inputLetras";
            this.inputLetras.Size = new System.Drawing.Size(155, 32);
            this.inputLetras.TabIndex = 9;
            this.inputLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputLetras_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Solo letras";
            // 
            // lblMause
            // 
            this.lblMause.BackColor = System.Drawing.Color.RosyBrown;
            this.lblMause.Location = new System.Drawing.Point(394, 221);
            this.lblMause.Name = "lblMause";
            this.lblMause.Size = new System.Drawing.Size(373, 199);
            this.lblMause.TabIndex = 10;
            this.lblMause.Text = "lblMause";
            this.lblMause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMause.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMause_MouseMove);
            // 
            // Form12Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 585);
            this.Controls.Add(this.lblMause);
            this.Controls.Add(this.inputLetras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObjetoReferencia);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.btnReferencia);
            this.Controls.Add(this.btnDoble);
            this.Controls.Add(this.inputNumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form12Metodos";
            this.Text = "Form12Metodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inputNumero;
        private Button btnDoble;
        private Button btnReferencia;
        private Label resultado;
        private Button btnObjetoReferencia;
        private TextBox inputNumeros;
        private Label label2;
        private TextBox inputLetras;
        private Label label3;
        private Label lblMause;
    }
}