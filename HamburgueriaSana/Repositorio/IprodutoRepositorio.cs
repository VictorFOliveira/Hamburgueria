using HamburgueriaSana.Models;

namespace HamburgueriaSana.Repositorio
{
    public interface IprodutoRepositorio
    {
        ProdutoModel Adicionar(ProdutoModel produto);
        ProdutoModel Remover(ProdutoModel produto);
        List<ProdutoModel>  BuscarTodos();

    }
}
