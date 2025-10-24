using MySql.Data.MySqlClient;

namespace DirectorioTelefonico.Data
{
    public class Conexion
    {
        private const string Cadena = "Server=127.0.0.1;Database=directorio;Uid=root;Pwd=;";
        public static MySqlConnection ObtenerConexion()
        {
            var conexion = new MySqlConnection(Cadena);
            conexion.Open();
            return conexion;
        }
    }
}
