﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TaskBoard.API.DbContexts;

#nullable disable

namespace TaskBoard.API.Migrations
{
    [DbContext(typeof(TaskBoardContext))]
    partial class TaskBoardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("BoardId")
                        .HasColumnType("integer");

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
                            BoardId = 0,
                            CardId = 1,
                            CardName = "Make Interesting Card",
                            ListId = 1,
                            ListName = "Urgent",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6030),
                            OperationName = "added",
                            ValueAfter = "Make Interesting Card",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 2,
                            BoardId = 0,
                            CardId = 2,
                            CardName = "Make Tests",
                            ListId = 1,
                            ListName = "Urgent",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6032),
                            OperationName = "added",
                            ValueAfter = "Make Tests",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 3,
                            BoardId = 0,
                            CardId = 3,
                            CardName = "Card Name 3",
                            ListId = 1,
                            ListName = "Urgent",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6034),
                            OperationName = "added",
                            ValueAfter = "Card Name 3",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 4,
                            BoardId = 0,
                            CardId = 4,
                            CardName = "Card 4",
                            ListId = 1,
                            ListName = "Urgent",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6036),
                            OperationName = "added",
                            ValueAfter = "Card 4",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 5,
                            BoardId = 0,
                            CardId = 5,
                            CardName = "Patch the card",
                            ListId = 2,
                            ListName = "Code",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6037),
                            OperationName = "added",
                            ValueAfter = "Patch the card",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 6,
                            BoardId = 0,
                            CardId = 6,
                            CardName = "Clean the code",
                            ListId = 2,
                            ListName = "Code",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6038),
                            OperationName = "added",
                            ValueAfter = "Clean the code",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 7,
                            BoardId = 0,
                            CardId = 7,
                            CardName = "Card 8",
                            ListId = 2,
                            ListName = "Code",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6040),
                            OperationName = "added",
                            ValueAfter = "Card 8",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 8,
                            BoardId = 0,
                            CardId = 8,
                            CardName = "Dance with a cat",
                            ListId = 3,
                            ListName = "Not quite yet",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6041),
                            OperationName = "added",
                            ValueAfter = "Dance with a cat",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 9,
                            BoardId = 0,
                            CardId = 9,
                            CardName = "Summon undead",
                            ListId = 3,
                            ListName = "Not quite yet",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6043),
                            OperationName = "added",
                            ValueAfter = "Summon undead",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 10,
                            BoardId = 0,
                            CardId = 10,
                            CardName = "Conquer the world",
                            ListId = 3,
                            ListName = "Not quite yet",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6044),
                            OperationName = "added",
                            ValueAfter = "Conquer the world",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 11,
                            BoardId = 0,
                            CardId = 11,
                            CardName = "Do something",
                            ListId = 4,
                            ListName = "Some other stuff",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6046),
                            OperationName = "added",
                            ValueAfter = "Do something",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 12,
                            BoardId = 0,
                            CardId = 12,
                            CardName = "Card 12",
                            ListId = 4,
                            ListName = "Some other stuff",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6047),
                            OperationName = "added",
                            ValueAfter = "Card 12",
                            ValueBefore = ""
                        },
                        new
                        {
                            Id = 13,
                            BoardId = 0,
                            CardId = 13,
                            CardName = "Fix the Activity UI",
                            ListId = 4,
                            ListName = "Some other stuff",
                            OperationDate = new DateTime(2024, 6, 26, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(6048),
                            OperationName = "added",
                            ValueAfter = "Fix the Activity UI",
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
                            Name = "Main Board"
                        });
                });

            modelBuilder.Entity("TaskBoard.API.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BoardId")
                        .HasColumnType("integer");

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
                            BoardId = 1,
                            Description = "Some Interesting description",
                            DueDate = new DateTime(2024, 6, 28, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5943),
                            ListId = 1,
                            Name = "Make Interesting Card",
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            BoardId = 1,
                            Description = "Testers want to sleep...",
                            DueDate = new DateTime(2024, 6, 28, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5952),
                            ListId = 1,
                            Name = "Make Tests",
                            Priority = 2
                        },
                        new
                        {
                            Id = 3,
                            BoardId = 1,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 6, 28, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5956),
                            ListId = 1,
                            Name = "Card Name 3",
                            Priority = 3
                        },
                        new
                        {
                            Id = 4,
                            BoardId = 1,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 6, 27, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5959),
                            ListId = 1,
                            Name = "Card 4",
                            Priority = 1
                        },
                        new
                        {
                            Id = 5,
                            BoardId = 1,
                            Description = "Try to Patch the card with ID 13.",
                            DueDate = new DateTime(2024, 6, 27, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5962),
                            ListId = 2,
                            Name = "Patch the card",
                            Priority = 3
                        },
                        new
                        {
                            Id = 6,
                            BoardId = 1,
                            Description = "Clean ALL the insufficient code before commit",
                            DueDate = new DateTime(2024, 6, 30, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5964),
                            ListId = 2,
                            Name = "Clean the code",
                            Priority = 1
                        },
                        new
                        {
                            Id = 7,
                            BoardId = 1,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 6, 30, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5966),
                            ListId = 2,
                            Name = "Card 8",
                            Priority = 2
                        },
                        new
                        {
                            Id = 8,
                            BoardId = 1,
                            Description = "Make an ritual dance with a cat",
                            DueDate = new DateTime(2024, 7, 1, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5969),
                            ListId = 3,
                            Name = "Dance with a cat",
                            Priority = 1
                        },
                        new
                        {
                            Id = 9,
                            BoardId = 1,
                            Description = "Summon the undead warrior to defend your planet",
                            DueDate = new DateTime(2024, 7, 1, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5971),
                            ListId = 3,
                            Name = "Summon undead",
                            Priority = 1
                        },
                        new
                        {
                            Id = 10,
                            BoardId = 1,
                            Description = "Make undesputable dominance over your world.",
                            DueDate = new DateTime(2024, 6, 29, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5973),
                            ListId = 3,
                            Name = "Conquer the world",
                            Priority = 1
                        },
                        new
                        {
                            Id = 11,
                            BoardId = 1,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 6, 27, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5976),
                            ListId = 4,
                            Name = "Do something",
                            Priority = 2
                        },
                        new
                        {
                            Id = 12,
                            BoardId = 1,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 6, 30, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5978),
                            ListId = 4,
                            Name = "Card 12",
                            Priority = 3
                        },
                        new
                        {
                            Id = 13,
                            BoardId = 1,
                            Description = "Task description should be unambiguous, accurate, factual.",
                            DueDate = new DateTime(2024, 6, 30, 11, 31, 40, 656, DateTimeKind.Utc).AddTicks(5980),
                            ListId = 4,
                            Name = "Fix the Activity UI",
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
                            Name = "Code"
                        },
                        new
                        {
                            Id = 3,
                            BoardId = 1,
                            Name = "Not quite yet"
                        },
                        new
                        {
                            Id = 4,
                            BoardId = 1,
                            Name = "Some other stuff"
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
