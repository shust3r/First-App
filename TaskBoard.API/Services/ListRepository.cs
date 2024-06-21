using Microsoft.EntityFrameworkCore;
using TaskBoard.API.DbContexts;
using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public class ListRepository : IListRepository
{
    private readonly TaskBoardContext _context;

    public ListRepository(TaskBoardContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<IEnumerable<List>> GetAllWithoutDetailsAsync()
    {
        var all = await _context.Lists
            .ToListAsync();

        return all;
    }

    public async Task<IEnumerable<List>> GetAllWithDetailsAsync()
    {
        var all = await _context.Lists
            .Include(l => l.Cards)
            .ThenInclude(c => c.Activities)
            .ToListAsync();

        return all;
    }

    public async Task<List?> GetByIdAsync(int listId)
    {
        var list = await _context.Lists
            .Include(l => l.Cards)
            .ThenInclude(c => c.Activities)
            .Where(l => l.Id == listId)
            .FirstOrDefaultAsync();

        return list;
    }

    public async Task<string> GetNameAsync(int listId)
    {
        var name = await _context.Lists
            .Where(l => l.Id == listId)
            .Select(l => l.Name)
            .FirstOrDefaultAsync();

        return name;
    }

    public async Task<List> AddAsync(List list)
    {
        await _context.Lists.AddAsync(list);
        await _context.SaveChangesAsync();
        return list;
    }

    public async Task<List> Update(List list)
    {
        _context.Entry(list).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return list;
    }

    public async Task<List?> Delete(int listId)
    {
        var list = await _context.Lists
            .Where(l => l.Id == listId)
            .FirstOrDefaultAsync();
        if (list is null)
        {
            return list;
        }

        _context.Lists.Remove(list);
        await _context.SaveChangesAsync();
        return list;
    }
}