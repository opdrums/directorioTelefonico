using System.Data;
using MySql.Data.MySqlClient;
using DirectorioTelefonico.Models;

namespace DirectorioTelefonico.Data
{
    public static class EmpleadoDAL
    {
        private static string connectionString = "Server=localhost;Database=directorio;Uid=root;Pwd=tu_contraseña;";

        // Cambia a true para simular la conexión a la BD
        public static bool SimularBD = false;

        public static void Agregar(Empleado emp)
        {
            if (SimularBD)
            {
                // En modo simulado no hace nada o puedes guardar en memoria si quieres
                return;
            }

            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = "INSERT INTO empleados (documento, nombre, apellidos, telefono, cargo, oficina) " +
                         "VALUES (@documento, @nombre, @apellidos, @telefono, @cargo, @oficina)";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@documento", emp.Documento);
            cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
            cmd.Parameters.AddWithValue("@apellidos", emp.Apellidos);
            cmd.Parameters.AddWithValue("@telefono", emp.Telefono);
            cmd.Parameters.AddWithValue("@cargo", emp.Cargo);
            cmd.Parameters.AddWithValue("@oficina", emp.Oficina);
            cmd.ExecuteNonQuery();
        }

        public static DataTable Listar()
        {
            if (SimularBD)
            {
                // Tabla simulada en memoria
                var dt = new DataTable();
                dt.Columns.Add("documento");
                dt.Columns.Add("nombre");
                dt.Columns.Add("apellidos");
                dt.Columns.Add("telefono");
                dt.Columns.Add("cargo");
                dt.Columns.Add("oficina");

                // Datos de ejemplo
                dt.Rows.Add("0001", "Juan", "Pérez", "555-1234", "Admin", "Of1");
                dt.Rows.Add("0002", "Ana", "Gómez", "555-5678", "User", "Of2");
                return dt;
            }

            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT * FROM empleados";
            using var adapter = new MySqlDataAdapter(sql, conn);
            var dtReal = new DataTable();
            adapter.Fill(dtReal);
            return dtReal;
        }

        public static void Eliminar(string documento)
        {
            if (SimularBD)
            {
                // No hace nada en modo simulado
                return;
            }

            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = "DELETE FROM empleados WHERE documento=@documento";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@documento", documento);
            cmd.ExecuteNonQuery();
        }
    }
}
