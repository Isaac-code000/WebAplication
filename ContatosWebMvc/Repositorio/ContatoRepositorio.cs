using ContatosWebMvc.Data;
using ContatosWebMvc.Models;

namespace ContatosWebMvc.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _BdContext;
        public ContatoRepositorio(BancoContext bancoContext) {
        _BdContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _BdContext.Contatos.Add(contato);
            _BdContext.SaveChanges();   
            return contato;
        }

        public List<ContatoModel> Listar()
        {
            return _BdContext.Contatos.ToList();
        }
    }
}
