namespace _01_Web_Fundamentos
{
    partial class Form07SumarNumeros2
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
            this.btnSumar = new System.Windows.Forms.Button();
            this.inputNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(71, 108);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(137, 23);
            this.btnSumar.TabIndex = 0;
            this.btnSumar.Text = "Sumar numeros";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // inputNum
            // 
            this.inputNum.Location = new System.Drawing.Point(71, 79);
            this.inputNum.Name = "inputNum";
            this.inputNum.Size = new System.Drawing.Size(137, 23);
            this.inputNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "sumar numeros";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(71, 148);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(139, 15);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "Resultado de la suma es: ";
            // 
            // Form07SumarNumeros2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNum);
            this.Controls.Add(this.btnSumar);
            this.Name = "Form07SumarNumeros2";
            this.Text = "Form07SumarNumeros2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSumar;
        private TextBox inputNum;
        private Label label1;
        private Label resultado;
    }
}