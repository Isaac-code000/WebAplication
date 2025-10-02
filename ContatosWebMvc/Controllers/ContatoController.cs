using ContatosWebMvc.Data;
using ContatosWebMvc.Models;
using ContatosWebMvc.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ContatosWebMvc.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio) {
            _contatoRepositorio = contatoRepositorio;
            
        }  
        public IActionResult Index()
        {
            List<ContatoModel> listaContatos = _contatoRepositorio.Listar();
            return View(listaContatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Apagar()
        {
            return View();
        }
        public IActionResult ApagarContato()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");  
        }
    }
}
