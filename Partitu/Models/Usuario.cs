using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;
using Partitu.Models.Validacoes;

namespace Partitu.Models
{
    public partial class Usuario
    {
        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "Campo requerido")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string senha { get; set; }
        [Compare("senha", ErrorMessage="As senhas são diferentes.")]
        [Required(ErrorMessage = "Campo requerido")]
        public string confirmarSenha { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage="digite um email válido")]
        [Required(ErrorMessage = "Campo requerido")]
        public string email { get; set; }
        [CPF]
        [Required(ErrorMessage = "Campo requerido")]
        public string cpf { get; set; }

        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage="Campo requerido")]
        public DateTime data_nascimento { get; set; }
        
        public DateTime data_cadastro { get; set; }
        public string nivel { get; set; }
        public int fk_endereco { get; set; }
        public string codS { get; set; }


    }
}