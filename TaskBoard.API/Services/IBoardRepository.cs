using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public interface IBoardRepository
{
    Task<IEnumerable<Board>> GetAllWithoutDetails();
    Task<Board?> GetByIdWithoutDetails(int boardId);
    Task<Board> AddAsync(Board board);
    Task<Board> Update(Board board);
    Task<Board?> Delete(int boardId);
}
