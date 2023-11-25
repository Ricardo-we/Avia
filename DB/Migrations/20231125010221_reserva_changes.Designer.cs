﻿// <auto-generated />
using System;
using Avia.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20231125010221_reserva_changes")]
    partial class reserva_changes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("DB.Asiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clase")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Reservado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VueloId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VueloId");

                    b.ToTable("asiento", (string)null);
                });

            modelBuilder.Entity("DB.Ciudad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("DB.Equipaje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("alto")
                        .HasColumnType("REAL");

                    b.Property<double>("ancho")
                        .HasColumnType("REAL");

                    b.Property<double>("largo")
                        .HasColumnType("REAL");

                    b.Property<double>("peso")
                        .HasColumnType("REAL");

                    b.Property<int>("userid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("equipaje", (string)null);
                });

            modelBuilder.Entity("DB.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("dpi")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("rol")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("dpi")
                        .IsUnique();

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("DB.Vuelo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CiudadDestinoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CiudadDestinoImg")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CiudadOrigenId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaIda")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaVuelta")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HoraLlegada")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HoraSalida")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("CiudadDestinoId");

                    b.HasIndex("CiudadOrigenId");

                    b.ToTable("vuelo", (string)null);
                });

            modelBuilder.Entity("DB.Asiento", b =>
                {
                    b.HasOne("DB.User", "user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Vuelo", "Vuelo")
                        .WithMany()
                        .HasForeignKey("VueloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vuelo");

                    b.Navigation("user");
                });

            modelBuilder.Entity("DB.Equipaje", b =>
                {
                    b.HasOne("DB.User", "user")
                        .WithMany()
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("DB.Vuelo", b =>
                {
                    b.HasOne("DB.Ciudad", "CiudadDestino")
                        .WithMany()
                        .HasForeignKey("CiudadDestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Ciudad", "CiudadOrigen")
                        .WithMany()
                        .HasForeignKey("CiudadOrigenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CiudadDestino");

                    b.Navigation("CiudadOrigen");
                });
#pragma warning restore 612, 618
        }
    }
}
