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

        public ContatoModel Editar(ContatoModel contato)
        {
            ContatoModel contatoDb = Buscar(contato.Id);
            if (contatoDb == null) throw new SystemException("Erro ao atualizar");

            contatoDb.Nome = contato.Nome;
            contatoDb.Email = contato.Email;
            contatoDb.Telefone = contato.Telefone;

            _BdContext.Contatos.Update(contatoDb);
            _BdContext.SaveChanges();

            return contatoDb;
        }

        public ContatoModel Buscar(int id)
        {
           return _BdContext.Contatos.FirstOrDefault(c => c.Id == id);
        }

        public List<ContatoModel> Listar()
        {
            return _BdContext.Contatos.ToList();
        }

        public bool Apagar(int id)
        {
           ContatoModel contatoDb = Buscar(id);
            if(contatoDb == null) throw new SystemException("Erro ao atualizar");

            _BdContext.Contatos.Remove(contatoDb);  
            _BdContext.SaveChanges();
            return true;
        } 
    }
}
