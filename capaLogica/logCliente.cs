using capaEntidad;
using capaAccesoDatos;
namespace capaLogica
{
    public class logCliente
    {
        private static readonly logCliente _instancia = new logCliente();
        public static logCliente instancia { get { return logCliente._instancia; } }
    
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.listarClientes();
        }
        public Boolean insertarCliente(entCliente nuevo)
        {
            return datCliente.Instancia.AgregarCliente(nuevo);
        }

        public Boolean deshabilitarCliente(entCliente cliente)
        {
            ///deshabilitar el cliente si ya no compra desde el 2018
            ///no podemos deshabilitar los clientes que sean una empresa cliente = empresa 
            return datCliente.Instancia.DeshabilitarCliente(cliente);
        }
        public Boolean editarCliente(entCliente cliente)
        {
            return datCliente.Instancia.EditarCliente(cliente);
        }
    }
}
