using Enti.Unagi;
using Repo.Unagi;

namespace Serv.Unagi
{
    public class Serv_Tipo
    {
        Repo_Tipo repoTipo = new Repo_Tipo();

        public List<Tipo> GetTipos()
        {
            return repoTipo.GetTipos();
        }

        public void AgregarTipo(Tipo tipo)
        {
            repoTipo.AgregarTipo(tipo);
        }

        public void EditarTipo(Tipo tipo)
        {
            repoTipo.EditarTipo(tipo);
        } 

        public void EliminarTipo(int idTipo)
        {
            repoTipo.EliminarTipo(idTipo);
        }
    }
}
