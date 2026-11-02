namespace Enti.Unagi
{
    public class Producto
    {
        public int Id_Productos;
        public string Nombre;
        public int Id_Tipo;
        public int Id_Marca;
        public string Descripcion;
        public decimal Precio;
        public int Stock;
        public string Foto;

        // Constructor
        public Producto()
        {
                
        }
        // Constructor sobrecargado 
        public Producto(int id_Productos, string nombre, int id_Tipo, int id_Marca, string descripcion, decimal presio, int stock, string foto)
        {
            Id_Productos = id_Productos;
            Nombre = nombre;
            Id_Tipo = id_Tipo;
            Id_Marca = id_Marca;
            Descripcion = descripcion;
            Precio = presio;
            Stock = stock;
            Foto = foto;
        }

        public Producto(int id_Productos, string nombre, int id_Tipo, int id_Marca, string descripcion, decimal presio, int stock)
        {
            Id_Productos = id_Productos;
            Nombre = nombre;
            Id_Tipo = id_Tipo;
            Id_Marca = id_Marca;
            Descripcion = descripcion;
            Precio = presio;
            Stock = stock;
        }

        // Propiedades de navegacion
        public Tipo tipo;

        public Marca marca;
    }

}
