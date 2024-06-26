﻿// <auto-generated />
using CarrosAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarrosAPI.Migrations
{
    [DbContext(typeof(CarroContext))]
    [Migration("20240426171948_CriandoTabelaDeCarro")]
    partial class CriandoTabelaDeCarro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CarrosAPI.Models.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Classe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Especificacoes")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Carros");
                });
#pragma warning restore 612, 618
        }
    }
}
