using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using Microsoft.Data.SqlClient;

namespace capaAccesoDatos
{
    public class datCliente
    {
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get { return datCliente._instancia; }
        }

        public List<entCliente> listarClientes()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();

            try
            {
                SqlConnection cn = Conexion.instancia.Conectar();
                cmd = new SqlCommand("listarClientes", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    entCliente cliente = new entCliente();
                    cliente.id = Convert.ToInt32(dr["id"]);
                    cliente.nombre = dr["name"].ToString();
                    cliente.correo = dr["email"].ToString();
                    cliente.telefeno = dr["phone"].ToString();
                    cliente.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean AgregarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            Boolean insertar = false;
            try
            {
                SqlConnection cn = Conexion.instancia.Conectar();
                cmd = new SqlCommand("agregarCliente", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@correo", cliente.correo);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefeno);

                int estado = cliente.estado ? 1 : 0;
                cmd.Parameters.AddWithValue("@estado", estado);
                cn.Open();
                int row = cmd.ExecuteNonQuery();
                insertar = row >= 1 ? true : false;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return insertar;
        }

        public Boolean DeshabilitarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            Boolean deshabilitar = false;
            try
            {
                SqlConnection cn = Conexion.instancia.Conectar();
                cmd = new SqlCommand("deshabilitarCliente", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", cliente.id);
                cn.Open();
                int row = cmd.ExecuteNonQuery();
                deshabilitar = row >= 1 ? true : false;
            }catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return deshabilitar;
        }

        public Boolean EditarCliente(entCliente cliente)
        {
            SqlCommand cmd = null;
            Boolean editar = false;
            try
            {
                SqlConnection cn = Conexion.instancia.Conectar();
                cmd = new SqlCommand("editarCliente", cn);
                cn.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", cliente.id);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@correo", cliente.correo);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefeno);

                int estado = cliente.estado ? 1 : 0;
                cmd.Parameters.AddWithValue("@estado", estado);
                int row = cmd.ExecuteNonQuery();
                editar = row >= 1 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return editar;
        }
    }
}
