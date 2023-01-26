namespace _01_Web_Fundamentos
{
    partial class Form24ColeccionXMLMascotas
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
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaMascota = new System.Windows.Forms.Button();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(14, 183);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(5);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(155, 23);
            this.txtEdad.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Años";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(204, 103);
            this.btnLeer.Margin = new System.Windows.Forms.Padding(5);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(239, 47);
            this.btnLeer.TabIndex = 17;
            this.btnLeer.Text = "Leer registro";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(204, 159);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(239, 47);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar registro";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(14, 110);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(5);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(155, 23);
            this.txtRaza.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(14, 39);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 23);
            this.txtNombre.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Raza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // btnNuevaMascota
            // 
            this.btnNuevaMascota.Location = new System.Drawing.Point(204, 39);
            this.btnNuevaMascota.Name = "btnNuevaMascota";
            this.btnNuevaMascota.Size = new System.Drawing.Size(239, 53);
            this.btnNuevaMascota.TabIndex = 20;
            this.btnNuevaMascota.Text = "Nueva mascota";
            this.btnNuevaMascota.UseVisualStyleBackColor = true;
            this.btnNuevaMascota.Click += new System.EventHandler(this.btnNuevaMascota_Click);
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 15;
            this.lstMascotas.Location = new System.Drawing.Point(513, 52);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(176, 199);
            this.lstMascotas.TabIndex = 22;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mascotas";
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(255, 243);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(137, 107);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 23;
            this.image.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(255, 370);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(137, 29);
            this.btnExaminar.TabIndex = 24;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // Form24ColeccionXMLMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.image);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNuevaMascota);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form24ColeccionXMLMascotas";
            this.Text = "Form24ColeccionXMLMascotas";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEdad;
        private Label label3;
        private Button btnLeer;
        private Button btnGuardar;
        private TextBox txtRaza;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private Button btnNuevaMascota;
        private ListBox lstMascotas;
        private Label label4;
        private PictureBox image;
        private Button btnExaminar;
    }
}