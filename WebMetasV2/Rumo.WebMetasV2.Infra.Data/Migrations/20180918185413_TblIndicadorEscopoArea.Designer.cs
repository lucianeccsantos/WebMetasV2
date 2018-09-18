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
    [Migration("20180918185413_TblIndicadorEscopoArea")]
    partial class TblIndicadorEscopoArea
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

                    b.Property<int>("DirecaoIndicador");

                    b.Property<int>("MesFim");

                    b.Property<int>("MesInicio");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

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

            modelBuilder.Entity("Rumo.WebMetasV2.Domain.Models.IndicadorEscopoArea", b =>
                {
                    b.HasOne("Rumo.WebMetasV2.Domain.Models.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId");

                    b.HasOne("Rumo.WebMetasV2.Domain.Models.Escopo", "Escopo")
                        .WithMany()
                        .HasForeignKey("EscopoId");

                    b.HasOne("Rumo.WebMetasV2.Domain.Models.Indicador", "Indicador")
                        .WithMany()
                        .HasForeignKey("IndicadorId");
                });
#pragma warning restore 612, 618
        }
    }
}