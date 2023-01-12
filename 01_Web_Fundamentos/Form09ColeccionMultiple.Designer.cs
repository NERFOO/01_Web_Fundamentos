namespace _01_Web_Fundamentos
{
    partial class Form09ColeccionMultiple
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
            this.lblItem = new System.Windows.Forms.Label();
            this.lblIndice = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.inputNewElemento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(515, 500);
            this.lblItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(49, 25);
            this.lblItem.TabIndex = 18;
            this.lblItem.Text = "Item";
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(515, 432);
            this.lblIndice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(63, 25);
            this.lblIndice.TabIndex = 17;
            this.lblIndice.Text = "Indice";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(512, 240);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(478, 48);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(515, 356);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(478, 48);
            this.btnBorrarTodo.TabIndex = 15;
            this.btnBorrarTodo.Text = "Borrar todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(515, 185);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(478, 48);
            this.btnInsertar.TabIndex = 14;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // inputNewElemento
            // 
            this.inputNewElemento.Location = new System.Drawing.Point(515, 118);
            this.inputNewElemento.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.inputNewElemento.Name = "inputNewElemento";
            this.inputNewElemento.Size = new System.Drawing.Size(475, 32);
            this.inputNewElemento.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nuevo elemento";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Items.AddRange(new object[] {
            "Lista de elemento"});
            this.listBox.Location = new System.Drawing.Point(75, 118);
            this.listBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(372, 404);
            this.listBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Elementos";
            // 
            // btnSeleccionado
            // 
            this.btnSeleccionado.Location = new System.Drawing.Point(515, 298);
            this.btnSeleccionado.Margin = new System.Windows.Forms.Padding(5);
            this.btnSeleccionado.Name = "btnSeleccionado";
            this.btnSeleccionado.Size = new System.Drawing.Size(478, 48);
            this.btnSeleccionado.TabIndex = 19;
            this.btnSeleccionado.Text = "Seleccionados";
            this.btnSeleccionado.UseVisualStyleBackColor = true;
            this.btnSeleccionado.Click += new System.EventHandler(this.btnSeleccionado_Click);
            // 
            // Form09ColeccionMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 591);
            this.Controls.Add(this.btnSeleccionado);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form09ColeccionMultiple";
            this.Text = "Form09ColeccionMultiple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblItem;
        private Label lblIndice;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Button btnInsertar;
        private TextBox inputNewElemento;
        private Label label2;
        private ListBox listBox;
        private Label label1;
        private Button btnSeleccionado;
    }
}