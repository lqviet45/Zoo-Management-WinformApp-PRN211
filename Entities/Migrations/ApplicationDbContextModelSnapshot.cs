﻿// <auto-generated />
using System;
using Entities.ApplicationDbCon;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CageId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Species")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CageId");

                    b.ToTable("Animal", (string)null);
                });

            modelBuilder.Entity("Entities.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Dob")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dob = new DateTime(2023, 10, 30, 19, 10, 13, 26, DateTimeKind.Local).AddTicks(3621),
                            Email = "saigonzoo@gmail.com",
                            FullName = "Admin",
                            Gender = "Male",
                            IsDeleted = false,
                            Password = "12345",
                            PhoneNumber = "1234567890",
                            Role = "Admin",
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Dob = new DateTime(2023, 10, 30, 19, 10, 13, 26, DateTimeKind.Local).AddTicks(3632),
                            Email = "saigonzoo@gmail.com",
                            FullName = "Staff",
                            Gender = "Male",
                            IsDeleted = false,
                            Password = "12345",
                            PhoneNumber = "1234567890",
                            Role = "Staff",
                            UserName = "staff1"
                        });
                });

            modelBuilder.Entity("Entities.Models.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Area", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Cage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("CageName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("Cage", (string)null);
                });

            modelBuilder.Entity("Entities.Models.Animal", b =>
                {
                    b.HasOne("Entities.Models.Cage", "Cage")
                        .WithMany("Animals")
                        .HasForeignKey("CageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cage");
                });

            modelBuilder.Entity("Entities.Models.Cage", b =>
                {
                    b.HasOne("Entities.Models.Area", "Area")
                        .WithMany("Cages")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("Entities.Models.Area", b =>
                {
                    b.Navigation("Cages");
                });

            modelBuilder.Entity("Entities.Models.Cage", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
