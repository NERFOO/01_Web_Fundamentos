namespace _01_Web_Fundamentos
{
    partial class Form03DateTime
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
            this.inputFechaActual = new System.Windows.Forms.TextBox();
            this.checkBoxCambiarFecha = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.incremento = new System.Windows.Forms.TextBox();
            this.btnIncremento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbYears = new System.Windows.Forms.RadioButton();
            this.rdbMonths = new System.Windows.Forms.RadioButton();
            this.rdbDays = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nuevaFecha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha actual";
            // 
            // inputFechaActual
            // 
            this.inputFechaActual.Location = new System.Drawing.Point(44, 73);
            this.inputFechaActual.Name = "inputFechaActual";
            this.inputFechaActual.Size = new System.Drawing.Size(365, 23);
            this.inputFechaActual.TabIndex = 1;
            // 
            // checkBoxCambiarFecha
            // 
            this.checkBoxCambiarFecha.AutoSize = true;
            this.checkBoxCambiarFecha.Location = new System.Drawing.Point(44, 102);
            this.checkBoxCambiarFecha.Name = "checkBoxCambiarFecha";
            this.checkBoxCambiarFecha.Size = new System.Drawing.Size(149, 19);
            this.checkBoxCambiarFecha.TabIndex = 2;
            this.checkBoxCambiarFecha.Text = "Cambiar formato fecha";
            this.checkBoxCambiarFecha.UseVisualStyleBackColor = true;
            this.checkBoxCambiarFecha.CheckedChanged += new System.EventHandler(this.checkBoxCambiarFecha_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.incremento);
            this.groupBox1.Controls.Add(this.btnIncremento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbYears);
            this.groupBox1.Controls.Add(this.rdbMonths);
            this.groupBox1.Controls.Add(this.rdbDays);
            this.groupBox1.Location = new System.Drawing.Point(44, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incrementar Fecha";
            // 
            // incremento
            // 
            this.incremento.Location = new System.Drawing.Point(193, 18);
            this.incremento.Name = "incremento";
            this.incremento.Size = new System.Drawing.Size(100, 23);
            this.incremento.TabIndex = 5;
            // 
            // btnIncremento
            // 
            this.btnIncremento.Location = new System.Drawing.Point(129, 54);
            this.btnIncremento.Name = "btnIncremento";
            this.btnIncremento.Size = new System.Drawing.Size(143, 43);
            this.btnIncremento.TabIndex = 4;
            this.btnIncremento.Text = "Incrementar";
            this.btnIncremento.UseVisualStyleBackColor = true;
            this.btnIncremento.Click += new System.EventHandler(this.btnIncremento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // rdbYears
            // 
            this.rdbYears.AutoSize = true;
            this.rdbYears.Location = new System.Drawing.Point(6, 78);
            this.rdbYears.Name = "rdbYears";
            this.rdbYears.Size = new System.Drawing.Size(52, 19);
            this.rdbYears.TabIndex = 2;
            this.rdbYears.TabStop = true;
            this.rdbYears.Text = "Años";
            this.rdbYears.UseVisualStyleBackColor = true;
            // 
            // rdbMonths
            // 
            this.rdbMonths.AutoSize = true;
            this.rdbMonths.Location = new System.Drawing.Point(6, 49);
            this.rdbMonths.Name = "rdbMonths";
            this.rdbMonths.Size = new System.Drawing.Size(58, 19);
            this.rdbMonths.TabIndex = 1;
            this.rdbMonths.TabStop = true;
            this.rdbMonths.Text = "Meses";
            this.rdbMonths.UseVisualStyleBackColor = true;
            // 
            // rdbDays
            // 
            this.rdbDays.AutoSize = true;
            this.rdbDays.Location = new System.Drawing.Point(6, 22);
            this.rdbDays.Name = "rdbDays";
            this.rdbDays.Size = new System.Drawing.Size(47, 19);
            this.rdbDays.TabIndex = 0;
            this.rdbDays.TabStop = true;
            this.rdbDays.Text = "Dias";
            this.rdbDays.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva Fecha";
            // 
            // nuevaFecha
            // 
            this.nuevaFecha.Location = new System.Drawing.Point(44, 341);
            this.nuevaFecha.Name = "nuevaFecha";
            this.nuevaFecha.Size = new System.Drawing.Size(365, 23);
            this.nuevaFecha.TabIndex = 5;
            // 
            // Form03DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nuevaFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxCambiarFecha);
            this.Controls.Add(this.inputFechaActual);
            this.Controls.Add(this.label1);
            this.Name = "Form03DateTime";
            this.Text = "Form03DateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inputFechaActual;
        private CheckBox checkBoxCambiarFecha;
        private GroupBox groupBox1;
        private TextBox incremento;
        private Button btnIncremento;
        private Label label2;
        private RadioButton rdbYears;
        private RadioButton rdbMonths;
        private RadioButton rdbDays;
        private Label label3;
        private TextBox nuevaFecha;
    }
}