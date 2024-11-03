using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entOrden
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public DateTime diaCompra { get; set; }
        public Boolean estado { get; set; }
    }
}
