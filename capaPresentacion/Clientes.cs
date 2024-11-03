using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaLogica;


namespace capaPresentacion
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            listarClientes();
        }

        private void listarClientes()
        {
            dvgClientes.DataSource = logCliente.instancia.ListarCliente();
        }

        private void limpiarVariables()
        {
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtId.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entCliente nuevo = new entCliente();
            nuevo.nombre = txtNombre.Text;
            nuevo.correo = txtCorreo.Text;
            nuevo.telefeno = txtTelefono.Text;
            nuevo.estado = cbxEstado.Checked;
            Boolean estado = logCliente.instancia.insertarCliente(nuevo);
            if (!estado)
            {
                MessageBox.Show("Error al ingresar el cliente");
            }
            else
            {
                listarClientes();
            }
            limpiarVariables();
        }

        private void dvgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dvgClientes.Rows[e.RowIndex];
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtCorreo.Text = filaActual.Cells[2].Value.ToString();
            txtTelefono.Text = filaActual.Cells[3].Value.ToString();
            cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            entCliente clienteActual = new entCliente();
            clienteActual.id = Convert.ToInt32(txtId.Text);
            clienteActual.estado = cbxEstado.Checked;
            Boolean estadoConsulta = logCliente.instancia.deshabilitarCliente(clienteActual);
            if (!estadoConsulta)
            {
                MessageBox.Show("Error al deshabilitar Cliente");
            }
            else
            {
                limpiarVariables();
                listarClientes();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entCliente nuevo = new entCliente();
            nuevo.id = Convert.ToInt32(txtId.Text);
            nuevo.nombre = txtNombre.Text;
            nuevo.correo = txtCorreo.Text;
            nuevo.telefeno = txtTelefono.Text;
            nuevo.estado = cbxEstado.Checked;
            Boolean estado = logCliente.instancia.editarCliente(nuevo);
            if (!estado)
            {
                MessageBox.Show("Error al editar el cliente");
            }
            else
            {
                listarClientes();
                limpiarVariables();
            }
        }
    }
}
