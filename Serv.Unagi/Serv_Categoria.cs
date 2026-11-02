 using Enti.Unagi;
using Repo.Unagi;

namespace Serv.Unagi
{
    public class Serv_Categoria
    {
        Repo_Categoria repoCategoria= new Repo_Categoria();

        public List<Categoria> GetCategorias()
        {
            return repoCategoria.GetCategorias();
        }

        public void AgregarCategoria(Categoria categoria)
        {
            repoCategoria.AgregarCategoria(categoria);
        }

        public void EditarCategoria(Categoria categoria)
        {
            repoCategoria.EditarCategoria(categoria);
        }

        public void EliminarCategoria(Categoria categoria)
        {
            repoCategoria.EliminarCategoria(categoria.Id_Categoria);
        }
    }
}
