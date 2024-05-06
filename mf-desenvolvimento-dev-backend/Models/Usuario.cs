using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_desenvolvimento_dev_backend.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string NomeCompleto { get; set; }
        [Required(ErrorMessage = "O e-mail é obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O telefone é obrigatório!")]
        public string NumCelular { get; set; }
        [Required(ErrorMessage = "O CPF é obrigatório!")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "A data de nascimento é obrigatório!")]
        public int DataNascimento { get; set; }
        [Required(ErrorMessage = "A senha é obrigatório!")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Confirmar a senha é obrigatório!")]
        public string ConfirmarSenha { get; set; }


        [Required(ErrorMessage = "CEP é obrigatório!")]
        public int Cep { get; set; }
        [Required(ErrorMessage = "Logradouro é obrigatório!")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Número da residência é obrigatório!")]
        public int NumeroResidencia { get; set; }
        [Required(ErrorMessage = "Bairro é obrigatório!")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Cidade é obrigatório!")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Estado é obrigatório!")]
        public string Estado { get; set; }

        public string Complemento { get; set; }
    }
}


