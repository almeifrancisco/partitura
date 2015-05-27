using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;

namespace Repositorio.Context
{
    public partial class FirstProjecEntities : DbContext
    {
        public FirstProjecEntities()
            : base("name=PartituraEntities")
        { 
        }

        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Partitura> Partitura { get; set; }
        public DbSet<PartiturasDoUsuario> PartituraDoUsuario { get; set; }
        public DbSet<Pesquisa> Pesquisa { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<Instrumento> Instrumento { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<DenunciaPartitura> DenunciaPartirura { get; set; }
        public DbSet<ContatoRespostaPesquisa> ContatoRepostaPesquisa { get; set; }
        public DbSet<InformacaoBancaria> InformacaoBancari { get; set; }
        public DbSet<categoriaDaPartitura> CategoriaDaPartitura { get; set; }
        public DbSet<CategoriaP> CategoriaP { get; set; }
        public DbSet<InstrumentosNaPartitura> InstrumentosNaPartitura { get; set; }
    }
}
