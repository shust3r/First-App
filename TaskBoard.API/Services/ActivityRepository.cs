using Microsoft.EntityFrameworkCore;
using TaskBoard.API.DbContexts;
using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public class ActivityRepository : IActivityRepository
{
    private readonly TaskBoardContext _context;

    public ActivityRepository(TaskBoardContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<IEnumerable<Activity>> GetAllAsync()
    {
        var all = await _context.Activities
            .ToListAsync();

        return all;
    }

    public async Task<Activity> AddAsync(Activity activity, int cardId)
    {
        await _context.Activities.AddAsync(activity);
        var card = await _context.Cards
            .Where(c => c.Id == cardId)
            .FirstOrDefaultAsync();
        if (card is not null)
        {
            card.Activities.Add(activity);
        }

        await _context.SaveChangesAsync();
        return activity;
    }
}
