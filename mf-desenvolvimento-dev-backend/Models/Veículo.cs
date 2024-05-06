using System.ComponentModel.DataAnnotations.Schema;

namespace mf_desenvolvimento_dev_backend.Models
{
    [Table]("Usuario")]
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string NumCelular { get; set; }
    }
}
