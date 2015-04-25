using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;

namespace Repositorio.Context
{
    public class FirstProjecEntities : DbContext
    {
        public FirstProjecEntities()
            : base("name=FirstProjecEntities")
        { 
        }

        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
               
    }
}
