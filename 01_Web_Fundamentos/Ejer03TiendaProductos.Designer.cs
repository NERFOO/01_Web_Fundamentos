namespace _01_Web_Fundamentos
{
    partial class Ejer03TiendaProductos
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
            this.inputProducto = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listTienda = new System.Windows.Forms.ListBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.listAlmacen = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // inputProducto
            // 
            this.inputProducto.Location = new System.Drawing.Point(107, 159);
            this.inputProducto.Name = "inputProducto";
            this.inputProducto.Size = new System.Drawing.Size(175, 32);
            this.inputProducto.TabIndex = 1;
            this.inputProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputProducto_KeyPress);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(107, 206);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(139, 48);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(107, 260);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 48);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(107, 314);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 48);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(107, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 48);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpiar lista";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(509, 234);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(139, 48);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccion -->";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tienda";
            // 
            // listTienda
            // 
            this.listTienda.FormattingEnabled = true;
            this.listTienda.ItemHeight = 25;
            this.listTienda.Location = new System.Drawing.Point(314, 159);
            this.listTienda.Name = "listTienda";
            this.listTienda.Size = new System.Drawing.Size(145, 254);
            this.listTienda.TabIndex = 8;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(509, 314);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(139, 48);
            this.btnTodos.TabIndex = 9;
            this.btnTodos.Text = "Todos -->";
            this.btnTodos.UseVisualStyleBackColor = true;
            // 
            // listAlmacen
            // 
            this.listAlmacen.FormattingEnabled = true;
            this.listAlmacen.ItemHeight = 25;
            this.listAlmacen.Location = new System.Drawing.Point(680, 162);
            this.listAlmacen.Name = "listAlmacen";
            this.listAlmacen.Size = new System.Drawing.Size(145, 254);
            this.listAlmacen.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Almacen";
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(889, 314);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(139, 48);
            this.btnBajar.TabIndex = 13;
            this.btnBajar.Text = "Bajar";
            this.btnBajar.UseVisualStyleBackColor = true;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(889, 234);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(139, 48);
            this.btnSubir.TabIndex = 12;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            // 
            // Ejer03TiendaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 602);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.listAlmacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.listTienda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.inputProducto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ejer03TiendaProductos";
            this.Text = "Ejer03TiendaProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inputProducto;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnClear;
        private Button btnSeleccionar;
        private Label label2;
        private ListBox listTienda;
        private Button btnTodos;
        private ListBox listAlmacen;
        private Label label3;
        private Button btnBajar;
        private Button btnSubir;
    }
}