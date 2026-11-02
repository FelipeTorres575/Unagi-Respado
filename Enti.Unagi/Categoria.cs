using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enti.Unagi
{
    public class Categoria
    {
        public int Id_Categoria;

        public string Nombre;
        public Categoria()
        {
            
        }

        public Categoria(int id_categoria, string nombre)
        {
            Id_Categoria = id_categoria;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
