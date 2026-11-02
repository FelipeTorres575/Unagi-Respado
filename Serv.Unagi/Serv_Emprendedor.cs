using Enti.Unagi;
using Repo.Unagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serv.Unagi
{
    public class Serv_Emprendedor
    {
        Repo_Emprendedor repo_Emprendedor = new Repo_Emprendedor();

        public List<Emprendedor> GetEmprendedors()
        {
            return repo_Emprendedor.GetEmprendedores();
        }

        public void AgregarEmprendedor(Emprendedor emprendedor)
        {
            repo_Emprendedor.AgregarEmprendedor(emprendedor);
        }

        public void EditarEmprendedor(Emprendedor emprendedor)
        {
            repo_Emprendedor.EditarEmprendedor(emprendedor);
        }

        public void EliminarEmprendedor(Emprendedor emprendedor)
        {
            repo_Emprendedor.EliminarEmprendedor(emprendedor.Id_Emprendedor);
        }
    }
}
