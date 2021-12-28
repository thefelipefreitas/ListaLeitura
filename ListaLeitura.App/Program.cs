using ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Hosting;

namespace ListaLeitura.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new LivroRepositorioCSV();

            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<StartUp>()
                .Build();

            host.Run();
        }
    }
}
