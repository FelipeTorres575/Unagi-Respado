using Enti.Unagi;
using Repo.Unagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serv.Unagi
{
    public class Serv_Producto
    {
        Repo_Producto repo=new Repo_Producto();

        public List<Producto> GetLista()
        {
            return repo.GetProductos();
        }

        public void Agregar(Producto producto)
        {
            repo.Agregar(producto);
        }

        public void Editar(Producto producto)
        {
            repo.Editar(producto);
        }

        public void Eliminar(int idPro)
        {
            repo.Eliminar(idPro);
        }


    }
}
