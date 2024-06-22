using Microsoft.EntityFrameworkCore;
using TaskBoard.API.DbContexts;
using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public class CardRepository : ICardRepository
{
    private readonly TaskBoardContext _context;
    private readonly IActivityRepository _repo;

    public CardRepository(TaskBoardContext context, IActivityRepository activityRepository)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _repo = activityRepository ?? throw new ArgumentNullException(nameof(activityRepository));
    }

    public async Task<IEnumerable<Card>> GetAllAsync()
    {
        var all = await _context.Cards
            .Include(c => c.Activities)
            .ToListAsync();

        return all;
    }

    public async Task<IEnumerable<Card>> GetByBoardIdAsync(int boardId)
    {
        var all = await _context.Cards
            .Where(c => c.BoardId == boardId)
            .Include(c => c.Activities)
            .ToListAsync();

        return all;
    }

    public async Task<Card?> GetByCardIdAsync(int cardId)
    {
        var card = await _context.Cards
            .Include(c => c.Activities)
            .Where(c => c.Id == cardId)
            .FirstOrDefaultAsync();

        return card;
    }

    public async Task<Card> AddAsync(Card card)
    {
        if (card.DueDate.Kind == DateTimeKind.Unspecified)
        {
            card.DueDate = DateTime.SpecifyKind((DateTime)card.DueDate, DateTimeKind.Utc);
        }

        await _context.Cards.AddAsync(card);

        var list = await _context.Lists
            .Where(l => l.Id == card.ListId)
            .FirstOrDefaultAsync();
        if (list is not null)
        {
            list.Cards.Add(card);
        }

        await _context.SaveChangesAsync();

        var activity = new Activity("added", "", card.Name, list!.Name, card.Name)
        {
            OperationDate = DateTime.UtcNow,
            CardId = card.Id,
            ListId = card.ListId
        };

        await _repo.AddAsync(activity);

        return card;
    }

    public async Task<Card> Update(Card card)
    {
        if (card.DueDate.Kind == DateTimeKind.Unspecified)
        {
            card.DueDate = DateTime.SpecifyKind((DateTime)card.DueDate, DateTimeKind.Utc);
        }

        _context.Entry(card).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return card;
    }

    public async Task<Card?> Delete(int cardId)
    {
        var card = await _context.Cards
            .Where(c => c.Id == cardId)
            .FirstOrDefaultAsync();
        if (card is null)
        {
            return card;
        }

        _context.Cards.Remove(card);
        await _context.SaveChangesAsync();
        return card;
    }
}