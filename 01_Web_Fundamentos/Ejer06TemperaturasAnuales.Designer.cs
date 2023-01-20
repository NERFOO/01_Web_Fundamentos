namespace _01_Web_Fundamentos
{
    partial class Ejer06TemperaturasAnuales
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
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarYears = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputMediaYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputMinYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputMaxYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Años";
            // 
            // dropDown
            // 
            this.dropDown.FormattingEnabled = true;
            this.dropDown.Location = new System.Drawing.Point(43, 56);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(121, 23);
            this.dropDown.TabIndex = 1;
            this.dropDown.SelectedIndexChanged += new System.EventHandler(this.dropDown_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(43, 132);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(166, 259);
            this.listBox.TabIndex = 22;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Meses";
            // 
            // btnGenerarYears
            // 
            this.btnGenerarYears.Location = new System.Drawing.Point(334, 38);
            this.btnGenerarYears.Name = "btnGenerarYears";
            this.btnGenerarYears.Size = new System.Drawing.Size(137, 56);
            this.btnGenerarYears.TabIndex = 23;
            this.btnGenerarYears.Text = "Generar Temperaturas";
            this.btnGenerarYears.UseVisualStyleBackColor = true;
            this.btnGenerarYears.Click += new System.EventHandler(this.btnGenerarYears_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.inputMedia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inputMin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.inputMax);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(265, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 298);
            this.panel1.TabIndex = 24;
            // 
            // inputMedia
            // 
            this.inputMedia.Location = new System.Drawing.Point(76, 242);
            this.inputMedia.Name = "inputMedia";
            this.inputMedia.Size = new System.Drawing.Size(75, 23);
            this.inputMedia.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Temperatura media mensual";
            // 
            // inputMin
            // 
            this.inputMin.Location = new System.Drawing.Point(76, 168);
            this.inputMin.Name = "inputMin";
            this.inputMin.Size = new System.Drawing.Size(75, 23);
            this.inputMin.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Temperatura mínima";
            // 
            // inputMax
            // 
            this.inputMax.Location = new System.Drawing.Point(76, 100);
            this.inputMax.Name = "inputMax";
            this.inputMax.Size = new System.Drawing.Size(75, 23);
            this.inputMax.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Temperatura máxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datos del mes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.inputMediaYear);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.inputMinYear);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.inputMaxYear);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(521, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 298);
            this.panel2.TabIndex = 26;
            // 
            // inputMediaYear
            // 
            this.inputMediaYear.Location = new System.Drawing.Point(76, 242);
            this.inputMediaYear.Name = "inputMediaYear";
            this.inputMediaYear.Size = new System.Drawing.Size(75, 23);
            this.inputMediaYear.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Temperatura media anual";
            // 
            // inputMinYear
            // 
            this.inputMinYear.Location = new System.Drawing.Point(76, 168);
            this.inputMinYear.Name = "inputMinYear";
            this.inputMinYear.Size = new System.Drawing.Size(75, 23);
            this.inputMinYear.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Temperatura mínima";
            // 
            // inputMaxYear
            // 
            this.inputMaxYear.Location = new System.Drawing.Point(76, 100);
            this.inputMaxYear.Name = "inputMaxYear";
            this.inputMaxYear.Size = new System.Drawing.Size(75, 23);
            this.inputMaxYear.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Temperatura máxima";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Datos anuales";
            // 
            // Ejer06TemperaturasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerarYears);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dropDown);
            this.Controls.Add(this.label1);
            this.Name = "Ejer06TemperaturasAnuales";
            this.Text = "Ejer06TemperaturasAnuales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox dropDown;
        private ListBox listBox;
        private Label label2;
        private Button btnGenerarYears;
        private Panel panel1;
        private Label label3;
        private TextBox inputMedia;
        private Label label4;
        private TextBox inputMin;
        private Label label5;
        private TextBox inputMax;
        private Label label6;
        private Panel panel2;
        private TextBox inputMediaYear;
        private Label label7;
        private TextBox inputMinYear;
        private Label label8;
        private TextBox inputMaxYear;
        private Label label9;
        private Label label10;
    }
}