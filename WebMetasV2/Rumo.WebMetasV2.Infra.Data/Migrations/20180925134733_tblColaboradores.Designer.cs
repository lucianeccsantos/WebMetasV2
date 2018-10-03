﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Rumo.WebMetasV2.Domain.Enumeradores;
using Rumo.WebMetasV2.Infra.Data.Context;
using System;

namespace Rumo.WebMetasV2.Infra.Data.Migrations
{
    [DbContext(typeof(WebMetasContext))]
    [Migration("20180925134733_tblColaboradores")]
    partial class tblColaboradores
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Core.Events.StoredEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AggregateId");

                    b.Property<string>("Data");

                    b.Property<string>("MessageType")
                        .HasColumnName("Action")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("CreationDate");

                    b.Property<string>("User");

                    b.HasKey("Id");

                    b.ToTable("StoredEvent");
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.Area", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.Cargo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("GrupoPoolId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("GrupoPoolId");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.Colaborador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ativo");

                    b.Property<bool>("CadastroIncompleto");

                    b.Property<Guid>("CargoId");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid>("PerfilId");

                    b.Property<Guid>("SuperiorImediatoId");

                    b.Property<Guid>("UnidadeId");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("PerfilId");

                    b.HasIndex("SuperiorImediatoId");

                    b.HasIndex("UnidadeId");

                    b.ToTable("Colaborador");
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.Dependencia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Dependencia");
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.Escopo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Escopo");
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.GrupoPool", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("GrupoPool");
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.Indicador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("DirecaoIndicador");

                    b.Property<string>("FormulaCalculo")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("MesFim");

                    b.Property<int>("MesInicio");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Periodicidade");

                    b.Property<int>("TipoIndicador");

                    b.HasKey("Id");

                    b.ToTable("Indicador");
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.IndicadorEscopoArea", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AreaId");

                    b.Property<Guid?>("EscopoId");

                    b.Property<Guid>("IdArea");

                    b.Property<Guid>("IdEscopo");

                    b.Property<Guid>("IdIndicador");

                    b.Property<Guid?>("IndicadorId");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("EscopoId");

                    b.HasIndex("IndicadorId");

                    b.ToTable("IndicadorEscopoArea");
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.Perfil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("Situacao")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.Unidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Unidade");
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.Cargo", b =>
                {
                    b.HasOne("Rumo.WebMetasV2.Domain.Models.GrupoPool", "GrupoPool")
                        .WithMany("Cargos")
                        .HasForeignKey("GrupoPoolId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.Colaborador", b =>
                {
                    b.HasOne("Rumo.WebMetasV2.Domain.Models.Cargo", "Cargo")
                        .WithMany("Colaboradores")
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Rumo.WebMetasV2.Domain.Models.Perfil", "Perfil")
                        .WithMany("Colaboradores")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Rumo.WebMetasV2.Domain.Models.Colaborador", "SuperiorImediato")
                        .WithMany("Colaboradores")
                        .HasForeignKey("SuperiorImediatoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Rumo.WebMetasV2.Domain.Models.Unidade", "Unidade")
                        .WithMany("Colaboradores")
                        .HasForeignKey("UnidadeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.IndicadorEscopoArea", b =>
                {
                    b.HasOne("Rumo.WebMetasV2.Domain.Models.Area", "Area")
                        .WithMany("IndicadorEscopoAreas")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Rumo.WebMetasV2.Domain.Models.Escopo", "Escopo")
                        .WithMany("IndicadorEscopoAreas")
                        .HasForeignKey("EscopoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Rumo.WebMetasV2.Domain.Models.Indicador", "Indicador")
                        .WithMany("IndicadorEscopoAreas")
                        .HasForeignKey("IndicadorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
