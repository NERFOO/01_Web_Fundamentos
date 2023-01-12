namespace _01_Web_Fundamentos
{
    partial class Form02ColoresPosicion
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
            this.posicionX = new System.Windows.Forms.TextBox();
            this.posicionY = new System.Windows.Forms.TextBox();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.btnColorFondo = new System.Windows.Forms.Button();
            this.opcionColor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // posicionX
            // 
            this.posicionX.Location = new System.Drawing.Point(44, 69);
            this.posicionX.Name = "posicionX";
            this.posicionX.Size = new System.Drawing.Size(100, 23);
            this.posicionX.TabIndex = 0;
            // 
            // posicionY
            // 
            this.posicionY.Location = new System.Drawing.Point(172, 69);
            this.posicionY.Name = "posicionY";
            this.posicionY.Size = new System.Drawing.Size(100, 23);
            this.posicionY.TabIndex = 1;
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(305, 68);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(151, 23);
            this.btnPosicion.TabIndex = 2;
            this.btnPosicion.Text = "Cambiar posicion";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // btnColorFondo
            // 
            this.btnColorFondo.Location = new System.Drawing.Point(305, 135);
            this.btnColorFondo.Name = "btnColorFondo";
            this.btnColorFondo.Size = new System.Drawing.Size(163, 22);
            this.btnColorFondo.TabIndex = 6;
            this.btnColorFondo.Text = "Cambiar color de fondo";
            this.btnColorFondo.UseVisualStyleBackColor = true;
            this.btnColorFondo.Click += new System.EventHandler(this.btnColorFondo_Click);
            // 
            // opcionColor
            // 
            this.opcionColor.FormattingEnabled = true;
            this.opcionColor.ItemHeight = 15;
            this.opcionColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.opcionColor.Location = new System.Drawing.Point(71, 135);
            this.opcionColor.Name = "opcionColor";
            this.opcionColor.Size = new System.Drawing.Size(120, 94);
            this.opcionColor.TabIndex = 7;
            // 
            // Form02ColoresPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opcionColor);
            this.Controls.Add(this.btnColorFondo);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.posicionY);
            this.Controls.Add(this.posicionX);
            this.Name = "Form02ColoresPosicion";
            this.Text = "Form02ColoresPosicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox posicionX;
        private TextBox posicionY;
        private Button btnPosicion;
        private Button btnColorFondo;
        private ListBox opcionColor;
    }
}