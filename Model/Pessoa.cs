using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImobiliariaProjeto.Model
{
    public class Pessoa
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [StringLength(11, ErrorMessage = "O CPF deve conter 11 digitos")]
        public string Cpf { get; set; }

        [Required]
        public DateTime dataNascimento { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Cep { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Uf { get; set; }
    }
}
