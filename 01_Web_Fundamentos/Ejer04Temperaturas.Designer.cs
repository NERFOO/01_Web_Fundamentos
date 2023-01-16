namespace _01_Web_Fundamentos
{
    partial class Ejer04Temperaturas
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
            this.btnMeses = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputMax = new System.Windows.Forms.TextBox();
            this.inputMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meses";
            // 
            // btnMeses
            // 
            this.btnMeses.Location = new System.Drawing.Point(284, 56);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(137, 23);
            this.btnMeses.TabIndex = 2;
            this.btnMeses.Text = "Generar meses";
            this.btnMeses.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(284, 98);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(137, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperatura máxima";
            // 
            // inputMax
            // 
            this.inputMax.Location = new System.Drawing.Point(315, 187);
            this.inputMax.Name = "inputMax";
            this.inputMax.Size = new System.Drawing.Size(75, 23);
            this.inputMax.TabIndex = 5;
            // 
            // inputMin
            // 
            this.inputMin.Location = new System.Drawing.Point(315, 255);
            this.inputMin.Name = "inputMin";
            this.inputMin.Size = new System.Drawing.Size(75, 23);
            this.inputMin.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Temperatura mínima";
            // 
            // inputMedia
            // 
            this.inputMedia.Location = new System.Drawing.Point(315, 329);
            this.inputMedia.Name = "inputMedia";
            this.inputMedia.Size = new System.Drawing.Size(75, 23);
            this.inputMedia.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temperatura media";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(55, 68);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(200, 319);
            this.listBox.TabIndex = 10;
            // 
            // Ejer04Temperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.inputMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.label1);
            this.Name = "Ejer04Temperaturas";
            this.Text = "Ejer04Temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnMeses;
        private Button btnMostrar;
        private Label label2;
        private TextBox inputMax;
        private TextBox inputMin;
        private Label label3;
        private TextBox inputMedia;
        private Label label4;
        private ListBox listBox;
    }
}