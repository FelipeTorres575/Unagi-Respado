namespace Enti.Unagi
{
    public class Tipo
    {
        public int Id_Tipo { get; set; }
        public string Nombre { get; set; }
        public int Id_Categoria { get; set; }

        public Tipo()
        {

        }

        public Tipo(int id_tipo, string nombre, int id_categoria)
        {
            Id_Tipo = id_tipo;
            Nombre = nombre;
            Id_Categoria = id_categoria;
        }

        public Tipo(int id_tipo, string nombre)
        {
            Id_Tipo = id_tipo;
            Nombre = nombre;
        }

        // Propiedad de navegacion
        public Categoria categoria;
    }
}
