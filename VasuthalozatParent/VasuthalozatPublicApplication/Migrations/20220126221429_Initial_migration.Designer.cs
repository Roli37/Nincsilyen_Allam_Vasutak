﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VasuthalozatPublicApplication.Entities;

namespace VasuthalozatPublicApplication.Migrations
{
    [DbContext(typeof(VasutContext))]
    [Migration("20220126221429_Initial_migration")]
    partial class Initial_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("VasuthalozatPublicApplication.Entities.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("ID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("VasuthalozatPublicApplication.Entities.Railway", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FromID")
                        .HasColumnType("int");

                    b.Property<int>("Km")
                        .HasColumnType("int");

                    b.Property<int?>("ToID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FromID");

                    b.HasIndex("ToID");

                    b.ToTable("Railways");
                });

            modelBuilder.Entity("VasuthalozatPublicApplication.Entities.Railway", b =>
                {
                    b.HasOne("VasuthalozatPublicApplication.Entities.City", "From")
                        .WithMany()
                        .HasForeignKey("FromID");

                    b.HasOne("VasuthalozatPublicApplication.Entities.City", "To")
                        .WithMany()
                        .HasForeignKey("ToID");

                    b.Navigation("From");

                    b.Navigation("To");
                });
#pragma warning restore 612, 618
        }
    }
}
