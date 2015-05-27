using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partitu.Models
{
    public class VendedorModel : UsuarioModel
    {

        public string descricao { get; set; }
        public string  foto { get; set; }
        public File file { get; set; }
        public string url { get; set; }
    }
}