﻿// <auto-generated />
using System;
using MSIF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MSIF.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230530010836_two")]
    partial class two
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MSIF.Model.Contatos", b =>
                {
                    b.Property<int>("ContatosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContatosId"));

                    b.Property<int>("Contato")
                        .HasColumnType("int");

                    b.Property<int>("Logado")
                        .HasColumnType("int");

                    b.HasKey("ContatosId");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("MSIF.Model.Recado", b =>
                {
                    b.Property<int>("RecadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecadoId"));

                    b.Property<DateTime>("Dataenvio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Destinatario")
                        .HasColumnType("int");

                    b.Property<int>("Remetente")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecadoId");

                    b.ToTable("Recado");
                });

            modelBuilder.Entity("MSIF.Model.Solicitacao", b =>
                {
                    b.Property<int>("SolicitacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SolicitacaoId"));

                    b.Property<int>("Destinatario")
                        .HasColumnType("int");

                    b.Property<int>("Remetente")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("SolicitacaoId");

                    b.ToTable("Solicitacao");
                });

            modelBuilder.Entity("MSIF.Model.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
