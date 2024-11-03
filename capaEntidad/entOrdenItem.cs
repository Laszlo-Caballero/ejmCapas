using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entOrdenItem
    {
        public int id { get; set; }
        public int ordenId { get; set; }
        public int productoId { get; set; }
        public int cantidad { get; set; }
        public float precioTotal { get; set; }
    }
}
