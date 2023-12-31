using HamburgueriaSana.Models;

namespace HamburgueriaSana.Repositorio
{
    public interface IprodutoRepositorio
    {
        ProdutoModel Adicionar(ProdutoModel produto);
        List<ProdutoModel>  BuscarTodos();
        ProdutoModel ListarPorId(int id);
        ProdutoModel Atualizar(ProdutoModel produto);
        bool Apagar(int id);


    }
}
