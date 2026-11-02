using Enti.Unagi;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Repo.Unagi
{
    public class Repo_Categoria
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["UnagiConexion"].ConnectionString;
        private static List<Categoria> listaCategoria= new List<Categoria>();

        public Repo_Categoria()
        {
            CargarDesdeBD();
        }

        private void CargarDesdeBD()
        {
            listaCategoria.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdCategoria, Nombre FROM Categoria";
                SqlCommand command = new SqlCommand(query, connection);
                // si marca error el servidor esta apagado
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idCategoria = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    Categoria categoria = new Categoria(idCategoria, nombre);
                    listaCategoria.Add(categoria);
                }
                reader.Close();
            }
        }

        public List<Categoria> GetCategorias()
        {
            return listaCategoria;
        }
        
        public void AgregarCategoria(Categoria categoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Categoria (Nombre) VALUES (@Nombre); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                connection.Open();
                int idCategoria = Convert.ToInt32(command.ExecuteScalar());
                categoria.Id_Categoria = idCategoria;
                listaCategoria.Add(categoria);
            }
        }

        public void EditarCategoria(Categoria categoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Categoria SET Nombre = @Nombre WHERE IdCategoria = @IdCategoria";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                command.Parameters.AddWithValue("@IdCategoria", categoria.Id_Categoria);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EliminarCategoria(int idCategoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // error al eliminar categoria si tiene tipos asociados, se debe eliminar primero los tipos asociados
                string query = "DELETE FROM Categoria WHERE IdCategoria = @IdCategoria";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCategoria", idCategoria);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}