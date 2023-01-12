namespace _01_Web_Fundamentos
{
    partial class Form08ColeccionGrafica
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNewElemento = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elementos";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Items.AddRange(new object[] {
            "Lista de elemento"});
            this.listBox.Location = new System.Drawing.Point(74, 85);
            this.listBox.Margin = new System.Windows.Forms.Padding(5);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(238, 254);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo elemento";
            // 
            // inputNewElemento
            // 
            this.inputNewElemento.Location = new System.Drawing.Point(354, 85);
            this.inputNewElemento.Margin = new System.Windows.Forms.Padding(5);
            this.inputNewElemento.Name = "inputNewElemento";
            this.inputNewElemento.Size = new System.Drawing.Size(304, 32);
            this.inputNewElemento.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(354, 125);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(304, 41);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(354, 219);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(304, 41);
            this.btnBorrarTodo.TabIndex = 5;
            this.btnBorrarTodo.Text = "Borrar todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(354, 172);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(304, 41);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(354, 273);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(63, 25);
            this.lblIndice.TabIndex = 8;
            this.lblIndice.Text = "Indice";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(354, 314);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(49, 25);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Item";
            // 
            // Form08ColeccionGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 489);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.inputNewElemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form08ColeccionGrafica";
            this.Text = "Form08ColeccionGrafica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listBox;
        private Label label2;
        private TextBox inputNewElemento;
        private Button btnInsertar;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Label lblIndice;
        private Label lblItem;
    }
}