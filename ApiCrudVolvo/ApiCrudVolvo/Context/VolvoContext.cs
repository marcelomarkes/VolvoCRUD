using ApiCrudVolvo.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudVolvo.Context
{
    public class VolvoContext : DbContext
    {
        public VolvoContext(DbContextOptions<VolvoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().ToTable("Status");
            modelBuilder.Entity<Status>().HasKey(p => p.IdStatus);
            modelBuilder.Entity<Status>().Property(p => p.IdStatus).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Status>().Property(p => p.Descricao).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Status>().HasData(
                new Status { IdStatus = 100, Descricao = "Liberabo" },
                new Status { IdStatus = 101, Descricao = "Bloqueado" }
                );

            modelBuilder.Entity<Caminhao>().ToTable("Caminhao");
            modelBuilder.Entity<Caminhao>().HasKey(p => p.IdCaminhao);
            modelBuilder.Entity<Caminhao>().Property(p => p.IdCaminhao).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Caminhao>().Property(p => p.Descricao).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Caminhao>().Property(p => p.AnoFabricacao).IsRequired();
            modelBuilder.Entity<Caminhao>().Property(p => p.AnoModelo).IsRequired();
            modelBuilder.Entity<Caminhao>().Property(p => p.CorCaminhao).IsRequired();
        }
    }
}
