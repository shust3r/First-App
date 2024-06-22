using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public interface IListRepository
{
    Task<IEnumerable<List>> GetAllWithDetailsAsync();
    Task<IEnumerable<List>> GetAllWithoutDetailsAsync();
    Task<IEnumerable<List>> GetAllByBoardId(int boardId);
    Task<List?> GetByIdWithoutDetails(int listId);
    Task<List> AddAsync(List list);
    Task<List> Update(List list);
    Task<List?> Delete(int listId);
}