﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApp.DataAccess;

#nullable disable

namespace TestApp.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20240929061852_AddedAnnotations")]
    partial class AddedAnnotations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("TestApp.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressNo")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Street")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "15",
                            City = "City1",
                            FullName = "Author 1",
                            Street = "Street 1"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "25",
                            City = "City2",
                            FullName = "Author 2",
                            Street = "Street 2"
                        });
                });

            modelBuilder.Entity("TestApp.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(130)
                        .HasColumnType("varchar(130)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2024, 9, 29, 11, 48, 51, 224, DateTimeKind.Local).AddTicks(6369),
                            Description = "Dis A",
                            Due = new DateTime(2024, 10, 4, 11, 48, 51, 224, DateTimeKind.Local).AddTicks(6386),
                            Status = 0,
                            Title = "Title A"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Created = new DateTime(2024, 9, 29, 11, 48, 51, 224, DateTimeKind.Local).AddTicks(6395),
                            Description = "Dis B",
                            Due = new DateTime(2024, 10, 4, 11, 48, 51, 224, DateTimeKind.Local).AddTicks(6396),
                            Status = 0,
                            Title = "Title B"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Created = new DateTime(2024, 9, 29, 11, 48, 51, 224, DateTimeKind.Local).AddTicks(6399),
                            Description = "Dis C",
                            Due = new DateTime(2024, 10, 4, 11, 48, 51, 224, DateTimeKind.Local).AddTicks(6400),
                            Status = 0,
                            Title = "Title C"
                        });
                });

            modelBuilder.Entity("TestApp.Models.Todo", b =>
                {
                    b.HasOne("TestApp.Models.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TestApp.Models.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
