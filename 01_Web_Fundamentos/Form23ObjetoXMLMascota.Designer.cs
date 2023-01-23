namespace _01_Web_Fundamentos
{
    partial class Form23ObjetoXMLMascota
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
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeerDato = new System.Windows.Forms.Button();
            this.btnGuardarDato = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(14, 139);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(5);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(155, 32);
            this.txtRaza.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(14, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 32);
            this.txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Raza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // btnLeerDato
            // 
            this.btnLeerDato.Location = new System.Drawing.Point(204, 104);
            this.btnLeerDato.Margin = new System.Windows.Forms.Padding(5);
            this.btnLeerDato.Name = "btnLeerDato";
            this.btnLeerDato.Size = new System.Drawing.Size(239, 47);
            this.btnLeerDato.TabIndex = 9;
            this.btnLeerDato.Text = "Leer dato";
            this.btnLeerDato.UseVisualStyleBackColor = true;
            this.btnLeerDato.Click += new System.EventHandler(this.btnLeerDato_Click);
            // 
            // btnGuardarDato
            // 
            this.btnGuardarDato.Location = new System.Drawing.Point(204, 160);
            this.btnGuardarDato.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarDato.Name = "btnGuardarDato";
            this.btnGuardarDato.Size = new System.Drawing.Size(239, 47);
            this.btnGuardarDato.TabIndex = 8;
            this.btnGuardarDato.Text = "Guardar dato";
            this.btnGuardarDato.UseVisualStyleBackColor = true;
            this.btnGuardarDato.Click += new System.EventHandler(this.btnGuardarDato_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(14, 212);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(5);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(155, 32);
            this.txtEdad.TabIndex = 11;
            // 
            // Form23ObjetoXMLMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 272);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLeerDato);
            this.Controls.Add(this.btnGuardarDato);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form23ObjetoXMLMascota";
            this.Text = "Form23ObjetoXMLMascota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtRaza;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private Button btnLeerDato;
        private Button btnGuardarDato;
        private Label label3;
        private TextBox txtEdad;
    }
}