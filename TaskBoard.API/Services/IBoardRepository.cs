using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public interface IBoardRepository
{
    Task<IEnumerable<Board>> GetAllAsync();
    Task<Board?> GetByIdAsync(int boardId);
    Task<Board> AddAsync(Board board);
    Task<Board> Update(Board board);
    Task<Board?> Delete(int boardId);
}
