namespace _01_Web_Fundamentos
{
    partial class Form06Email
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
            this.validarEmail = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.respuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validarEmail
            // 
            this.validarEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.validarEmail.Location = new System.Drawing.Point(36, 99);
            this.validarEmail.Name = "validarEmail";
            this.validarEmail.Size = new System.Drawing.Size(111, 49);
            this.validarEmail.TabIndex = 0;
            this.validarEmail.Text = "Validar email";
            this.validarEmail.UseVisualStyleBackColor = true;
            this.validarEmail.Click += new System.EventHandler(this.validarEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(36, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduzca un email";
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Location = new System.Drawing.Point(36, 161);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(66, 15);
            this.respuesta.TabIndex = 3;
            this.respuesta.Text = "Respuesta: ";
            // 
            // Form06Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.validarEmail);
            this.Name = "Form06Email";
            this.Text = "Form06Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button validarEmail;
        private TextBox txtEmail;
        private Label label1;
        private Label respuesta;
    }
}