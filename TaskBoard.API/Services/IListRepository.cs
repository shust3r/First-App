using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public interface IListRepository
{
    Task<IEnumerable<List>> GetAllAsync();
    Task<List?> GetByIdAsync(int listId);
    Task<string> GetNameAsync(int listId);
    Task<List> AddAsync(List list);
    Task<List> Update(List list);
    Task<List?> Delete(int listId);
}