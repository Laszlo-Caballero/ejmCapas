using capaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaAccesoDatos
{
    public class datOrden
    {
        private static readonly datOrden _instancia = new datOrden();
        public static datOrden Instancia
        {
            get { return datOrden._instancia; }
        }


        public List<entOrden> listarOrdenes()
        {
            SqlCommand cmd = null;
            List<entOrden> ordenes = new List<entOrden>();
            try
            {
                SqlConnection cn = Conexion.instancia.Conectar();
                cmd = new SqlCommand("listarOrdenes", cn);
                cn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    entOrden nuevo = new entOrden();
                    nuevo.id = Convert.ToInt32(rd["id"]);
                    nuevo.idCliente = Convert.ToInt32(rd["customer_id"]);
                    nuevo.diaCompra = Convert.ToDateTime(rd["order_date"]);
                    nuevo.estado = Convert.ToBoolean(rd["estado"]);
                    ordenes.Add(nuevo);
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return ordenes;
        }

        public Boolean agregarCompra(entOrden compra)
        {
            SqlCommand cmd = null;
            Boolean estado = false;
            try
            {
                SqlConnection cn = Conexion.instancia.Conectar();
                cmd = new SqlCommand("agregarCompra", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", compra.idCliente);
                cmd.Parameters.AddWithValue("@fecha", compra.diaCompra);

                int estadoOrden = compra.estado ? 1 : 0;
                cmd.Parameters.AddWithValue("@estado", estadoOrden);
                cn.Open();
                int row = cmd.ExecuteNonQuery();
                estado = row >= 1 ? true : false;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return estado;
        }

        public int verUltimaCompra()
        {
            SqlCommand cmd = null;
            int id = -1;

            try
            {
                SqlConnection cn = Conexion.instancia.Conectar();
                cmd = new SqlCommand("ultimaCompra", cn);
                cn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    id = Convert.ToInt32(rd["id"]);
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return id;
        }

        public Boolean deshabilitarCompra(entOrden compra)
        {
            SqlCommand cmd = null;
            Boolean resultado = false;
            try
            {
                SqlConnection cn = Conexion.instancia.Conectar();
                cmd = new SqlCommand("deshabilitarCompra", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCompra", compra.id);
                cn.Open();
                int row = cmd.ExecuteNonQuery();
                resultado = row >= 1 ? true : false;
            } catch (Exception ex) { 
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
