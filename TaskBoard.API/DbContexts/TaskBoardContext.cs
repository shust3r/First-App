using Microsoft.EntityFrameworkCore;
using TaskBoard.API.Entities;

namespace TaskBoard.API.DbContexts;

public class TaskBoardContext : DbContext
{
    public DbSet<Board> Boards { get; set; }
    public DbSet<List> Lists { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Activity> Activities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Board>()
            .HasData(
        new Board("Main Board")
        {
            Id = 1,
            Lists = new List<List>()
        });

        modelBuilder.Entity<List>()
            .HasData(
        new List("Urgent")
        {
            Id = 1,
            BoardId = 1,
            Cards = new List<Card>()
        },
        new List("Code")
        {
            Id = 2,
            BoardId = 1,
            Cards = new List<Card>()
        },
        new List("Not quite yet")
        {
            Id = 3,
            BoardId = 1,
            Cards = new List<Card>()
        },
        new List("Some other stuff")
        {
            Id = 4,
            BoardId = 1,
            Cards = new List<Card>()
        });

        modelBuilder.Entity<Card>()
            .HasData(
        new Card("Make Interesting Card", "Some Interesting description")
        {
            Id = 1,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(2),
            ListId = 1,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Make Tests", "Testers want to sleep...")
        {
            Id = 2,
            Priority = 2,
            DueDate = DateTime.UtcNow.AddDays(2),
            ListId = 1,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Card Name 3", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 3,
            Priority = 3,
            DueDate = DateTime.UtcNow.AddDays(2),
            ListId = 1,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Card 4", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 4,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(1),
            ListId = 1,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Patch the card", "Try to Patch the card with ID 13.")
        {
            Id = 5,
            Priority = 3,
            DueDate = DateTime.UtcNow.AddDays(1),
            ListId = 2,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Clean the code", "Clean ALL the insufficient code before commit")
        {
            Id = 6,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(4),
            ListId = 2,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Card 8", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 7,
            Priority = 2,
            DueDate = DateTime.UtcNow.AddDays(4),
            ListId = 2,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Dance with a cat", "Make an ritual dance with a cat")
        {
            Id = 8,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(5),
            ListId = 3,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Summon undead", "Summon the undead warrior to defend your planet")
        {
            Id = 9,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(5),
            ListId = 3,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Conquer the world", "Make undesputable dominance over your world.")
        {
            Id = 10,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(3),
            ListId = 3,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Do something", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 11,
            Priority = 2,
            DueDate = DateTime.UtcNow.AddDays(1),
            ListId = 4,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Card 12", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 12,
            Priority = 3,
            DueDate = DateTime.UtcNow.AddDays(4),
            ListId = 4,
            BoardId = 1,
            Activities = new List<Activity>()
        },
        new Card("Fix the Activity UI", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 13,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(4),
            ListId = 4,
            BoardId = 1,
            Activities = new List<Activity>()
        });

        modelBuilder.Entity<Activity>()
            .HasData(
            new Activity("added", string.Empty, "Make Interesting Card", "Urgent", "Make Interesting Card")
            {
                Id = 1,
                OperationDate = DateTime.UtcNow,
                ListId = 1,
                CardId = 1,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Make Tests", "Urgent", "Make Tests")
            {
                Id = 2,
                OperationDate = DateTime.UtcNow,
                ListId = 1,
                CardId = 2,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Card Name 3", "Urgent", "Card Name 3")
            {
                Id = 3,
                OperationDate = DateTime.UtcNow,
                ListId = 1,
                CardId = 3,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Card 4", "Urgent", "Card 4")
            {
                Id = 4,
                OperationDate = DateTime.UtcNow,
                ListId = 1,
                CardId = 4,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Patch the card", "Code", "Patch the card")
            {
                Id = 5,
                OperationDate = DateTime.UtcNow,
                ListId = 2,
                CardId = 5,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Clean the code", "Code", "Clean the code")
            {
                Id = 6,
                OperationDate = DateTime.UtcNow,
                ListId = 2,
                CardId = 6,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Card 8", "Code", "Card 8")
            {
                Id = 7,
                OperationDate = DateTime.UtcNow,
                ListId = 2,
                CardId = 7,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Dance with a cat", "Not quite yet", "Dance with a cat")
            {
                Id = 8,
                OperationDate = DateTime.UtcNow,
                ListId = 3,
                CardId = 8,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Summon undead", "Not quite yet", "Summon undead")
            {
                Id = 9,
                OperationDate = DateTime.UtcNow,
                ListId = 3,
                CardId = 9,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Conquer the world", "Not quite yet", "Conquer the world")
            {
                Id = 10,
                OperationDate = DateTime.UtcNow,
                ListId = 3,
                CardId = 10,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Do something", "Some other stuff", "Do something")
            {
                Id = 11,
                OperationDate = DateTime.UtcNow,
                ListId = 4,
                CardId = 11,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Card 12", "Some other stuff", "Card 12")
            {
                Id = 12,
                OperationDate = DateTime.UtcNow,
                ListId = 4,
                CardId = 12,
                BoardId = 1
            },
            new Activity("added", string.Empty, "Fix the Activity UI", "Some other stuff", "Fix the Activity UI")
            {
                Id = 13,
                OperationDate = DateTime.UtcNow,
                ListId = 4,
                CardId = 13,
                BoardId = 1
            });

        base.OnModelCreating(modelBuilder);

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost; Database=task-board; Username=postgres; Password=123");
}