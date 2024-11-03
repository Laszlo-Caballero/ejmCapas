using Microsoft.Data.SqlClient;


namespace capaAccesoDatos
{
    public class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        
        public static Conexion instancia
        {
            get { return Conexion._instancia; }
        }


        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LASZLO\\SQLEXPRESS; Initial Catalog =market;" +//"User ID=sa; Password=123";
                                "Integrated Security=true; TrustServerCertificate=True;";
            return cn;
        }
    }
}
