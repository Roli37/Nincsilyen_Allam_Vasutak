﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VasuthalozatPublicApplication.Database;

namespace VasuthalozatPublicApplication.Migrations
{
    [DbContext(typeof(VasutContext))]
    partial class VasutContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Wonoharjo"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Miaoyu"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Chivhu"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Beni"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Manicaragua"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Bentar"
                        },
                        new
                        {
                            ID = 7,
                            Name = "Golcuv Jeníkov"
                        },
                        new
                        {
                            ID = 8,
                            Name = "Kuantan"
                        },
                        new
                        {
                            ID = 9,
                            Name = "Nova Kakhovka"
                        },
                        new
                        {
                            ID = 10,
                            Name = "Dollard-Des Ormeaux"
                        },
                        new
                        {
                            ID = 11,
                            Name = "Kabardinka"
                        },
                        new
                        {
                            ID = 12,
                            Name = "Caoxi"
                        },
                        new
                        {
                            ID = 13,
                            Name = "San Lorenzo"
                        },
                        new
                        {
                            ID = 14,
                            Name = "Normanton"
                        },
                        new
                        {
                            ID = 15,
                            Name = "Sao Joao del Rei"
                        },
                        new
                        {
                            ID = 16,
                            Name = "Dongshi"
                        },
                        new
                        {
                            ID = 17,
                            Name = "Arruda dos Vinhos"
                        },
                        new
                        {
                            ID = 18,
                            Name = "Elliot"
                        },
                        new
                        {
                            ID = 19,
                            Name = "Upper San Mateo"
                        },
                        new
                        {
                            ID = 20,
                            Name = "Kalilangan"
                        });
                });

            modelBuilder.Entity("VasuthalozatPublicApplication.Entities.Foglalas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RailwayID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RailwayID");

                    b.HasIndex("UserID");

                    b.ToTable("Foglalasok");
                });

            modelBuilder.Entity("VasuthalozatPublicApplication.Entities.Railway", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FromID")
                        .HasColumnType("int");

                    b.Property<int>("Km")
                        .HasColumnType("int");

                    b.Property<int>("ToID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FromID");

                    b.HasIndex("ToID");

                    b.ToTable("Railways");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FromID = 1,
                            Km = 38,
                            ToID = 4
                        },
                        new
                        {
                            ID = 2,
                            FromID = 1,
                            Km = 56,
                            ToID = 13
                        },
                        new
                        {
                            ID = 3,
                            FromID = 1,
                            Km = 83,
                            ToID = 15
                        },
                        new
                        {
                            ID = 4,
                            FromID = 1,
                            Km = 145,
                            ToID = 18
                        },
                        new
                        {
                            ID = 5,
                            FromID = 2,
                            Km = 49,
                            ToID = 3
                        },
                        new
                        {
                            ID = 6,
                            FromID = 2,
                            Km = 82,
                            ToID = 5
                        },
                        new
                        {
                            ID = 7,
                            FromID = 2,
                            Km = 92,
                            ToID = 6
                        },
                        new
                        {
                            ID = 8,
                            FromID = 2,
                            Km = 95,
                            ToID = 8
                        },
                        new
                        {
                            ID = 9,
                            FromID = 2,
                            Km = 42,
                            ToID = 19
                        },
                        new
                        {
                            ID = 10,
                            FromID = 3,
                            Km = 49,
                            ToID = 2
                        },
                        new
                        {
                            ID = 11,
                            FromID = 3,
                            Km = 66,
                            ToID = 4
                        },
                        new
                        {
                            ID = 12,
                            FromID = 3,
                            Km = 34,
                            ToID = 7
                        },
                        new
                        {
                            ID = 13,
                            FromID = 3,
                            Km = 1,
                            ToID = 14
                        },
                        new
                        {
                            ID = 14,
                            FromID = 3,
                            Km = 67,
                            ToID = 19
                        },
                        new
                        {
                            ID = 15,
                            FromID = 3,
                            Km = 14,
                            ToID = 20
                        },
                        new
                        {
                            ID = 16,
                            FromID = 4,
                            Km = 38,
                            ToID = 1
                        },
                        new
                        {
                            ID = 17,
                            FromID = 4,
                            Km = 66,
                            ToID = 3
                        },
                        new
                        {
                            ID = 18,
                            FromID = 4,
                            Km = 116,
                            ToID = 6
                        },
                        new
                        {
                            ID = 19,
                            FromID = 4,
                            Km = 75,
                            ToID = 17
                        },
                        new
                        {
                            ID = 20,
                            FromID = 5,
                            Km = 82,
                            ToID = 2
                        },
                        new
                        {
                            ID = 21,
                            FromID = 5,
                            Km = 134,
                            ToID = 8
                        },
                        new
                        {
                            ID = 22,
                            FromID = 5,
                            Km = 68,
                            ToID = 9
                        },
                        new
                        {
                            ID = 23,
                            FromID = 5,
                            Km = 148,
                            ToID = 11
                        },
                        new
                        {
                            ID = 24,
                            FromID = 5,
                            Km = 2,
                            ToID = 20
                        },
                        new
                        {
                            ID = 25,
                            FromID = 6,
                            Km = 92,
                            ToID = 2
                        },
                        new
                        {
                            ID = 26,
                            FromID = 6,
                            Km = 116,
                            ToID = 4
                        },
                        new
                        {
                            ID = 27,
                            FromID = 6,
                            Km = 98,
                            ToID = 8
                        },
                        new
                        {
                            ID = 28,
                            FromID = 6,
                            Km = 56,
                            ToID = 11
                        },
                        new
                        {
                            ID = 29,
                            FromID = 6,
                            Km = 49,
                            ToID = 16
                        },
                        new
                        {
                            ID = 30,
                            FromID = 7,
                            Km = 34,
                            ToID = 3
                        },
                        new
                        {
                            ID = 31,
                            FromID = 7,
                            Km = 45,
                            ToID = 18
                        },
                        new
                        {
                            ID = 32,
                            FromID = 7,
                            Km = 131,
                            ToID = 20
                        },
                        new
                        {
                            ID = 33,
                            FromID = 8,
                            Km = 95,
                            ToID = 2
                        },
                        new
                        {
                            ID = 34,
                            FromID = 8,
                            Km = 134,
                            ToID = 5
                        },
                        new
                        {
                            ID = 35,
                            FromID = 8,
                            Km = 98,
                            ToID = 6
                        },
                        new
                        {
                            ID = 36,
                            FromID = 8,
                            Km = 89,
                            ToID = 9
                        },
                        new
                        {
                            ID = 37,
                            FromID = 8,
                            Km = 78,
                            ToID = 16
                        },
                        new
                        {
                            ID = 38,
                            FromID = 8,
                            Km = 75,
                            ToID = 18
                        },
                        new
                        {
                            ID = 39,
                            FromID = 9,
                            Km = 68,
                            ToID = 5
                        },
                        new
                        {
                            ID = 40,
                            FromID = 9,
                            Km = 89,
                            ToID = 8
                        },
                        new
                        {
                            ID = 41,
                            FromID = 9,
                            Km = 117,
                            ToID = 10
                        },
                        new
                        {
                            ID = 42,
                            FromID = 9,
                            Km = 96,
                            ToID = 13
                        },
                        new
                        {
                            ID = 43,
                            FromID = 9,
                            Km = 46,
                            ToID = 16
                        },
                        new
                        {
                            ID = 44,
                            FromID = 9,
                            Km = 148,
                            ToID = 20
                        },
                        new
                        {
                            ID = 45,
                            FromID = 10,
                            Km = 117,
                            ToID = 9
                        },
                        new
                        {
                            ID = 46,
                            FromID = 10,
                            Km = 130,
                            ToID = 17
                        },
                        new
                        {
                            ID = 47,
                            FromID = 10,
                            Km = 115,
                            ToID = 18
                        },
                        new
                        {
                            ID = 48,
                            FromID = 11,
                            Km = 148,
                            ToID = 5
                        },
                        new
                        {
                            ID = 49,
                            FromID = 11,
                            Km = 56,
                            ToID = 6
                        },
                        new
                        {
                            ID = 50,
                            FromID = 11,
                            Km = 11,
                            ToID = 14
                        },
                        new
                        {
                            ID = 51,
                            FromID = 11,
                            Km = 47,
                            ToID = 20
                        },
                        new
                        {
                            ID = 52,
                            FromID = 12,
                            Km = 112,
                            ToID = 17
                        },
                        new
                        {
                            ID = 53,
                            FromID = 13,
                            Km = 56,
                            ToID = 1
                        },
                        new
                        {
                            ID = 54,
                            FromID = 13,
                            Km = 96,
                            ToID = 9
                        },
                        new
                        {
                            ID = 55,
                            FromID = 13,
                            Km = 2,
                            ToID = 14
                        },
                        new
                        {
                            ID = 56,
                            FromID = 13,
                            Km = 55,
                            ToID = 16
                        },
                        new
                        {
                            ID = 57,
                            FromID = 14,
                            Km = 1,
                            ToID = 3
                        },
                        new
                        {
                            ID = 58,
                            FromID = 14,
                            Km = 11,
                            ToID = 11
                        },
                        new
                        {
                            ID = 59,
                            FromID = 14,
                            Km = 2,
                            ToID = 13
                        },
                        new
                        {
                            ID = 60,
                            FromID = 14,
                            Km = 129,
                            ToID = 15
                        },
                        new
                        {
                            ID = 61,
                            FromID = 14,
                            Km = 46,
                            ToID = 16
                        },
                        new
                        {
                            ID = 62,
                            FromID = 15,
                            Km = 83,
                            ToID = 1
                        },
                        new
                        {
                            ID = 63,
                            FromID = 15,
                            Km = 129,
                            ToID = 14
                        },
                        new
                        {
                            ID = 64,
                            FromID = 15,
                            Km = 115,
                            ToID = 20
                        },
                        new
                        {
                            ID = 65,
                            FromID = 16,
                            Km = 49,
                            ToID = 6
                        },
                        new
                        {
                            ID = 66,
                            FromID = 16,
                            Km = 78,
                            ToID = 8
                        },
                        new
                        {
                            ID = 67,
                            FromID = 16,
                            Km = 46,
                            ToID = 9
                        },
                        new
                        {
                            ID = 68,
                            FromID = 16,
                            Km = 55,
                            ToID = 13
                        },
                        new
                        {
                            ID = 69,
                            FromID = 16,
                            Km = 46,
                            ToID = 14
                        },
                        new
                        {
                            ID = 70,
                            FromID = 16,
                            Km = 132,
                            ToID = 17
                        },
                        new
                        {
                            ID = 71,
                            FromID = 16,
                            Km = 115,
                            ToID = 18
                        },
                        new
                        {
                            ID = 72,
                            FromID = 17,
                            Km = 75,
                            ToID = 4
                        },
                        new
                        {
                            ID = 73,
                            FromID = 17,
                            Km = 130,
                            ToID = 10
                        },
                        new
                        {
                            ID = 74,
                            FromID = 17,
                            Km = 112,
                            ToID = 12
                        },
                        new
                        {
                            ID = 75,
                            FromID = 17,
                            Km = 132,
                            ToID = 16
                        },
                        new
                        {
                            ID = 76,
                            FromID = 18,
                            Km = 145,
                            ToID = 1
                        },
                        new
                        {
                            ID = 77,
                            FromID = 18,
                            Km = 45,
                            ToID = 7
                        },
                        new
                        {
                            ID = 78,
                            FromID = 18,
                            Km = 75,
                            ToID = 8
                        },
                        new
                        {
                            ID = 79,
                            FromID = 18,
                            Km = 115,
                            ToID = 10
                        },
                        new
                        {
                            ID = 80,
                            FromID = 18,
                            Km = 115,
                            ToID = 16
                        },
                        new
                        {
                            ID = 81,
                            FromID = 19,
                            Km = 42,
                            ToID = 2
                        },
                        new
                        {
                            ID = 82,
                            FromID = 19,
                            Km = 67,
                            ToID = 3
                        },
                        new
                        {
                            ID = 83,
                            FromID = 19,
                            Km = 99,
                            ToID = 20
                        },
                        new
                        {
                            ID = 84,
                            FromID = 20,
                            Km = 14,
                            ToID = 3
                        },
                        new
                        {
                            ID = 85,
                            FromID = 20,
                            Km = 2,
                            ToID = 5
                        },
                        new
                        {
                            ID = 86,
                            FromID = 20,
                            Km = 131,
                            ToID = 7
                        },
                        new
                        {
                            ID = 87,
                            FromID = 20,
                            Km = 148,
                            ToID = 9
                        },
                        new
                        {
                            ID = 88,
                            FromID = 20,
                            Km = 47,
                            ToID = 11
                        },
                        new
                        {
                            ID = 89,
                            FromID = 20,
                            Km = 115,
                            ToID = 15
                        },
                        new
                        {
                            ID = 90,
                            FromID = 20,
                            Km = 99,
                            ToID = 19
                        });
                });

            modelBuilder.Entity("VasuthalozatPublicApplication.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("VasuthalozatPublicApplication.Entities.Foglalas", b =>
                {
                    b.HasOne("VasuthalozatPublicApplication.Entities.Railway", "Railway")
                        .WithMany()
                        .HasForeignKey("RailwayID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VasuthalozatPublicApplication.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Railway");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VasuthalozatPublicApplication.Entities.Railway", b =>
                {
                    b.HasOne("VasuthalozatPublicApplication.Entities.City", "From")
                        .WithMany()
                        .HasForeignKey("FromID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VasuthalozatPublicApplication.Entities.City", "To")
                        .WithMany()
                        .HasForeignKey("ToID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("From");

                    b.Navigation("To");
                });
#pragma warning restore 612, 618
        }
    }
}
