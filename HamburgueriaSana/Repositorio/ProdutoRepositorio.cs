using HamburgueriaSana.Data;
using HamburgueriaSana.Models;
using Microsoft.EntityFrameworkCore;

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

        public ProdutoModel Atualizar(ProdutoModel produto)
        {
            ProdutoModel produtoDb = ListarPorId(produto.ProdutoId);
            if (produtoDb == null)
                throw new System.Exception("Houve um erro na atualização do contato");

            produtoDb.Nome = produto.Nome;
            produtoDb.Preco = produto.Preco;
            _db.Produto.Update(produtoDb);
            _db.SaveChanges();
            return produtoDb;
        }

        public List<ProdutoModel> BuscarTodos()
        {
            return _db.Produto.ToList();
        }

        public ProdutoModel ListarPorId(int id)
        {
            return _db.Produto.FirstOrDefault(x => x.ProdutoId == id);
        }

        public bool Apagar(int id)
        {
            ProdutoModel produtoDb = ListarPorId(id);
            if (produtoDb == null) throw new System.Exception("Houve um erro na delação do produto");

            _db.Produto.Remove(produtoDb);
            _db.SaveChanges();
            return true;

        }
    }
}
