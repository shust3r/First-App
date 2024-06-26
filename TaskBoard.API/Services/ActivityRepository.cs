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
            .OrderByDescending(a => a.OperationDate)
            .ToListAsync();

        return all;
    }

    public async Task<IEnumerable<Activity>> GeByBoardIdAsync(int boardId)
    {
        var activities = await _context.Activities
            .Where(a => a.BoardId == boardId)
            .OrderByDescending(a => a.OperationDate)
            .ToListAsync();

        return activities;
    }

    public async Task<IEnumerable<Activity>> GeByCardIdAsync(int cardId)
    {
        var activities = await _context.Activities
            .Where(a => a.CardId == cardId)
            .OrderByDescending(a => a.OperationDate)
            .ToListAsync();

        return activities;
    }

    public async Task AddAsync(Activity activity)
    {
        await _context.Activities.AddAsync(activity);

        await _context.SaveChangesAsync();
    }

    public async Task AddRangeAsync(IEnumerable<Activity> activities)
    {
        await _context.Activities.AddRangeAsync(activities);

        await _context.SaveChangesAsync();
    }
}
