using MySql.Data.MySqlClient;
using Dapper;


namespace Datos.Nucleo
{
    public class Context<T> where T : class
    {
        private readonly Connection _conexion;

        //Los metodos Protected solo podran ser heredados por las clase hija y no por la clase nieta
        protected Context()
        {
            _conexion = new Connection();
        }

        protected async Task<T?> GET_BYID(int id)
        {
            using (var conexion = _conexion.ObtenerConexion())
            {
                conexion.Open();
                return await conexion.QuerySingleOrDefaultAsync<T>($"SELECT * FROM {typeof(T).Name} WHERE Id = @Id", new { Id = id });
            }
        }
        protected async Task<IEnumerable<T>> GET_ALL()
        {
            using (var connection = _conexion.ObtenerConexion())
            {
                connection.Open();
                return await connection.QueryAsync<T>($"SELECT * FROM {typeof(T).Name}");
            }
        }

        protected async Task<T?> INSERT(T entidad)
        {
            using (var connection = _conexion.ObtenerConexion())
            {
                connection.Open();
                var query = GenerarQueryInsert(entidad);
                return await connection.ExecuteScalarAsync<T>(query, entidad);
                //return await GET_LAST();
            }
        }

        protected async Task<T?> UPDATE(T entidad)
        {
            using (var connection = _conexion.ObtenerConexion())
            {
                connection.Open();
                var query = GenerarQueryUpdate(entidad);
                return await connection.ExecuteScalarAsync<T>(query, entidad);
            }
        }

        protected async Task<T?> DELETE(int id)
        {
            using (var connection = _conexion.ObtenerConexion())
            {
                connection.Open();
                return await connection.ExecuteScalarAsync<T>($"DELETE FROM {typeof(T).Name} WHERE Id = @Id", new { Id = id });
            }
        }

        //Estos metodos private son propios de esta clase no pueden ser heredados
        private string GenerarQueryInsert(T entidad)
        {
            var properties = typeof(T).GetProperties();
            var columnNames = string.Join(", ", properties.Select(p => p.Name));
            var paramNames = string.Join(", ", properties.Select(p => "@" + p.Name));
            return $"INSERT INTO {typeof(T).Name} ({columnNames}) VALUES ({paramNames})";
        }
        private string GenerarQueryUpdate(T entidad)
        {
            var properties = typeof(T).GetProperties();
            var setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));
            return $"UPDATE {typeof(T).Name} SET {setClause} WHERE Id = @Id";
        }
        private async Task<T?> GET_LAST()
        {
            using (var connection = _conexion.ObtenerConexion())
            {
                connection.Open();
                return await connection.QuerySingleOrDefaultAsync<T>($"SELECT * FROM {typeof(T).Name} order by Id desc limit 1");
            }
        }
    }
}
