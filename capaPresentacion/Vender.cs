using capaEntidad;
using capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Vender : Form
    {
        private List<entOrdenItem> carrito = new List<entOrdenItem>();
        public Vender()
        {
            InitializeComponent();
            listarProductos();
            listarClientes();
            listarOrdenes();
        }

        private void listarOrdenes()
        {
            dvgOrdenes.DataSource = logOrden.Instancia.listarOrdenes();
        }

        private void listarProductos()
        {
            List<entProducto> productos = logProducto.Instancia.listarProductos();
            cbProductos.Items.Clear();
            cbProductos.DataSource = productos;
            cbProductos.DisplayMember = "nombre";
        }
        private void listarClientes()
        {
            List<entCliente> clientes = logCliente.instancia.ListarCliente();
            cbClientes.Items.Clear();
            cbClientes.DataSource = clientes;
            cbClientes.DisplayMember = "nombre";
            cbClientes.ValueMember = "id";
        }

        private void btnAñadirCarrito_Click(object sender, EventArgs e)
        {


            entProducto producto = cbProductos.SelectedValue as entProducto;
            int id = producto.id;
            string nombre = cbProductos.Text;
            string cantidad = txtCantidad.Text;

            entOrdenItem nuevo = new entOrdenItem();
            nuevo.productoId = producto.id;
            nuevo.cantidad = Convert.ToInt32(cantidad);
            nuevo.precioTotal = Convert.ToInt32(cantidad) * producto.precio;
            carrito.Add(nuevo);
            ListViewItem item = new ListViewItem(id.ToString());
            item.SubItems.Add(nombre);
            item.SubItems.Add(cantidad);
            lwCarrito.Items.Add(item);
            txtCantidad.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            entOrden compra = new entOrden();
            compra.idCliente = Convert.ToInt32(cbClientes.SelectedValue);
            compra.diaCompra = DateTime.Now;
            compra.estado = true;


            Boolean estado = logOrden.Instancia.agergarCompraDatos(compra, carrito);
            if (!estado)
            {
                MessageBox.Show("Error al realizar la compra");
            }
            else
            {
                listarOrdenes();
                carrito = new List<entOrdenItem>();
                lwCarrito.Items.Clear();
            }

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            entOrden compra = new entOrden();
            compra.id = Convert.ToInt32(txtId.Text);
            Boolean resultado = logOrden.Instancia.deshabilitarCompra(compra);
            if (!resultado)
            {
                MessageBox.Show("Error al deshabilitar la compra");
            }
            else
            {
                listarOrdenes();
                txtId.Text = "";
            }
        }

        private void dvgOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dvgOrdenes.Rows[e.RowIndex];
            txtId.Text = filaActual.Cells[0].Value.ToString();
        }
    }
}
