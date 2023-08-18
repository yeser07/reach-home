﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reach_Home.Data;

#nullable disable

namespace Reach_Home.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230818233322_CreateTableUbicacion")]
    partial class CreateTableUbicacion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Reach_Home.Models.Rol", b =>
                {
                    b.Property<int>("rol_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("rol_descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("rol_id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Reach_Home.Models.Ubicacion", b =>
                {
                    b.Property<int>("ubicacion_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ubicacion_ciudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ubicacion_colonia")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ubicacion_direccion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ubicacion_estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("ubicacion_latitud")
                        .HasColumnType("double");

                    b.Property<double>("ubicacion_longitud")
                        .HasColumnType("double");

                    b.Property<string>("ubicacion_pais")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ubicacion_id");

                    b.ToTable("Ubicaciones");
                });

            modelBuilder.Entity("Reach_Home.Models.Usuario", b =>
                {
                    b.Property<int>("usuario_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("usuario_activo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("usuario_contrasenia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("usuario_nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("usuario_rol_id")
                        .HasColumnType("int");

                    b.Property<string>("usuario_telefono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("usuario_id");

                    b.HasIndex("usuario_rol_id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Reach_Home.Models.Usuario", b =>
                {
                    b.HasOne("Reach_Home.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("usuario_rol_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}