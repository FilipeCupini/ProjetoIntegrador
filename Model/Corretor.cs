using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImobiliariaProjeto.Model
{
    public class Corretor : Pessoa
    {
        [Required(ErrorMessage = "CRECI deve conter 8 digitos")]
        [StringLength(8, ErrorMessage = "CRECI não tem 8 digitos")]
        public string Creci { get; set; } 
    }
}
