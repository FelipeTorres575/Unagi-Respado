using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enti.Unagi
{
    public class Marca
    {
        public int Id_Marca { get; set; }
        public string Nombre { get; set; }
        public int Id_Emprendedor { get; set; }
        public string Logo { get; set; }

        public Marca()
        {
                
        }

        public Marca(int id_Marca, string nombre, int id_Emprendedor, string logo)
        {
            Id_Marca = id_Marca;
            Nombre = nombre;
            Id_Emprendedor = id_Emprendedor;
            Logo = logo;
        }

        //este constructor es para cuando no se tiene el logo
        public Marca(int id_Marca, string nombre, int id_Emprendedor)
        {
            Id_Marca = id_Marca;
            Nombre = nombre;
            Id_Emprendedor = id_Emprendedor;
        }

        public Marca(int id_Marca, string nombre)
        {
            Id_Marca = id_Marca;
            Nombre = nombre;
        }

        //Propiedad de Navegacion
        public Emprendedor emprendedor;
    }
}
