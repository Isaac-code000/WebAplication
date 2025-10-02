using ContatosWebMvc.Models;

namespace ContatosWebMvc.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
        List<ContatoModel> Listar();
        bool Apagar(int id);
        ContatoModel Buscar(int id);

        ContatoModel Editar(ContatoModel contato);   

    }
}
