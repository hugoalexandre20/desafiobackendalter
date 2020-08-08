﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using web.api.Context;

namespace Alterdata.Bimer.Core.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200729191427_vr2")]
    partial class vr2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Alterdata.Bimer.Core.Modelo.Abstracoes.Contato", b =>
                {
                    b.Property<int>("Identificador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ClienteIdentificador")
                        .HasColumnType("integer");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Identificador");

                    b.HasIndex("ClienteIdentificador");

                    b.ToTable("Contatos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Contato");
                });

            modelBuilder.Entity("Alterdata.Bimer.Core.Modelo.Cliente", b =>
                {
                    b.Property<int>("Identificador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Identificador");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Alterdata.Bimer.Core.ValueObjects.Impl.Telefone", b =>
                {
                    b.HasBaseType("Alterdata.Bimer.Core.Modelo.Abstracoes.Contato");

                    b.HasDiscriminator().HasValue("Telefone");
                });

            modelBuilder.Entity("Alterdata.Bimer.Core.Modelo.Abstracoes.Contato", b =>
                {
                    b.HasOne("Alterdata.Bimer.Core.Modelo.Cliente", null)
                        .WithMany("Contatos")
                        .HasForeignKey("ClienteIdentificador");

                    b.OwnsOne("Alterdata.Bimer.Core.ValueObjects.Impl.Descricao", "Descricao", b1 =>
                        {
                            b1.Property<int>("ContatoIdentificador")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<string>("Texto")
                                .HasColumnType("text");

                            b1.HasKey("ContatoIdentificador");

                            b1.ToTable("Contatos");

                            b1.WithOwner()
                                .HasForeignKey("ContatoIdentificador");
                        });
                });

            modelBuilder.Entity("Alterdata.Bimer.Core.Modelo.Cliente", b =>
                {
                    b.OwnsOne("Alterdata.Bimer.Core.ValueObjects.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("ClienteIdentificador")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<string>("Bairro")
                                .HasColumnName("Bairro")
                                .HasColumnType("character varying(30)")
                                .HasMaxLength(30);

                            b1.Property<string>("CEP")
                                .IsRequired()
                                .HasColumnName("Cep")
                                .HasColumnType("character varying(10)")
                                .HasMaxLength(10);

                            b1.Property<string>("Complemento")
                                .HasColumnName("ComplementoEndereco")
                                .HasColumnType("character varying(10)")
                                .HasMaxLength(10);

                            b1.Property<int>("Numero")
                                .HasColumnName("NumeroEndereco")
                                .HasColumnType("integer")
                                .HasMaxLength(10);

                            b1.Property<string>("Rua")
                                .IsRequired()
                                .HasColumnName("Rua")
                                .HasColumnType("character varying(50)")
                                .HasMaxLength(50);

                            b1.HasKey("ClienteIdentificador");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteIdentificador");
                        });

                    b.OwnsOne("Alterdata.Bimer.Core.ValueObjects.Impl.Nome", "Nome", b1 =>
                        {
                            b1.Property<int>("ClienteIdentificador")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<string>("NomePrincipal")
                                .IsRequired()
                                .HasColumnName("NomePrincipal")
                                .HasColumnType("character varying(30)")
                                .HasMaxLength(30);

                            b1.Property<string>("Sobrenome")
                                .HasColumnName("Sobrenome")
                                .HasColumnType("character varying(50)")
                                .HasMaxLength(50);

                            b1.HasKey("ClienteIdentificador");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteIdentificador");
                        });
                });

            modelBuilder.Entity("Alterdata.Bimer.Core.ValueObjects.Impl.Telefone", b =>
                {
                    b.OwnsOne("Alterdata.Bimer.Core.ValueObjects.Impl.Ddd", "Ddd", b1 =>
                        {
                            b1.Property<int>("TelefoneIdentificador")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<int>("DddValue")
                                .HasColumnType("integer");

                            b1.HasKey("TelefoneIdentificador");

                            b1.ToTable("Contatos");

                            b1.WithOwner()
                                .HasForeignKey("TelefoneIdentificador");
                        });

                    b.OwnsOne("Alterdata.Bimer.Core.ValueObjects.Impl.Numero", "Numero", b1 =>
                        {
                            b1.Property<int>("TelefoneIdentificador")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<int>("NumeroValue")
                                .HasColumnType("integer");

                            b1.HasKey("TelefoneIdentificador");

                            b1.ToTable("Contatos");

                            b1.WithOwner()
                                .HasForeignKey("TelefoneIdentificador");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
