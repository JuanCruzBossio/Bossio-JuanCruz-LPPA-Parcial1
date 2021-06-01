using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ParcialLPPA.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ParcialLPPA.Servicios
{
    public class ObraDbContext:DbContext
    {
        public ObraDbContext() : base(nameOrConnectionString: "DefaultConnection") { }

        public DbSet<Afiliado> Afiliados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}