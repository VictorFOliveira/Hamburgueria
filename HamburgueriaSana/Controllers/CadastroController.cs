using HamburgueriaSana.Models;
using HamburgueriaSana.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaSana.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IprodutoRepositorio _produtoRepositorio;

        public CadastroController(IprodutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ProdutoModel produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _produtoRepositorio.Adicionar(produto);
                    TempData["MensagemSucesso"] = "Produto Cadastrado";
                    return RedirectToAction("Index");
                }
                return View(produto);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar o seu produto, tente novamente. Detalhes do erro{erro}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Listar()
        {
            List<ProdutoModel> produtos = _produtoRepositorio.BuscarTodos();
            return View(produtos);
        }

        public IActionResult Editar()
        {

            ProdutoModel produtos = _produtoRepositorio.ListarPorId(id);
            return View(contatos);

        }
    }
}