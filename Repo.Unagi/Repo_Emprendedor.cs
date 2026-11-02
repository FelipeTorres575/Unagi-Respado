using Enti.Unagi;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Repo.Unagi
{
    public class Repo_Emprendedor
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["UnagiConexion"].ConnectionString;
        private readonly List<Emprendedor> listaEmprendedores = new List<Emprendedor>();

        public Repo_Emprendedor()
        {
            CargarDesdeBD();
        }

        private void CargarDesdeBD()
        {
            listaEmprendedores.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IdEmprendedor, Nombre, Apellido, Dni, Correo, Telefono " +
                    "FROM Emprendedor";
                SqlCommand command = new SqlCommand(query, connection);
                // si marca error el servidor esta apagado
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idEmprendedor = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string dni = reader.GetString(3);
                    string correo = reader.GetString(4);
                    string telefono = reader.GetString(5);
                    Emprendedor emprendedor = new Emprendedor
                    {
                        Id_Emprendedor = idEmprendedor,
                        Nombre = nombre,
                        Apellido = apellido,
                        Dni = dni,
                        Correo = correo,
                        Telefono = telefono
                    };
                    listaEmprendedores.Add(emprendedor);
                }
                reader.Close();
            }
        }

        public List<Emprendedor> GetEmprendedores()
        {
            return listaEmprendedores;
        }

        public void AgregarEmprendedor(Emprendedor emprendedor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Emprendedor (Nombre, Apellido, Dni, Correo, Telefono) " +
                    "VALUES (@Nombre, @Apellido, @Dni, @Correo, @Telefono); " +
                    "SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", emprendedor.Nombre);
                command.Parameters.AddWithValue("@Apellido", emprendedor.Apellido);
                command.Parameters.AddWithValue("@Dni", emprendedor.Dni);
                command.Parameters.AddWithValue("@Correo", emprendedor.Correo);
                command.Parameters.AddWithValue("@Telefono", emprendedor.Telefono);
                connection.Open();
                int idEmprendedor = Convert.ToInt32(command.ExecuteScalar());
                emprendedor.Id_Emprendedor = idEmprendedor;
                listaEmprendedores.Add(emprendedor);
            }
        }

        public void EditarEmprendedor(Emprendedor emprendedor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Emprendedor SET Nombre = @Nombre, Apellido = @Apellido, " +
                    "Dni = @Dni, " +
                    "Correo = @Correo, Telefono = @Telefono WHERE IdEmprendedor = @Id_Emprendedor  ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", emprendedor.Nombre);
                command.Parameters.AddWithValue("@Apellido", emprendedor.Apellido);
                command.Parameters.AddWithValue("@Dni", emprendedor.Dni);
                command.Parameters.AddWithValue("@Correo", emprendedor.Correo);
                command.Parameters.AddWithValue("@Telefono", emprendedor.Telefono);
                command.Parameters.AddWithValue("@Id_Emprendedor", emprendedor.Id_Emprendedor);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EliminarEmprendedor(int idEmprendedor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // error al eliminar emprendedor si tiene tipos asociados, se debe eliminar primero los tipos asociados
                string query = "DELETE FROM Emprendedor WHERE IdEmprendedor = @Id_Emprendedor";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Emprendedor", idEmprendedor);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
