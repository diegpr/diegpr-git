﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheProject.API.Model.Infra;

namespace TheProject.API.Model.Infra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheProject.API.Model.Entities.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<string>("Nome");

                    b.Property<int>("UFId");

                    b.HasKey("Id");

                    b.HasIndex("UFId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<long>("CNPJ");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<string>("NomeAmigavel");

                    b.Property<string>("NomeFantasia");

                    b.Property<string>("RazaoSocial");

                    b.Property<int>("SegmentoClienteId");

                    b.HasKey("Id");

                    b.HasIndex("SegmentoClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<string>("DocumentoPrincipal");

                    b.Property<string>("Nome");

                    b.Property<int>("TipoDocumentoId");

                    b.HasKey("Id");

                    b.HasIndex("TipoDocumentoId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.FuncionarioCargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("CargoId");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<int>("FuncionarioId");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("FuncionarioCargo");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.FuncionarioEndereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Bairro");

                    b.Property<int>("CEP");

                    b.Property<int>("CidadeId");

                    b.Property<string>("Complemento");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<int>("FuncionarioId");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Numero");

                    b.Property<int>("TipoLogradouroId");

                    b.Property<int>("UFId");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("TipoLogradouroId");

                    b.HasIndex("UFId");

                    b.ToTable("FuncionarioEndereco");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Projeto");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.ProjetoFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<int>("FuncionarioId");

                    b.Property<int>("ProjetoId");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ProjetoId");

                    b.ToTable("ProjetoFuncionario");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.SegmentoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("SegmentoCliente");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumento");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.TipoLogradouro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("TipoLogradouro");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.UF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime?>("DataUltimaAlteracao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("UF");
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.Cidade", b =>
                {
                    b.HasOne("TheProject.API.Model.Entities.UF", "UF")
                        .WithMany()
                        .HasForeignKey("UFId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.Cliente", b =>
                {
                    b.HasOne("TheProject.API.Model.Entities.SegmentoCliente", "SegmentoCliente")
                        .WithMany()
                        .HasForeignKey("SegmentoClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.Funcionario", b =>
                {
                    b.HasOne("TheProject.API.Model.Entities.TipoDocumento", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("TipoDocumentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.FuncionarioCargo", b =>
                {
                    b.HasOne("TheProject.API.Model.Entities.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TheProject.API.Model.Entities.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.FuncionarioEndereco", b =>
                {
                    b.HasOne("TheProject.API.Model.Entities.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TheProject.API.Model.Entities.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TheProject.API.Model.Entities.TipoLogradouro", "TipoLogradouro")
                        .WithMany()
                        .HasForeignKey("TipoLogradouroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TheProject.API.Model.Entities.UF", "UF")
                        .WithMany()
                        .HasForeignKey("UFId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.Projeto", b =>
                {
                    b.HasOne("TheProject.API.Model.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheProject.API.Model.Entities.ProjetoFuncionario", b =>
                {
                    b.HasOne("TheProject.API.Model.Entities.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TheProject.API.Model.Entities.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
