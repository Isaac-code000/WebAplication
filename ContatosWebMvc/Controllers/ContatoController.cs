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
        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.Buscar(id); 
            return View(contato);
        }
        public IActionResult Apagar(int id)
        {
            ContatoModel contato = _contatoRepositorio.Buscar(id);
            return View(contato);
        }

        public IActionResult Deletar(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");  
        }
        [HttpPost]
        public IActionResult Editar(ContatoModel contato)
        {
            _contatoRepositorio.Editar(contato);
            return RedirectToAction("Index");
        }
        



    }
}
