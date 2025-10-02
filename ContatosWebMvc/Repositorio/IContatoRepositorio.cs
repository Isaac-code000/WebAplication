using ContatosWebMvc.Models;

namespace ContatosWebMvc.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
        List<ContatoModel> Listar();
       
    }
}
