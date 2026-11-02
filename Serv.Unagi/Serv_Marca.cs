using Enti.Unagi;
using Repo.Unagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serv.Unagi
{
    public class Serv_Marca
    {
        Repo_Marca repoMarca = new Repo_Marca();

        public List<Marca> GetMarcas()
        {
            return repoMarca.GetMarcas();
        }

        public void AgregarMarca(Marca marca)
        {
            repoMarca.AgregarMarca(marca);
        }

        public void EditarMarca(Marca marca)
        {
            repoMarca.EditarMarca(marca);
        }

        public void EliminarMarca(Marca marca)
        {
            repoMarca.EliminarMarca(marca.Id_Marca);
        }
    } 
}
