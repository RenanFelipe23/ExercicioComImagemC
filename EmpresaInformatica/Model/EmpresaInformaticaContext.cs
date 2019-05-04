using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;

namespace EmpresaInformatica.Model
{
   public class EmpresaInformaticaContext:DbContext
    {
        public EmpresaInformaticaContext()
            :base("Connection")
        { }
        public DbSet<Itens> Itens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}