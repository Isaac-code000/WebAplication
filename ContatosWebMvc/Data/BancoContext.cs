using ContatosWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace ContatosWebMvc.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ContatoModel> Contatos { get; set; }   
    }
}
