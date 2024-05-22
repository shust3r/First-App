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
    [Migration("20240522175011_ListName_CardName_for_Activity_Added")]
    partial class ListName_CardName_for_Activity_Added
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TaskBoard.API.Entities.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CardId")
                        .HasColumnType("integer");

                    b.Property<string>("CardName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ListId")
                        .HasColumnType("integer");

                    b.Property<string>("ListName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("OperationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ValueAfter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ValueBefore")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardId = 1,
                            CardName = "Card Name 1",
                            ListId = 1,
                            ListName = "Urgent",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5255),
                            OperationName = "added",
                            ValueAfter = "Card Name 1",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 2,
                            CardId = 2,
                            CardName = "Card 2",
                            ListId = 1,
                            ListName = "Urgent",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5257),
                            OperationName = "added",
                            ValueAfter = "Card 2",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 3,
                            CardId = 3,
                            CardName = "Card Name 3",
                            ListId = 1,
                            ListName = "Urgent",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5259),
                            OperationName = "added",
                            ValueAfter = "Card Name 3",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 4,
                            CardId = 4,
                            CardName = "Card 4",
                            ListId = 1,
                            ListName = "Urgent",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5260),
                            OperationName = "added",
                            ValueAfter = "Card 4",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 5,
                            CardId = 5,
                            CardName = "Card Name 5",
                            ListId = 1,
                            ListName = "Urgent",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5262),
                            OperationName = "added",
                            ValueAfter = "Card Name 5",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 6,
                            CardId = 6,
                            CardName = "Card 6",
                            ListId = 2,
                            ListName = "Second List",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5263),
                            OperationName = "added",
                            ValueAfter = "Card 6",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 7,
                            CardId = 7,
                            CardName = "Card Name 7",
                            ListId = 2,
                            ListName = "Second List",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5264),
                            OperationName = "added",
                            ValueAfter = "Card Name 7",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 8,
                            CardId = 8,
                            CardName = "Card 8",
                            ListId = 2,
                            ListName = "Second List",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5266),
                            OperationName = "added",
                            ValueAfter = "Card 8",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 9,
                            CardId = 9,
                            CardName = "Card Name 9",
                            ListId = 2,
                            ListName = "Second List",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5267),
                            OperationName = "added",
                            ValueAfter = "Card Name 9",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 10,
                            CardId = 10,
                            CardName = "Card 10",
                            ListId = 2,
                            ListName = "Second List",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5268),
                            OperationName = "added",
                            ValueAfter = "Card 10",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 11,
                            CardId = 11,
                            CardName = "Card 11",
                            ListId = 3,
                            ListName = "Third List",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5270),
                            OperationName = "added",
                            ValueAfter = "Card 11",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 12,
                            CardId = 12,
                            CardName = "Card 12",
                            ListId = 4,
                            ListName = "Fourth List",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5271),
                            OperationName = "added",
                            ValueAfter = "Card 12",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 13,
                            CardId = 13,
                            CardName = "Card Name 13",
                            ListId = 4,
                            ListName = "Fourth List",
                            OperationDate = new DateTime(2024, 5, 22, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5273),
                            OperationName = "added",
                            ValueAfter = "Fix Activity UI",
                            ValueBefore = ""
                        });
                });

            modelBuilder.Entity("TaskBoard.API.Entities.Board", b =>
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

                    b.ToTable("Boards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "First Board"
                        });
                });

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
                            DueDate = new DateTime(2024, 5, 24, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5180),
                            ListId = 1,
                            Name = "Card Name 1",
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 24, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5189),
                            ListId = 1,
                            Name = "Card 2",
                            Priority = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 24, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5192),
                            ListId = 1,
                            Name = "Card Name 3",
                            Priority = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 23, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5194),
                            ListId = 1,
                            Name = "Card 4",
                            Priority = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 23, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5196),
                            ListId = 1,
                            Name = "Card Name 5",
                            Priority = 2
                        },
                        new
                        {
                            Id = 6,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 23, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5198),
                            ListId = 2,
                            Name = "Card 6",
                            Priority = 3
                        },
                        new
                        {
                            Id = 7,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 26, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5200),
                            ListId = 2,
                            Name = "Card Name 7",
                            Priority = 1
                        },
                        new
                        {
                            Id = 8,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 26, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5202),
                            ListId = 2,
                            Name = "Card 8",
                            Priority = 2
                        },
                        new
                        {
                            Id = 9,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 26, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5204),
                            ListId = 2,
                            Name = "Card Name 9",
                            Priority = 3
                        },
                        new
                        {
                            Id = 10,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 26, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5206),
                            ListId = 2,
                            Name = "Card 10",
                            Priority = 1
                        },
                        new
                        {
                            Id = 11,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 27, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5208),
                            ListId = 3,
                            Name = "Card 11",
                            Priority = 1
                        },
                        new
                        {
                            Id = 12,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 27, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5210),
                            ListId = 4,
                            Name = "Card 12",
                            Priority = 1
                        },
                        new
                        {
                            Id = 13,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 5, 25, 17, 50, 11, 328, DateTimeKind.Utc).AddTicks(5212),
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

                    b.Property<int>("BoardId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.ToTable("Lists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BoardId = 1,
                            Name = "Urgent"
                        },
                        new
                        {
                            Id = 2,
                            BoardId = 1,
                            Name = "Second List"
                        },
                        new
                        {
                            Id = 3,
                            BoardId = 1,
                            Name = "Third List"
                        },
                        new
                        {
                            Id = 4,
                            BoardId = 1,
                            Name = "Fourth List"
                        });
                });

            modelBuilder.Entity("TaskBoard.API.Entities.Activity", b =>
                {
                    b.HasOne("TaskBoard.API.Entities.Card", null)
                        .WithMany("Activities")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("TaskBoard.API.Entities.Board", null)
                        .WithMany("Lists")
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskBoard.API.Entities.Board", b =>
                {
                    b.Navigation("Lists");
                });

            modelBuilder.Entity("TaskBoard.API.Entities.Card", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("TaskBoard.API.Entities.List", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
