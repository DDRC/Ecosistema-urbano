using Microsoft.EntityFrameworkCore;
using System.Buffers.Binary;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcosistemaUrbano 
{
    
    class contextoBD : DbContext
    {
     public DbSet<Persona> Personas {get; set;}
     public DbSet<Barrio> Barrios {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //on fluentAPI
            modelBuilder.Entity<Persona>().HasKey(bp=>new {bp.Id});
            modelBuilder.Entity<Persona>()
                .HasOne(bp => bp.Barrio)
                .WithMany(b=>b.ListaPersonasBarrio)
                .HasForeignKey(bp=>bp.BarrioId);
        }
    }
}
