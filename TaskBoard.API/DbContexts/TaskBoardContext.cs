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
        new Board("First Board")
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
        new List("Second List")
        {
            Id = 2,
            BoardId = 1,
            Cards = new List<Card>()
        },
        new List("Third List")
        {
            Id = 3,
            BoardId = 1,
            Cards = new List<Card>()
        },
        new List("Fourth List")
        {
            Id = 4,
            BoardId = 1,
            Cards = new List<Card>()
        });

        modelBuilder.Entity<Card>()
            .HasData(
        new Card("Card Name 1", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 1,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(2),
            ListId = 1,
            Activities = new List<Activity>()
        },
        new Card("Card 2", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 2,
            Priority = 2,
            DueDate = DateTime.UtcNow.AddDays(2),
            ListId = 1,
            Activities = new List<Activity>()
        },
        new Card("Card Name 3", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 3,
            Priority = 3,
            DueDate = DateTime.UtcNow.AddDays(2),
            ListId = 1,
            Activities = new List<Activity>()
        },
        new Card("Card 4", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 4,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(1),
            ListId = 1,
            Activities = new List<Activity>()
        },
        new Card("Card Name 5", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 5,
            Priority = 2,
            DueDate = DateTime.UtcNow.AddDays(1),
            ListId = 1,
            Activities = new List<Activity>()
        },
        new Card("Card 6", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 6,
            Priority = 3,
            DueDate = DateTime.UtcNow.AddDays(1),
            ListId = 2,
            Activities = new List<Activity>()
        },
        new Card("Card Name 7", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 7,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(4),
            ListId = 2,
            Activities = new List<Activity>()
        },
        new Card("Card 8", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 8,
            Priority = 2,
            DueDate = DateTime.UtcNow.AddDays(4),
            ListId = 2,
            Activities = new List<Activity>()
        },
        new Card("Card Name 9", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 9,
            Priority = 3,
            DueDate = DateTime.UtcNow.AddDays(4),
            ListId = 2,
            Activities = new List<Activity>()
        },
        new Card("Card 10", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 10,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(4),
            ListId = 2,
            Activities = new List<Activity>()
        },
        new Card("Card 11", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 11,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(5),
            ListId = 3,
            Activities = new List<Activity>()
        },
        new Card("Card 12", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 12,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(5),
            ListId = 4,
            Activities = new List<Activity>()
        },
        new Card("Card 13", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 13,
            Priority = 1,
            DueDate = DateTime.UtcNow.AddDays(3),
            ListId = 4,
            Activities = new List<Activity>()
        });

        modelBuilder.Entity<Activity>()
            .HasData(
            new Activity("added", string.Empty, "Card Name 1", "Urgent", "Card Name 1")
            {
                Id = 1,
                OperationDate = DateTime.UtcNow,
                ListId = 1,
                CardId = 1
            },
            new Activity("added", string.Empty, "Card 2", "Urgent", "Card 2")
            {
                Id = 2,
                OperationDate = DateTime.UtcNow,
                ListId = 1,
                CardId = 2
            },
            new Activity("added", string.Empty, "Card Name 3", "Urgent", "Card Name 3")
            {
                Id = 3,
                OperationDate = DateTime.UtcNow,
                ListId = 1,
                CardId = 3
            },
            new Activity("added", string.Empty, "Card 4", "Urgent", "Card 4")
            {
                Id = 4,
                OperationDate = DateTime.UtcNow,
                ListId = 1,
                CardId = 4
            },
            new Activity("added", string.Empty, "Card Name 5", "Urgent", "Card Name 5")
            {
                Id = 5,
                OperationDate = DateTime.UtcNow,
                ListId = 1,
                CardId = 5
            },
            new Activity("added", string.Empty, "Card 6", "Second List", "Card 6")
            {
                Id = 6,
                OperationDate = DateTime.UtcNow,
                ListId = 2,
                CardId = 6
            },
            new Activity("added", string.Empty, "Card Name 7", "Second List", "Card Name 7")
            {
                Id = 7,
                OperationDate = DateTime.UtcNow,
                ListId = 2,
                CardId = 7
            },
            new Activity("added", string.Empty, "Card 8", "Second List", "Card 8")
            {
                Id = 8,
                OperationDate = DateTime.UtcNow,
                ListId = 2,
                CardId = 8
            },
            new Activity("added", string.Empty, "Card Name 9", "Second List", "Card Name 9")
            {
                Id = 9,
                OperationDate = DateTime.UtcNow,
                ListId = 2,
                CardId = 9
            },
            new Activity("added", string.Empty, "Card 10", "Second List", "Card 10")
            {
                Id = 10,
                OperationDate = DateTime.UtcNow,
                ListId = 2,
                CardId = 10
            },
            new Activity("added", string.Empty, "Card 11", "Third List", "Card 11")
            {
                Id = 11,
                OperationDate = DateTime.UtcNow,
                ListId = 3,
                CardId = 11
            },
            new Activity("added", string.Empty, "Card 12", "Fourth List", "Card 12")
            {
                Id = 12,
                OperationDate = DateTime.UtcNow,
                ListId = 4,
                CardId = 12
            },
            new Activity("added", string.Empty, "Fix Activity UI", "Fourth List", "Card Name 13")
            {
                Id = 13,
                OperationDate = DateTime.UtcNow,
                ListId = 4,
                CardId = 13
            });

        base.OnModelCreating(modelBuilder);

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost; Database=task-board; Username=postgres; Password=123");
}