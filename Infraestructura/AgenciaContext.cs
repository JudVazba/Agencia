using Microsoft.EntityFrameworkCore;
using System;
using Agencia.Dominio;


namespace Agencia.Infraestructura
{
    public class AgenciaContext : DbContext

    {
        public DbSet<Agencia> Agencia { get; set; }

        public DbSet<Modelo> Modelo { get; set; }

        public DbSet<Marca> Marca { get; set; }

    }
}

 public AgenciaContext(DbContextOptions<AgenciaContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AgenciasConfiguration.Apply(modelBuilder);
            ModeloConfiguration.Apply(modelBuilder);
            MarcaIngredienteConfiguration.Apply(modelBuilder);
       
        }
         public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

