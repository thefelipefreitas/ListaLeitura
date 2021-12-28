using ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ListaLeitura.App.Logica
{
    public class LivrosController : Controller
    {
        public IActionResult ParaLer()
        {
            var _repositorio = new LivroRepositorioCSV();
            ViewBag.Livros = _repositorio.ParaLer.Livros;
            return View("lista");
        }

        public IActionResult Lendo()
        {
            var _repositorio = new LivroRepositorioCSV();
            ViewBag.Livros = _repositorio.Lendo.Livros;
            return View("lista");
        }

        public IActionResult Lidos()
        {
            var _repositorio = new LivroRepositorioCSV();
            ViewBag.Livros = _repositorio.Lidos.Livros;
            return View("lista");
        }

        public string ExibirDetalhes(int id)
        {
            var _repositorio = new LivroRepositorioCSV();
            var livro = _repositorio.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }
    }
}
