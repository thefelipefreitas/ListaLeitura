using ListaLeitura.App.Negocio;
using ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ListaLeitura.App.Logica
{
    public class CadastroController
    {
        public IActionResult Incluir(Livro livro)
        {
            var _repositorio = new LivroRepositorioCSV();
            _repositorio.Incluir(livro);
            var html = new ViewResult { ViewName = "aviso-sucesso" };
            return html;
        }

        public IActionResult ExibirFormulario()
        {
            var html = new ViewResult { ViewName = "formulario" };
            return html;
        }
    }
}
