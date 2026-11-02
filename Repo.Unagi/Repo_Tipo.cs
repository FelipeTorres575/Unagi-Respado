using Enti.Unagi;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Repo.Unagi
{
    public class Repo_Tipo
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["UnagiConexion"].ConnectionString;
        private static List<Tipo> listaTipo = new List<Tipo>();

        public Repo_Tipo()
        {
            CargarDesdeBD();
        }

        private void CargarDesdeBD()
        {
            listaTipo.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select t.IdTipo, t.Nombre, t.IdCategoria, c.Nombre " +
                    "from tipo " +
                    "t\r\ninner join Categoria c on c.IdCategoria = t.IdCategoria";
                SqlCommand command = new SqlCommand(query, connection);
                // si marca error el servidor esta apagado MSSQLSERVER
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idTipo = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    int idCategoria = reader.GetInt32(2);
                    Tipo tipo = new Tipo(idTipo, nombre, idCategoria);

                    //aca entra en juego la propiedad de navegacion
                    tipo.categoria = new Categoria()
                    {
                        Id_Categoria=tipo.Id_Categoria,
                        Nombre=reader.GetString(3)
                    };
                    listaTipo.Add(tipo);
                }
                reader.Close();
            }
        }

        public List<Tipo> GetTipos()
        {
            return listaTipo;
        }

        public void AgregarTipo(Tipo tipo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Tipo (Nombre, IdCategoria) VALUES (@Nombre, @IdCategoria); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", tipo.Nombre);
                command.Parameters.AddWithValue("@IdCategoria", tipo.Id_Categoria);
                connection.Open();
                int idTipo = Convert.ToInt32(command.ExecuteScalar());
                tipo.Id_Tipo = idTipo;
                listaTipo.Add(tipo);
            }
        }

        public void EditarTipo(Tipo tipo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Tipo SET Nombre = @Nombre, IdCategoria = @IdCategoria WHERE IdTipo = @IdTipo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", tipo.Nombre);
                command.Parameters.AddWithValue("@IdCategoria", tipo.Id_Categoria);
                command.Parameters.AddWithValue("@IdTipo", tipo.Id_Tipo);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EliminarTipo(int idTipo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // error futuro por si hay productos asociados a este tipo  
                // futuramente implemnetar un falso borrao ,actualizar un campo activo
                // en la tabla tipo y en la tabla producto
                string query = "DELETE FROM Tipo WHERE IdTipo = @IdTipo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdTipo", idTipo);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
