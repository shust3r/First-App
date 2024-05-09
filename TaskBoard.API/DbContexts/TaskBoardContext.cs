using Microsoft.EntityFrameworkCore;
using TaskBoard.API.Entities;

namespace TaskBoard.API.DbContexts;

public class TaskBoardContext : DbContext
{
    public DbSet<List> Lists { get; set; }
    public DbSet<Card> Cards { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<List>()
            .HasData(
        new List("First List")
        {
            Id = 1,
            Cards = new List<Card>()
        },
        new List("Second List")
        {
            Id = 2,
            Cards = new List<Card>()
        });

        modelBuilder.Entity<Card>()
            .HasData(
        new Card("Card Name 1", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 1,
            ModifiedDate = DateTime.UtcNow.AddDays(-10),
            Priority = 1,
            ListId = 1
        },
        new Card("Card 2", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 2,
            ModifiedDate = DateTime.UtcNow.AddDays(-9),
            Priority = 2,
            ListId = 1
        },
        new Card("Card Name 3", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 3,
            ModifiedDate = DateTime.UtcNow.AddDays(-8),
            Priority = 3,
            ListId = 1
        },
        new Card("Card 4", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 4,
            ModifiedDate = DateTime.UtcNow.AddDays(-7),
            Priority = 1,
            ListId = 1
        },
        new Card("Card Name 5", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 5,
            ModifiedDate = DateTime.UtcNow.AddDays(-6),
            Priority = 2,
            ListId = 1
        },
        new Card("Card 6", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 6,
            ModifiedDate = DateTime.UtcNow.AddDays(-5),
            Priority = 3,
            ListId = 2
        },
        new Card("Card Name 7", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 7,
            ModifiedDate = DateTime.UtcNow.AddDays(-4),
            Priority = 1,
            ListId = 2
        },
        new Card("Card 8", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 8,
            ModifiedDate = DateTime.UtcNow.AddDays(-3),
            Priority = 2,
            ListId = 2
        },
        new Card("Card Name 9", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 9,
            ModifiedDate = DateTime.UtcNow.AddDays(-2),
            Priority = 3,
            ListId = 2
        },
        new Card("Card 10", "Task description should be unambiguous, accurate, factual.")
        {
            Id = 10,
            ModifiedDate = DateTime.UtcNow.AddDays(-1),
            Priority = 1,
            ListId = 2
        });

        base.OnModelCreating(modelBuilder);

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost; Database=task-board-db; Username=postgres; Password=123");
}