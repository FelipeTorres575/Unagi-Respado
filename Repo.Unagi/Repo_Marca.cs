using Enti.Unagi;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Repo.Unagi
{
    public class Repo_Marca
    {
        private readonly List<Marca> listaMarca = new List<Marca>();
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["UnagiConexion"].ConnectionString;

        public Repo_Marca()
        {
            CargarDesdeBD();
        }

        private void CargarDesdeBD()
        {
            listaMarca.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Traemos Nombre y Apellido por separado de la tabla Emprendedor
                string query = "SELECT M.IdMarca, M.Nombre, M.Logo, E.IdEmprendedor, E.Nombre, E.Apellido " +
                               "FROM Marca M " +
                               "INNER JOIN Emprendedor E ON M.IdEmprendedor = E.IdEmprendedor";

                SqlCommand command = new SqlCommand(query, connection);
                // si marca error el servidor esta apagado MSSQLSERVER
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idMarca = reader.GetInt32(0);
                    string nombreMarca = reader.GetString(1);
                    string logo = reader.GetString(2);
                    int idEmprendedor = reader.GetInt32(3);

                    Marca marca = new Marca(idMarca, nombreMarca, idEmprendedor, logo);

                    marca.emprendedor = new Emprendedor()
                    {
                        Id_Emprendedor = idEmprendedor,
                        Nombre = reader.GetString(4),     
                        Apellido = reader.GetString(5)    
                    };

                    listaMarca.Add(marca);
                }
                reader.Close();
            }
        }

        public List<Marca> GetMarcas()
        {
            return listaMarca;
        }

        public void AgregarMarca(Marca marca)
        {
            if (marca.Logo == null)
            {
                marca.Logo = "default_logo.png"; // Asignar un valor predeterminado si es nulo
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Marca (Nombre, IdEmprendedor, Logo) VALUES (@Nombre, @IdEmprendedor, @Logo); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", marca.Nombre);
                command.Parameters.AddWithValue("@IdEmprendedor", marca.Id_Emprendedor);
                command.Parameters.AddWithValue("@Logo", marca.Logo);
                connection.Open();
                int idMarca = Convert.ToInt32(command.ExecuteScalar());
                marca.Id_Marca = idMarca;
                listaMarca.Add(marca);
            }
        }

        public void EditarMarca(Marca marca)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Marca SET Nombre = @Nombre, IdEmprendedor = @IdEmprendedor, Logo = @Logo WHERE IdMarca = @IdMarca";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", marca.Nombre);
                command.Parameters.AddWithValue("@IdEmprendedor ", marca.Id_Emprendedor);
                command.Parameters.AddWithValue("@IdMarca", marca.Id_Marca);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EliminarMarca(int idMarca)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // error futuro por si hay productos asociados a este tipo
                string query = "DELETE FROM Marca WHERE IdMarca = @IdMarca";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdMarca", idMarca);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
