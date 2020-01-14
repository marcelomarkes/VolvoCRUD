﻿// <auto-generated />
using System;
using ApiCrudVolvo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiCrudVolvo.Migrations
{
    [DbContext(typeof(VolvoContext))]
    partial class VolvoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiCrudVolvo.Models.Entity.Caminhao", b =>
                {
                    b.Property<int>("IdCaminhao")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AnoFabricacao");

                    b.Property<DateTime>("AnoModelo");

                    b.Property<string>("CorCaminhao")
                        .IsRequired();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("IdStatus");

                    b.HasKey("IdCaminhao");

                    b.HasIndex("IdStatus");

                    b.ToTable("Caminhao");
                });

            modelBuilder.Entity("ApiCrudVolvo.Models.Entity.Status", b =>
                {
                    b.Property<int>("IdStatus")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("IdStatus");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            IdStatus = 100,
                            Descricao = "Liberabo"
                        },
                        new
                        {
                            IdStatus = 101,
                            Descricao = "Bloqueado"
                        });
                });

            modelBuilder.Entity("ApiCrudVolvo.Models.Entity.Caminhao", b =>
                {
                    b.HasOne("ApiCrudVolvo.Models.Entity.Status", "Status")
                        .WithMany()
                        .HasForeignKey("IdStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
