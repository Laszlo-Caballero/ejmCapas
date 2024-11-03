using capaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaAccesoDatos
{
    public class datProducto
    {
        private static readonly datProducto _instancia = new datProducto();
        public static datProducto Instancia
        {
            get { return datProducto._instancia; }
        }

        public List<entProducto> listarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> productos = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.instancia.Conectar();
                cmd = new SqlCommand("listarProductos", cn);
                cn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    entProducto nuevo = new entProducto();
                    nuevo.id = Convert.ToInt32(rd["id"]);
                    nuevo.nombre = rd["name"].ToString();
                    nuevo.descripcion = rd["description"].ToString();
                    nuevo.precio = float.Parse(rd["price"].ToString());
                    productos.Add(nuevo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productos;
        }
    }
}
