using MySql.Data.MySqlClient;


namespace Datos.Nucleo
{
    public class Connection
    {
        private readonly string _conectionString;
        public Connection()
        {
            _conectionString = "server=localhost; database=SIF; userid= root; password= 123456;";
        }
        public MySqlConnection ObtenerConexion()
        {
            var conexion = new MySqlConnection(_conectionString);
            return conexion;
        }


    }
}
