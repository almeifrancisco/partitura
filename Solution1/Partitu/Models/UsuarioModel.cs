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
    public partial class UsuarioModel
    {
        
        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "Campo requerido")]
        public string nome { get; set; }
        [RegularExpression("^(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=])(?=\\S+$).{8,}$", ErrorMessage="A senha deve conter 8 caracteres, letras maiusculas e minusculas e numeros")]
        [Required(ErrorMessage = "Campo requerido")]
        public string senha { get; set; }
        [Compare("senha", ErrorMessage="As senhas são diferentes.")]
        [Required(ErrorMessage = "Campo requerido")]
        public string confirmarSenha { get; set; }
        
        [EmailExist(ErrorMessage="Alguém já esta usando esse email")]
        [DataType(DataType.EmailAddress, ErrorMessage="digite um email válido")]
        [Required(ErrorMessage = "Campo requerido")]
        public string email { get; set; }
        
        [CPF(ErrorMessage="Informe um CPF válido")]
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