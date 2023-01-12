namespace _01_Web_Fundamentos
{
    partial class Form01SumarNumeros
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.resultadoSuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(136, 31);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 23);
            this.num1.TabIndex = 2;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(136, 90);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 23);
            this.num2.TabIndex = 3;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(283, 62);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // resultadoSuma
            // 
            this.resultadoSuma.AutoSize = true;
            this.resultadoSuma.BackColor = System.Drawing.SystemColors.Control;
            this.resultadoSuma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultadoSuma.Location = new System.Drawing.Point(443, 66);
            this.resultadoSuma.Name = "resultadoSuma";
            this.resultadoSuma.Size = new System.Drawing.Size(119, 15);
            this.resultadoSuma.TabIndex = 5;
            this.resultadoSuma.Text = "Resultado de la suma";
            // 
            // Form01SumarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultadoSuma);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form01SumarNumeros";
            this.Text = "Form01SumarNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox num1;
        private TextBox num2;
        private Button btnSuma;
        private Label resultadoSuma;
    }
}