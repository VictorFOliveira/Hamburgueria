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


        public IActionResult Editar(int id)
        {
            ProdutoModel produto = _produtoRepositorio.ListarPorId(id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult Alterar(ProdutoModel produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _produtoRepositorio.Atualizar(produto);
                    TempData["MensagemSucesso"] = "Produto Atualizado com sucesso";
                    return RedirectToAction("Listar");
                }
                return View(produto);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos alterar seu produto, tente novamente. Detalhes do erro: {erro}";
                return RedirectToAction("Listar");
            }
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            ProdutoModel produto = _produtoRepositorio.ListarPorId(id);
            return View(produto);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _produtoRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Produto apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "Ops, Não conseguimos apagar seu produto";
                }
                return RedirectToAction("Listar");
            }
            catch(System.Exception erro)
            {
                TempData["MensagemErro"] = $"ops, não conseguimos apagar seu contato. Tente novamente. Detalhes do erro: {erro}";
                return RedirectToAction("Listar");
            }
        }
    }
}