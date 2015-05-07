using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Partitu.Models.Validacoes
{
    public class DataAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return true;
        }

    }
}