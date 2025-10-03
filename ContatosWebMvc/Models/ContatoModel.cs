using System.ComponentModel.DataAnnotations;

namespace ContatosWebMvc.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Informe o Nome do contato")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o Email do contato")]
        [EmailAddress(ErrorMessage ="O email informado é invalido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o Telefone do contato")]
        [Phone(ErrorMessage = "Numero de celular invalido")]
        public string Telefone { get; set; }
    }
}
