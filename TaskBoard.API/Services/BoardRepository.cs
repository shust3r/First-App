using Microsoft.EntityFrameworkCore;
using TaskBoard.API.DbContexts;
using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public class BoardRepository : IBoardRepository
{
    private readonly TaskBoardContext _context;

    public BoardRepository(TaskBoardContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<IEnumerable<Board>> GetAllWithoutDetails()
    {
        var all = await _context.Boards
            .Include(b => b.Lists)
            .ToListAsync();

        return all;
    }

    public async Task<Board?> GetByIdWithoutDetails(int boardId)
    {
        var board = await _context.Boards
            .Where(b => b.Id == boardId)
            .Include(b => b.Lists)
            .FirstOrDefaultAsync();

        return board;
    }

    public async Task<Board> AddAsync(Board board)
    {
        await _context.Boards.AddAsync(board);
        await _context.SaveChangesAsync();
        return board;
    }

    public async Task<Board> Update(Board board)
    {
        _context.Entry(board).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return board;
    }

    public async Task<Board?> Delete(int boardId)
    {
        var board = await _context.Boards
            .Where(b => b.Id == boardId)
            .FirstOrDefaultAsync();
        if (board is null)
        {
            return board;
        }

        _context.Boards.Remove(board);
        await _context.SaveChangesAsync();
        return board;
    }
}
