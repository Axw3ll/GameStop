﻿// <auto-generated />
using GameStop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameStop.Migrations
{
    [DbContext(typeof(GameStopDBContext))]
    [Migration("20241126154344_Uno_muchos")]
    partial class Uno_muchos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameStop.Models.Clasificacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Clasificaciones");
                });

            modelBuilder.Entity("GameStop.Models.Juego", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("ClasificacionId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("ClasificacionId");

                    b.ToTable("Juegos");
                });

            modelBuilder.Entity("GameStop.Models.Juego", b =>
                {
                    b.HasOne("GameStop.Models.Clasificacion", "Clasificacion")
                        .WithMany("Juegos")
                        .HasForeignKey("ClasificacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clasificacion");
                });

            modelBuilder.Entity("GameStop.Models.Clasificacion", b =>
                {
                    b.Navigation("Juegos");
                });
#pragma warning restore 612, 618
        }
    }
}
