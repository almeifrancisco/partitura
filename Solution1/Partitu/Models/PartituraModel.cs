using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Partitu.Models
{
    public class PartituraModel
    {
        [Required]
        public string nome { get; set; }
        [Required]
        public string descricao { get; set; }
        
        public string instrumentos { get; set; }
        [Required]
        public string artista { get; set; }
        [Required]
        public string musica { get; set; }
        public int fk_vendedor { get; set; }

        [Required]
        public float preco { get; set; }


        public string url { get; set; }
        
        public string transcricao { get; set; }
        
        [Required(ErrorMessage="Partitura esta disponivel para compra?")]
        public bool disponivel { get; set; }


    }
}