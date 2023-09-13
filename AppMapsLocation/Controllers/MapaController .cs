using AppMapsLocation.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace AppMapsLocation.Controllers
{
    //Declaração da Classe do Controlador
    public class MapaController : Controller
    {


        private Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment;
        public MapaController(Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            hostingEnvironment = environment;
        }
        public IActionResult ExibirMapa()
        {
            //Nesta parte, o código está lendo o arquivo JSON chamado dados.json do diretório raiz da pasta web
            //(usando hostingEnvironment.WebRootPath) e o desserializando em uma lista de objetos do tipo DadosModel usando a biblioteca Newtonsoft.Json
            string caminhoArquivo = Path.Combine(hostingEnvironment.WebRootPath, "~/Static/dados.json");
            var json = System.IO.File.ReadAllText(caminhoArquivo);
            var dados = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DadosModel>>(json);

            return View(dados);
        }

        private object ContentRootPath()
        {
            throw new NotImplementedException();
        }
    }
}
