using Microsoft.EntityFrameworkCore;
using TaskBoard.API.DbContexts;
using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public class CardRepository : ICardRepository
{
    private readonly TaskBoardContext _context;
    private readonly ActivityService _svc;

    public CardRepository(TaskBoardContext context, ActivityService svc)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _svc = svc ?? throw new ArgumentNullException(nameof(svc));
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
        ////Чи достатньо цього
        //  //чи не треба ще й await _context.Activities.AddAsync(activity);

        //card.Activities.Add(activity);

        await _context.Cards.AddAsync(card);

        var list = await _context.Lists
            .Where(l => l.Id == card.ListId)
            .FirstOrDefaultAsync();
        if (list is not null)
        {
            list.Cards.Add(card);
        }

        await _context.SaveChangesAsync();

        await _svc.InitActivity(card);

        return card;
    }

    public async Task<Card> Update(Card card)
    {
        var oldCard = await _context.Cards
            .Where(c => c.Id == card.Id)
            .FirstOrDefaultAsync();

        _context.Entry(card).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        await _svc.AddUpdateActivity(oldCard!, card);

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