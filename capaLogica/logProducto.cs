using capaAccesoDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
    public class logProducto
    {
        private static readonly logProducto _instance = new logProducto();
        public static logProducto Instancia
        {
            get { return logProducto._instance; }
        }

        public List<entProducto> listarProductos()
        {
            return datProducto.Instancia.listarProducto();
        }
    }
}
