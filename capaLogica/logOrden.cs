using capaAccesoDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
    public class logOrden
    {
        private static readonly logOrden _instancia = new logOrden();
        public static logOrden Instancia
        {
            get { return logOrden._instancia; }
        }

        public List<entOrden> listarOrdenes()
        {
            return datOrden.Instancia.listarOrdenes();
        }

        public Boolean agregarCompra(entOrden compra)
        {
            return datOrden.Instancia.agregarCompra(compra);
        }

        public int verUltimaCompra()
        {
            return datOrden.Instancia.verUltimaCompra();
        }

        public Boolean agergarCompraDatos(entOrden compra, List<entOrdenItem> productos)
        {
            agregarCompra(compra);
            int ultimaCompra = verUltimaCompra();
            return datOrdenItems.Instancia.agregarProductosOrden(productos, ultimaCompra);

        }

        public Boolean deshabilitarCompra(entOrden compra)
        {
            return datOrden.Instancia.deshabilitarCompra(compra);
        }
    }
}
