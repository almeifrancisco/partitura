using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Service.service;

namespace Partitu.Models.Validacoes
{
    public class EmailExist : ValidationAttribute
    {
       
         public override bool IsValid(object value)
        {
            var email = Convert.ToString(value);

           return Validate(email); 
        }

         public bool Validate(string email)
         {
             UsuarioService servi = new UsuarioService();

             if(servi.Exists(email) == null ) return false; else return true;

         }
            

    }
}
