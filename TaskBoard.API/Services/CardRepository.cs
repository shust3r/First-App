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

    public async Task<Card?> GetByIdAsync(int cardId)
    {
        var card = await _context.Cards
            .Include(c => c.Activities)
            .Where(c => c.Id == cardId)
            .FirstOrDefaultAsync();

        return card;
    }

    public async Task<Card> AddAsync(Card card)
    {
        await _context.Cards.AddAsync(card);

        var list = await _context.Lists
            .Where(l => l.Id == card.ListId)
            .FirstOrDefaultAsync();
        if (list is not null)
        {
            list.Cards.Add(card);
        }

        await _context.SaveChangesAsync();

        var activity = new Activity("added the card", "", card.Name)
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