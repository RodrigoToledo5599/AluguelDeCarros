﻿// <auto-generated />
using System;
using AluguelDeCarros.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AluguelDeCarros.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231117191537_adqeopkqokpewqopkeq")]
    partial class adqeopkqokpewqopkeq
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AluguelDeCarros.Models.AluguelAtivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarroId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CarroPego")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeEntrega")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Finalizado")
                        .HasColumnType("bit");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CarroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("AluguelAtivos");
                });

            modelBuilder.Entity("AluguelDeCarros.Models.Carros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Alugado")
                        .HasColumnType("bit");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ValorDia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Carros");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alugado = false,
                            MarcaId = 3,
                            Name = "Celta",
                            ValorDia = 30
                        },
                        new
                        {
                            Id = 2,
                            Alugado = false,
                            MarcaId = 2,
                            Name = "Uno",
                            ValorDia = 30
                        },
                        new
                        {
                            Id = 3,
                            Alugado = false,
                            MarcaId = 2,
                            Name = "Palio",
                            ValorDia = 30
                        },
                        new
                        {
                            Id = 4,
                            Alugado = false,
                            MarcaId = 4,
                            Name = "Fusion",
                            ValorDia = 80
                        },
                        new
                        {
                            Id = 5,
                            Alugado = false,
                            MarcaId = 10,
                            Name = "C4 Lounge",
                            ValorDia = 70
                        },
                        new
                        {
                            Id = 6,
                            Alugado = false,
                            MarcaId = 5,
                            Name = "Civic lxr",
                            ValorDia = 50
                        },
                        new
                        {
                            Id = 7,
                            Alugado = false,
                            MarcaId = 11,
                            Name = "Dodge Ram",
                            ValorDia = 140
                        },
                        new
                        {
                            Id = 8,
                            Alugado = false,
                            MarcaId = 3,
                            Name = "Corvette C7 Stingray",
                            ValorDia = 390
                        },
                        new
                        {
                            Id = 9,
                            Alugado = false,
                            MarcaId = 12,
                            Name = "C63",
                            ValorDia = 200
                        },
                        new
                        {
                            Id = 10,
                            Alugado = false,
                            MarcaId = 1,
                            Name = "Gol",
                            ValorDia = 50
                        },
                        new
                        {
                            Id = 11,
                            Alugado = false,
                            MarcaId = 7,
                            Name = "Prius",
                            ValorDia = 40
                        },
                        new
                        {
                            Id = 12,
                            Alugado = false,
                            MarcaId = 7,
                            Name = "Corolla 2017",
                            ValorDia = 45
                        },
                        new
                        {
                            Id = 13,
                            Alugado = false,
                            MarcaId = 7,
                            Name = "Yaris",
                            ValorDia = 45
                        },
                        new
                        {
                            Id = 14,
                            Alugado = false,
                            MarcaId = 4,
                            Name = "Ford Gt 2017",
                            ValorDia = 500
                        },
                        new
                        {
                            Id = 15,
                            Alugado = false,
                            MarcaId = 8,
                            Name = "Bmw M8",
                            ValorDia = 360
                        },
                        new
                        {
                            Id = 16,
                            Alugado = false,
                            MarcaId = 9,
                            Name = "Fluence",
                            ValorDia = 55
                        });
                });

            modelBuilder.Entity("AluguelDeCarros.Models.DmMarcas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Marca")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.HasKey("Id");

                    b.ToTable("DmMarcas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Marca = 1,
                            Name = "Volkswagen"
                        },
                        new
                        {
                            Id = 2,
                            Marca = 2,
                            Name = "Fiat"
                        },
                        new
                        {
                            Id = 3,
                            Marca = 3,
                            Name = "Chevrolet"
                        },
                        new
                        {
                            Id = 4,
                            Marca = 4,
                            Name = "Ford"
                        },
                        new
                        {
                            Id = 5,
                            Marca = 5,
                            Name = "Honda"
                        },
                        new
                        {
                            Id = 6,
                            Marca = 6,
                            Name = "Suzuki"
                        },
                        new
                        {
                            Id = 7,
                            Marca = 7,
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = 8,
                            Marca = 8,
                            Name = "Bmw"
                        },
                        new
                        {
                            Id = 9,
                            Marca = 9,
                            Name = "Renault"
                        },
                        new
                        {
                            Id = 10,
                            Marca = 10,
                            Name = "Citroen"
                        },
                        new
                        {
                            Id = 11,
                            Marca = 11,
                            Name = "Dodge"
                        },
                        new
                        {
                            Id = 12,
                            Marca = 12,
                            Name = "Mercedez"
                        });
                });

            modelBuilder.Entity("AluguelDeCarros.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("nvarchar(127)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = "525788ef-77ef-4f60-b104-bb9c03096829",
                            Email = "ddd@gmail.com",
                            Name = "Rodrigo",
                            Senha = "123"
                        },
                        new
                        {
                            Id = "67ed01d1-0032-4587-93c6-2d083329384f",
                            Email = "adm@gmail.com",
                            Name = "Adm",
                            Role = 2,
                            Senha = "123"
                        });
                });

            modelBuilder.Entity("AluguelDeCarros.Models.AluguelAtivo", b =>
                {
                    b.HasOne("AluguelDeCarros.Models.Carros", "Carros")
                        .WithMany()
                        .HasForeignKey("CarroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AluguelDeCarros.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carros");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AluguelDeCarros.Models.Carros", b =>
                {
                    b.HasOne("AluguelDeCarros.Models.DmMarcas", "DmMarcas")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AluguelDeCarros.Models.Usuario", null)
                        .WithMany("Carros")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("DmMarcas");
                });

            modelBuilder.Entity("AluguelDeCarros.Models.Usuario", b =>
                {
                    b.Navigation("Carros");
                });
#pragma warning restore 612, 618
        }
    }
}
