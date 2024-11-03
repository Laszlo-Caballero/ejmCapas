namespace capaPresentacion
{
    partial class Clientes
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
            dvgClientes = new DataGridView();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            cbxEstado = new CheckBox();
            btnAgregar = new Button();
            btnDeshabilitar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgClientes).BeginInit();
            SuspendLayout();
            // 
            // dvgClientes
            // 
            dvgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgClientes.Location = new Point(34, 26);
            dvgClientes.Name = "dvgClientes";
            dvgClientes.RowHeadersWidth = 51;
            dvgClientes.Size = new Size(938, 174);
            dvgClientes.TabIndex = 0;
            dvgClientes.CellClick += dvgClientes_CellClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 276);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(131, 326);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(188, 27);
            txtCorreo.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(131, 380);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(188, 27);
            txtTelefono.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 283);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 329);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 387);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 231);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 7;
            label4.Text = "id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(131, 224);
            txtId.Name = "txtId";
            txtId.Size = new Size(188, 27);
            txtId.TabIndex = 8;
            // 
            // cbxEstado
            // 
            cbxEstado.AutoSize = true;
            cbxEstado.Location = new Point(380, 250);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(76, 24);
            cbxEstado.TabIndex = 9;
            cbxEstado.Text = "estado";
            cbxEstado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(522, 240);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(182, 63);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.Location = new Point(745, 240);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(183, 63);
            btnDeshabilitar.TabIndex = 11;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = true;
            btnDeshabilitar.Click += btnDeshabilitar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(745, 344);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(183, 63);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnDeshabilitar);
            Controls.Add(btnAgregar);
            Controls.Add(cbxEstado);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(dvgClientes);
            Name = "Clientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dvgClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgClientes;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private CheckBox cbxEstado;
        private Button btnAgregar;
        private Button btnDeshabilitar;
        private Button btnEditar;
    }
}