using HamburgueriaSana.Data;
using HamburgueriaSana.Models;

namespace HamburgueriaSana.Repositorio
{
    public class ProdutoRepositorio : IprodutoRepositorio
    {
        private readonly ApplicationDbContext _db;

        public ProdutoRepositorio(ApplicationDbContext db)
        {
            this._db = db;
        }
        public ProdutoModel Adicionar(ProdutoModel produto)
        {
            _db.Produto.Add(produto);
            _db.SaveChanges();
            return produto;

        }
        public ProdutoModel ListarProdutosPorId(int id)
        {
            return _db.Produto.FirstOrDefault(x => x.ProdutoId == id);
        }

        public ProdutoModel Remover(ProdutoModel produto)
        {
            _db.Produto.Remove(produto);
            _db.SaveChanges();
            return produto;
        }
    }
}
