using capaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaAccesoDatos
{
    public class datOrdenItems
    {
        private static readonly datOrdenItems _instancia = new datOrdenItems();
        public static datOrdenItems Instancia
        {
            get { return datOrdenItems._instancia; }
        }

        public Boolean agregarProductosOrden(List<entOrdenItem> productos, int id)
        {
            SqlCommand cmd = null;
            Boolean resultado = false;
            try
            {
                SqlConnection cn = Conexion.instancia.Conectar();
                cn.Open();
                foreach (entOrdenItem item in productos)
                {
                    cmd = new SqlCommand("agregarItem", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@compraId", id);
                    cmd.Parameters.AddWithValue("@productoId", item.productoId);
                    cmd.Parameters.AddWithValue("@cantidad", item.cantidad);
                    cmd.Parameters.AddWithValue("@preciototal", item.precioTotal);
                    int row = cmd.ExecuteNonQuery();
                    if (row == 0)
                    {
                        break;
                    }
                }
                resultado = true;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return resultado;
        }
    }
}
