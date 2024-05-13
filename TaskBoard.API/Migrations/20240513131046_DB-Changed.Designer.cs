﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TaskBoard.API.DbContexts;

#nullable disable

namespace TaskBoard.API.Migrations
{
    [DbContext(typeof(TaskBoardContext))]
    [Migration("20240513131046_DB-Changed")]
    partial class DBChanged
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TaskBoard.API.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ListId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ListId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 1,
                            Name = "Card Name 1",
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 1,
                            Name = "Card 2",
                            Priority = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 1,
                            Name = "Card Name 3",
                            Priority = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 1,
                            Name = "Card 4",
                            Priority = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 1,
                            Name = "Card Name 5",
                            Priority = 2
                        },
                        new
                        {
                            Id = 6,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 2,
                            Name = "Card 6",
                            Priority = 3
                        },
                        new
                        {
                            Id = 7,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 2,
                            Name = "Card Name 7",
                            Priority = 1
                        },
                        new
                        {
                            Id = 8,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 2,
                            Name = "Card 8",
                            Priority = 2
                        },
                        new
                        {
                            Id = 9,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 2,
                            Name = "Card Name 9",
                            Priority = 3
                        },
                        new
                        {
                            Id = 10,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 2,
                            Name = "Card 10",
                            Priority = 1
                        },
                        new
                        {
                            Id = 11,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 3,
                            Name = "Card 11",
                            Priority = 1
                        },
                        new
                        {
                            Id = 12,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 4,
                            Name = "Card 12",
                            Priority = 1
                        },
                        new
                        {
                            Id = 13,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListId = 4,
                            Name = "Card 13",
                            Priority = 1
                        });
                });

            modelBuilder.Entity("TaskBoard.API.Entities.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Lists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "First List"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Second List"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Third List"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Fourth List"
                        });
                });

            modelBuilder.Entity("TaskBoard.API.Entities.Card", b =>
                {
                    b.HasOne("TaskBoard.API.Entities.List", null)
                        .WithMany("Cards")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskBoard.API.Entities.List", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
