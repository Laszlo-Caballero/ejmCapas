namespace capaPresentacion
{
    partial class Vender
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
            dvgOrdenes = new DataGridView();
            btnAgregar = new Button();
            btnDeshabilitar = new Button();
            cbProductos = new ComboBox();
            cbClientes = new ComboBox();
            txtCantidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAñadirCarrito = new Button();
            label4 = new Label();
            lwCarrito = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label5 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvgOrdenes).BeginInit();
            SuspendLayout();
            // 
            // dvgOrdenes
            // 
            dvgOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgOrdenes.Location = new Point(12, 12);
            dvgOrdenes.Name = "dvgOrdenes";
            dvgOrdenes.RowHeadersWidth = 51;
            dvgOrdenes.Size = new Size(687, 186);
            dvgOrdenes.TabIndex = 0;
            dvgOrdenes.CellClick += dvgOrdenes_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(721, 33);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(226, 73);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(721, 125);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(226, 73);
            btnDeshabilitar.TabIndex = 2;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // cbProductos
            // 
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new Point(137, 257);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(192, 28);
            cbProductos.TabIndex = 3;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(137, 359);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(192, 28);
            cbClientes.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(137, 304);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(190, 27);
            txtCantidad.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 265);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 6;
            label1.Text = "Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 307);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 367);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 8;
            label3.Text = "Cliente";
            // 
            // btnAñadirCarrito
            // 
            btnAñadirCarrito.Location = new Point(393, 257);
            btnAñadirCarrito.Name = "btnAñadirCarrito";
            btnAñadirCarrito.Size = new Size(121, 56);
            btnAñadirCarrito.TabIndex = 9;
            btnAñadirCarrito.Text = "Añadir a Carrito";
            btnAñadirCarrito.UseVisualStyleBackColor = true;
            btnAñadirCarrito.Click += btnAñadirCarrito_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(565, 230);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 10;
            label4.Text = "Carrito";
            // 
            // lwCarrito
            // 
            lwCarrito.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lwCarrito.Location = new Point(565, 257);
            lwCarrito.Name = "lwCarrito";
            lwCarrito.Size = new Size(335, 112);
            lwCarrito.TabIndex = 12;
            lwCarrito.UseCompatibleStateImageBehavior = false;
            lwCarrito.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "nombre";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "cantidad";
            columnHeader3.Width = 120;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 220);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 13;
            label5.Text = "id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(139, 217);
            txtId.Name = "txtId";
            txtId.Size = new Size(190, 27);
            txtId.TabIndex = 14;
            // 
            // Vender
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 450);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(lwCarrito);
            Controls.Add(label4);
            Controls.Add(btnAñadirCarrito);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCantidad);
            Controls.Add(cbClientes);
            Controls.Add(cbProductos);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnAgregar);
            Controls.Add(dvgOrdenes);
            Name = "Vender";
            Text = "Vender";
            ((System.ComponentModel.ISupportInitialize)dvgOrdenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgOrdenes;
        private Button btnAgregar;
        private Button btnDeshabilitar;
        private ComboBox cbProductos;
        private ComboBox cbClientes;
        private TextBox txtCantidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAñadirCarrito;
        private Label label4;
        private ListView lwCarrito;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label5;
        private TextBox txtId;
    }
}