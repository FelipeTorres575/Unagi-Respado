using Enti.Unagi;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Repo.Unagi
{
    public class Repo_Producto
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["UnagiConexion"].ConnectionString;
        private static List<Producto> listaProductos = new List<Producto>();

        public Repo_Producto()
        {
            CargarDesdeBD();
        }

        private void CargarDesdeBD()
        {
            listaProductos.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Traemos Nombre y Apellido por separado de la tabla Emprendedor
                string query = "Select P.IdProducto, P.Nombre, P.IdTipo, T.Nombre, " +
               "P.IdMarca, M.Nombre, P.Descripcion, P.Precio, P.Stock " +
               "from Producto P " +
               "inner join Tipo T on T.IdTipo = P.IdTipo " +
               "inner join Marca M on M.IdMarca = P.IdMarca";

                SqlCommand command = new SqlCommand(query, connection);
                // si marca error el servidor esta apagado MSSQLSERVER
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ProductoId = reader.GetInt32(0);
                    string nombreProducto = reader.GetString(1);
                    int idTipo = reader.GetInt32(2);
                    int idMarca = reader.GetInt32(4);
                    string descripcion = reader.GetString(6);
                    decimal precio = reader.GetDecimal(7);
                    int stock = reader.GetInt32(8);

                    Producto producto = new Producto(ProductoId, nombreProducto, idTipo, idMarca, descripcion, precio, stock);

                    Tipo tipo = new Tipo()
                    {
                        Id_Tipo = idTipo,
                        Nombre = reader.GetString(3)
                    };

                    Marca marca = new Marca()
                    {
                        Id_Marca = idMarca,
                        Nombre = reader.GetString(5)
                    };
                    ///instaciar
                    producto.tipo = tipo;
                    producto.marca = marca;

                    listaProductos.Add(producto);
                }
                reader.Close();
            }
        }

        public List<Producto> GetProductos()
        {
            return listaProductos;
        }

        public void Agregar(Producto producto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Producto (Nombre, IdTipo, IdMarca, Descripcion, Precio, " +
                    "Stock) VALUES (@Nombre, @IdTipo, @IdMarca, @Descripcion, @Precio, @Stock); " +
                    "SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@IdTipo", producto.Id_Tipo);
                command.Parameters.AddWithValue("@IdMarca", producto.Id_Marca);
                command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Stock", producto.Stock);
                // command.Parameters.AddWithValue("@Foto", producto.Foto);
                connection.Open();
                int idProducto = Convert.ToInt32(command.ExecuteScalar());
                producto.Id_Productos = idProducto;
                listaProductos.Add(producto);
            }
        }

        public void Editar(Producto producto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Producto SET Nombre = @Nombre, IdTipo = @IdTipo," +
                    " IdMarca = @IdMarca, Descripcion = @Descripcion, Precio = @Precio," +
                    " Stock = @Stock WHERE IdProducto = @IdProducto";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@IdTipo", producto.Id_Tipo);
                command.Parameters.AddWithValue("@IdMarca", producto.Id_Marca);
                command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Stock", producto.Stock);
                // command.Parameters.AddWithValue("@Foto", producto.Foto);
                command.Parameters.AddWithValue("@IdProducto", producto.Id_Productos);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idPro)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // error futuro por si hay productos asociados a este tipo
                string query = "DELETE FROM Producto WHERE IdProducto = @IdProducto";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdProducto", idPro);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
